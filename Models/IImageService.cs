namespace Hattfabriken.Models
{
    public interface IImageService
    {
        byte[] ConvertToByteArray(IFormFile file);
    }

    public class ImageService : IImageService
    {
        public byte[] ConvertToByteArray(IFormFile file)
        {
            using (MemoryStream memorystream = new MemoryStream())
            {
                file.CopyTo(memorystream);
                return memorystream.ToArray();
            }
        }
    }
}
