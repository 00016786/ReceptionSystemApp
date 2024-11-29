namespace WAD.CODEBASE._00016786.Models
{
    public class Visitor
    {
        public int VisitorID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Employee EmployeeID { get; set; }
        public Room RoomID { get; set; }
    }
}
