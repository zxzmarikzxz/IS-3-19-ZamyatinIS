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
        abstract class Complect<T>
        {           
            private int price;
            private int yearofissue;
            T articul;

            public Complect(int pr,int year)
            {
                price = pr;
                yearofissue = year;
            }
            public virtual string Display()
            {
                return($"Цена {price} Год выпуска {yearofissue}");
            }
        }
        class CP<T>:Complect<T>
        {
            private int Chastota { get; set; }
            private int Yadra { get; set; }
            private int Potoki { get; set; }
            public CP(int pra,int years,int Chastot,int Yadr,int Potok):base(pra,years)
            {
                Chastota = Chastot;
                Yadra = Yadr;
                Potoki = Potok;
            }
            public override string Display()
            {
                return base.Display() + ($"Частота {Chastota} Кол-во ядер {Yadra} Кол-во потоков {Potoki}");
            }
        }
        class Videomap<T>:Complect<T>
        {
            private int GPU { get; set; }
            private string Proizvoditel { get; set; }
            private int Memory { get; set; }
            public Videomap(int prr, int yea,int GPu, string Proizvoditell, int Memor) : base(prr,yea)
            {
                GPU = GPu;
                Proizvoditel = Proizvoditell;
                Memory = Memor;
            }
            public override string Display()
            { 
                return ($"GPU {GPU} Производитель {Proizvoditel} Объём памяти {Memory}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CP<int> cp = new CP<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            listBox1.Items.Add(cp.Display());            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Videomap<int> vp = new Videomap<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox6.Text), textBox7.Text, Convert.ToInt32(textBox8.Text));
            listBox1.Items.Add(vp.Display());
        }
    }
}
