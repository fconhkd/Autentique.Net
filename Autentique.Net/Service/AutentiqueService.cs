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

        public async Task<GenericResult<List<Document>>> ListDocuments(string _token)
        {
            var result = new GenericResult<List<Document>>();

            var client = new RestClient(_urlBase);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", string.Format("Bearer {0}", _token));
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(new GraphQLRequest(Queries.DOC_LIST)));
            
            IRestResponse response = await client.ExecuteAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var convert = JsonConvert.DeserializeObject<QueryResponse>(response.Content);
                result.Result = convert.data.documents.data;
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

        public async Task<GenericResult<List<Folder>>> ListFolders(string _token)
        {
            var result = new GenericResult<List<Folder>>();

            var client = new RestClient(_urlBase);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", string.Format("Bearer {0}", _token));
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(new GraphQLRequest(Queries.FOLDER_LIST)));

            IRestResponse response = await client.ExecuteAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var convert = JsonConvert.DeserializeObject<QueryResponse>(response.Content);
                result.Result = convert.data.folders.data;
                result.Success = true;
                result.Json = response.Content;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                result.Result = new List<Folder>();
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
