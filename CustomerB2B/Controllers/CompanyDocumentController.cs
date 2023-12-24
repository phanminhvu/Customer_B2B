using CustomerB2B.Services.CompanyDocumentInfo;
using CustomerB2B.Services.CompanyGroupInfo;
using CustomerB2B.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerB2B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyDocumentController : ControllerBase
    {
        private readonly ICompanyDocumentInfo _companyDocumentInfo;
        public CompanyDocumentController(ICompanyDocumentInfo companyDocumentInfo)
        {
            _companyDocumentInfo = companyDocumentInfo;
        }

        [HttpGet]
        public IActionResult Get(string companyId)
        {
            var lstCompanyGroup = _companyDocumentInfo.GetAll(companyId);
            return Ok(lstCompanyGroup);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var lstCompanyGroup = _companyDocumentInfo.GetCompanyDocumentById(id);
            return Ok(lstCompanyGroup);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CompanyDocumentInsertInfoViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = _companyDocumentInfo.InsertCompanyDocument(data);
            return Ok(res);
        }

        [HttpPost("update/{id}")]
        public IActionResult Update(string id, [FromBody] CompanyDocumentInfoViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = _companyDocumentInfo.UpdateCompanyDocument(data, id);
            return Ok(res);
        }

        [HttpPost("delete/{id}")]
        public IActionResult Remove(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = _companyDocumentInfo.DeleteCompnayDocument(id);
            return Ok(res);
        }


        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file is selected");

            var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");
            if (!Directory.Exists(uploadsFolderPath))
            {
                Directory.CreateDirectory(uploadsFolderPath);
            }

            var filePath = Path.Combine(uploadsFolderPath, file.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Trả lại đường dẫn tương đối hoặc tuyệt đối của file
            var fileUrl = Path.Combine("UploadedFiles", file.FileName);
            return Ok(new { FileUrl = fileUrl });
        }
    }
}
