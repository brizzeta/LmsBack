using System.ComponentModel.DataAnnotations;

namespace LmsBack.Model {
    public class HomeworkStudent {
        public int Id { get; set; }
        public string? FilePath { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UploadDate { get; set; }
        public string? Description { get; set; }
        public virtual Student? Student { get; set; }
        public virtual HomeworkMark? HomeworkMark { get; set; }
    }
}