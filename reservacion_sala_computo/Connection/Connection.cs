using reservacion_sala_computo.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace reservacion_sala_computo.Connection
{
    public class ConnectionDB
    {
        private static ConnectionDB _instance = null;
        private SQLiteConnection conn = null;

        //constructor
        private ConnectionDB()
        {
            string connString = ConfigurationManager.ConnectionStrings["SQLite"].ConnectionString;
            conn = new SQLiteConnection(connString);
        }

        public static ConnectionDB Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnectionDB();
                }
                return _instance;
            }
        }

        public SQLiteConnection GetConnection()
        {
            return conn;
        }

    }
}
