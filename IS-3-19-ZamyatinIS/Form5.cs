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
using Library74;

namespace IS_3_19_ZamyatinIS
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnBaza conbaza = new ConnBaza();         
            conbaza.ConnBaz().Open();
            {            
                string commandStr = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES (@fio_stud,@datestud)";
                using (MySqlCommand command = new MySqlCommand(commandStr, conbaza.ConnBaz()))
                try
                {                                              
                        command.Parameters.Add("@fio_stud", MySqlDbType.VarChar).Value = textBox1.Text;//берём значение из текстбокса и кидаем в базу данных
                        command.Parameters.Add("@datestud", MySqlDbType.DateTime).Value = dateTimePicker1.Text;//тоже самое только значение из датапикера
                        command.Connection.Open();
                        command.ExecuteNonQuery(); //Изменения данных в базе данных
                }
                catch (Exception ex)
                {
                        MessageBox.Show($"{ex}");
                }
                finally
                {
                        conbaza.ConnBaz().Close();
                }
            }
        }
    }
}
