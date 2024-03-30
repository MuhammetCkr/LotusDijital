using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class UpdateProductDto : BaseDto
    {
        public string Title { get; set; }
        public string Contents { get; set; } // İçerik
        public string ShortContent { get; set; } // Kısa içerik
        public string Image { get; set; }
        public string SmallImage { get; set; }
        public string Banner { get; set; }
        public bool IsHome { get; set; }
        public string Link { get; set; }
        public string TrendyolLink { get; set; }
        public string HepsiBuradaLink { get; set; }
        public string CicekSepetiLink { get; set; }
        public byte[] QRCode { get; set; }
        public List<int> CategoryIds { get; set; }
        public List<int> ImageGalleryIds { get; set; }
        public List<int> VideoGalleryIds { get; set; }
        public List<int> DocumentGalleryIds { get; set; }
    }
}
