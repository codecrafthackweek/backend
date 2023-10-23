using APICodeCraft.Models;
using APICodeCraft.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICodeCraft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _contentService;

        public ContentController(IContentService contentService)
        {
            this._contentService = contentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Content>>> GetAllContent()
        {
            var contents = await _contentService.GetAllContentAsync();
            return Ok(contents);
        }

    }
}
