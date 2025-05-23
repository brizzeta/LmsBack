﻿using System.Text.Json.Serialization;

namespace LmsBack.Model {
    public class LessonMark {
        public int Id { get; set; }
        public int Mark { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Lesson? Lesson { get; set; }
        public virtual Group? Group { get; set; }
    }
}