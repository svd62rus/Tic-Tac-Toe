using System;
using NUnit.Framework;
using System.Windows.Forms;
using Tic_Tac_Toe;

namespace Tic_Tac_Toe.UnitTests
{
    [TestFixture]
    public class MainFormTests
    {
        private MainForm mainForm;
        private Button[] gameFieldButtons;
        private Panel GamePanel;

        [OneTimeSetUp]
        public void SetUpMainForm()
        {
            Button Button0 = new Button();
            Button Button1 = new Button();
            Button Button2 = new Button();
            Button Button3 = new Button();
            Button Button4 = new Button();
            Button Button5 = new Button();
            Button Button6 = new Button();
            Button Button7 = new Button();
            Button Button8 = new Button();

            GamePanel = new Panel();

            gameFieldButtons = new Button[9]
            {
                Button0, Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8
            };

            mainForm = new MainForm();
        }

        [Test]
        public void GamePanelVisible_SetUpGamePanelVisible_ReturnUnvisible()
        {
            Assert.AreEqual(mainForm.GetGamePanelStatus(), false);
        }

        [Test]
        public void GameFieldButtons_SetUpButtonsArray_ReturnCorrectButtonsCount()
        {
            Assert.AreEqual(mainForm.GetGameFieldFieldButtonsCount(),
                gameFieldButtons.Length);
        }

        [Test]
        public void GamePanelVisible_ChangeVisibleOnTrue_ReturnTrue()
        {
            var state = mainForm.ChangeGamePanelVisible(true);
            Assert.AreEqual(state,true);
        }

        [Test]
        public void GamePanelVisible_ChangeVisibleOnFalse_ReturnFalse()
        {
            var state = mainForm.ChangeGamePanelVisible(false);
            Assert.AreEqual(state,false);
        }

        [Test]
        public void GameFieldButtonsColor_ColorToDefault_Return9GrayColor()
        {
            Assert.AreEqual(mainForm.GetCountDefaultColorButtons(), 9);
        }

        [Test]
        public void MainForm_EnabledForPlayer1_ReturnTrue()
        {
            Game game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(mainForm.ChangeEnabledStateNow("Player1"),
                true);
        }

        [Test]
        public void MainForm_DisabledForPlayer1_ReturnFalse()
        {
            Game game = new SinglePlayer(Game.Difficults.Low);
            Assert.AreEqual(mainForm.ChangeEnabledStateNow("Player2"),
                false);
        }
    }
}
