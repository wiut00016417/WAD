using System.ComponentModel.DataAnnotations.Schema;

namespace IssueTracker_00016417.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int DeveloperId { get; set; }
        public required string Title { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("DeveloperId")]
        public virtual Developer? Developer { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}
