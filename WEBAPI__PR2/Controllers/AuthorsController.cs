using BLLP2.DTO.Req;
using BLLP2.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Project2.DAL.Entities;
using Project2.DAL.Interfaces;

namespace WEBAPI__PR2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly ILogger<Authors> _logger;
        //private readonly IUnitOfWork UOW;
        private readonly IAuthorService _authorservice;

        public AuthorsController(IAuthorService authorservice, ILogger<Authors> logger)
        {
            _logger = logger;

            _authorservice = authorservice;
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthorAsync([FromBody] AuthorReqDTO requestDto)
        {
            try
            {
                await _authorservice.AddAsync(requestDto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthorAsync([FromBody] AuthorReqDTO requestDto)
        {
            try
            {
                await _authorservice.UpdateAsync(requestDto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthorAsync(int id)
        {
            try
            {
                await _authorservice.DeleteAsync(id);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            try
            {
                var result = await _authorservice.GetByIdAsync(id);

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
                var results = await _authorservice.GetAllAsync();
                return Ok(results);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

    }
}
