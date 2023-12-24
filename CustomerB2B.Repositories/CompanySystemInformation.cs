using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerB2B.Repositories
{
    public class CompanySystemInformation
    {
        public Guid Id { get; set; }
        public Int16? CustomerType { get; set; }
        public string SaleStaff { get; set; }
        public string CompanyId { get; set; }
    }
}
