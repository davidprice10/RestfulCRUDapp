using Microsoft.AspNetCore.Mvc;
using RestfulCRUDapp.PlayerData;

namespace RestfulCRUDapp.Controllers
{
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private IPlayerData _playerData;
        public PlayersController(IPlayerData playerData)
        {
            _playerData = playerData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetPlayers()
        {
            return Ok (_playerData.getAllPlayers());
        }
    }
}
