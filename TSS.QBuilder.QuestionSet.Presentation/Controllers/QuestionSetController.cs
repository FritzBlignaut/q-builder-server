using Microsoft.AspNetCore.Mvc;
using TSS.QBuilder.Service.Contracts;

namespace TSS.QBuilder.QuestionSet.Presentation.Controllers
{
    [Route("api/questionset")]
    [ApiController]
    public class QuestionSetController : ControllerBase
    {
        private readonly IServiceManager _service;

        public QuestionSetController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetAllQuestionSets(bool trackChanges)
        {
            try
            {
                var questionSets = _service.QuestionSetService.GetAllQuestionSets(trackChanges)?.ToList() ?? [];
                return Ok(questionSets);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
