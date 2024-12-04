using IssueTracker_00016417.Data;
using IssueTracker_00016417.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker_00016417.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly Context _context;
        public DeveloperController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetDevelopers()
        {
            return Ok(_context.Developers.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetDeveloper(int id)
        {
            return Ok(_context.Developers.Find(id));
        }

        [HttpPost]
        public IActionResult PostDeveloper(Developer developer)
        {
            _context.Developers.Add(developer);
            _context.SaveChanges();
            return Ok(developer);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDeveloper(int id, Developer developer)
        {
            var foundDeveloper = _context.Developers.Find(id);
            if (foundDeveloper != null)
            {
                _context.Remove(foundDeveloper);
                _context.Add(developer);
                return Ok(developer);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDeveloper(int id)
        {
            _context.Remove(_context.Developers.Find(id));
            _context.SaveChanges();
            return Ok();
        }
            
    }
}