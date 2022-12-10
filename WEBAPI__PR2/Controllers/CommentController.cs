using BLLP2.DTO.Req;
using BLLP2.Interfaces;
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
        //private readonly IUnitOfWork UOW;
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService, ILogger<Comments> logger)
        {
            //this.UOW = uow;
            _logger = logger;
            _commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCommentAsync([FromBody] CommentReqDTO requestDto)
        {
            try
            {
                await _commentService.AddAsync(requestDto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCommentAsync([FromBody] CommentReqDTO requestDto)
        {
            try
            {
                await _commentService.UpdateAsync(requestDto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommentAsync(int id)
        {
            try
            {
                await _commentService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            try
            {
                var result = await _commentService.GetByIdAsync(id);

                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var results = await _commentService.GetAllAsync();
                return Ok(results);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

    }
}
