using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
namespace dotHackFragmentLobbyServer.Classes
{
    public static class Database
    {
       //Non specific database variables
        static string dbEngine = Classes.ApplicationSettings.dataBaseType;
        static string connectionString = Classes.ApplicationSettings.connString;
        
        //MSSQL
        static SqlConnection msSqlConnection;
        static SqlCommand msSqlCommand;
        
        //MySQL
        static MySqlConnection mySQLConnection;
        static MySqlCommand mySQLCommand;
        


        private static void Connect()
        {
            try
            {
                //Using MS SQL Server
                if (dbEngine == "MSSQL")
                {

                    msSqlConnection = new SqlConnection(connectionString);
                    msSqlConnection.Open();


                }
                else if (dbEngine == "MYSQL") //Using MY SQL Server
                {
                    mySQLConnection = new MySqlConnection(connectionString);
                    mySQLConnection.Open();
                }
            }
            catch (Exception e)
            {

                throw e;
            }


        }

        private static void Disconnect()
        {
            try
            {
                //Using MS SQL Server
                if (dbEngine == "MSSQL")
                {
                    msSqlConnection.Close();
                }
                else if (dbEngine == "MYSQL") //Using MY SQL Server
                {
                    mySQLConnection.Close();
                }


            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public static DataTable GetDataTable (string SQL)
        {
            DataTable DT = new DataTable();

            try
            {
                Connect();
                if (dbEngine == "MSSQL")
                {
                    SqlDataAdapter msSQLDataAdaptor = new SqlDataAdapter();
                    msSqlCommand = new SqlCommand();
                    msSqlCommand.Connection = msSqlConnection;
                    msSqlCommand.CommandText = SQL;
                    msSQLDataAdaptor.SelectCommand = msSqlCommand;
                    msSQLDataAdaptor.Fill(DT);


                }
                else if (dbEngine == "MYSQL") //Using MY SQL Server
                {
                    MySqlDataAdapter mySQLDataAdaptor = new MySqlDataAdapter();
                    mySQLCommand = new MySqlCommand();
                    mySQLCommand.Connection = mySQLConnection;
                    mySQLCommand.CommandText = SQL;
                    mySQLDataAdaptor.SelectCommand = mySQLCommand;
                    mySQLDataAdaptor.Fill(DT);
                }
                Disconnect();
            }
            catch (Exception)
            {

                throw;
            }

            
            return DT;
        }

        public static string GetScaler (string SQL)
        {
            string returnedData = "0";
            try
            {
                Connect();
                if (dbEngine == "MSSQL")
                {
                    SqlDataAdapter msSQLDataAdaptor = new SqlDataAdapter();
                    msSqlCommand = new SqlCommand();
                    msSqlCommand.Connection = msSqlConnection;
                    msSqlCommand.CommandText = SQL;
                    returnedData = (string)msSqlCommand.ExecuteScalar();
                   
                }
                else if (dbEngine == "MYSQL") //Using MY SQL Server
                {
                    MySqlDataAdapter mySQLDataAdaptor = new MySqlDataAdapter();
                    mySQLCommand = new MySqlCommand();
                    mySQLCommand.Connection = mySQLConnection;
                    mySQLCommand.CommandText = SQL;
                    returnedData = (string)mySQLCommand.ExecuteScalar();
                }

                Disconnect();
                return returnedData;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
