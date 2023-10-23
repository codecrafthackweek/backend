namespace APICodeCraft.Models
{
    public class Subtopic
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specification { get; set; } = string.Empty;

        public int CourseId { get; set; }
        public Course Course { get; set; }
     }
}
