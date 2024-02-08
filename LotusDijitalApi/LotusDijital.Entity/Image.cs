using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Entity
{
    public class Image : Base
    {
        public ImageGallery ImageGallery { get; set; }
        public int? ImageGalleryId { get; set; }

    }
}
