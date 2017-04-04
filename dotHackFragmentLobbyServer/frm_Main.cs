using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;
namespace dotHackFragmentLobbyServer
{
    public partial class frm_Main : Form
    {
        Boolean applicationSettings = true;


        public frm_Main()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_Settings = new frm_Settings();
            frm_Settings.Show();
        }



        // Checks our current Server settings
        private Boolean  CheckSettingsFile()
        {
            string dataBaseType = Properties.Settings.Default.dataBaseType;
            string connString = Properties.Settings.Default.connString;
            string databaseFilePath = Properties.Settings.Default.databaseFilePath;
            string IPAddress = Properties.Settings.Default.IPAddress;
            int Port = Properties.Settings.Default.Port;

            if (dataBaseType == "" || connString =="" || IPAddress == "" || Port == 0){return false;}

            if(dataBaseType !="" && databaseFilePath ==""){ return false;}

            return true;
        }


        #region Form Events

        private void frm_Main_Load(object sender, EventArgs e)
        {


        }
        private void frm_Main_Shown(object sender, EventArgs e)
        {
            //Display the settings form if it returns false
            applicationSettings = true; //CheckSettingsFile();
            if (applicationSettings == false)
            {
                Form frm_Settings = new frm_Settings();

                MessageBox.Show("There are settings that need to be setup before you can run the server!", "Error", MessageBoxButtons.OK);
                frm_Settings.Show();
                frm_Settings.BringToFront();
            }

        }



        #endregion

    }
}
