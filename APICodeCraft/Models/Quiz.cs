﻿namespace APICodeCraft.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public bool Answer { get; set;}
        public string UrlImage { get; set; } = string.Empty;

        public int SubtopicId { get; set; }
        public Subtopic Subtopic { get; set; }

    }
}
