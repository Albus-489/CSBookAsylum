using Microsoft.AspNetCore.Mvc;
using Project2.DAL.Entities;
using Project2.DAL.Interfaces;

namespace WEBAPI__PR2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ILogger<Comments> _logger;
        private readonly IUnitOfWork UOW;

        public CommentController(IUnitOfWork uow, ILogger<Comments> logger)
        {
            this.UOW = uow;
            _logger = logger;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<Comments>>> GetAllCategoriesAsync()
        {
            try
            {
                var results = await UOW.Comments.GetAllAsync();
                //UOW.Commit();
                _logger.LogInformation($"Returned all Comments from database.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside GetAllComments() action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost("Create")]
        public async Task<ActionResult<long>> Post([FromBody] Comments comment)
        {

            try
            {
                if (comment == null)
                {
                    _logger.LogError("Comment object sent from client is null.");
                    return BadRequest("Comment object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid Comment object sent from client.");
                    return BadRequest("Invalid model object");
                }
                await UOW.Comments.AddAsync(comment);
                //_unitOfWOrk.Commit();
                //_logger.LogInformation($"Add post by id {branch.id}");
                return Ok("Comment has been added");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! \nSomething went wrong insede AddAsync action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

    }
}
