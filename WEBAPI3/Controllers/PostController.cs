using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project3.App.WorkWithModel.PostDir.GetById;
using Project3.App.WorkWithModel.PostDir.GetList;

namespace Project3.WEBAPI3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private ISender _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostDTO>> GetPostById(int id)
        {
            try
            {
                var value = new GetPostByID(id);
                var post = await _mediator.Send(value);
                if (post == null)
                {
                    return NotFound();
                }

                return Ok(post);
            }
            catch (Exception ex)
            {
                return Ok("Error in GetPostById()" + ex.Message);
            }
        }
    }
}
