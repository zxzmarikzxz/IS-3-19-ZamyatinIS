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
       
        private BindingSource bSource = new BindingSource(); //Унифицированный доступ к источнику данных          
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter(); //Получение данных из источника  
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
                ConnBaza conbaza = new ConnBaza();
                try
                {
                    conbaza.ConnBaz().Open();
                    string commandStr = "SELECT id AS 'ID', fio AS 'ФИО', theme_kurs AS 'Тема' FROM t_stud";//Запрос к базе данных(взять id,fio и theme_kurs из таблицы t_stud)
                    MySqlDataAdapter adapter = new MySqlDataAdapter(commandStr, conbaza.ConnBaz());
                    DataTable dTable = new DataTable();
                    adapter.Fill(dTable);
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < dTable.Rows.Count; i++)//Добавление строк пока i не станет больше или равно количеству строк таблицы(dTable.Rows.Count количество строк таблицы)
                    {
                        dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                    }
                }
                catch (Exception ex)//Обработка исключений
                {
                    MessageBox.Show($"{ex}");
                }
                finally
                {
                    MessageBox.Show("Подключение успешно");
                    conbaza.ConnBaz().Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());//Вывод ФИО в MessageBox

        }
    }
}
