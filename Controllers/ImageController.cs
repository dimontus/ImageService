using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ImageService.Models;
using System.Threading.Tasks;
using AutoMapper;
using ImageService.Services;

namespace ImageService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IImageServiceTest _imageServiceTest;
        private readonly ILogger<ImageController> _logger;

        public ImageController(IMapper mapper,  IImageServiceTest imageServiceTest, ILogger<ImageController> logger)
        {
            _mapper = mapper;
            _imageServiceTest = imageServiceTest;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Image>> Get()
        {
            var imageEntities =  await _imageServiceTest.GetAll();
            return _mapper.Map<IEnumerable<Image>>(imageEntities);
        }
    }
}
