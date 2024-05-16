namespace LmsBack.Model
{
    public class LessonMark
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public Student Student { get; set; }
        public Lesson Lesson { get; set; }
    }
}
