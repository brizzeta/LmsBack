using LmsBack.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LmsBack.Model {
    public class Student {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        public string? Surname { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        public string? Patronymic { get; set; }
        [Phone(ErrorMessage = "Неправильний формат телефонного номера!")]
        public string? Phone { get; set; }
        [EmailAddress(ErrorMessage = "Неправильний формат адреси електронної пошти!")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [FutureDate(ErrorMessage = "Дата не може бути в майбутньому!")]
        public DateTime BirthDate { get; set; }
        public virtual Account? Account { get; set; }
        public virtual ICollection<Parent>? Parents { get; set; }

        [JsonIgnore]
        public virtual ICollection<Group>? Groups
        {
            get; set;
        }
        public virtual ICollection<Attendence>? Attendences { get; set; }
        public virtual ICollection<LessonMark>? LessonMarks { get; set; }
    }
}