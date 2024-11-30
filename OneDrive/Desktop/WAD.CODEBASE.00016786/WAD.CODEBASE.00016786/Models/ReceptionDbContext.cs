using Microsoft.EntityFrameworkCore;

namespace WAD.CODEBASE._00016786.Models
{
    public class ReceptionDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Visitor> Visitors { get; set; }

        public ReceptionDbContext(DbContextOptions<ReceptionDbContext> options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .HasOne(r => r.CurrentVisitor)
                .WithOne(v => v.Room)
                .HasForeignKey<Visitor>(v => v.RoomID)
                .IsRequired(false);

            modelBuilder.Entity<Visitor>()
                 .HasOne(v => v.BookedBy)
                 .WithMany()
                 .HasForeignKey(v => v.EmployeeID)
                 .IsRequired(true);
        }
    }
}
