namespace ApplicationTracker.BL.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Status { get; set; }
        public string Position { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Location { get; set; }

    }
}
