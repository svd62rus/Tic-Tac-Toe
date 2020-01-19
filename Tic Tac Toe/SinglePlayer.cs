using System;
using System.Collections.Generic;
using Tic_Tac_Toe.Localization;
using Tic_Tac_Toe.Utilites;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Class of single player game
    /// </summary>
    public sealed class SinglePlayer : Game, ISinglePlayer
    {
        /// <summary>
        /// Massive of corners index
        /// </summary>
        private readonly int[] Corners = new int[4] { 0, 2, 6, 8 };
        /// <summary>
        /// Delegate of computer logic
        /// </summary>
        private delegate void ComputerLogic();
        /// <summary>
        /// Delegate of get index method
        /// </summary>
        /// <param name="index">Input index</param>
        /// <returns>Output index</returns>
        private delegate int GetIndexMethod(int index);
        /// <summary>
        /// Field of computer logic method
        /// </summary>
        private readonly ComputerLogic logic;
        /// <summary>
        /// Danger game combination
        /// </summary>
        private readonly Dictionary<string, int> dangerCombinations =
            new Dictionary<string, int>(24)
            {
                {"01",2},{"02",1},{"12",0},{"34",5},{"35",4},{"45",3},{"67",8},{"68",7},
                {"78",6},{"03",6},{"06",3},{"36",0},{"14",7},{"17",4},{"47",1},{"25",8},
                {"28",5},{"58",2},{"04",8},{"08",4},{"48",0},{"24",6},{"26",4}, {"46",2}
            };
        /// <summary>
        /// Name of computer
        /// </summary>
        public string BotName { get; set; }
        /// <summary>
        /// Constructor of single player mode
        /// </summary>
        /// <param name="difficult">Difficult of game</param>
        /// <param name="humanName">Name of human</param>
        /// <param name="locale">Locale</param>
        public SinglePlayer(Enum difficult, string humanName, Locale locale)
        {
            GameType = GameTypes.Single;
            Difficult = difficult;
            switch (Difficult)
            {
                case Game.Difficults.Low:
                    logic = LowDifficultLogic;
                    break;
                case Game.Difficults.Hard:
                    logic = HardDifficultLogic;
                    break;
            }
            BotName = locale.GetBotNameText();
            SelectPlayers(humanName);
            ClearGameField();
        }
        /// <summary>
        /// Change bot name with current localization
        /// </summary>
        /// <param name="locale">Localization</param>
        public void ChangeBotNameWithLocale(Locale locale)
        {
            BotName = locale.GetBotNameText();
            Player2.PlayerName = BotName;
        }
        /// <summary>
        /// Get game type method
        /// </summary>
        /// <returns>game type</returns>
        public Enum GetGameType()
        {
            return GameType;
        }
        /// <summary>
        /// Get game difficult method
        /// </summary>
        /// <returns>Difficult</returns>
        public Enum GetGameDifficult()
        {
            return Difficult;
        }
        /// <summary>
        /// Get logic name method
        /// </summary>
        /// <returns>Logic mathod name</returns>
        public string GetLogicName()
        {
            return logic.Method.Name;
        }
        /// <summary>
        /// Get current player
        /// </summary>
        /// <returns>Current player</returns>
        public Player GetCurrentPlayer()
        {
            return CurrentPlayer;
        }
        /// <summary>
        /// Get type of player method
        /// </summary>
        /// <param name="player">Player</param>
        /// <returns>Type of player</returns>
        public Enum GetTypeOfPlayer(Player player)
        {
            return player.TypeOfPlayer;
        }
        /// <summary>
        /// Get player sign method
        /// </summary>
        /// <param name="player">Player</param>
        /// <returns>Player sign</returns>
        public string GetPlayerSign(Player player)
        {
            return player.PlayerSign;
        }
        /// <summary>
        /// Get count of empty fields method
        /// </summary>
        /// <returns>Count of empty fields</returns>
        public int GetCountOfEmptyFields()
        {
            var count = 0;
            foreach(string field in GameField)
            {
                if (field == empty)
                    count++;
            }
            return count;
        }
        /// <summary>
        /// Override select players method
        /// </summary>
        /// <param name="humanName">Name of human</param>
        protected override void SelectPlayers(string humanName)
        {
            CurrentPlayer = Player1;
            Player1.TypeOfPlayer = PlayersType.Human;
            Player1.PlayerSign = cross;
            Player1.PlayerName = humanName;
            Player2.TypeOfPlayer = PlayersType.Computer;
            Player2.PlayerSign = zero;
            Player2.PlayerName = BotName;
        }
        /// <summary>
        /// Override player step method
        /// </summary>
        public override void PlayerStep()
        {
            logic();
            freeCells--;
        }
        /// <summary>
        /// Low difficult computer logic
        /// </summary>
        private void LowDifficultLogic()
        {
            GoToFreeCell((index) => index,8);
        }
        /// <summary>
        /// Hard difficult computer logic
        /// </summary>
        private void HardDifficultLogic()
        {
            if (freeCells == 8 && GameField[4] == empty)
                GameField[4] = Player2.PlayerSign;
            else
            {
                if (freeCells == 8)
                    GoToFreeCell((index) => Corners[index],3);
                else
                {
                    if (freeCells == 7)
                        CheckCorners();
                    if (freeCells < 7)
                    {
                        if (!ImmediateAction(Player2))
                            if(!ImmediateAction(Player1))
                                GoToFreeCell((index) => Corners[index],3);
                    }    
                }
            }
        }
        /// <summary>
        /// Immediate action - need for win or not lose
        /// </summary>
        /// <param name="immPlayer">Immediate player</param>
        /// <returns></returns>
        private bool ImmediateAction(Player immPlayer)
        {
            bool result = false;
            foreach (var element in dangerCombinations)
            {
                int indexOne = int.Parse(element.Key.Substring(0, 1));
                int indexTwo = int.Parse(element.Key.Substring(1, 1));
                if (GameField[indexOne] == immPlayer.PlayerSign &&
                    GameField[indexTwo] == immPlayer.PlayerSign &&
                    GameField[element.Value] == empty)
                {
                    GameField[element.Value] = Player2.PlayerSign;
                    result = true;
                    break;
                }

            }
            return result;
        }
        /// <summary>
        /// Check corners of gamefield method
        /// </summary>
        private void CheckCorners()
        {
            if (GameField[0] == Player1.PlayerSign && GameField[8] == empty)
                GameField[8] = Player2.PlayerSign;
            if (GameField[8] == Player1.PlayerSign && GameField[0] == empty)
                GameField[0] = Player2.PlayerSign;

            if (GameField[2] == Player1.PlayerSign && GameField[6] == empty)
                GameField[6] = Player2.PlayerSign;
            if (GameField[6] == Player1.PlayerSign && GameField[2] == empty)
                GameField[2] = Player2.PlayerSign;
        }
        /// <summary>
        /// Go step in free cell method
        /// </summary>
        /// <param name="getIndex">Get index method</param>
        /// <param name="targetCells">Count of target cells</param>
        private void GoToFreeCell(GetIndexMethod getIndex, int targetCells)
        {
            int i;
            do
            {
                Random rnd = new Random();
                i = rnd.Next(0, targetCells);
            } while (GameField[getIndex(i)] != empty);
            GameField[getIndex(i)] = Player2.PlayerSign;
        }
    }
}
