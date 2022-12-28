using Project1.DAL.Interfaces;
using Project1.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace FPWEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ThemesController : ControllerBase
    {
        private readonly ILogger<ThemesController> _logger;
        private IUnitOfWork  _uow;
        public ThemesController(ILogger<ThemesController> logger, IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;
        }

        // GET: api/Themes/GetAllThemes
        [HttpGet("GetAllThemes")]
        public async Task<ActionResult<IEnumerable<Themes>>> GetAllCategoriesAsync()
        {
            try
            {
                var results = await _uow.ThemesRepository.GetAllAsync();
                _uow.Commit();
                _logger.LogInformation($"Returned all themes from database.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside GetAllThemes() action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        // DELETE: api/Theme/Delete/{id}
        [HttpDelete("Delete/{Id}")]
        public async Task<ActionResult> Delete([FromBody] long id)
        {
            try
            {
                await _uow.ThemesRepository.DeleteAsync(id);
                //_unitOfWOrk.Commit();
                _logger.LogInformation($"Delete theme by id {id}");
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! \nSomething want wrong insede DeleteAsync action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost()]
        public async Task<ActionResult<long>> Post([FromBody] Themes theme)
        {

            try
            {
                if (theme == null)
                {
                    _logger.LogError("Comment object sent from client is null.");
                    return BadRequest("Comment object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid Comment object sent from client.");
                    return BadRequest("Invalid model object");
                }
                var result = await _uow.ThemesRepository.AddAsync(theme);
                //_unitOfWOrk.Commit();
                //_logger.LogInformation($"Add post by id {theme.id}");
                return (result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! \nSomething went wrong insede AddAsync action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult> GetAsync(long id)
        {
            try
            {
                var results = await _uow.ThemesRepository.GetAsync(id);
                _logger.LogInformation($"Returned theme from database with id:{id}.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside GetByID() action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}