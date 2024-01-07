namespace LotusDijital.WebUI.Areas.Admin.Models
{
    public static class Jobs
    {
        public const string ImageRoute = "/content/images/";

        public static string UploadImage(IFormFile formFile)
        {
            var extension = Path.GetExtension(formFile.FileName);
            var randomName = Path.GetRandomFileName() + extension;

            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/content/images");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var path = Path.Combine(folderPath, randomName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                formFile.CopyTo(stream);
            }
            return randomName;
        }

    }
}
