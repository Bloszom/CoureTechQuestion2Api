using CoureTechQuestion2.Core.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoureTechQuestion2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneNoController : ControllerBase
    {

        private readonly ICountryService _countryService;

        public PhoneNoController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("phoneNumber")]
        public IActionResult GetCountryDetails(string phoneNumber)
        {
            var result = _countryService.GetCountryDetailsByPhoneNumber(phoneNumber);
            if (result == null)
            {
                return NotFound("Country not found.");
            }

            return Ok(result);

        }
    }
}
