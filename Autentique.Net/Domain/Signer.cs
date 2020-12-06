using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Domain
{
    public class Signer
    {
        public string name { get; set; }
        public string email { get; set; }
        public SignerAction action { get; set; }
    }
}
