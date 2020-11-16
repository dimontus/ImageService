using System.Collections.Generic;
using ImageService.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ImageService.Services
{
    public class ImageServiceTest : IImageServiceTest
    {
        private readonly ImageContext _imageContext;

        public ImageServiceTest(ImageContext imageContext)
        {
            _imageContext = imageContext;
        }

        public async Task<IEnumerable<ImageEntity>> GetAll()
        {
            return await _imageContext.Images.ToListAsync();
        }
    }
}