using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class AddCategoryDto
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public string Details { get; set; }

    }
}
