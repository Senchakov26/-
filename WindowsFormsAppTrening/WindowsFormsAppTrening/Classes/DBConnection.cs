using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsAppTrening.Classes
{
    class DBConnection
    {
        static public string connectStr = "Database = esoft; DataSource = localhost; user = root; password = qwerty; charset = utf8;";

        static public MySqlConnection myConnect;
        static public MySqlCommand myCommand;
        static public MySqlDataAdapter myDataAdapter;

        static public bool DBConnect()
        {
            myConnect = new MySqlConnection(connectStr);
            myConnect.Open();
            myCommand = new MySqlCommand();
            myCommand.Connection = myConnect;
            myDataAdapter = new MySqlDataAdapter(myCommand);
            return true;
        }
        static public void DBConnectClose()
        {
            myConnect.Close();
        }
    }
}
