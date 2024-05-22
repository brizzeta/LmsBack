using System.ComponentModel.DataAnnotations;

namespace LmsBack.Model {
    public class Course {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        public string? Name { get; set; }
    }
}