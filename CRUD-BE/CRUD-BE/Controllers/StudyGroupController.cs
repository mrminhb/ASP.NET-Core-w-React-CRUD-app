using CRUD_BE.Business;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_BE.Models;

[ApiController]
[Route("[controller]")]
public class StudyGroupController : ControllerBase
{ 
    private readonly IStudyGroupService _studygroupService;

        public StudyGroupController(IStudyGroupService studyGroupService)
        {
            _studygroupService = studyGroupService;
        }

        [HttpPost]
        public IActionResult CreateGroup(List<Card> cards)
        {
            _studygroupService.Add(cards);

            return StatusCode(201);
        }
}