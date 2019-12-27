using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Tic_Tac_Toe.Localization;
using Tic_Tac_Toe.Utilites;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Form class
    /// </summary>
    public partial class MainForm : Form, IMainForm
    {
        /// <summary>
        /// Parameters variable
        /// </summary>
        private Parameters parameters;
        /// <summary>
        /// Game variable
        /// </summary>
        private Game game;
        /// <summary>
        /// Massive of game fields buttons 
        /// </summary>
        private readonly Button[] gameFieldButtons;
        /// <summary>
        /// Game profile for save score and information
        /// </summary>
        public GameProfile profile = new GameProfile();
        /// <summary>
        /// Program localization settings
        /// </summary>
        private readonly Locale locale;
        /// <summary>
        /// Constructor of form class
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            locale = LocaleCreator.CreateLocale(LocaleCreator.InterfaceLanguage.en);
            SetLocale(locale);
            ChangeGamePanelVisible(false);
            gameFieldButtons = new Button[9]
            {
                Button0, Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8
            };
        }
        private void SetLocale(Locale locale)
        {
            MainMenu.Text = locale.GetMainMenuText();
            SinglePlayerMenu.Text = locale.GetSinglePlayerMenuText();
            LowDifficult.Text = locale.GetLowDifficultText();
            HardDifficult.Text = locale.GetHardDifficultText();
            ExitMenu.Text = locale.GetExitMenuText();
            ScoreMenu.Text = locale.GetScoreMenuText();

        }
        /// <summary>
        /// Get game panel visible status method
        /// </summary>
        /// <returns>Visible or not</returns>
        public bool GetGamePanelStatus()
        {
            return GamePanel.Visible;
        }
        /// <summary>
        /// Get count of gamefield buttons method
        /// </summary>
        /// <returns>Count of gamefield buttons</returns>
        public int GetGameFieldFieldButtonsCount()
        {
            return gameFieldButtons.Length;
        }
        /// <summary>
        /// Change enabled form state method
        /// </summary>
        /// <param name="player">Player</param>
        /// <returns>Enabled or not</returns>
        public bool ChangeEnabledStateNow(string player)
        {
            if (player == "Player1")
                Enabled = true;
            else
                Enabled = false;
            return Enabled;
        }
        /// <summary>
        /// Click on low difficult method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void LowDifficult_Click(object sender, EventArgs e)
        {
            ChangeGamePanelVisible(true);
            ChangeButtonColor();
            StartGame(Game.Difficults.Low);
            ShowParameters();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool ChangeGamePanelVisible(bool state)
        {
            GamePanel.Visible = state;
            return state;
        }
        /// <summary>
        /// Click on hard difficult method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void HardDifficult_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = true;
            ChangeButtonColor();
            StartGame(Game.Difficults.Hard);
            ShowParameters();
        }
        /// <summary>
        /// Start single game method
        /// </summary>
        /// <param name="difficult">Difficult of current game</param>
        private void StartGame(Enum difficult)
        {
            game = new SinglePlayer(difficult, profile.PlayerName, locale);
            CreateSubscribes();
            parameters = new Parameters(game);
            UpdateButtons();
        }
        /// <summary>
        /// Create event subscribes method
        /// </summary>
        private void CreateSubscribes()
        {
            game.Player1IsCurrent += Game_Player1IsCurrent;
            game.Player2IsCurrent += Game_Player2IsCurrent;
            game.Win += Game_Win;
            game.Draw += Game_Draw;
        }
        /// <summary>
        /// Game draw method
        /// </summary>
        /// <param name="result">Result of game</param>
        private void Game_Draw(string result)
        {
            Enabled = true;
            profile.Draw(game.Difficult.ToString());
            GameDataBus.SaveGameResultInScore(profile, locale);
            DeleteSubscribes();
            GameDataBus.ShowResult(result, locale);
            GamePanel.Visible = false;
        }
        /// <summary>
        /// Game win method
        /// </summary>
        /// <param name="result">Result of game</param>
        private void Game_Win(string result)
        {
            Enabled = true;
            if (game.Winner == game.Player1)
            {
                profile.Win(game.Difficult.ToString());
                GameDataBus.SaveGameResultInScore(profile, locale);
                ChangeButtonColor(Color.Green);
            }
            else
            {
                profile.Lose(game.Difficult.ToString());
                GameDataBus.SaveGameResultInScore(profile, locale);
                ChangeButtonColor(Color.Red);
            }
            GameDataBus.ShowResult(result, locale);
            DeleteSubscribes();
            GamePanel.Visible = false;
        }
        /// <summary>
        /// Player 2 is current method
        /// </summary>
        private void Game_Player2IsCurrent()
        {
            ShowParameters();
            Enabled = false;
            Thread.Sleep(500);
            game.PlayerStep();
            UpdateButtons();
            game.CheckGameStatus();
            if (game.GameInProgress)
                game.ChangeCurrentPlayer();
        }
        /// <summary>
        /// Player 1 is current method
        /// </summary>
        private void Game_Player1IsCurrent()
        {
            Enabled = true;
            ShowParameters();
        }
        /// <summary>
        /// Show parameters method
        /// </summary>
        private void ShowParameters()
        {
            parameters.UpdateParameters(locale);
            GameInfoLabel.Text = parameters.GameParameters;
            PlayerInfoLabel.Text = parameters.PlayerParameters;
        }
        /// <summary>
        /// Update text on buttons method
        /// </summary>
        private void UpdateButtons()
        {
            for (int i = 0; i < gameFieldButtons.Length; i++)
            {
                gameFieldButtons[i].Text = game.GameField[i];
            }
        }
        /// <summary>
        /// Click on game field buttons method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void GameFieldButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int i = int.Parse(button.Tag.ToString());
            game.PlayerStep(i, out bool isPossible);
            if (!isPossible)
                GameDataBus.ShowImpossibleStepMessage(locale);
            UpdateButtons();
            game.CheckGameStatus();
            if(game.GameInProgress && isPossible)
                game.ChangeCurrentPlayer();
        }
        /// <summary>
        /// Delete subscribes method
        /// </summary>
        private void DeleteSubscribes()
        {
            game.Player1IsCurrent -= Game_Player1IsCurrent;
            game.Player2IsCurrent -= Game_Player2IsCurrent;
            game.Win -= Game_Win;
            game.Draw -= Game_Draw;
        }
        /// <summary>
        /// Change buttons color method
        /// </summary>
        private void ChangeButtonColor(Color color)
        {
            for (int i = 0; i < game.WinIndexes.Length; i++)
            {
                string tag = game.WinIndexes[i].ToString();
                for (int j = 0; j < gameFieldButtons.Length; j++)
                {
                    if (gameFieldButtons[j].Tag.ToString() == tag)
                    {
                        gameFieldButtons[j].BackColor = color;
                    }
                }
            }
        }
        /// <summary>
        /// Change buttons color to default
        /// </summary>
        private void ChangeButtonColor()
        {
            for (int i = 0; i < gameFieldButtons.Length; i++)
                    gameFieldButtons[i].BackColor = Color.LightGray;
        }
        /// <summary>
        /// Get count of buttons with default color method
        /// </summary>
        /// <returns>Count of buttons</returns>
        public int GetCountDefaultColorButtons()
        {
            ChangeButtonColor();
            var count = 0;
            foreach (Button button in gameFieldButtons)
            {
                if (button.BackColor == Color.LightGray)
                    count++;
            }
            return count;
        }
        /// <summary>
        /// Main form load event method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!SaveLoadProfile.CheckExistFileSave())
            {
#pragma warning disable IDE0067 // Dispose objects before losing scope
                NewProfile addUserForm = new NewProfile(profile);
#pragma warning restore IDE0067 // Dispose objects before losing scope
                addUserForm.ShowDialog();
                if (!GameDataBus.ProfileIsCreated)
                    Close();
            }
            else
            {
                profile = GameDataBus.LoadGameResultInScore(locale);
            }
        }
        /// <summary>
        /// Main form exit event method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            GameDataBus.SaveGameResultInScore(profile, locale);
            Application.Exit();
        }
        /// <summary>
        /// Show game score method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Param</param>
        private void ScoreMenu_Click(object sender, EventArgs e)
        {
            GameDataBus.ShowScore(profile, locale);
        }
    }
}
