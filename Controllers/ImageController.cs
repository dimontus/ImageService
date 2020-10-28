using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ImageService.Models;
using System.Threading.Tasks;

namespace ImageService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly ILogger<ImageController> _logger;

        public ImageController(ILogger<ImageController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Image>> Get()
        {
            var rng = new Random();
            return await Task.Run(() => Enumerable.Range(1, 5).Select(index => new Image()).ToArray());
        }
    }
}
