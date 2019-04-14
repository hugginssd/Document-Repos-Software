using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliamero_Document_Repository_System.BLL
{
    class UserEmployeeBLL
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public byte[] Picture { get; set; }
        public string Cellnumber { get; set; }
        public string Email { get; set; }

    }
}
