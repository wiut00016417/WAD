namespace IssueTracker_00016417.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Importance { get; set; }
        public List<Issue>? Issues { get; set; }
    }
}
