namespace LmsBack.Model
{
    public class HomeworkTeacher
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
    }
}
