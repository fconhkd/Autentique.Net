using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Utils
{
    internal class ErrorResult
    {
        public IList<string> Errors { get; internal set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; internal set; }
    }
}
