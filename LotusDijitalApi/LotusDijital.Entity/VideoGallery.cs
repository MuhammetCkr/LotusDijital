using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Entity
{
    public class VideoGallery : Base
    {
        public string VideoImage { get; set; }
        public string VideoEmbed { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int InnerPageId { get; set; }
        public InnerPage InnerPage { get; set; }
    }
}
