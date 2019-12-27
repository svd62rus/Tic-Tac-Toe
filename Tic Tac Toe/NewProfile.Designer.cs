namespace Tic_Tac_Toe
{
    partial class NewProfile
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
            this.InputPlayerNameLabel = new System.Windows.Forms.Label();
            this.TxtBoxPlayerName = new System.Windows.Forms.TextBox();
            this.ButtonCreateProfile = new System.Windows.Forms.Button();
            this.RadioButtonEN = new System.Windows.Forms.RadioButton();
            this.RadioButtonRU = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // InputPlayerNameLabel
            // 
            this.InputPlayerNameLabel.AutoSize = true;
            this.InputPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPlayerNameLabel.Location = new System.Drawing.Point(33, 90);
            this.InputPlayerNameLabel.Name = "InputPlayerNameLabel";
            this.InputPlayerNameLabel.Size = new System.Drawing.Size(140, 20);
            this.InputPlayerNameLabel.TabIndex = 0;
            this.InputPlayerNameLabel.Text = "Input player name:";
            // 
            // TxtBoxPlayerName
            // 
            this.TxtBoxPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtBoxPlayerName.Location = new System.Drawing.Point(37, 113);
            this.TxtBoxPlayerName.Name = "TxtBoxPlayerName";
            this.TxtBoxPlayerName.Size = new System.Drawing.Size(197, 26);
            this.TxtBoxPlayerName.TabIndex = 1;
            this.TxtBoxPlayerName.TextChanged += new System.EventHandler(this.TxtBoxPlayerName_TextChanged);
            // 
            // ButtonCreateProfile
            // 
            this.ButtonCreateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateProfile.Location = new System.Drawing.Point(37, 158);
            this.ButtonCreateProfile.Name = "ButtonCreateProfile";
            this.ButtonCreateProfile.Size = new System.Drawing.Size(197, 31);
            this.ButtonCreateProfile.TabIndex = 2;
            this.ButtonCreateProfile.Text = "Create";
            this.ButtonCreateProfile.UseVisualStyleBackColor = true;
            this.ButtonCreateProfile.Click += new System.EventHandler(this.ButtonCreateProfile_Click);
            // 
            // RadioButtonEN
            // 
            this.RadioButtonEN.AutoSize = true;
            this.RadioButtonEN.Checked = true;
            this.RadioButtonEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonEN.Location = new System.Drawing.Point(37, 32);
            this.RadioButtonEN.Name = "RadioButtonEN";
            this.RadioButtonEN.Size = new System.Drawing.Size(79, 24);
            this.RadioButtonEN.TabIndex = 3;
            this.RadioButtonEN.TabStop = true;
            this.RadioButtonEN.Text = "English";
            this.RadioButtonEN.UseVisualStyleBackColor = true;
            this.RadioButtonEN.CheckedChanged += new System.EventHandler(this.RadioButtonEN_CheckedChanged);
            // 
            // RadioButtonRU
            // 
            this.RadioButtonRU.AutoSize = true;
            this.RadioButtonRU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonRU.Location = new System.Drawing.Point(148, 32);
            this.RadioButtonRU.Name = "RadioButtonRU";
            this.RadioButtonRU.Size = new System.Drawing.Size(86, 24);
            this.RadioButtonRU.TabIndex = 4;
            this.RadioButtonRU.Text = "Русский";
            this.RadioButtonRU.UseVisualStyleBackColor = true;
            this.RadioButtonRU.CheckedChanged += new System.EventHandler(this.RadioButtonRU_CheckedChanged);
            // 
            // NewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.RadioButtonRU);
            this.Controls.Add(this.RadioButtonEN);
            this.Controls.Add(this.ButtonCreateProfile);
            this.Controls.Add(this.TxtBoxPlayerName);
            this.Controls.Add(this.InputPlayerNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputPlayerNameLabel;
        private System.Windows.Forms.TextBox TxtBoxPlayerName;
        private System.Windows.Forms.Button ButtonCreateProfile;
        private System.Windows.Forms.RadioButton RadioButtonEN;
        private System.Windows.Forms.RadioButton RadioButtonRU;
    }
}