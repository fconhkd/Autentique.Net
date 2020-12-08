using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Domain
{
    public class Document
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool refusable { get; set; }
        public bool sortable { get; set; }
        public DateTime created_at { get; set; }
        public List<Signature> signatures { get; set; }
        public File files { get; set; }
    }
}
