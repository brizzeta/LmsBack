using System.Text.Json.Serialization;

namespace LmsBack.Model {
    public class Attendance {
        public int Id { get; set; }
        public bool Status { get; set; }
        [JsonIgnore]
        public virtual Student? Student { get; set; }
        public virtual Lesson? Lesson { get; set; }    // !!!
    }
}