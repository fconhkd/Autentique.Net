using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Domain
{
    public class GraphQLRequest
    {
        public GraphQLRequest() { }
        public GraphQLRequest(string _query) { this.query = _query; }
        public GraphQLRequest(string _query, string _variables) { this.query = _query; this.variables = _variables; }

        public string query { get; set; }
        public string variables { get; set; }
    }
}
