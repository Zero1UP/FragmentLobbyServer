using System;
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

            cmb_IPSelection.SelectedItem = settings[1].ToString();
            num_Port.Value = decimal.Parse( settings[2].ToString());
            txt_HostName.Text = settings[3].ToString();
            txt_UserName.Text = settings[4].ToString();
            txt_PassWord.Text = settings[5].ToString();
            num_PingDelay.Value = decimal.Parse(settings[6].ToString());
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string dbEngine ="";
            string validationReturn;
            int selectedPort = 0;
            int selectedPingDelay = 0;

            if (rdo_MSSQL.Checked) { dbEngine = "MSSQL"; }
            if (rdo_MYSQL.Checked) { dbEngine = "MYSQL"; }
            if (rdo_SQLITE.Checked) { dbEngine = "SQLITE"; }
            int.TryParse( num_Port.Value.ToString(),out selectedPort ); //Need to convert this to an int because the numeric updown is a decimal
            int.TryParse(num_PingDelay.Value.ToString(), out selectedPingDelay);//Need to convert this to an int because the numeric updown is a decimal

            validationReturn = ValidateSettings();
            if (validationReturn =="")
            {
                Classes.ApplicationSettings.SaveSettings(dbEngine, cmb_IPSelection.SelectedItem.ToString(), selectedPort, txt_HostName.Text, txt_UserName.Text, txt_PassWord.Text, selectedPingDelay);
            }
            else
            {
                MessageBox.Show(validationReturn);
            }
            
        }

        private String ValidateSettings()
        {
            string errorMessage ="";
            string[] splitIPV4 = cmb_IPSelection.SelectedItem.ToString().Split('.');
            
            if(splitIPV4.Length != 4) { errorMessage = "Please enter a valid IP Address for Server Info."; }
            if(num_Port.Value == 0) { errorMessage += "\n Please enter a port higher than 0."; }
            if(rdo_MSSQL.Checked ==false && rdo_MYSQL.Checked ==false && rdo_SQLITE.Checked == false) { errorMessage += "\n Please select a database engine."; }

            //SQL Lite database does no require a user name or password so this check only applies to MSSQL and MYSQL
            if (rdo_MSSQL.Checked ==true || rdo_MYSQL.Checked ==true)
            {
                if(txt_HostName.Text == "") { errorMessage += "\n Please enter a host name under Connection String."; }
                if(txt_UserName.Text == "") { errorMessage += "\n Please enter a user name under Connection String."; }
                if(txt_PassWord.Text == "") { errorMessage += "\n Please enter a pass word under Connection String."; }
            }

            return errorMessage;
        }
    }


}
