namespace Tic_Tac_Toe
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxPlayerName = new System.Windows.Forms.TextBox();
            this.ButtonCreateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя игрока:";
            // 
            // TxtBoxPlayerName
            // 
            this.TxtBoxPlayerName.Location = new System.Drawing.Point(21, 45);
            this.TxtBoxPlayerName.Name = "TxtBoxPlayerName";
            this.TxtBoxPlayerName.Size = new System.Drawing.Size(197, 20);
            this.TxtBoxPlayerName.TabIndex = 1;
            this.TxtBoxPlayerName.TextChanged += new System.EventHandler(this.TxtBoxPlayerName_TextChanged);
            // 
            // ButtonCreateProfile
            // 
            this.ButtonCreateProfile.Location = new System.Drawing.Point(66, 96);
            this.ButtonCreateProfile.Name = "ButtonCreateProfile";
            this.ButtonCreateProfile.Size = new System.Drawing.Size(113, 23);
            this.ButtonCreateProfile.TabIndex = 2;
            this.ButtonCreateProfile.Text = "Создать профиль";
            this.ButtonCreateProfile.UseVisualStyleBackColor = true;
            this.ButtonCreateProfile.Click += new System.EventHandler(this.ButtonCreateProfile_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 131);
            this.Controls.Add(this.ButtonCreateProfile);
            this.Controls.Add(this.TxtBoxPlayerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый профиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxPlayerName;
        private System.Windows.Forms.Button ButtonCreateProfile;
    }
}