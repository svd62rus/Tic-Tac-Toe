using System;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Class of player
    /// </summary>
    public sealed class Player
    {
        /// <summary>
        /// Sign of player
        /// </summary>
        public string PlayerSign { get; set; }
        /// <summary>
        /// Type of player
        /// </summary>
        public Enum TypeOfPlayer { get; set; }
    }
}
