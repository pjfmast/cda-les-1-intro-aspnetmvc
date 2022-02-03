namespace IntroAspNetMvc.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Instructor { get; set; }
        public string Location { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Capacity { get; set; }

        public ICollection<string> Enrolled { get; }
        public ICollection<string> WaitingList { get; }
    }
}
