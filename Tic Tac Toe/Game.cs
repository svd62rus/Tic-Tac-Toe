using System;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Abstract base class of game
    /// </summary>
    public abstract class Game
    {
        /// <summary>
        /// Delegate of current player state
        /// </summary>
        public delegate void CurrentPlayerStateHandler();
        /// <summary>
        /// Game over delegate
        /// </summary>
        /// <param name="result">Result of game</param>
        public delegate void GameEndingHandler(string result);
        /// <summary>
        /// Event "Player1 - is current"
        /// </summary>
        public event CurrentPlayerStateHandler Player1IsCurrent;
        /// <summary>
        /// Event "Player2 - is current"
        /// </summary>
        public event CurrentPlayerStateHandler Player2IsCurrent;
        /// <summary>
        /// Event "Win"
        /// </summary>
        public event GameEndingHandler Win;
        /// <summary>
        /// Event "Draw"
        /// </summary>
        public event GameEndingHandler Draw;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        /// <summary>
        /// Enum fifficults of single player game
        /// </summary>
        public enum Difficults { Low, Hard }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        /// <summary>
        /// Enum game types(modes)
        /// </summary>
        public enum GameTypes { Single, Split, Multi }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        /// <summary>
        /// Enum player types
        /// </summary>
        public enum PlayersType { Human, Computer }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        /// <summary>
        /// Current difficult of game
        /// </summary>
        public Enum Difficult { get; protected set; }
        /// <summary>
        /// Current game type(mode)
        /// </summary>
        public Enum GameType { get; protected set; }
        /// <summary>
        /// Player 1
        /// </summary>
        public Player Player1 { get; protected set; } = new Player();
        /// <summary>
        /// Player 2
        /// </summary>
        public Player Player2 { get; protected set; } = new Player();
        /// <summary>
        /// Current Player
        /// </summary>
        public Player CurrentPlayer { get; protected set; } = new Player();
        /// <summary>
        /// Winner Player
        /// </summary>
        public Player Winner { get; protected set; } = new Player();
        /// <summary>
        /// Bool variable showing game in progress or not
        /// </summary>
        public bool GameInProgress { get; protected set; } = true;
        /// <summary>
        /// Sign of empty cell
        /// </summary>
        protected string empty = " ";
        /// <summary>
        /// Cross sign
        /// </summary>
        protected string cross = "X";
        /// <summary>
        /// Zero sign
        /// </summary>
        protected string zero = "0";
        /// <summary>
        /// Game field
        /// </summary>
        public string[] GameField { get; protected set; } = new string[9];
        /// <summary>
        /// Positions of win
        /// </summary>
        protected string [] WinPositions = 
            {"012" , "345" , "678" , "258" , "036" , "048" , "246","147"};
        /// <summary>
        /// Count of free cells
        /// </summary>
        protected int freeCells = 9;
        /// <summary>
        /// Index of win cells
        /// </summary>
        public int [] WinIndexes { get; protected set; }
        /// <summary>
        /// Change current player method
        /// </summary>
        public void ChangeCurrentPlayer()
        {
            if (CurrentPlayer == Player1)
            {
                CurrentPlayer = Player2;
                Player2IsCurrent();
            }
            else
            {
                CurrentPlayer = Player1;
                Player1IsCurrent();
            }    
        }
        /// <summary>
        /// Clear game field method
        /// </summary>
        protected void ClearGameField()
        {
            for (int i = 0; i < GameField.Length; i++)
                GameField[i] = empty;
        }
        /// <summary>
        /// Abstract select players method
        /// </summary>
        protected abstract void SelectPlayers();
        /// <summary>
        /// Make player step method
        /// </summary>
        /// <param name="index">Index of game field cell</param>
        /// <param name="isPossible">This step is possible or not</param>
        public void PlayerStep(int index, out bool isPossible)
        {
            isPossible = false;
            if (GameField[index] != Player1.PlayerSign && GameField[index] != Player2.PlayerSign)
            {
                GameField[index] = Player1.PlayerSign;
                isPossible = true;
                freeCells--;
            }                
        }
        /// <summary>
        /// Abstract player step method
        /// </summary>
        public abstract void PlayerStep();
        /// <summary>
        /// Check game status (win, who win, draw...) method
        /// </summary>
        public void CheckGameStatus()
        {
            if (freeCells > 0)
            {
                CheckGameFieldOnWinCombination();
            }
            else if (!CheckGameFieldOnWinCombination())
            {
                GameInProgress = false;
                Draw("Draw");
            }            
        }
        /// <summary>
        /// Check gamefield on win combinations method
        /// </summary>
        /// <returns>Gamefield contains or not contains win combinations (true/false)</returns>
        private bool CheckGameFieldOnWinCombination()
        {
            for (int i = 0; i < WinPositions.Length; i++)
            {
                var firstIndex = int.Parse(WinPositions[i].Substring(0, 1));
                var secondIndex = int.Parse(WinPositions[i].Substring(1, 1));
                var thirdIndex = int.Parse(WinPositions[i].Substring(2, 1));
                if (GameField[firstIndex] != empty &&
                    GameField[firstIndex] == GameField[secondIndex] &&
                    GameField[firstIndex] == GameField[thirdIndex])
                {
                    WinIndexes = new int[3] { firstIndex, secondIndex, thirdIndex };
                    if (GameField[firstIndex] == Player1.PlayerSign)
                    {
                        Winner = Player1;
                        Win(Player1.TypeOfPlayer.ToString());
                    }
                    else
                    {
                        Winner = Player2;
                        Win(Player2.TypeOfPlayer.ToString());
                    }
                    GameInProgress = false;
                    return true;
                }
            }
            return false;
        }
    }
}
