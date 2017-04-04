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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_DatabaseSettings = new System.Windows.Forms.TabPage();
            this.tb_ServerSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_MSSQL = new System.Windows.Forms.RadioButton();
            this.rdo_MYSQL = new System.Windows.Forms.RadioButton();
            this.rdo_SQLITE = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tb_DatabaseSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_DatabaseSettings);
            this.tabControl1.Controls.Add(this.tb_ServerSettings);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 237);
            this.tabControl1.TabIndex = 0;
            // 
            // tb_DatabaseSettings
            // 
            this.tb_DatabaseSettings.Controls.Add(this.groupBox1);
            this.tb_DatabaseSettings.Location = new System.Drawing.Point(4, 22);
            this.tb_DatabaseSettings.Name = "tb_DatabaseSettings";
            this.tb_DatabaseSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tb_DatabaseSettings.Size = new System.Drawing.Size(632, 211);
            this.tb_DatabaseSettings.TabIndex = 0;
            this.tb_DatabaseSettings.Text = "Database Settings";
            this.tb_DatabaseSettings.UseVisualStyleBackColor = true;
            // 
            // tb_ServerSettings
            // 
            this.tb_ServerSettings.Location = new System.Drawing.Point(4, 22);
            this.tb_ServerSettings.Name = "tb_ServerSettings";
            this.tb_ServerSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tb_ServerSettings.Size = new System.Drawing.Size(632, 211);
            this.tb_ServerSettings.TabIndex = 1;
            this.tb_ServerSettings.Text = "Server Settings";
            this.tb_ServerSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_SQLITE);
            this.groupBox1.Controls.Add(this.rdo_MYSQL);
            this.groupBox1.Controls.Add(this.rdo_MSSQL);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Engine";
            // 
            // rdo_MSSQL
            // 
            this.rdo_MSSQL.AutoSize = true;
            this.rdo_MSSQL.Location = new System.Drawing.Point(7, 20);
            this.rdo_MSSQL.Name = "rdo_MSSQL";
            this.rdo_MSSQL.Size = new System.Drawing.Size(65, 17);
            this.rdo_MSSQL.TabIndex = 0;
            this.rdo_MSSQL.TabStop = true;
            this.rdo_MSSQL.Text = "MS SQL";
            this.rdo_MSSQL.UseVisualStyleBackColor = true;
            this.rdo_MSSQL.CheckedChanged += new System.EventHandler(this.rdo_MSSQL_CheckedChanged);
            // 
            // rdo_MYSQL
            // 
            this.rdo_MYSQL.AutoSize = true;
            this.rdo_MYSQL.Location = new System.Drawing.Point(7, 44);
            this.rdo_MYSQL.Name = "rdo_MYSQL";
            this.rdo_MYSQL.Size = new System.Drawing.Size(60, 17);
            this.rdo_MYSQL.TabIndex = 1;
            this.rdo_MYSQL.TabStop = true;
            this.rdo_MYSQL.Text = "MySQL";
            this.rdo_MYSQL.UseVisualStyleBackColor = true;
            this.rdo_MYSQL.CheckedChanged += new System.EventHandler(this.rdo_MYSQL_CheckedChanged);
            // 
            // rdo_SQLITE
            // 
            this.rdo_SQLITE.AutoSize = true;
            this.rdo_SQLITE.Location = new System.Drawing.Point(7, 68);
            this.rdo_SQLITE.Name = "rdo_SQLITE";
            this.rdo_SQLITE.Size = new System.Drawing.Size(57, 17);
            this.rdo_SQLITE.TabIndex = 2;
            this.rdo_SQLITE.TabStop = true;
            this.rdo_SQLITE.Text = "SQLite";
            this.rdo_SQLITE.UseVisualStyleBackColor = true;
            this.rdo_SQLITE.CheckedChanged += new System.EventHandler(this.rdo_SQLITE_CheckedChanged);
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Settings";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tb_DatabaseSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_DatabaseSettings;
        private System.Windows.Forms.TabPage tb_ServerSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_SQLITE;
        private System.Windows.Forms.RadioButton rdo_MYSQL;
        private System.Windows.Forms.RadioButton rdo_MSSQL;
    }
}