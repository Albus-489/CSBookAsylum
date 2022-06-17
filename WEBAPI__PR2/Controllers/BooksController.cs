using Microsoft.AspNetCore.Mvc;
using Project2.DAL.Entities;
using Project2.DAL.Interfaces;

namespace WEBAPI__PR2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<Books> _logger;
        private readonly IUnitOfWork UOW;

        public BooksController(IUnitOfWork uow, ILogger<Books> logger)
        {
            this.UOW = uow;
            _logger = logger;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<Books>>> GetAllCategoriesAsync()
        {
            try
            {
                var results = await UOW.Books.GetAllAsync();
                //UOW.Commit();
                _logger.LogInformation($"Returned all books from database.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside GetAll() action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost("Create")]
        public async Task<ActionResult<long>> Post([FromBody] Books book)
        {

            try
            {
                if (book == null)
                {
                    _logger.LogError("Comment object sent from client is null.");
                    return BadRequest("Comment object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid Comment object sent from client.");
                    return BadRequest("Invalid model object");
                }
                await UOW.Books.AddAsync(book);
                //_unitOfWOrk.Commit();
                //_logger.LogInformation($"Add post by id {branch.id}");
                return Ok("Book has been added");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! \nSomething went wrong insede AddAsync action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

    }
}
