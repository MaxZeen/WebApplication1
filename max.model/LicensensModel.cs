using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.Model
{
    public class LicensensModel
    {
        public string CustomerCode { get; set; }
        public int MenuID { get; set; }
        public int CreateUser { get; set; }
        public DateTime ActivateDate { get; set; }
        public int ModifyUser { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
