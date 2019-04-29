using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Utilites
{
    public interface IMainForm
    {
        bool GetGamePanelStatus();
        int GetGameFieldFieldButtonsCount();
        bool ChangeGamePanelVisible(bool state);
        int GetCountDefaultColorButtons();
        bool ChangeEnabledStateNow(string player);
    }
}
