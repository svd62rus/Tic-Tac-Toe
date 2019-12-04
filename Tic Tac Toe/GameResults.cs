using System;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Game results class
    /// </summary>
    [Serializable]
    public class GameResults
    {
        /// <summary>
        /// Count of win
        /// </summary>
        public int Win { get; set; } = 0;
        /// <summary>
        /// Count of lose
        /// </summary>
        public int Lose { get; set; } = 0;
        /// <summary>
        /// Count of draw
        /// </summary>
        public int Draw { get; set; } = 0;
        /// <summary>
        /// Default class constructor
        /// </summary>
        public GameResults() { }
    }
}
