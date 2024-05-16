namespace LmsBack.Model
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public Manager Manager { get; set; }
        public Schedule Schedule { get; set; }
        public Course Course { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
