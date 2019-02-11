using System;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Game profile class
    /// </summary>
    [Serializable]
    public class GameProfile
    {
        /// <summary>
        /// Player custom name
        /// </summary>
        public string PlayerName { get; set; } = string.Empty;
        /// <summary>
        /// Statistic for low difficult games
        /// </summary>
        public GameResults LowLevelStat { get; set; } = new GameResults();
        /// <summary>
        /// Statistic for hard difficult games
        /// </summary>
        public GameResults HardLevelStat { get; set; } = new GameResults();
        public GameProfile()
        {
        }
        /// <summary>
        /// Add win to statistic
        /// </summary>
        /// <param name="difficult">Difficult of game</param>
        public void Win(string difficult)
        {
            if (difficult == Game.Difficults.Low.ToString())
                LowLevelStat.Win++;
            else
                HardLevelStat.Win++;
        }
        /// <summary>
        /// Add lose for statistic
        /// </summary>
        /// <param name="difficult">Difficult of game</param>
        public void Lose(string difficult)
        {
            if (difficult == Game.Difficults.Low.ToString())
                LowLevelStat.Lose++;
            else
                HardLevelStat.Lose++;
        }
        /// <summary>
        /// Add draw to statistic
        /// </summary>
        /// <param name="difficult">Difficult of games</param>
        public void Draw(string difficult)
        {
            if (difficult == Game.Difficults.Low.ToString())
                LowLevelStat.Draw++;
            else
                HardLevelStat.Draw++;
        }
    }
}
