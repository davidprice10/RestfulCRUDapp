using RestfulCRUDapp.Models;

namespace RestfulCRUDapp.PlayerData
{
    public class FakePlayerData : IPlayerData
    {
        private List<Player> players = new List<Player>()
        {
            new Player()
            {
                Id = Guid.NewGuid(),
                Name = "Joe Bloggs",
                TeamName = "Manchester City",
                Position = "Striker"
            },
            new Player()
            {
                Id = Guid.NewGuid(),
                Name = "Jane Smith",
                TeamName = "Manchester United",
                Position = "Goalkeeper"
            }
        };

        public Player AddPlayer(Player player)
        {
            player.Id = Guid.NewGuid();
            players.Add(player);
            return player;
        }

        public void DeletePlayer(Player player)
        {
            players.Remove(player);
        }

        public Player getAllPlayersByTeam(string teamName)
        {
            return players.SingleOrDefault(x => x.TeamName == teamName);
        }

        public Player getPlayerById(Guid id)
        {
            return players.SingleOrDefault(x => x.Id == id);
        }

        public Player getAllPlayersByPosition(string position)
        {
            return players.SingleOrDefault(x => x.Position == position);
        }

        public List<Player> getAllPlayers()
        {
            return players;
        }

        public Player UpdatePlayer(Player player)
        {
            var existingPlayer = getPlayerById(player.Id);
            if(existingPlayer != null)
            {
                existingPlayer.Name = player.Name;
                existingPlayer.TeamName = player.TeamName;
                existingPlayer.Position = player.Position;
                return existingPlayer;
            }

            return null;
        }
    }
}
