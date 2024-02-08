using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class AddImageGalleryDto
    {
        public string Name { get; set; }
        public List<ImageDto> Images { get; set; }
        public bool IsActive { get; set; }

    }
}
