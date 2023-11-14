using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class AddProductDto
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public List<int> CategoryIds { get; set; }
        public List<int> ImageGalleryIds { get; set; }
        public List<int> VideoGalleryIds { get; set; }
        public List<int> DocumentGalleryIds { get; set; }
    }
}
