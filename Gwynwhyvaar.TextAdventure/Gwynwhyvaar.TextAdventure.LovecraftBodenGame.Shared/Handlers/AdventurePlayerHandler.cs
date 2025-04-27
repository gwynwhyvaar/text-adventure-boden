using System.Collections.Generic;

using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Handlers
{
    public class AdventurePlayerHandler
    {
        private static AdventurePlayerHandler _instance;
        private static object _lock = new object();

        private readonly AdventureGamePlayerDataService _gamePlayerDataService;
        private AdventurePlayerHandler()
        {
            _gamePlayerDataService = new AdventureGamePlayerDataService();
        }
        public static AdventurePlayerHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new AdventurePlayerHandler();
                        }
                    }
                }
                return _instance;
            }
        }
        public void CreatePlayer(AdventureGamePlayer player, string playerDataStore)
        {
            AdventureGamePlayerData data = null;
            var playerData = _gamePlayerDataService.Load(playerDataStore);

            if (playerData == null)
            {
                data = new AdventureGamePlayerData();
            }
            data.AdventureGamePlayers[player.AdventureGuid] = player;
            _gamePlayerDataService.Save(data, playerDataStore);
        }
        public List<AdventureGamePlayer> GetAdventurePlayers(string playerDataStore) => _gamePlayerDataService.LoadAll(playerDataStore);
    }
}
