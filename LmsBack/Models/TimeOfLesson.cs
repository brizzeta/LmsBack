using System.ComponentModel.DataAnnotations;

namespace LmsBack.Model {
    public class TimeOfLesson {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TimeStart { get; set; }
        public virtual DayOfWeek? DayOfWeek { get; set; }
    }
}