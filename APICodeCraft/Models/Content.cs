namespace APICodeCraft.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string UrlImage { get; set; } = string.Empty;

        public int SubtopicId { get; set; }
        public Subtopic Subtopic { get; set; }
    }
}
