using System;
using System.Collections;
namespace dotHackFragmentLobbyServer.Classes
{
   public static class ApplicationSettings
    {
        public readonly static string dataBaseType = Properties.Settings.Default.dataBaseType;
        public readonly static string connString = Properties.Settings.Default.connString;
        public readonly static string ipAddress = Properties.Settings.Default.IPAddress;
        public readonly static int port = Properties.Settings.Default.Port;
        public readonly static string hostName = Properties.Settings.Default.HostName;
        public readonly static string userName = Properties.Settings.Default.UserName;
        public readonly static string passWord = Properties.Settings.Default.PassWord;
        public readonly static int pingDelay = Properties.Settings.Default.pingDelay;


        public static Boolean CheckSettings ()
        {
           
            if (dataBaseType =="" || hostName =="" || userName =="" || passWord == "" || ipAddress=="" || port == 0) { return false; }

            return true;

        }

        public static void SaveSettings(string dataBaseType,string ipAddress,int port,string hostName, string userName, string passWord,int pingDelay)
        {
            Properties.Settings.Default.dataBaseType = dataBaseType;

            //Build our connection string based on the information we got back from the user
            if (dataBaseType == "MSSQL")
            {
                Properties.Settings.Default.connString = "Server=" + hostName + ";Database=Fragment;User Id="+ userName + ";Password=" + passWord + "; ";
            } else if(dataBaseType == "MYSQL")
            {
                Properties.Settings.Default.connString = "Server=" + hostName + ";Database=Fragment;Uid=" + userName + ";Pwd=" + passWord + "; ";
            }
         
            Properties.Settings.Default.IPAddress = ipAddress;
            Properties.Settings.Default.Port = port;
            Properties.Settings.Default.HostName = hostName;
            Properties.Settings.Default.UserName = userName;
            Properties.Settings.Default.PassWord = passWord;
            Properties.Settings.Default.pingDelay = pingDelay;
            Properties.Settings.Default.Save();
        }

        public static ArrayList GetSettings()
        {
            ArrayList settings = new ArrayList();

            settings.Add(dataBaseType);
            settings.Add(ipAddress);
            settings.Add(port);
            settings.Add(hostName);
            settings.Add(userName);
            settings.Add(passWord);
            settings.Add(pingDelay);
            return settings;
        }
    }
}
