using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class SettingsDto : BaseDto
    {
        public string Favicon { get; set; }
        public string Logo { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Youtube { get; set; }
        public string Instagram { get; set; }
        public string Trendyol { get; set; }
        public string Hepsiburada { get; set; }
        public string Ciceksepeti { get; set; }
        public string FooterContent { get; set; }
        public string Phone { get; set; }
    }
}
