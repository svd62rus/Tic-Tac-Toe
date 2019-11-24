using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Game data bus class
    /// </summary>
    static class GameDataBus
    {
        /// <summary>
        /// Save game result in statistic method
        /// </summary>
        /// <param name="profile">Game profile</param>
        public static void SaveGameResultInStatistic(GameProfile profile)
        {
            var saveResult = SaveLoadProfile.Save(profile);
            if (saveResult.IsError)
            {
                MessageBox.Show("Error of file save saving! Statistic is not changed", "Error!");
            }
        }/// <summary>
        /// Load game result in statistic method
        /// </summary>
        /// <returns>Game profile</returns>
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
