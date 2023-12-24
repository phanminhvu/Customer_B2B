using CustomerB2B.Models;
using CustomerB2B.Repositories;
using CustomerB2B.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerB2B.Services.CompanySystemInfo
{
    public interface ICompanySystemInfo
    {
        CompanySystemInformation GetCompanySystemByCompanyId(string companyId);
        ResponseData UpdateCompanySystem(CompanySystemUpdateInfoViewModel companySystemInfo, string id);
        ResponseData InsertCompanySystem(CompanySystemInsertInfoViewModel companySystemInfo);
    }
}
