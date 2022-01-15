using RestfulCRUDapp.Models;

namespace RestfulCRUDapp.PlayerData
{
    public interface IPlayerData
    {
        List<Player> getAllPlayers();

        Player getPlayerById(int id);

        Player getPlayerByPosition(string position);

        Player getAllPlayersByTeam(string teamName);

        Player AddPlayer(Player player);

        Player UpdatePlayer(Player player);

        void DeletePlayer(Player player);
    }
}
