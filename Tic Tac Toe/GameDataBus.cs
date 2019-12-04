using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Game data bus class
    /// </summary>
    static class GameDataBus
    {
        /// <summary>
        /// Save game result in score method
        /// </summary>
        /// <param name="profile">Game profile</param>
        public static void SaveGameResultInScore(GameProfile profile)
        {
            var saveResult = SaveLoadProfile.Save(profile);
            if (saveResult.IsError)
            {
                MessageBox.Show("Error of file save saving! Score is dropped.", "Error!");
            }
        }/// <summary>
        /// Load game result in score method
        /// </summary>
        /// <returns>Game profile</returns>
        public static GameProfile LoadGameResultInScore()
        {
            var loadResult = SaveLoadProfile.Load();
            if (loadResult.IsError)
            {
                MessageBox.Show("Error of file save loading! Score is dropped.", "Error!");
            }
            return loadResult.Profile;
        }
        /// <summary>
        /// Show score method
        /// </summary>
        /// <param name="profile">Game profile</param>
        public static void ShowScore(GameProfile profile)
        {
            MessageBox.Show($"Profile: {profile.PlayerName}\n\n\n" +
                               $"--Low difficult--\n" +
                               $"Win: {profile.LowLevelScore.Win}\n" +
                               $"Lose: {profile.LowLevelScore.Lose}\n" +
                               $"Draw: {profile.LowLevelScore.Draw}\n\n" +
                               $"--Hard difficult--\n" +
                               $"Win: {profile.HardLevelScore.Win}\n" +
                               $"Lose: {profile.HardLevelScore.Lose}\n" +
                               $"Draw: {profile.HardLevelScore.Draw}\n", "Score");
        }
        /// <summary>
        /// Show game result method
        /// </summary>
        /// <param name="result">String result</param>
        public static void ShowResult(string result)
        {
            if(result.Equals("Draw"))
                MessageBox.Show(result);
            else
                MessageBox.Show(result + " win!");
        }
        /// <summary>
        /// Show message about impossible step method
        /// </summary>
        public static void ShowImpossibleStepMessage()
        {
            MessageBox.Show("Такой ход невозможен!");
        }
    }
}
