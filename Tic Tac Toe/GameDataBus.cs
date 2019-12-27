using System.Windows.Forms;
using Tic_Tac_Toe.Localization;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Game data bus class
    /// </summary>
    static class GameDataBus
    {
        /// <summary>
        /// Profile created or not
        /// </summary>
        public static bool ProfileIsCreated { get; set; }
        /// <summary>
        /// Save game result in score method
        /// </summary>
        /// <param name="profile">Game profile</param>
        /// <param name="locale">Locale</param>
        public static void SaveGameResultInScore(GameProfile profile, Locale locale)
        {
            var saveResult = SaveLoadProfile.Save(profile);
            if (saveResult.IsError)
            {
                MessageBox.Show(locale.GetSavesSavingErrorText(), locale.GetErrorText());
            }
        }
        /// <summary>
        /// Load game result in score method
        /// </summary>
        /// <param name="locale">Locale</param>
        /// <returns>Game profile</returns>
        public static GameProfile LoadGameResultInScore(Locale locale)
        {
            var loadResult = SaveLoadProfile.Load();
            if (loadResult.IsError)
            {
                MessageBox.Show(locale.GetSavesLoadingErrorText(), locale.GetErrorText());
            }
            return loadResult.Profile;
        }
        /// <summary>
        /// Show score method
        /// </summary>
        /// <param name="profile">Game profile</param>
        /// <param name="locale">Locale</param>
        public static void ShowScore(GameProfile profile, Locale locale)
        {
            MessageBox.Show($"{locale.GetProfileText()}: {profile.PlayerName}\n\n\n" +
                               $"-------{locale.GetLowDifficultText()}-------\n" +
                               $"{locale.GetWinsCountText()}: {profile.LowLevelScore.Win}\n" +
                               $"{locale.GetLosesCountText()}: {profile.LowLevelScore.Lose}\n" +
                               $"{locale.GetDrawCountText()}: {profile.LowLevelScore.Draw}\n\n" +
                               $"-------{locale.GetHardDifficultText()}-------\n" +
                               $"{locale.GetWinsCountText()}: {profile.HardLevelScore.Win}\n" +
                               $"{locale.GetLosesCountText()}: {profile.HardLevelScore.Lose}\n" +
                               $"{locale.GetDrawCountText()}: {profile.HardLevelScore.Draw}\n",
                               locale.GetScoreMenuText());
        }
        /// <summary>
        /// Show game result method
        /// </summary>
        /// <param name="result">String result</param>
        /// <param name="locale">Locale</param>
        public static void ShowResult(string result, Locale locale)
        {
            if(result.Equals("Draw"))
                MessageBox.Show(locale.GetDrawText());
            else
                MessageBox.Show(result + locale.GetWinText());
        }
        /// <summary>
        /// Show message about impossible step method
        /// </summary>
        /// <param name="locale">Locale</param>
        public static void ShowImpossibleStepMessage(Locale locale)
        {
            MessageBox.Show(locale.GetImpossibleStepText());
        }
    }
}
