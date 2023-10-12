namespace _152120201079_seyma_costur_lab6
{
    partial class adminPanel
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
            this.button_List = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_adminPanel = new System.Windows.Forms.TextBox();
            this.label_adminPanel = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_List
            // 
            this.button_List.Location = new System.Drawing.Point(131, 202);
            this.button_List.Name = "button_List";
            this.button_List.Size = new System.Drawing.Size(123, 31);
            this.button_List.TabIndex = 0;
            this.button_List.Text = "List";
            this.button_List.UseVisualStyleBackColor = true;
            this.button_List.Click += new System.EventHandler(this.button_List_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(286, 202);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(123, 31);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(442, 202);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(123, 31);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(374, 253);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(123, 31);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            // 
            // textBox_adminPanel
            // 
            this.textBox_adminPanel.Location = new System.Drawing.Point(195, 264);
            this.textBox_adminPanel.Name = "textBox_adminPanel";
            this.textBox_adminPanel.Size = new System.Drawing.Size(100, 20);
            this.textBox_adminPanel.TabIndex = 5;
            // 
            // label_adminPanel
            // 
            this.label_adminPanel.AutoSize = true;
            this.label_adminPanel.Location = new System.Drawing.Point(168, 248);
            this.label_adminPanel.Name = "label_adminPanel";
            this.label_adminPanel.Size = new System.Drawing.Size(175, 13);
            this.label_adminPanel.TabIndex = 6;
            this.label_adminPanel.Text = "Silmek istediginiz kisinin id\'sini giriniz";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(207, 318);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(123, 31);
            this.button_connect.TabIndex = 7;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 318);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 39);
            this.textBox1.TabIndex = 8;
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label_adminPanel);
            this.Controls.Add(this.textBox_adminPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_List);
            this.Name = "adminPanel";
            this.Text = "adminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_List;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_adminPanel;
        private System.Windows.Forms.Label label_adminPanel;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textBox1;
    }
}