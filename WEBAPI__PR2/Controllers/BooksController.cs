using BLLP2.DTO.Req;
using BLLP2.Interfaces;
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
        //private readonly IUnitOfWork UOW;
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService, ILogger<Books> logger)
        {
            //this.UOW = uow;
            _logger = logger;
            _bookService = bookService;
        }

        [HttpPost]
        public async Task<IActionResult> AddBookAsync([FromBody] BookReqDTO requestDto)
        {
            try
            {
                await _bookService.AddAsync(requestDto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBookAsync([FromBody] BookReqDTO requestDto)
        {
            try
            {
                await _bookService.UpdateAsync(requestDto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookAsync(int id)
        {
            try
            {
                await _bookService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            try
            {
                var result = await _bookService.GetByIdAsync(id);

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
                var results = await _bookService.GetAllAsync();
                return Ok(results);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

    }
}
