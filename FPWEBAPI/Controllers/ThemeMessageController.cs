using Project1.DAL.Interfaces;
using Project1.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace FPWEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ThemeMessageController : ControllerBase
    {
        private readonly ILogger<ThemeMessageController> _logger;
        private IUnitOfWork  _uow;
        public ThemeMessageController(ILogger<ThemeMessageController> logger, IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;
        }

        // GET: api/ThemeMessage/GetAllThemeMessages
        [HttpGet("GetAllThemeMessages")]
        public async Task<ActionResult<IEnumerable<ThemeMessage>>> GetAllCategoriesAsync()
        {
            try
            {
                var results = await _uow.ThemeMessageRepo.GetAllAsync();
                _uow.Commit();
                _logger.LogInformation($"Returned all theme message from database.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside GetAllThemeMessages() action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult> GetAsync(long id)
        {
            try
            {
                var results = await _uow.ThemeMessageRepo.GetAsync(id);
                //usrSrvcs.Commit();
                _logger.LogInformation($"Returned theme message from database with id:{id}.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside getThemeMessageByID action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete([FromBody] long id)
        {
            try
            {
                await _uow.ThemeMessageRepo.DeleteAsync(id);
                //_unitOfWOrk.Commit();
                _logger.LogInformation($"Delete theme message by id {id}");
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! \nSomething want wrong insede DeleteAsync action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("Create")]
        public async Task<ActionResult<long>> Post([FromBody] ThemeMessage tm)
        {

            try
            {
                if (tm == null)
                {
                    _logger.LogError("Comment object sent from client is null.");
                    return BadRequest("Comment object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid Comment object sent from client.");
                    return BadRequest("Invalid model object");
                }
                var result = await _uow.ThemeMessageRepo.AddAsync(tm);
                //_unitOfWOrk.Commit();
                //_logger.LogInformation($"Add post by id {thememessage.id}");
                return (result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! \nSomething went wrong insede AddAsync (theme message) action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}