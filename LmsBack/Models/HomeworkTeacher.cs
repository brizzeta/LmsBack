using System.ComponentModel.DataAnnotations;

namespace LmsBack.Model {
    public class HomeworkTeacher {
        public int Id { get; set; }
        public string? FilePath { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UploadDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Deadline { get; set; }
        public string? Description { get; set; }
    }
}