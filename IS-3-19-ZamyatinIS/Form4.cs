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
using Library74;//Добавление библиотеки классов


namespace IS_3_19_ZamyatinIS
{
    public partial class Form4 : Form
    {
        private BindingSource bSource = new BindingSource(); //Унифицированный доступ к источнику данных          
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter(); //Получение данных из источника  
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                ConnBaza conbaza = new ConnBaza();
                try
                {
                    conbaza.ConnBaz().Open();
                    string commandStr = "SELECT idStud AS 'ID', fioStud AS 'ФИО', drStud AS 'Дата рождения' FROM t_datetime";//Запрос к базе данных(взять idstud,fioStud и drStud из таблицы t_datetime)
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
            DateTime DT = new DateTime();
            DT = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            MessageBox.Show(DateTime.Today.Subtract(DT.Date).Days.ToString() + " дней с момента рождения.");
        }
    }
}
