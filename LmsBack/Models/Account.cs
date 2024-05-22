using System.ComponentModel.DataAnnotations;

namespace LmsBack.Model {
    public class Account  {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        public string? Login { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public string? Salt { get; set; }
    }
}