namespace LmsBack.Model
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
