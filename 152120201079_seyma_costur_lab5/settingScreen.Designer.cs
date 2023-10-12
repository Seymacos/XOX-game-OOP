namespace _152120201079_seyma_costur_lab6
{
    partial class settingScreen
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
            this.button_difficulty = new System.Windows.Forms.Button();
            this.button_adminPanel = new System.Windows.Forms.Button();
            this.button_newGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_difficulty
            // 
            this.button_difficulty.Location = new System.Drawing.Point(46, 113);
            this.button_difficulty.Name = "button_difficulty";
            this.button_difficulty.Size = new System.Drawing.Size(162, 59);
            this.button_difficulty.TabIndex = 0;
            this.button_difficulty.Text = "Difficulty Level";
            this.button_difficulty.UseVisualStyleBackColor = true;
            this.button_difficulty.Click += new System.EventHandler(this.button_difficulty_Click);
            // 
            // button_adminPanel
            // 
            this.button_adminPanel.Location = new System.Drawing.Point(273, 115);
            this.button_adminPanel.Name = "button_adminPanel";
            this.button_adminPanel.Size = new System.Drawing.Size(153, 57);
            this.button_adminPanel.TabIndex = 1;
            this.button_adminPanel.Text = "Admin Panel";
            this.button_adminPanel.UseVisualStyleBackColor = true;
            this.button_adminPanel.Click += new System.EventHandler(this.button_adminPanel_Click);
            // 
            // button_newGame
            // 
            this.button_newGame.Location = new System.Drawing.Point(487, 115);
            this.button_newGame.Name = "button_newGame";
            this.button_newGame.Size = new System.Drawing.Size(144, 57);
            this.button_newGame.TabIndex = 2;
            this.button_newGame.Text = "New Game";
            this.button_newGame.UseVisualStyleBackColor = true;
            this.button_newGame.Click += new System.EventHandler(this.button_newGame_Click);
            // 
            // settingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 417);
            this.Controls.Add(this.button_newGame);
            this.Controls.Add(this.button_adminPanel);
            this.Controls.Add(this.button_difficulty);
            this.Name = "settingScreen";
            this.Text = "settingScreen";
            this.Load += new System.EventHandler(this.settingScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_difficulty;
        private System.Windows.Forms.Button button_adminPanel;
        private System.Windows.Forms.Button button_newGame;
    }
}