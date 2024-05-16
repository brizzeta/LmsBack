namespace LmsBack.Model
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public int CountLessons { get; set; }
        public ICollection<TimeOfLesson> TimeOfLessons { get; set;}
    }
}
