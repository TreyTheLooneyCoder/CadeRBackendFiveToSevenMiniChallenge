using Microsoft.AspNetCore.Mvc;
using CadeRBackendFiveToSeven.Services;

namespace CadeRBackendFiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphanumericController : ControllerBase
    {
        private readonly ReverseItAlphanumericServices _reverseItAlphanumericServices;
        public ReverseItAlphanumericController(ReverseItAlphanumericServices reverseItAlphanumericServices)
        {
            _reverseItAlphanumericServices = reverseItAlphanumericServices;
        }

        [HttpGet]
        [Route("Reversing/{letters}")]
        public string LetterReverse(string letters)
        {
            return _reverseItAlphanumericServices.LetterReverse(letters);
        }
    }
}