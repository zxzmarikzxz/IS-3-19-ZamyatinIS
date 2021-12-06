using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_3_19_ZamyatinIS
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }     
    }
    public class ConnBaza
    {
        public MySqlConnection ConnBaz()
        {
            //Создание строки подключения
            string port = "33333";
            string host = "caseum.ru";
            string user = "test_user";
            string password = "test_pass";
            string db = "db_test";
            string connStr = $"server={host};port={port};user={user};database={db};password={password};";
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn; //Возврат строки подключения
        }
    }
}
