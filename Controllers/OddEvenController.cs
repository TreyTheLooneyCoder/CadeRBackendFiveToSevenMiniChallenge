using Microsoft.AspNetCore.Mvc;
using CadeRBackendFiveToSeven.Services;

namespace CadeRBackendFiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddEvenController : ControllerBase
    {
         private readonly OddEvenServices _oddEvenServices;
        public OddEvenController(OddEvenServices oddEvenServices)
        {
            _oddEvenServices = oddEvenServices;
        }

        [HttpGet]
        [Route("OddEven/{checkedNum}")]
         public string OddOrEven(int checkedNum)
        {
            return _oddEvenServices.OddOrEven(checkedNum);
        }
    }
}