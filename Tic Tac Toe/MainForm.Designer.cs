namespace Tic_Tac_Toe
{
    partial class MainForm
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
            this.GamePanel = new System.Windows.Forms.Panel();
            this.PlayerInfoLabel = new System.Windows.Forms.Label();
            this.GameInfoLabel = new System.Windows.Forms.Label();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SinglePlayerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LowDifficult = new System.Windows.Forms.ToolStripMenuItem();
            this.HardDifficult = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ScoreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GamePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.PlayerInfoLabel);
            this.GamePanel.Controls.Add(this.GameInfoLabel);
            this.GamePanel.Controls.Add(this.Button8);
            this.GamePanel.Controls.Add(this.Button7);
            this.GamePanel.Controls.Add(this.Button6);
            this.GamePanel.Controls.Add(this.Button5);
            this.GamePanel.Controls.Add(this.Button4);
            this.GamePanel.Controls.Add(this.Button3);
            this.GamePanel.Controls.Add(this.Button2);
            this.GamePanel.Controls.Add(this.Button1);
            this.GamePanel.Controls.Add(this.Button0);
            this.GamePanel.Location = new System.Drawing.Point(13, 32);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(347, 403);
            this.GamePanel.TabIndex = 0;
            // 
            // PlayerInfoLabel
            // 
            this.PlayerInfoLabel.AutoSize = true;
            this.PlayerInfoLabel.Location = new System.Drawing.Point(15, 333);
            this.PlayerInfoLabel.Name = "PlayerInfoLabel";
            this.PlayerInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.PlayerInfoLabel.TabIndex = 10;
            this.PlayerInfoLabel.Text = "label1";
            // 
            // GameInfoLabel
            // 
            this.GameInfoLabel.AutoSize = true;
            this.GameInfoLabel.Location = new System.Drawing.Point(15, 308);
            this.GameInfoLabel.Name = "GameInfoLabel";
            this.GameInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.GameInfoLabel.TabIndex = 9;
            this.GameInfoLabel.Text = "label1";
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.Location = new System.Drawing.Point(228, 207);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(99, 84);
            this.Button8.TabIndex = 8;
            this.Button8.Tag = "8";
            this.Button8.Text = "Button8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.GameFieldButton_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.Location = new System.Drawing.Point(122, 207);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(99, 84);
            this.Button7.TabIndex = 7;
            this.Button7.Tag = "7";
            this.Button7.Text = "Button7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.GameFieldButton_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Location = new System.Drawing.Point(15, 206);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(100, 85);
            this.Button6.TabIndex = 6;
            this.Button6.Tag = "6";
            this.Button6.Text = "Button6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.GameFieldButton_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(228, 116);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(99, 84);
            this.Button5.TabIndex = 5;
            this.Button5.Tag = "5";
            this.Button5.Text = "Button5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.GameFieldButton_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Location = new System.Drawing.Point(122, 116);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(99, 84);
            this.Button4.TabIndex = 4;
            this.Button4.Tag = "4";
            this.Button4.Text = "Button4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.GameFieldButton_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(15, 115);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 85);
            this.Button3.TabIndex = 3;
            this.Button3.Tag = "3";
            this.Button3.Text = "Button3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.GameFieldButton_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button2.Location = new System.Drawing.Point(227, 24);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 85);
            this.Button2.TabIndex = 2;
            this.Button2.Tag = "2";
            this.Button2.Text = "Button2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.GameFieldButton_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(121, 24);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 85);
            this.Button1.TabIndex = 1;
            this.Button1.Tag = "1";
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.GameFieldButton_Click);
            // 
            // Button0
            // 
            this.Button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button0.Location = new System.Drawing.Point(15, 24);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(100, 85);
            this.Button0.TabIndex = 0;
            this.Button0.Tag = "0";
            this.Button0.Text = "Button0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.GameFieldButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu,
            this.ScoreMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenu
            // 
            this.MainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SinglePlayerMenu,
            this.ExitMenu});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(50, 20);
            this.MainMenu.Text = "Menu";
            // 
            // SinglePlayerMenu
            // 
            this.SinglePlayerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LowDifficult,
            this.HardDifficult});
            this.SinglePlayerMenu.Name = "SinglePlayerMenu";
            this.SinglePlayerMenu.Size = new System.Drawing.Size(139, 22);
            this.SinglePlayerMenu.Text = "Single game";
            // 
            // LowDifficult
            // 
            this.LowDifficult.Name = "LowDifficult";
            this.LowDifficult.Size = new System.Drawing.Size(100, 22);
            this.LowDifficult.Text = "Low";
            this.LowDifficult.Click += new System.EventHandler(this.LowDifficult_Click);
            // 
            // HardDifficult
            // 
            this.HardDifficult.Name = "HardDifficult";
            this.HardDifficult.Size = new System.Drawing.Size(100, 22);
            this.HardDifficult.Text = "Hard";
            this.HardDifficult.Click += new System.EventHandler(this.HardDifficult_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(139, 22);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // ScoreMenu
            // 
            this.ScoreMenu.Name = "ScoreMenu";
            this.ScoreMenu.Size = new System.Drawing.Size(48, 20);
            this.ScoreMenu.Text = "Score";
            this.ScoreMenu.Click += new System.EventHandler(this.ScoreMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SinglePlayerMenu;
        private System.Windows.Forms.ToolStripMenuItem LowDifficult;
        private System.Windows.Forms.ToolStripMenuItem HardDifficult;
        private System.Windows.Forms.Label GameInfoLabel;
        private System.Windows.Forms.Label PlayerInfoLabel;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem ScoreMenu;
    }
}

