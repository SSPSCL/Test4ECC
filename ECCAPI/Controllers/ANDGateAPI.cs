using Microsoft.AspNetCore.Mvc;

using ECCServices.Interfaces;

namespace ECCAPI.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class ANDGateAPI : ControllerBase
    {
        private IANDGate andGate;

        public ANDGateAPI (IANDGate andGate)
        {
            this.andGate = andGate;
        }

        [HttpGet]
        public uint And (uint inputA, uint inputB)
        {
            return andGate.AND (inputA, inputB);
        }
    }
}