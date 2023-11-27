using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class ProductDto : BaseDto
    {
        public string Image { get; set; }
        public string Link { get; set; }
        public List<CategoryDto> Categories { get; set; }
        public List<ImageGalleryDto> ImageGalleries { get; set; }
        //public List<VideoGalleryDto> VideoGalleries { get; set; }
        //public List<DocumentGalleryDto> DocumentGalleries { get; set; }

    }
}
