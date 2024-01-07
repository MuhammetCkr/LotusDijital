using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class PageDto : BaseDto
    {
        public string Title { get; set; }
        public List<InnerPageDto> InnerPages { get; set; }
    }
}
