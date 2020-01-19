using Tic_Tac_Toe.Localization;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Supporting class. Game parameters.
    /// </summary>
    class Parameters
    {
        /// <summary>
        /// Game parameters string
        /// </summary>
        public string GameParameters { get; private set; } = string.Empty;
        /// <summary>
        /// Player parameters string
        /// </summary>
        public string PlayerParameters { get; private set; } = string.Empty;
        /// <summary>
        /// Current game
        /// </summary>
        private readonly Game game;
        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="game">Current game variable</param>
        public Parameters(Game game)
        {
            this.game = game;
        }
        /// <summary>
        /// Update parameters method
        /// </summary>
        public void UpdateParameters(Locale locale)
        {
            GameParameters = string.Empty;
            if (game.GameType.Equals(Game.GameTypes.Single))
            {
                if(game.Difficult.Equals(Game.Difficults.Hard))
                    GameParameters += $"{locale.GetDifficultText()}:" +
                        $" {locale.GetCurrentGameHardDifficultText()}";
                if (game.Difficult.Equals(Game.Difficults.Low))
                    GameParameters += $"{locale.GetDifficultText()}:" +
                        $" {locale.GetCurrentGameLowDifficultText()}";
            }

            PlayerParameters = $"{locale.GetPlayerText()}: {game.CurrentPlayer.PlayerName}";
        }
    }
}
