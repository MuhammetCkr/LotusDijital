using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Entity
{
    public class Category : Base
    {
        public Category()
        {
            new List<ProductCategories>();
        }
        public string Image { get; set; }
        public string Details { get; set; }
        public List<ProductCategories> ProductCategories { get; set; }
    }
}
