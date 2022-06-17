using Project1.DAL.Interfaces;
using Project1.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Project1.BLL.Services;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;
using Project1.BLL.Interfaces;

namespace FPWEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private IUnitOfWork  _uow;
        public UsersController(ILogger<UsersController> logger, IUnitOfWork usrUOW)
        {
            _logger = logger;
            _uow = usrUOW;
        }

        // GET: api/Users/GetAllUsers
        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<AspNetUsers>>> GetAllUsersAsync()
        {
            try
            {
                var results = await _uow.UsersRepository.GetAllAsync();
                //usrSrvcs.Commit();
                _logger.LogInformation($"Returned all users from database.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside GetAllUsers() action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult> GetAsync(long id)
        {
            try
            {
                var results = await _uow.UsersRepository.GetAsync(id);
                //usrSrvcs.Commit();
                _logger.LogInformation($"Returned user from database with id:{id}.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside GetUserByID() action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete([FromBody] long id)
        {
            try
            {
                await _uow.UsersRepository.DeleteAsync(id);
                //_unitOfWOrk.Commit();
                _logger.LogInformation($"Delete User by id {id}");
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! \nSomething want wrong insede DeleteAsync action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("Create")]
        public async Task<ActionResult<long>> Post([FromBody] AspNetUsers user)
        {

            try
            {
                if (user == null)
                {
                    _logger.LogError("Comment object sent from client is null.");
                    return BadRequest("Comment object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid Comment object sent from client.");
                    return BadRequest("Invalid model object");
                }
                var result = await _uow.UsersRepository.AddAsync(user);
                //_unitOfWOrk.Commit();
                //_logger.LogInformation($"Add post by id {user.id}");
                return (result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! \nSomething went wrong insede AddAsync action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}