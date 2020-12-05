using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Domain
{
    public class Document
    {
        public int id { get; set; }
        public string name { get; set; }
        public string filePath { get; set; }
        public Signer[] signers { get; set; }
    }
}
