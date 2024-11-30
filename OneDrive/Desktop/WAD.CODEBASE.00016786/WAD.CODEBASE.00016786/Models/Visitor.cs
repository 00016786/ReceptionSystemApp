namespace WAD.CODEBASE._00016786.Models
{
    public class Visitor
    {
        public int VisitorID { get; set; }
        public required string Name { get; set; }
        public required string Contact { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }


        // Foreign Key to Employee
        public int EmployeeID { get; set; } // Foreign Key
        public Employee BookedBy { get; set; } // Navigation Property

        // Foreign Key to Room
        public int RoomID { get; set; } // Foreign Key
        public Room Room { get; set; } // Navigation Property
    }
}
