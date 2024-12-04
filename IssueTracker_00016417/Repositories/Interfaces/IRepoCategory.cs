using IssueTracker_00016417.Models;

namespace IssueTracker_00016417.Repositories.Interfaces
{
    public interface IRepoCategory
    {
        public IEnumerable<Category> GetCategories();
        public Category GetCategory(int id);
        public void CreateCategory(Category category);
        public void UpdateCategory(int id, Category category);
        public void DeleteCategory(int id);
    }
}
