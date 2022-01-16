using Microsoft.AspNetCore.Mvc;
using RestfulCRUDapp.Models;
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

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetPlayerById(Guid id)
        {
            var player = _playerData.getPlayerById(id);

            if (player != null)
            {
                return Ok(player);
            }
            else
            {
                return NotFound($"Player with Id: {id} was not found.");
            }
        }

        [HttpGet]
        [Route("api/[controller]/TeamName/{teamName}")]
        public IActionResult GetAllPlayersByTeam(string teamName)
        {
            var player = _playerData.getAllPlayersByTeam(teamName);

            if (player != null)
            {
                return Ok(player);
            }
            else
            {
                return NotFound($"No current players in this team: {teamName}.");
            }
        }

        [HttpGet]
        [Route("api/[controller]/Position/{position}")]
        public IActionResult GetAllPlayerByPosition(string position)
        {
            var player = _playerData.getAllPlayersByPosition(position);

            if (player != null)
            {
                return Ok(player);
            }
            else
            {
                return NotFound($"No current players playing this position: {position}.");
            }
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddPlayer(Player player)
        {
            _playerData.AddPlayer(player);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + player.Id, player);

        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeletePlayer(Guid id)
        {
            var player = _playerData.getPlayerById(id);
            if(player != null)
            {
                _playerData.DeletePlayer(player);
                return Ok("Successfully deleted");
            }

            return NotFound($"Player with Id: {id} was not found.");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult UpdatePlayer(Guid id, Player player)
        {
            var existingPlayer = _playerData.getPlayerById(id);
            if(existingPlayer == null)
            {
                return BadRequest($"Player with Id: {id} was not found.");
            }

            if (player != null)
            {
                player.Id = existingPlayer.Id;
                _playerData.UpdatePlayer(player);
            }

            return Ok(player);
        }
    }
}
