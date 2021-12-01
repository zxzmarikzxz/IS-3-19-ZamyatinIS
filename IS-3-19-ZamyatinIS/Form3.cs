using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_3_19_ZamyatinIS
{
    public partial class Form3 : Form
    {
        class ConnBaza
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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
