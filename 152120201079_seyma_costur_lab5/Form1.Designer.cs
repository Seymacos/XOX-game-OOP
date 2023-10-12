namespace _152120201079_seyma_costur_lab6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.box1 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.Button();
            this.box3 = new System.Windows.Forms.Button();
            this.box4 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.Button();
            this.box6 = new System.Windows.Forms.Button();
            this.box7 = new System.Windows.Forms.Button();
            this.box8 = new System.Windows.Forms.Button();
            this.box9 = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.textBox_StudentNumber = new System.Windows.Forms.TextBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.AImoves = new System.Windows.Forms.Timer(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(12, 51);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(50, 50);
            this.box1.TabIndex = 0;
            this.box1.UseVisualStyleBackColor = true;
            this.box1.Click += new System.EventHandler(this.playerClick);
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(68, 51);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(50, 50);
            this.box2.TabIndex = 1;
            this.box2.UseVisualStyleBackColor = true;
            this.box2.Click += new System.EventHandler(this.playerClick);
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(124, 51);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(50, 50);
            this.box3.TabIndex = 2;
            this.box3.UseVisualStyleBackColor = true;
            this.box3.Click += new System.EventHandler(this.playerClick);
            // 
            // box4
            // 
            this.box4.Location = new System.Drawing.Point(12, 107);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(50, 50);
            this.box4.TabIndex = 3;
            this.box4.UseVisualStyleBackColor = true;
            this.box4.Click += new System.EventHandler(this.playerClick);
            // 
            // box5
            // 
            this.box5.Location = new System.Drawing.Point(68, 107);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(50, 50);
            this.box5.TabIndex = 4;
            this.box5.UseVisualStyleBackColor = true;
            this.box5.Click += new System.EventHandler(this.playerClick);
            // 
            // box6
            // 
            this.box6.Location = new System.Drawing.Point(124, 107);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(50, 50);
            this.box6.TabIndex = 5;
            this.box6.UseVisualStyleBackColor = true;
            this.box6.Click += new System.EventHandler(this.playerClick);
            // 
            // box7
            // 
            this.box7.Location = new System.Drawing.Point(12, 163);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(50, 50);
            this.box7.TabIndex = 6;
            this.box7.UseVisualStyleBackColor = true;
            this.box7.Click += new System.EventHandler(this.playerClick);
            // 
            // box8
            // 
            this.box8.Location = new System.Drawing.Point(68, 163);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(50, 50);
            this.box8.TabIndex = 7;
            this.box8.UseVisualStyleBackColor = true;
            this.box8.Click += new System.EventHandler(this.playerClick);
            // 
            // box9
            // 
            this.box9.Location = new System.Drawing.Point(124, 163);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(50, 50);
            this.box9.TabIndex = 8;
            this.box9.UseVisualStyleBackColor = true;
            this.box9.Click += new System.EventHandler(this.playerClick);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(97, 219);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "RESET GAME";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // textBox_StudentNumber
            // 
            this.textBox_StudentNumber.Location = new System.Drawing.Point(12, 12);
            this.textBox_StudentNumber.Name = "textBox_StudentNumber";
            this.textBox_StudentNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_StudentNumber.TabIndex = 10;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(77, 245);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(0, 13);
            this.label_Result.TabIndex = 12;
            // 
            // AImoves
            // 
            this.AImoves.Interval = 1000;
            this.AImoves.Tick += new System.EventHandler(this.AImove);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 219);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 264);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.textBox_StudentNumber);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button box1;
        private System.Windows.Forms.Button box2;
        private System.Windows.Forms.Button box3;
        private System.Windows.Forms.Button box4;
        private System.Windows.Forms.Button box5;
        private System.Windows.Forms.Button box6;
        private System.Windows.Forms.Button box7;
        private System.Windows.Forms.Button box8;
        private System.Windows.Forms.Button box9;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.TextBox textBox_StudentNumber;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Timer AImoves;
        private System.Windows.Forms.Button buttonBack;
    }
}

