namespace KaziFlowApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }

        // Foreign key
        public int UserId { get; set; }
        public User User { get; set; }

        public int? ProjectId { get; set; }      // Optional
        public Project? Project { get; set; }

        // Optional relationships
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
        public ICollection<Tag> TaskTags { get; set; } = new List<Tag>();
    }
}
