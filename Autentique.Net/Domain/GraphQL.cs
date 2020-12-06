using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Domain
{
    public class GraphQLRequest
    {
        public string query { get; set; }
        public string variables { get; set; }
    }
}
