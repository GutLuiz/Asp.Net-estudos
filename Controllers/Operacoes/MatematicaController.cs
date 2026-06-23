using Microsoft.AspNetCore.Mvc;

namespace Estudos.Controllers.Operacoes
{
    [ApiController]
    [Route("[controller]")]
    public class MatematicaController : ControllerBase
    {
        [HttpGet("/Sum/{n1}/{n2}")]

        public IActionResult GetSoma(string n1, string n2)
        {
            if(isNumeric(n1) && isNumeric(n2))
            {
                var sum = ConvertToDecimal(n1) + ConvertToDecimal(n2);
                return Ok(sum);
            }
            return BadRequest(0);
        }
        [HttpGet("/sub/{n1}/{n2}")]
        public IActionResult GetSubtrai(string n1, string n2)
        {
            if (isNumeric(n1) && isNumeric(n2))
            {
                var sub = ConvertToDecimal(n1) - ConvertToDecimal(n2);
                return Ok(sub);
            }
            return BadRequest(0);
        }
        [HttpGet("/mul/{n1}/{n2}")]
        public IActionResult GetMultiplica(string n1, string n2)
        {
            if (isNumeric(n1) && isNumeric(n2))
            {
                var mult = ConvertToDecimal(n1) * ConvertToDecimal(n2);
                return Ok(mult);
            }
            return BadRequest(0);
        }
        [HttpGet("/div/{n1}/{n2}")]
        public IActionResult GetDivide(string n1, string n2)
        {
            if (isNumeric(n1) && isNumeric(n2))
            {
                var div = ConvertToDecimal(n1) / ConvertToDecimal(n2);
                return Ok(div);
            }
            return BadRequest(0);
        }
        [HttpGet("/med/{n1}/{n2}")]
        public IActionResult GetMedia(string n1, string n2)
        {
            if (isNumeric(n1) && isNumeric(n2))
            {
                var med = (ConvertToDecimal(n1) + ConvertToDecimal(n2)) / 2 ;
                return Ok(med);
            }
            return BadRequest(0);
        }

        private int ConvertToDecimal(string n2)
        {
            throw new NotImplementedException();
        }

        private bool isNumeric(string n1)
        {
            throw new NotImplementedException();
        }
    }
}
