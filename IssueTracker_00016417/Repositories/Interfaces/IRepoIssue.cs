using IssueTracker_00016417.Models;

namespace IssueTracker_00016417.Repositories.Interfaces
{
    public interface IRepoIssue
    {
        public IEnumerable<Issue> GetIssues();
        public Issue GetIssue(int id);
        public void CreateIssue(Issue issue);
        public void UpdateIssue(int id, Issue issue);
        public void DeleteIssue(int id);
    }
}
