using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    static class GameDataBus
    {
        public static void SaveGameResultInStatistic(GameProfile profile)
        {
            var saveResult = SaveLoadProfile.Save(profile);
            if (saveResult.IsError)
            {
                MessageBox.Show("Error of file save saving! Statistic is not changed", "Error!");
            }
        }
        public static GameProfile LoadGameResultInStatistic()
        {
            var loadResult = SaveLoadProfile.Load();
            if (loadResult.IsError)
            {
                MessageBox.Show("Error of file save loading! Statistic is dropped.", "Error!");
            }
            return loadResult.Profile;
        }

    }
}
