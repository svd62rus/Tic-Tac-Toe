using System;
using System.Windows.Forms;

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
        /// <summary>
        /// Constructor of form
        /// </summary>
        /// <param name="profile">Game profile for write information</param>
        public NewProfile(GameProfile profile)
        {
            this.profile = profile;
            InitializeComponent();
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
            SaveLoadProfile.Save(profile);
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
    }
}
