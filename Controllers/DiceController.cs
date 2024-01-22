using Microsoft.AspNetCore.Mvc;
using ShadowrunDiceRollerBot.Models;

namespace ShadowrunDiceRollerBot.Controllers
{
    [ApiController]
    [Route("dice")]
    public class DiceController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public ActionResult<string> Index()
        {
            return Ok("ping");
        }

        [HttpPost]
        [Route("roll")]
        public ActionResult<DiceRollResult> Roll(DiceRollParameters parameters)
        {
            var result = new DiceRollResult();
            return Ok(result);
        }
    }
}