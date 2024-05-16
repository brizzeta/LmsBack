namespace LmsBack.Model
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public DateTime Date { get; set; }
        public int NumberLesson { get; set; }
        public HomeworkTeacher HomeworkTeacher { get; set; }
        public ICollection<HomeworkStudent> HomeworkStudents { get; set; }
        public ICollection<Attendence> Attendences { get; set; }
        public ICollection<LessonMark> LessonMarks { get; set; }
    }
}
