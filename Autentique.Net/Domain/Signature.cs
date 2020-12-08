using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Domain
{
    public class Signature
    {
        public string public_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime created_at { get; set; }
        public Action action { get; set; }
        public Link link { get; set; }
        public User user { get; set; }
        public Event viewed { get; set; }
        public Event signed { get; set; }
        public Event rejected { get; set; }
    }
}
