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
        /// Player language
        /// </summary>
        public string PlayerLocale { get; set; } = string.Empty;
        /// <summary>
        /// Score for low difficult games
        /// </summary>
        public GameResults LowLevelScore { get; set; } = new GameResults();
        /// <summary>
        /// Score for hard difficult games
        /// </summary>
        public GameResults HardLevelScore { get; set; } = new GameResults();
        /// <summary>
        /// Default constructor
        /// </summary>
        public GameProfile()
        {
        }
        /// <summary>
        /// Add win to score
        /// </summary>
        /// <param name="difficult">Difficult of game</param>
        public void Win(string difficult)
        {
            if (difficult == Game.Difficults.Low.ToString())
                LowLevelScore.Win++;
            else
                HardLevelScore.Win++;
        }
        /// <summary>
        /// Add lose for score
        /// </summary>
        /// <param name="difficult">Difficult of game</param>
        public void Lose(string difficult)
        {
            if (difficult == Game.Difficults.Low.ToString())
                LowLevelScore.Lose++;
            else
                HardLevelScore.Lose++;
        }
        /// <summary>
        /// Add draw to score
        /// </summary>
        /// <param name="difficult">Difficult of games</param>
        public void Draw(string difficult)
        {
            if (difficult == Game.Difficults.Low.ToString())
                LowLevelScore.Draw++;
            else
                HardLevelScore.Draw++;
        }
    }
}
