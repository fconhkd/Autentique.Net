using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentique.Utils
{
    class Queries
    {
        public const string DOC_LIST = "query { documents(limit: 60, page: 1) { total, data { id, name, refusable, sortable, created_at, signatures { public_id, name, email, created_at, action { name }, link { short_link }, user { id, name, email }, viewed { created_at }, signed { created_at }, rejected { created_at } } files { original signed } } } }";
        public const string FOLDER_LIST = "query { folders(limit: 60, page: 1) { total, data { id, name, type, created_at } } }";
    }
}
