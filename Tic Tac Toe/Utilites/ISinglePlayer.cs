using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Utilites
{
    /// <summary>
    /// Single player interface
    /// </summary>
    public interface ISinglePlayer
    {
        /// <summary>
        /// Get game type
        /// </summary>
        /// <returns>enum</returns>
        Enum GetGameType();
        /// <summary>
        /// Get game difficult
        /// </summary>
        /// <returns>enum</returns>
        Enum GetGameDifficult();
        /// <summary>
        /// Get logic name
        /// </summary>
        /// <returns>enum</returns>
        string GetLogicName();
        /// <summary>
        /// Get current player
        /// </summary>
        /// <returns>enum</returns>
        Player GetCurrentPlayer();
        /// <summary>
        /// Get type of player
        /// </summary>
        /// <param name="player">Player</param>
        /// <returns>enum</returns>
        Enum GetTypeOfPlayer(Player player);
        /// <summary>
        /// Get player sign
        /// </summary>
        /// <param name="player">Player</param>
        /// <returns>enum</returns>
        string GetPlayerSign(Player player);
        /// <summary>
        /// Get count of empty fields
        /// </summary>
        /// <returns>Count of empty fields</returns>
        int GetCountOfEmptyFields();
    }
}
