using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class DocumentGalleryDto : BaseDto
    {
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int InnerPageId { get; set; }
        public InnerPageDto InnerPage { get; set; }
    }
}
