namespace _152120201079_seyma_costur_lab6
{
    partial class diffucultyLevel
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
            this.buttonEasy_diffucultyLevel = new System.Windows.Forms.Button();
            this.buttonMedium_diffucultyLevel = new System.Windows.Forms.Button();
            this.buttonHard_diffucultyLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEasy_diffucultyLevel
            // 
            this.buttonEasy_diffucultyLevel.Location = new System.Drawing.Point(36, 85);
            this.buttonEasy_diffucultyLevel.Name = "buttonEasy_diffucultyLevel";
            this.buttonEasy_diffucultyLevel.Size = new System.Drawing.Size(98, 65);
            this.buttonEasy_diffucultyLevel.TabIndex = 0;
            this.buttonEasy_diffucultyLevel.Text = "EASY";
            this.buttonEasy_diffucultyLevel.UseVisualStyleBackColor = true;
            this.buttonEasy_diffucultyLevel.Click += new System.EventHandler(this.buttonEasy_diffucultyLevel_Click);
            // 
            // buttonMedium_diffucultyLevel
            // 
            this.buttonMedium_diffucultyLevel.Location = new System.Drawing.Point(186, 85);
            this.buttonMedium_diffucultyLevel.Name = "buttonMedium_diffucultyLevel";
            this.buttonMedium_diffucultyLevel.Size = new System.Drawing.Size(98, 65);
            this.buttonMedium_diffucultyLevel.TabIndex = 1;
            this.buttonMedium_diffucultyLevel.Text = "MEDIUM";
            this.buttonMedium_diffucultyLevel.UseVisualStyleBackColor = true;
            this.buttonMedium_diffucultyLevel.Click += new System.EventHandler(this.buttonMedium_diffucultyLevel_Click);
            // 
            // buttonHard_diffucultyLevel
            // 
            this.buttonHard_diffucultyLevel.Location = new System.Drawing.Point(334, 85);
            this.buttonHard_diffucultyLevel.Name = "buttonHard_diffucultyLevel";
            this.buttonHard_diffucultyLevel.Size = new System.Drawing.Size(98, 65);
            this.buttonHard_diffucultyLevel.TabIndex = 2;
            this.buttonHard_diffucultyLevel.Text = "HARD";
            this.buttonHard_diffucultyLevel.UseVisualStyleBackColor = true;
            this.buttonHard_diffucultyLevel.Click += new System.EventHandler(this.buttonHard_diffucultyLevel_Click);
            // 
            // diffucultyLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.buttonHard_diffucultyLevel);
            this.Controls.Add(this.buttonMedium_diffucultyLevel);
            this.Controls.Add(this.buttonEasy_diffucultyLevel);
            this.Name = "diffucultyLevel";
            this.Text = "difficultyLevel";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonEasy_diffucultyLevel;
        public System.Windows.Forms.Button buttonMedium_diffucultyLevel;
        public System.Windows.Forms.Button buttonHard_diffucultyLevel;
    }
}