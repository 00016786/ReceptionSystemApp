namespace WAD.CODEBASE._00016786.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public int RoomNumber { get; set; }
        public required string RoomType { get; set; }
        public decimal RoomPrice { get; set; }
        public bool IsAvailable {  get; set; }

        public int? CurrentVisitorId { get; set; }
        public required Visitor CurrentVisitor { get; set; }

    }
}
