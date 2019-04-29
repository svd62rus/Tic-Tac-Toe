using NUnit.Framework;
using Tic_Tac_Toe;

namespace Tic_Tac_Toe.UnitTests
{
    [TestFixture]
    public class SinglePlayerTests
    {
        [Test]
        public void SinglePlayer_CreateSingleGame_ReturnCorrectGameType()
        {
            var game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(game.GetGameType(), Game.GameTypes.Single);
        }

        [Test]
        public void SinglePlayer_CreateLowDiffGame_ReturnCorrectDiff()
        {
            var game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(game.GetGameDifficult(), Game.Difficults.Low);
        }

        [Test]
        public void SinglePlayer_CreateHardDiffGame_ReturnCorrectDiff()
        {
            var game = new SinglePlayer(Game.Difficults.Hard);
            Assert.AreEqual(game.GetGameDifficult(), Game.Difficults.Hard);
        }

        [Test]
        public void SinglePlayer_CreateLowDiffGame_ReturnCorrectLogic()
        {
            var game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(game.GetLogicName(), "LowDifficultLogic");
        }

        [Test]
        public void SinglePlayer_CreateHardDiffGame_ReturnCorrectLogic()
        {
            var game = new SinglePlayer(Game.Difficults.Hard);
            Assert.AreEqual(game.GetLogicName(), "HardDifficultLogic");
        }

        [Test]
        public void SinglePlayer_SelectPlayers_ReturnCorrectCurrentPlayer()
        {
            var game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(game.GetCurrentPlayer(), game.Player1);
        }

        [Test]
        public void SinglePlayer_SelectPlayers_ReturnCorrectPlayer1Type()
        {
            var game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(game.GetTypeOfPlayer(game.Player1), 
                Game.PlayersType.Human);
        }

        [Test]
        public void SinglePlayer_SelectPlayers_ReturnCorrectPlayer2Type()
        {
            var game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(game.GetTypeOfPlayer(game.Player2),
                Game.PlayersType.Computer);
        }

        [Test]
        public void SinglePlayer_SelectPlayers_ReturnCorrectPlayer1Sign()
        {
            var game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(game.GetPlayerSign(game.Player1),"X");
        }

        [Test]
        public void SinglePlayer_SelectPlayers_ReturnCorrectPlayer2Sign()
        {
            var game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(game.GetPlayerSign(game.Player2), "0");
        }

        [Test]
        public void SinglePlayer_ClearGameField_ReturnCorrectCountOfEmptyFields()
        {
            var game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(game.GetCountOfEmptyFields(), 9);
        }


    }
}
