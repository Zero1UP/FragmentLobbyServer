using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace dotHackFragmentLobbyServer.Classes
{
   public static class ApplicationSettings
    {
        static string dataBaseType = Properties.Settings.Default.dataBaseType;
        static string connString = Properties.Settings.Default.connString;
        static string databaseFilePath = Properties.Settings.Default.databaseFilePath;
        static string ipAddress = Properties.Settings.Default.IPAddress;
        static int port = Properties.Settings.Default.Port;
        
  

        //Build our constructor
        public static Boolean CheckSettings ()
        {
            if (dataBaseType == "" || connString == "" || ipAddress == "" || port == 0) { return false; }

            if (dataBaseType != "" && databaseFilePath == "") { return false; }

            return true;

        }

        public static void SaveSettings(string dataBaseType,string connString,string databaseFilePath,string ipAddress,int port)
        {
            Properties.Settings.Default.dataBaseType = dataBaseType;
            Properties.Settings.Default.connString = connString;
            Properties.Settings.Default.databaseFilePath = databaseFilePath;
            Properties.Settings.Default.IPAddress = ipAddress;
            Properties.Settings.Default.Port = port;
            Properties.Settings.Default.Save();
        }

        public static ArrayList GetSettings()
        {
            ArrayList settings = new ArrayList();

            settings.Add(Properties.Settings.Default.dataBaseType);
            settings.Add(Properties.Settings.Default.connString);
            settings.Add(Properties.Settings.Default.databaseFilePath);
            settings.Add(Properties.Settings.Default.IPAddress);
            settings.Add(Properties.Settings.Default.Port);

            return settings;
        }
    }
}
