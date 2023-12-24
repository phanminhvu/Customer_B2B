using CustomerB2B.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerB2B.ViewModels
{
    public class CompanySystemInfoViewModel
    {
        public string Id { get; set; }
        public string CompanyId { get; set; }
        public Int16? CustomerType { get; set; }
        public string SaleStaff { get; set; }
        public CompanySystemInfoViewModel() { }
        public CompanySystemInfoViewModel(CompanySystemInformation model)
        {
            Id = model.Id.ToString();
            CustomerType = model.CustomerType;
            CompanyId = model.CompanyId;
            SaleStaff = model.SaleStaff;

        }

        public CompanySystemInformation ConvertViewModel(CompanySystemInfoViewModel model)
        {
            return new CompanySystemInformation
            {
                Id = Guid.Parse(model.Id),
                CustomerType = model.CustomerType,
                SaleStaff = model.SaleStaff,
                CompanyId = model.CompanyId
            };
        }
    }



    public class CompanySystemInsertInfoViewModel
    {
        public Int16? CustomerType { get; set; }
        public string SaleStaff { get; set; }
        public string CompanyId { get; set; }

        public CompanySystemInsertInfoViewModel() { }



        public CompanySystemInformation ConvertViewModel(CompanySystemInsertInfoViewModel model)
        {
            return new CompanySystemInformation
            {
                Id = new Guid(),
                CustomerType = model.CustomerType,
                SaleStaff = model.SaleStaff,
                CompanyId = model.CompanyId
            };
        }
    }


    public class CompanySystemUpdateInfoViewModel
    {
        public Int16? CustomerType { get; set; }
        public string SaleStaff { get; set; }

        public CompanySystemUpdateInfoViewModel() { }



        public CompanySystemInformation ConvertViewModel(CompanySystemUpdateInfoViewModel model)
        {
            return new CompanySystemInformation
            {
                CustomerType = model.CustomerType,
                SaleStaff = model.SaleStaff,
            };
        }
    }
}
