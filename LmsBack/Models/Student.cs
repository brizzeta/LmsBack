namespace LmsBack.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Account Account { get; set; }
        public ICollection<Parent> Parents { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Attendence> Attendences { get; set; }
        public ICollection<LessonMark> LessonMarks { get; set; }
    }
}