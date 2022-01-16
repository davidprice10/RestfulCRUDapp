using RestfulCRUDapp.Models;

namespace RestfulCRUDapp.PlayerData
{
    public class SqlPlayerData : IPlayerData
    {
        private PlayerContext _playerContext;

        public SqlPlayerData(PlayerContext playerContext)
        {
            _playerContext = playerContext;
        }

        public Player AddPlayer(Player player)
        {
            player.Id = Guid.NewGuid();
            _playerContext.Players.Add(player);
            _playerContext.SaveChanges();
            return player;
        }

        public void DeletePlayer(Player player)
        {
            _playerContext.Players.Remove(player);
            _playerContext.SaveChanges();
        }

        public List<Player> getAllPlayers()
        {
            return _playerContext.Players.ToList();
        }

        public Player getAllPlayersByPosition(string position)
        {
            var player = _playerContext.Players.Find(position);
            return player;
        }

        public Player getAllPlayersByTeam(string teamName)
        {
            var player = _playerContext.Players.Find(teamName);
            return player;
        }

        public Player getPlayerById(Guid id)
        {
            var player = _playerContext.Players.Find(id);
            return player;
        }

        public Player UpdatePlayer(Player player)
        {
            var existingPlayer = _playerContext.Players.Find(player.Id);
            if (existingPlayer != null)
            {
                _playerContext.Players.Update(existingPlayer);
                _playerContext.SaveChanges();
            }

            return player;
        }
    }
}
