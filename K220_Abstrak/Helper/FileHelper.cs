namespace K220_Abstrak.Helper
{
    public static class FileHelper
    {
        public static async Task<string> UploadImage(IFormFile ImageUrl, IWebHostEnvironment _env)
        {
            var path = "/images/" + Guid.NewGuid().ToString() + ImageUrl.FileName;
            using (var fileStream = new FileStream(_env.WebRootPath + path, FileMode.Create))
            {
                ImageUrl.CopyToAsync(fileStream);
            }
            
            return path;
        }
    }
}
