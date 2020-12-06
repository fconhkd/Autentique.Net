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
        public string filePath { get; set; }
        public List<Signer> signers { get; set; }
    }
}
