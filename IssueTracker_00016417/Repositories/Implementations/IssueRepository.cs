using IssueTracker_00016417.Data;
using IssueTracker_00016417.Models;
using IssueTracker_00016417.Repositories.Interfaces;

namespace IssueTracker_00016417.Repositories.Implementations
{
    public class IssueRepository : IRepoIssue
    {
        private readonly Context _context;

        public IssueRepository(Context context)
        {
            _context = context;
        }

        public void CreateIssue(Issue issue)
        {
            var issueCategory = _context.Categories.Find(issue.CategoryId);
            var issueDeveloper = _context.Developers.Find(issue.DeveloperId);
            issue.Developer = issueDeveloper;
            issue.Category = issueCategory;
            _context.Issues.Add(issue);
            _context.SaveChanges();
        }

        public void DeleteIssue(int id)
        {
            _context.Issues.Remove(GetIssue(id));
            _context.SaveChanges();
        }

        public Issue GetIssue(int id)
        {
            return _context.Issues.Find(id);
        }

        public IEnumerable<Issue> GetIssues()
        {
            return _context.Issues.ToList();
        }

        public void UpdateIssue(int id, Issue issue)
        {
            var foundIssue = GetIssue(id);
            if (foundIssue != null)
            {
                _context.Issues.Remove(foundIssue);
                _context.Issues.Add(issue);
                _context.SaveChanges();
            }
        }
    }
}
