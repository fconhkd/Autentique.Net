using Autentique.Domain;
using Autentique.Utils;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Autentique.Service
{
    /// <summary>
    /// Autentique SDK. For more information visit <see cref="https://docs.autentique.com.br/api"/>
    /// </summary>
    public class AutentiqueService
    {
        private readonly ILog log;
        private string _url = Constants.URL_BASE;
        private string _token { get; set; }

        /// <summary>
        /// Initialize new instance of class <see cref="AutentiqueService"/>
        /// </summary>
        /// <param name="urlBase"></param>
        public AutentiqueService(string token, string urlBase = "https://api.autentique.com.br/v2/graphql")
        {
            if (string.IsNullOrEmpty(token)) throw new ArgumentNullException("token", "Token is null or empty");

            this._token = token;
            this._url = urlBase;
            this.log = LogManager.GetLogger(this.GetType());
        }

        public async Task<GenericResult<List<Document>>> ListDocuments()
        {
            var result = new GenericResult<List<Document>>();

            var request = new RestRequest();
            request.AddHeader("Authorization", string.Format("Bearer {0}", _token));
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(new GraphQLRequest(Queries.DOC_LIST)));

            var client = new RestClient(_url);
            RestResponse response = await client.ExecutePostAsync(request);
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

        public async Task<GenericResult<List<Folder>>> ListFolders()
        {
            var result = new GenericResult<List<Folder>>();

            var request = new RestRequest();
            request.AddHeader("Authorization", string.Format("Bearer {0}", _token));
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(new GraphQLRequest(Queries.FOLDER_LIST)));

            var client = new RestClient(_url);
            RestResponse response = await client.ExecutePostAsync(request);
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
