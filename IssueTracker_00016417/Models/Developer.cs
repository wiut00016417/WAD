namespace IssueTracker_00016417.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Issue>? Issues { get; set; }
    }
}
