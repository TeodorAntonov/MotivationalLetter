using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace FastMotivationalLetter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonInfoController : ControllerBase
    {
        private ICreateDocumentService _service;
        public PersonInfoController(ICreateDocumentService service)
        {
            _service = service;
        }
        [HttpPost("CreateDocument")]
        public async Task<IActionResult> CreateDocument([FromBody] PersonInfo personInfo)
        {

            await _service.CreateDcoument(personInfo);
            return Ok(personInfo.Name);
        }
    }
}
