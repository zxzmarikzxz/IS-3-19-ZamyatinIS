using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_3_19_ZamyatinIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class Complect
        {           
            private int price;
            private int yearofissue;
            public Complect(int pr,int year)
            {
                price = pr;
                yearofissue = year;
            }
            public string Display()
            {
                return($"Цена {price} Год выпуска {yearofissue}");
            }
        }
        class CP:Complect
        {
            private int Chastota;
            private int Yadra;
            private int Potoki;
            public CP(int pra,int years,int Chastot,int Yadr,int Potok):base(pra,years)
            {
                Chastota = Chastot;
                Yadra = Yadr;
                Potoki = Potok;
            }
            public string Display()
            {
                return ($"Частота {Chastota} Кол-во ядер {Yadra} Кол-во потоков {Potoki}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Complect price = new Complect(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            listBox1.Items.Add(price.Display());
            CP cp = new CP(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text),Convert.ToInt32(textBox5.Text));
            listBox1.Items.Add(cp.Display());
        }
    }
}
