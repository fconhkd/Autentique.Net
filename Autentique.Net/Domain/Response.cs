using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Domain
{
    public class QueryResponse
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public DocumentsResponse documents { get; set; }
        public FoldersResponse folders { get; set; }
    }

    public class DocumentsResponse
    {
        public List<Document> data { get; set; }
    }

    public class FoldersResponse
    {
        public List<Folder> data { get; set; }
    }
}
