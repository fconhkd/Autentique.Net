using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Utils
{
    public class AutentiqueException : Exception
    {
        private string message;
        private int statusCode;

        public AutentiqueException(string message, int statusCode)
        {
            this.message = message;
            this.statusCode = statusCode;

        }
    }
}
