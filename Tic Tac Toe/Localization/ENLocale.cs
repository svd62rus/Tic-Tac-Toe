using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Localization
{
    /// <summary>
    /// EN localization class
    /// </summary>
    public class ENLocale : Locale, ILocalization
    {
        private readonly string mainMenuText = "Menu";
        private readonly string singlePlayerMenuText = "New game";
        private readonly string lowDifficultText = "Low";
        private readonly string hardDifficultText = "Hard";
        private readonly string exitMenuText = "Exit";
        private readonly string scoreMenuText = "Score";
        private readonly string difficultText = "Difficult";
        private readonly string currentDifficultText_Low = "low";
        private readonly string currentDifficultText_Hard = "hard";
        private readonly string playerText = "Current player";
        private readonly string botNameText = "Computer";
        private readonly string drawText = "Draw...";
        private readonly string winText = " win!";
        private readonly string impossibleStepText = "Such a step is impossible!";
        private readonly string savesSavingErrorText = "Error of file save saving! Score is dropped.";
        private readonly string savesLoadingErrorText = "Error of file save loading! Score is dropped.";
        private readonly string errorText = "Error!";
        private readonly string profileText = "Profile";
        private readonly string winCountText = "Wins";
        private readonly string loseCountText = "Loses";
        private readonly string drawCountText = "Draw";
        private readonly string inputPlayerNameText = "Enter player name:";
        private readonly string createPlayerButtonText = "Create profile";
        /// <summary>
        /// Constructor of english locale
        /// </summary>
        public ENLocale()
        {
            localeDict[LocaleIds.MainMenuID] = mainMenuText;
            localeDict[LocaleIds.SinglePlayerMenuID] = singlePlayerMenuText;
            localeDict[LocaleIds.LowDifficultID] = lowDifficultText;
            localeDict[LocaleIds.HardDifficultID] = hardDifficultText;
            localeDict[LocaleIds.ExitMenuID] = exitMenuText;
            localeDict[LocaleIds.ScoreMenuID] = scoreMenuText;
            localeDict[LocaleIds.DifficultTextID] = difficultText;
            localeDict[LocaleIds.CurrentGameLowDifficultID] = currentDifficultText_Low;
            localeDict[LocaleIds.CurrentGameHardDifficultID] = currentDifficultText_Hard;
            localeDict[LocaleIds.PlayerTextID] = playerText;
            localeDict[LocaleIds.BotNameID] = botNameText;
            localeDict[LocaleIds.DrawTextID] = drawText;
            localeDict[LocaleIds.WinTextID] = winText;
            localeDict[LocaleIds.ImpossibleStepTextID] = impossibleStepText;
            localeDict[LocaleIds.SavesSavingErrorID] = savesSavingErrorText;
            localeDict[LocaleIds.SavesLoadingErrorID] = savesLoadingErrorText;
            localeDict[LocaleIds.ErrorID] = errorText;
            localeDict[LocaleIds.ProfileID] = profileText;
            localeDict[LocaleIds.WinsCountID] = winCountText;
            localeDict[LocaleIds.LosesCountID] = loseCountText;
            localeDict[LocaleIds.DrawCountID] = drawCountText;
            localeDict[LocaleIds.InputProfileNameID] = inputPlayerNameText;
            localeDict[LocaleIds.CreateProfileButtonNameID] = createPlayerButtonText;
            Localization = LocaleCreator.InterfaceLanguage.en;
        }
    }
}
