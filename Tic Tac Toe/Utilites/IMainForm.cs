using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Utilites
{
    /// <summary>
    /// MainForm interface
    /// </summary>
    public interface IMainForm
    {
        /// <summary>
        /// Get game panel status
        /// </summary>
        /// <returns>Game panel status</returns>
        bool GetGamePanelStatus();
        /// <summary>
        /// Get gamefield buttons count
        /// </summary>
        /// <returns>Count of gamefield buttons</returns>
        int GetGameFieldFieldButtonsCount();
        /// <summary>
        /// Change game panel visible
        /// </summary>
        /// <param name="state">State</param>
        /// <returns>Visible state</returns>
        bool ChangeGamePanelVisible(bool state);
        /// <summary>
        /// Get count of buttons with default color
        /// </summary>
        /// <returns>Count of buttons with default color</returns>
        int GetCountDefaultColorButtons();
        /// <summary>
        /// Change enabled state now
        /// </summary>
        /// <param name="player">Player</param>
        /// <returns>True or false</returns>
        bool ChangeEnabledStateNow(string player);
    }
}
