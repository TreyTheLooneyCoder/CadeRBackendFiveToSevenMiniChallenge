using Microsoft.AspNetCore.Mvc;
using CadeRBackendFiveToSeven.Services;

namespace CadeRBackendFiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersController : ControllerBase
    {
        private readonly ReverseItNumbersServices _reverseItNumbersServices;
        public ReverseItNumbersController(ReverseItNumbersServices reverseItNumbersServices)
        {
            _reverseItNumbersServices = reverseItNumbersServices;
        }

        [HttpGet]
        [Route("Reversing/{reverseNum}")]
        public string NumReverse(int reverseNum)
        {
            return _reverseItNumbersServices.NumReverse(reverseNum);
        }
    }
}