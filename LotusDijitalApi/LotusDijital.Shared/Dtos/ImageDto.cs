using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class ImageDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public ImageGalleryDto ImageGallery { get; set; }
        public int ImageGalleryId { get; set; }
    }
}
