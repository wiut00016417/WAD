using IssueTracker_00016417.Data;
using IssueTracker_00016417.Models;
using IssueTracker_00016417.Repositories.Interfaces;

namespace IssueTracker_00016417.Repositories.Implementations
{
    public class CategoryRepository : IRepoCategory
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public void CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            _context.Categories.Remove(GetCategory(id));
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Find(id);
        }

        public void UpdateCategory(int id, Category category)
        {
            var foundCategory = GetCategory(id);
            if (foundCategory != null)
            {
                _context.Categories.Remove(foundCategory);
                _context.Categories.Add(category);
                _context.SaveChanges();
            }
        }
    }
}
