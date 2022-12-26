using Project1.DAL.Interfaces;
using Project1.DAL.Models;
using Project1.BLL.Configs;
using Project1.BLL.Services;
using Project1.BLL.DTO.Req;
using Project1.BLL.DTO.Res;
using Project1.BLL.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace FPWEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchesController : ControllerBase
    {
        private IBranchesServices _branchService;

        public BranchesController(IBranchesServices branchService)
        {
            _branchService = branchService;
        }

        // GET: api/Branches/GetAllBranches
        [HttpGet("GetAllBranches")]
        public async Task<ActionResult<IEnumerable<BranchesResDTO>>> GetAllBranchesAsync()
        {
            try
            {
                var results = await _branchService.GetAllBranches();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        // DELETE: api/Branches/Delete/{id}
        [HttpDelete("Delete/{Id}")]
        public async Task<ActionResult> Delete([FromBody] long id)
        {
            try
            {
                await _branchService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost("Create")]
        public async Task<ActionResult<long>> Post([FromBody] BranchesReqDTO branch)
        {

            try
            {
                await _branchService.AddAsync(branch);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.ToString());
            }
        }

        [HttpPut("Edit")]
        public async Task<ActionResult> UpdateBranch(BranchesReqDTO branch)
        {
            try
            {
                await _branchService.UpdateAsync(branch);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}