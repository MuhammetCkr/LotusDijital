using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Entity
{
    public class Product : Base
    {
        public string Image { get; set; }
        public string Link { get; set; }
        public List<ProductCategories> ProductCategories { get; set; }
    }
}
