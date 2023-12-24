using CustomerB2B.Models;
using CustomerB2B.Repositories;
using CustomerB2B.Repositories.Interfaces;
using CustomerB2B.Services.CompanyDocumentInfo;
using CustomerB2B.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerB2B.Services.CompanySystemInfo
{
    public class CompanySystemInfoService : ICompanySystemInfo
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CustomerB2BDbContext _dbContext;
        public CompanySystemInfoService(IUnitOfWork unitOfWork, CustomerB2BDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _dbContext = dbContext; 
        }
        public CompanySystemInformation GetCompanySystemByCompanyId(string companyId)
        {
            var model = _dbContext.CompanySystemInformations.Where(x => x.CompanyId == companyId).FirstOrDefault();
            if (model == null)
            {
                return new CompanySystemInformation();
            }
            return model;
        }

        public ResponseData InsertCompanySystem(CompanySystemInsertInfoViewModel companySystemInfo)
        {
            ResponseData res = new ResponseData();
            try
            {
                var model = new CompanySystemInsertInfoViewModel().ConvertViewModel(companySystemInfo);
                _unitOfWork.GenericRepository<CompanySystemInformation>().Add(model);
                _unitOfWork.Save();
                res.ResponseCode = ErrorCode.SUCCESS_CODE;
                res.ResponseMessage = ErrorCode.INSERT_SUCCESS_MESSAGE;
                res.Data = model;
            }
            catch (Exception ex)
            {
                res.ResponseCode = ErrorCode.ERROR_SYSTEM_CODE;
                res.ResponseMessage = ErrorCode.ERROR_SYSTEM_MESSAGE;
                res.Data = null;
            }
            return res;
        }

        public ResponseData UpdateCompanySystem(CompanySystemUpdateInfoViewModel companySystemInfo, string id)
        {
            ResponseData res = new ResponseData();
            try
            {
                var _id = Guid.Parse(id);
                var modelById = _unitOfWork.GenericRepository<CompanySystemInformation>().GetById(_id);
                modelById.SaleStaff = companySystemInfo.SaleStaff;
                modelById.CustomerType = companySystemInfo.CustomerType;
                _unitOfWork.GenericRepository<CompanySystemInformation>().Update(modelById);
                _unitOfWork.Save();
                res.ResponseCode = ErrorCode.SUCCESS_CODE;
                res.ResponseMessage = ErrorCode.UPDATE_SUCCESS_MESSAGE;
                res.Data = modelById;
            }
            catch (Exception ex)
            {
                res.ResponseCode = ErrorCode.ERROR_SYSTEM_CODE;
                res.ResponseMessage = ErrorCode.ERROR_SYSTEM_MESSAGE;
                res.Data = null;
            }
            return res;
        }
    }
}
