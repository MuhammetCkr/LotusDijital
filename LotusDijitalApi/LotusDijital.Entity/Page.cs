using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Entity
{
    public class Page : Base
    {
        public Page()
        {
            InnerPages = new List<InnerPage>();
        }
        public string Title { get; set; }
        public List<InnerPage> InnerPages { get; set; }
        
    }
}
