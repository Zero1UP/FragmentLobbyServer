namespace dotHackFragmentLobbyServer
{
    partial class frm_Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_SQLITE = new System.Windows.Forms.RadioButton();
            this.rdo_MYSQL = new System.Windows.Forms.RadioButton();
            this.rdo_MSSQL = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_IPSelection = new System.Windows.Forms.ComboBox();
            this.num_Port = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_HostName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_PingDelay = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Port)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_PingDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_SQLITE);
            this.groupBox1.Controls.Add(this.rdo_MYSQL);
            this.groupBox1.Controls.Add(this.rdo_MSSQL);
            this.groupBox1.Location = new System.Drawing.Point(2, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Engine";
            // 
            // rdo_SQLITE
            // 
            this.rdo_SQLITE.AutoSize = true;
            this.rdo_SQLITE.Location = new System.Drawing.Point(7, 68);
            this.rdo_SQLITE.Name = "rdo_SQLITE";
            this.rdo_SQLITE.Size = new System.Drawing.Size(57, 17);
            this.rdo_SQLITE.TabIndex = 3;
            this.rdo_SQLITE.Text = "SQLite";
            this.rdo_SQLITE.UseVisualStyleBackColor = true;
            // 
            // rdo_MYSQL
            // 
            this.rdo_MYSQL.AutoSize = true;
            this.rdo_MYSQL.Location = new System.Drawing.Point(7, 44);
            this.rdo_MYSQL.Name = "rdo_MYSQL";
            this.rdo_MYSQL.Size = new System.Drawing.Size(60, 17);
            this.rdo_MYSQL.TabIndex = 2;
            this.rdo_MYSQL.Text = "MySQL";
            this.rdo_MYSQL.UseVisualStyleBackColor = true;
            // 
            // rdo_MSSQL
            // 
            this.rdo_MSSQL.AutoSize = true;
            this.rdo_MSSQL.Location = new System.Drawing.Point(7, 20);
            this.rdo_MSSQL.Name = "rdo_MSSQL";
            this.rdo_MSSQL.Size = new System.Drawing.Size(65, 17);
            this.rdo_MSSQL.TabIndex = 1;
            this.rdo_MSSQL.Text = "MS SQL";
            this.rdo_MSSQL.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_PingDelay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmb_IPSelection);
            this.groupBox2.Controls.Add(this.num_Port);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 92);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ping Delay";
            // 
            // cmb_IPSelection
            // 
            this.cmb_IPSelection.FormattingEnabled = true;
            this.cmb_IPSelection.Location = new System.Drawing.Point(75, 9);
            this.cmb_IPSelection.Name = "cmb_IPSelection";
            this.cmb_IPSelection.Size = new System.Drawing.Size(121, 21);
            this.cmb_IPSelection.TabIndex = 1;
            // 
            // num_Port
            // 
            this.num_Port.Location = new System.Drawing.Point(78, 36);
            this.num_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_Port.Name = "num_Port";
            this.num_Port.Size = new System.Drawing.Size(120, 20);
            this.num_Port.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(2, 290);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(216, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_PassWord);
            this.groupBox3.Controls.Add(this.txt_UserName);
            this.groupBox3.Controls.Add(this.txt_HostName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(112, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 138);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connection String";
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(9, 112);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.PasswordChar = '*';
            this.txt_PassWord.Size = new System.Drawing.Size(96, 20);
            this.txt_PassWord.TabIndex = 2;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(9, 76);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(96, 20);
            this.txt_UserName.TabIndex = 1;
            // 
            // txt_HostName
            // 
            this.txt_HostName.Location = new System.Drawing.Point(10, 37);
            this.txt_HostName.Name = "txt_HostName";
            this.txt_HostName.Size = new System.Drawing.Size(96, 20);
            this.txt_HostName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Host Name";
            // 
            // num_PingDelay
            // 
            this.num_PingDelay.Location = new System.Drawing.Point(78, 66);
            this.num_PingDelay.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_PingDelay.Name = "num_PingDelay";
            this.num_PingDelay.Size = new System.Drawing.Size(120, 20);
            this.num_PingDelay.TabIndex = 4;
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 338);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_Settings";
            this.Load += new System.EventHandler(this.frm_Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Port)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_PingDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_SQLITE;
        private System.Windows.Forms.RadioButton rdo_MYSQL;
        private System.Windows.Forms.RadioButton rdo_MSSQL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_IPSelection;
        private System.Windows.Forms.NumericUpDown num_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_HostName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_PingDelay;
    }
}