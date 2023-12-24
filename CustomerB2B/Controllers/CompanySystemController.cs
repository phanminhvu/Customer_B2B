using CustomerB2B.Services.CompanyDocumentInfo;
using CustomerB2B.Services.CompanySystemInfo;
using CustomerB2B.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerB2B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanySystemController : ControllerBase
    {
        private readonly ICompanySystemInfo _companySystemInfo;
        public CompanySystemController(ICompanySystemInfo companySystemInfo)
        {
            _companySystemInfo =  companySystemInfo;
        }

        [HttpGet]
        public IActionResult GetByCompanyId(string companyId)
        {
            var lstCompanyGroup = _companySystemInfo.GetCompanySystemByCompanyId(companyId);
            return Ok(lstCompanyGroup);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CompanySystemInsertInfoViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = _companySystemInfo.InsertCompanySystem(data);
            return Ok(res);
        }

        [HttpPost("update/{id}")]
        public IActionResult Update(string id, [FromBody] CompanySystemUpdateInfoViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = _companySystemInfo.UpdateCompanySystem(data, id);
            return Ok(res);
        }
    }
}
