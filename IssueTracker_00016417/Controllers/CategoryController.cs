using IssueTracker_00016417.Models;
using IssueTracker_00016417.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker_00016417.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepoCategory _repo;
        public CategoryController(IRepoCategory repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(_repo.GetCategories());
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            return Ok(_repo.GetCategory(id));
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _repo.CreateCategory(category);
            return Ok(category);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, Category category)
        {
            _repo.UpdateCategory(id, category);
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _repo.DeleteCategory(id);
            return Ok();
        }
    }
}
