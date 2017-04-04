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

        #region Form Events

        private void frm_Main_Load(object sender, EventArgs e)
        {


        }
        private void frm_Main_Shown(object sender, EventArgs e)
        {
            //If the server is not currently configured then we need to display the settings window to the user as a first time setup.
            //This form has the options to set the server IP, port number and database information
            applicationSettings = Classes.ApplicationSettings.CheckSettings();
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
