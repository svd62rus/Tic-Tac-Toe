using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Utilites
{
    public interface ISinglePlayer
    {
        Enum GetGameType();
        Enum GetGameDifficult();
        string GetLogicName();
        Player GetCurrentPlayer();
        Enum GetTypeOfPlayer(Player player);
        string GetPlayerSign(Player player);
        int GetCountOfEmptyFields();
    }
}
