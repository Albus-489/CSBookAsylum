using BLLP2.DTO.Req;
using BLLP2.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Project2.DAL.Entities;
using Project2.DAL.Interfaces;

namespace WEBAPI__PR2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CollectionController : ControllerBase
    {
        private readonly ILogger<Collections> _logger;
        //private readonly IUnitOfWork UOW;
        private readonly ICollectionService _CollectionService;

        public CollectionController(ICollectionService CollectionService, ILogger<Collections> logger)
        {
            //this.UOW = uow;
            _logger = logger;
            _CollectionService = CollectionService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCollectionAsync([FromBody] CollectionReqDTO requestDto)
        {
            try
            {
                await _CollectionService.AddAsync(requestDto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCollectionAsync([FromBody] CollectionReqDTO requestDto)
        {
            try
            {
                await _CollectionService.UpdateAsync(requestDto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollectionAsync(int id)
        {
            try
            {
                await _CollectionService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCollectionById(int id)
        {
            try
            {
                var result = await _CollectionService.GetByIdAsync(id);

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
                var results = await _CollectionService.GetAllAsync();
                return Ok(results);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

    }
}
