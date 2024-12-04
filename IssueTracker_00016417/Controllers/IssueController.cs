using IssueTracker_00016417.Models;
using IssueTracker_00016417.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker_00016417.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        private readonly IRepoIssue _repo;

        public IssueController(IRepoIssue repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetIssues()
        {
            return Ok(_repo.GetIssues());
        }

        [HttpGet("{id}")]
        public IActionResult GetIssue(int id)
        {
            return Ok(_repo.GetIssue(id));
        }

        [HttpPost]
        public IActionResult AddIssue(Issue issue)
        {
            _repo.CreateIssue(issue);
            return Ok(issue);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateIssue(int id, Issue issue)
        {
            _repo.UpdateIssue(id, issue);
            return Ok(issue);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteIssue(int id)
        {
            _repo.DeleteIssue(id);
            return Ok();
        }
    }
}
