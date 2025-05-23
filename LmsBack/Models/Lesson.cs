﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LmsBack.Model {
    public class Lesson {
        public int Id { get; set; }
        public string? Topic { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public int NumberLesson { get; set; }
        public virtual HomeworkTeacher? HomeworkTeacher { get; set; }
        public virtual ICollection<HomeworkStudent>? HomeworkStudents { get; set; }

        [JsonIgnore]
        public virtual ICollection<Attendance>? Attendances { get; set; }
        [JsonIgnore]
        public virtual ICollection<LessonMark>? LessonMarks { get; set; }
    }
}