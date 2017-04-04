using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Collections;
namespace dotHackFragmentLobbyServer
{
    public partial class frm_Settings : Form
    {
        public frm_Settings()
        {
            InitializeComponent();
        }

 
        //Lists all of the machines IPV4 addresses that could be bound to.
        private void ListNetWorkAdapters()
        {
            foreach (NetworkInterface netWorkAdaptor in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties IpProps = netWorkAdaptor.GetIPProperties();
                String IPV4Address = "";

                try
                {
                    IPV4Address = IpProps.UnicastAddresses[1].Address.ToString();
                    //Test to see if this is an IPV4 Address
                    IPV4Address.Substring(0, IPV4Address.IndexOf("."));
                    cmb_IPSelection.Items.Add(IPV4Address);
                }
                catch (Exception)
                {

                   // We could throw the error here but all it would mean is that we got an IPV6 address or at least not an IPV4
                }

            }
        }

        private void frm_Settings_Load(object sender, EventArgs e)
        {
            ListNetWorkAdapters();
            PopulateForm();

        }

        private void PopulateForm()
        {
            ArrayList settings = Classes.ApplicationSettings.GetSettings();

            if(settings[0].ToString() == "MSSQL") { rdo_MSSQL.Checked = true; }
            if (settings[0].ToString() == "MYSQL") { rdo_MYSQL.Checked = true; }
            if (settings[0].ToString() == "SQLITE") { rdo_SQLITE.Checked = true; }

            //connstring
            //databaseFilePath
            cmb_IPSelection.SelectedItem = settings[3].ToString();
            num_Port.Value = decimal.Parse( settings[4].ToString());
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string dbEngine ="";
            int selectedPort = 0;

            if (rdo_MSSQL.Checked) { dbEngine = "MSSQL"; }
            if (rdo_MYSQL.Checked) { dbEngine = "MYSQL"; }
            if (rdo_SQLITE.Checked) { dbEngine = "SQLITE"; }
            int.TryParse( num_Port.Value.ToString(),out selectedPort );

            Classes.ApplicationSettings.SaveSettings(dbEngine, "", "", cmb_IPSelection.SelectedItem.ToString(), selectedPort);
        }

    }


}
