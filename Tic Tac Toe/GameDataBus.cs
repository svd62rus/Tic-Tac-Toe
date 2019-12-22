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
            string[] scoreTexts = locale.GetScoreWindowTexts();

            /*Set score texts from massive
            0-"Score", 1-"Profile", 2-"Low difficult", 3-"Win", 4-"Lose", 
            5-"Draw", 6-"Hard difficult", 7-"Win", 8-"Lose", 9-"Draw"
            */

            MessageBox.Show($"{scoreTexts[1]}: {profile.PlayerName}\n\n\n" +
                               $"-----{scoreTexts[2]}-----\n" +
                               $"{scoreTexts[3]}: {profile.LowLevelScore.Win}\n" +
                               $"{scoreTexts[4]}: {profile.LowLevelScore.Lose}\n" +
                               $"{scoreTexts[5]}: {profile.LowLevelScore.Draw}\n\n" +
                               $"-----{scoreTexts[6]}-----\n" +
                               $"{scoreTexts[7]}: {profile.HardLevelScore.Win}\n" +
                               $"{scoreTexts[8]}: {profile.HardLevelScore.Lose}\n" +
                               $"{scoreTexts[9]}: {profile.HardLevelScore.Draw}\n", scoreTexts[0]);
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
