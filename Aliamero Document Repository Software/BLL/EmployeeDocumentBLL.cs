using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliamero_Document_Repository_System.BLL
{
    class EmployeeDocumentBLL
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string DocumentType { get; set; }
        public string DocumentTypeCategory { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public DateTime SubmittedDate { get; set; }
        public bool OriginalDuplicate { get; set; }
        public bool ExpiryNo { get; set; }
        public DateTime ExpiryDate { get; set; }

    }
}
