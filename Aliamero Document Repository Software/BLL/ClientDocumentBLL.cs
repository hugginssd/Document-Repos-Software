using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliamero_Document_Repository_System.BLL
{
    class ClientDocumentBLL
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentName { get; set; }
        public DateTime SubmittDate { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string Document { get; set; }

    }
}
