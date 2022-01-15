using RestfulCRUDapp.Models;

namespace RestfulCRUDapp.PlayerData
{
    public class FakePlayerData : IPlayerData
    {
        public Player AddPlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public void DeletePlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public Player getAllPlayersByTeam(string teamName)
        {
            throw new NotImplementedException();
        }

        public Player getPlayerById(int id)
        {
            throw new NotImplementedException();
        }

        public Player getPlayerByPosition(string position)
        {
            throw new NotImplementedException();
        }

        public List<Player> getAllPlayers()
        {
            throw new NotImplementedException();
        }

        public Player UpdatePlayer(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
