using System;
using System.Windows.Forms;
using Tic_Tac_Toe.Localization;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Add user form class
    /// </summary>
    public partial class NewProfile : Form
    {
        /// <summary>
        /// Game profile variable
        /// </summary>
        private GameProfile profile;
        private Locale locale;
        /// <summary>
        /// Constructor of form
        /// </summary>
        /// <param name="profile">Game profile for write information</param>
        /// <param name="locale">Locale</param>
        public NewProfile(GameProfile profile, Locale locale)
        {
            this.profile = profile;
            this.locale = locale;
            InitializeComponent();
            SetLocale(locale);
            ButtonCreateProfile.Enabled = false;
        }
        /// <summary>
        /// Button create player profile click method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void ButtonCreateProfile_Click(object sender, EventArgs e)
        {
            profile.PlayerName = TxtBoxPlayerName.Text;
            profile.PlayerLocale = locale.Localization;
            SaveLoadProfile.Save(profile);
            GameDataBus.ProfileIsCreated = true;
            GameDataBus.TempProfile = profile;
            Close();
        }
        /// <summary>
        /// Player name text changed event method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void TxtBoxPlayerName_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TxtBoxPlayerName.Text) || TxtBoxPlayerName.Text.Length>16)
                ButtonCreateProfile.Enabled = false;
            else
                ButtonCreateProfile.Enabled = true;
        }
        /// <summary>
        /// English radio button event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonEN_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonEN.Checked)
            {
                locale = LocaleCreator.CreateLocale(LocaleCreator.InterfaceLanguage.en);
                SetLocale(locale);
            }
        }
        /// <summary>
        /// Set locale method
        /// </summary>
        /// <param name="locale">Locale</param>
        private void SetLocale(Locale locale)
        {   
            InputPlayerNameLabel.Text = locale.GetInputProfileNameText();
            ButtonCreateProfile.Text = locale.GetCreateProfileButtonText();
        }
        /// <summary>
        /// Russian radio button event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonRU_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonRU.Checked)
            {
                locale = LocaleCreator.CreateLocale(LocaleCreator.InterfaceLanguage.ru);
                SetLocale(locale);
            }
        }
    }
}
