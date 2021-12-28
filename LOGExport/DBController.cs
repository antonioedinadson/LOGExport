using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LOGExport {
    class DBController {

        public static MySqlConnection connection = new MySqlConnection("Server=localhost;Database=chrome;Uid=root;Pwd=;");

        public MySqlConnection GetConnection() {
            return connection;
        }

        public void OpenConnetion() {
            if (connection.State == System.Data.ConnectionState.Closed) {
                connection.Open();
            }
        }

        public void CloseConnetion() {
            if (connection.State == System.Data.ConnectionState.Open) {
                connection.Close();
            }
        }


    }
}
