namespace LmsBack.Model
{
    public class Attendence
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public Student Student { get; set; }
        public Lesson Lesson { get; set; }
    }
}
