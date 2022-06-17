using Project1.DAL.Interfaces;
using Project1.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace FPWEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchesController : ControllerBase
    {
        private readonly ILogger<BranchesController> _logger;
        private IUnitOfWork  _uow;
        public BranchesController(ILogger<BranchesController> logger, IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;
        }

        // GET: api/Branches/GetAllBranches
        [HttpGet("GetAllBranches")]
        public async Task<ActionResult<IEnumerable<Branches>>> GetAllCategoriesAsync()
        {
            try
            {
                var results = await _uow.BranchesRepository.GetAllAsync();
                _uow.Commit();
                _logger.LogInformation($"Returned all branhes from database.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside GetAllBranches() action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        // DELETE: api/Branches/Delete/{id}
        [HttpDelete("Delete/{Id}")]
        public async Task<ActionResult> Delete([FromBody] long id)
        {
            try
            {
                await _uow.BranchesRepository.DeleteAsync(id);
                //_unitOfWOrk.Commit();
                _logger.LogInformation($"Delete branch by id {id}");
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! \nSomething want wrong insede DeleteAsync action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("Create")]
        public async Task<ActionResult<long>> Post([FromBody] Branches branch)
        {

            try
            {
                if (branch == null)
                {
                    _logger.LogError("Comment object sent from client is null.");
                    return BadRequest("Comment object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid Comment object sent from client.");
                    return BadRequest("Invalid model object");
                }
                var result = await _uow.BranchesRepository.AddAsync(branch);
                //_unitOfWOrk.Commit();
                //_logger.LogInformation($"Add post by id {branch.id}");
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
                var results = await _uow.BranchesRepository.GetAsync(id);
                //usrSrvcs.Commit();
                _logger.LogInformation($"Returned branch from database with id:{id}.");
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