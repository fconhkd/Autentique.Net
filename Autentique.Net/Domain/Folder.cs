using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Domain
{
    public class Folder
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public DateTime created_at { get; set; }
    }
}
