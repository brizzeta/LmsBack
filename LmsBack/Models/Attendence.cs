namespace LmsBack.Model {
    public class Attendence {
        public int Id { get; set; }
        public bool Status { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Lesson? Lesson { get; set; }
    }
}