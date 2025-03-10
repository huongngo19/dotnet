using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class ImageService
    {
        private readonly string _imagePath = "wwwroot/images/";

        public async Task<string> SaveImageAsync(IFormFile image)
        {
            if (image == null || image.Length == 0)
                return null;

            var filePath = Path.Combine(_imagePath, image.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            return filePath;
        }

        public void DeleteImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }
    }
}
