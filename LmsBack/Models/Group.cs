using System.ComponentModel.DataAnnotations;

namespace LmsBack.Model {
    public class Group {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        public string? Name { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual Manager? Manager { get; set; }
        public virtual Schedule? Schedule { get; set; }
        public virtual Course? Course { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
        public virtual ICollection<Lesson>? Lessons { get; set; }
    }
}