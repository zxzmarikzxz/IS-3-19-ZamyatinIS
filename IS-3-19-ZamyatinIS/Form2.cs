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
    public partial class Form2 : Form
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
                return conn;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   //Проверка подключения
            ConnBaza ConnBaza = new ConnBaza();
            try
            {
                ConnBaza.ConnBaz().Open();//Попытка открытия соединения
            }
            catch (Exception ex)//(Exception ex)-обработка всех исключений, которые могут возникнуть
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                MessageBox.Show("Подключение успешно");
                ConnBaza.ConnBaz().Close();//Закрытие соединения
            }
        }
    }
}
