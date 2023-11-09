using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Entity
{
    public class ImageGallery : Base
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int InnerPageId { get; set; }
        public InnerPage InnerPage { get; set; }

    }
}
