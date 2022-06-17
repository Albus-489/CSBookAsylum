using BLL_Project2.DTO.Requests;
using BLL_Project2.Interfaces;
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

        [HttpPost("CreateAuthor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AddOfferAsync([FromBody] AuthorReqDTO author)
        {

            try
            {
                await _authorservice.AddAsync(author);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllAsync()
        {

            try
            {
                var result = await _authorservice.GetAllAsync();

                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }


        [HttpDelete("DeleteAuthor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteOfferAsync([FromBody] int authorID)
        {

            try
            {
                await _authorservice.DeleteAsync(authorID);

                return Ok("Author removed");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

    }
}
