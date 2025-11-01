namespace KaziFlowApi.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Tag> TaskTags { get; set; } = new List<Tag>();
    }
}
