using Autentique.Domain;
using Autentique.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;


namespace Autentique.Service
{
    public class AutentiqueService
    {
        private string _urlBase = Constants.URL_BASE;
        public AutentiqueService() { }

        public AutentiqueService(string urlBase)
        {
            _urlBase = urlBase;
        }

        public GenericResult<List<Document>> ListDocuments(string token)
        {
            string payLoad = "query { documents(limit: 60, page: 1) { total data { id name } } }";

            var result = new GenericResult<List<Document>>();

            var client = new RestClient(_urlBase);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", string.Format("bearer {0}", token));
            request.AddHeader("Content-Type", "application/json");
            request.AddBody(payLoad);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                result.Result = JsonConvert.DeserializeObject<List<Document>>(response.Content);
                result.Success = true;
                result.Json = response.Content;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                result.Result = new List<Document>();
                result.Success = true;
            }
            else
            {
                result.Message = response.StatusDescription;
            }

            return result;
        }
    }
}
