using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotHackFragmentLobbyServer
{
    public partial class frm_Settings : Form
    {
        public frm_Settings()
        {
            InitializeComponent();
        }

        private void rdo_MSSQL_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dataBaseType = "MSSQL";
            Properties.Settings.Default.Save();
        }

        private void rdo_MYSQL_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dataBaseType = "MYSQL";
            Properties.Settings.Default.Save();
        }

        private void rdo_SQLITE_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dataBaseType = "SQLITE";
            Properties.Settings.Default.Save();
        }
    }
}
