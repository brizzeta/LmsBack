namespace LmsBack.Model
{
    public class HomeworkStudent
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public string Description { get; set; }
        public Student Student { get; set; }
        public HomeworkMark HomeworkMark { get; set; }
    }
}
