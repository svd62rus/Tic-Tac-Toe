using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Localization
{
    interface ILocalization
    {
        string GetMainMenuText();
        string GetSinglePlayerMenuText();
        string GetLowDifficultText();
        string GetHardDifficultText();
        string GetExitMenuText();
        string GetScoreMenuText();
        string GetDifficultText();
        string GetCurrentGameLowDifficultText();
        string GetCurrentGameHardDifficultText();
        string GetPlayerText();
        string GetBotNameText();
        string GetDrawText();
        string GetWinText();
        string GetImpossibleStepText();
        string GetSavesSavingErrorText();
        string GetSavesLoadingErrorText();
        string GetErrorText();
        string GetProfileText();
        string GetWinsCountText();
        string GetLosesCountText();
        string GetDrawCountText();
    }
}
