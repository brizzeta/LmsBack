namespace LmsBack.Model
{
    public class TimeOfLesson
    {
        public int Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
    }
}
