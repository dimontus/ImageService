using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImageService.Entities;

namespace ImageService.Services
{
    public interface IImageServiceTest
    {
        Task<IEnumerable<ImageEntity>> GetAll();
    }
}