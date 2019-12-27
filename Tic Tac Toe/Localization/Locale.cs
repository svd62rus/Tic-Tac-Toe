using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Localization
{
    /// <summary>
    /// Locale class
    /// </summary>
    public class Locale
    {
        /// <summary>
        /// Text localization ids
        /// </summary>
        protected enum LocaleIds
        { 
            /// <summary>
            /// Main menu id
            /// </summary>
            MainMenuID,
            /// <summary>
            /// New single player game menu id
            /// </summary>
            SinglePlayerMenuID,
            /// <summary>
            /// Low difficult menu item id
            /// </summary>
            LowDifficultID,
            /// <summary>
            /// Hard difficult menu item id
            /// </summary>
            HardDifficultID,
            /// <summary>
            /// Exit menu item id
            /// </summary>
            ExitMenuID,
            /// <summary>
            /// Score menu id
            /// </summary>
            ScoreMenuID,
            /// <summary>
            /// Difficult text id
            /// </summary>
            DifficultTextID,
            /// <summary>
            /// Current game difficult (low) id
            /// </summary>
            CurrentGameLowDifficultID,
            /// <summary>
            /// Current game difficult (hard) id
            /// </summary>
            CurrentGameHardDifficultID,
            /// <summary>
            /// Player name id
            /// </summary>
            PlayerTextID,
            /// <summary>
            /// Bot name id
            /// </summary>
            BotNameID,
            /// <summary>
            /// Draw id
            /// </summary>
            DrawTextID,
            /// <summary>
            /// Win id
            /// </summary>
            WinTextID,
            /// <summary>
            /// Impossible step id
            /// </summary>
            ImpossibleStepTextID,
            /// <summary>
            /// Error of saving filesave id
            /// </summary>
            SavesSavingErrorID,
            /// <summary>
            /// Error of loading filesave id
            /// </summary>
            SavesLoadingErrorID,
            /// <summary>
            /// Error id
            /// </summary>
            ErrorID,
            /// <summary>
            /// Profile text id
            /// </summary>
            ProfileID,
            /// <summary>
            /// Wins count text id
            /// </summary>
            WinsCountID,
            /// <summary>
            /// Loses count text id
            /// </summary>
            LosesCountID,
            /// <summary>
            /// Draw count text id
            /// </summary>
            DrawCountID
        };
        /// <summary>
        /// Localization texts dictionary
        /// </summary>
        protected Dictionary<LocaleIds, string> localeDict = new Dictionary<LocaleIds, string>()
        {
            {LocaleIds.MainMenuID, string.Empty },
            {LocaleIds.SinglePlayerMenuID, string.Empty },
            {LocaleIds.LowDifficultID, string.Empty },
            {LocaleIds.HardDifficultID, string.Empty },        
            {LocaleIds.ExitMenuID, string.Empty },
            {LocaleIds.ScoreMenuID, string.Empty },
            {LocaleIds.DifficultTextID, string.Empty },
            {LocaleIds.CurrentGameLowDifficultID, string.Empty },
            {LocaleIds.CurrentGameHardDifficultID, string.Empty },
            {LocaleIds.PlayerTextID, string.Empty },
            {LocaleIds.BotNameID, string.Empty },
            {LocaleIds.DrawTextID, string.Empty },
            {LocaleIds.WinTextID, string.Empty },
            {LocaleIds.ImpossibleStepTextID, string.Empty },
            {LocaleIds.SavesSavingErrorID, string.Empty },
            {LocaleIds.SavesLoadingErrorID, string.Empty },
            {LocaleIds.ErrorID, string.Empty },
            {LocaleIds.ProfileID, string.Empty },
            {LocaleIds.WinsCountID, string.Empty },
            {LocaleIds.LosesCountID, string.Empty },
            {LocaleIds.DrawCountID, string.Empty },
        };
        /// <summary>
        /// Massive of score window texts
        /// </summary>
        protected string[] scoreWindowLocales = new string[10];
        /// <summary>
        /// Get main menu text
        /// </summary>
        /// <returns>Main menu text</returns>
        public string GetMainMenuText()
        {
            return localeDict[LocaleIds.MainMenuID];
        }
        /// <summary>
        /// Get new single player game menu text
        /// </summary>
        /// <returns>New single player game menu text</returns>
        public string GetSinglePlayerMenuText()
        {
            return localeDict[LocaleIds.SinglePlayerMenuID];
        }
        /// <summary>
        /// Get low difficult item text
        /// </summary>
        /// <returns>Low difficult text</returns>
        public string GetLowDifficultText()
        {
            return localeDict[LocaleIds.LowDifficultID];
        }
        /// <summary>
        /// Get hard difficult item text
        /// </summary>
        /// <returns>Hard difficult text</returns>
        public string GetHardDifficultText()
        {
            return localeDict[LocaleIds.HardDifficultID];
        }
        /// <summary>
        /// Get exit item text
        /// </summary>
        /// <returns>Exit text</returns>
        public string GetExitMenuText()
        {
            return localeDict[LocaleIds.ExitMenuID];
        }
        /// <summary>
        /// Get score menu text
        /// </summary>
        /// <returns>Score menu text</returns>
        public string GetScoreMenuText()
        {
            return localeDict[LocaleIds.ScoreMenuID];
        }
        /// <summary>
        /// Get difficult text
        /// </summary>
        /// <returns>Difficult text</returns>
        public string GetDifficultText()
        {
            return localeDict[LocaleIds.DifficultTextID];
        }
        /// <summary>
        /// Get current game text (low)
        /// </summary>
        /// <returns>Low difficult text</returns>
        public string GetCurrentGameLowDifficultText()
        {
            return localeDict[LocaleIds.CurrentGameLowDifficultID];
        }
        /// <summary>
        /// Get current game text (hard)
        /// </summary>
        /// <returns>Hard difficult text</returns>
        public string GetCurrentGameHardDifficultText()
        {
            return localeDict[LocaleIds.CurrentGameHardDifficultID];
        }
        /// <summary>
        /// Get player text
        /// </summary>
        /// <returns>Player text</returns>
        public string GetPlayerText()
        {
            return localeDict[LocaleIds.PlayerTextID];
        }
        /// <summary>
        /// Get bot name
        /// </summary>
        /// <returns>Bot name</returns>
        public string GetBotNameText()
        {
            return localeDict[LocaleIds.BotNameID];
        }
        /// <summary>
        /// Get draw text
        /// </summary>
        /// <returns>Draw text</returns>
        public string GetDrawText()
        {
            return localeDict[LocaleIds.DrawTextID];
        }
        /// <summary>
        /// Get win text
        /// </summary>
        /// <returns>Win text</returns>
        public string GetWinText()
        {
            return localeDict[LocaleIds.WinTextID];
        }
        /// <summary>
        /// Get message for impossible step
        /// </summary>
        /// <returns>Text of impossible step</returns>
        public string GetImpossibleStepText()
        {
            return localeDict[LocaleIds.ImpossibleStepTextID];
        }
        /// <summary>
        /// Get saving error text
        /// </summary>
        /// <returns>Saving error text</returns>
        public string GetSavesSavingErrorText()
        {
            return localeDict[LocaleIds.SavesSavingErrorID];
        }
        /// <summary>
        /// Get loading error text
        /// </summary>
        /// <returns>Loading error text</returns>
        public string GetSavesLoadingErrorText()
        {
            return localeDict[LocaleIds.SavesLoadingErrorID];
        }
        /// <summary>
        /// Get error text
        /// </summary>
        /// <returns>Error text</returns>
        public string GetErrorText()
        {
            return localeDict[LocaleIds.ErrorID];
        }
        /// <summary>
        /// Get profile text
        /// </summary>
        /// <returns></returns>
        public string GetProfileText()
        {
            return localeDict[LocaleIds.ProfileID];
        }
        /// <summary>
        /// Get wins count text
        /// </summary>
        /// <returns></returns>
        public string GetWinsCountText()
        {
            return localeDict[LocaleIds.WinsCountID];
        }
        /// <summary>
        /// Get lose count text
        /// </summary>
        /// <returns></returns>
        public string GetLosesCountText()
        {
            return localeDict[LocaleIds.LosesCountID];
        }
        /// <summary>
        /// Get draw count text
        /// </summary>
        /// <returns></returns>
        public string GetDrawCountText()
        {
            return localeDict[LocaleIds.DrawCountID];
        }
    }
}
