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
        private Game game;
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
        public void UpdateParameters()
        {
            GameParameters = $"Mode: {game.GameType}";
            if (game.GameType.Equals(Game.GameTypes.Single))
                GameParameters += $", difficult: {game.Difficult}";
            PlayerParameters = $"Player 1: {game.Player1.TypeOfPlayer}, " +
                               $"player 2: {game.Player2.TypeOfPlayer}, " +
                               $"current: {game.CurrentPlayer.TypeOfPlayer}";
        }
    }
}
