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
        {   //Объявляем поля       
            private int price;
            private int yearofissue;
            T articul; //Обобщённый тип

            public Complect(int pr,int year,T art)//Инициализация через конструктор
            {
                price = pr;
                yearofissue = year;
                articul = art;
            }
            public virtual string Display() //Метод вывода информации
            {
                return($"Цена {price} Год выпуска {yearofissue} Артикул {articul}");
            }
        }
        class CP<T>:Complect<T> //Наследование обобщённого класса
        {
            private int Chastota { get; set; } //Закрываем поля свойствами
            private int Yadra { get; set; }
            private int Potoki { get; set; }
            public CP(int pra,int years,T artic,int Chastot,int Yadr,int Potok):base(pra,years,artic)
            {
                Chastota = Chastot;
                Yadra = Yadr;
                Potoki = Potok;
            }
            public override string Display()//Переопределяем метод
            {
                return base.Display() + ($"Частота {Chastota} Кол-во ядер {Yadra} Кол-во потоков {Potoki}");
            }
        }
        class Videomap<T>:Complect<T>
        {
            private int GPU { get; set; }
            private string Proizvoditel { get; set; }
            private int Memory { get; set; }
            public Videomap(int prr, int yea, T articc,int GPu, string Proizvoditell, int Memor) : base(prr,yea,articc)
            {
                GPU = GPu;
                Proizvoditel = Proizvoditell;
                Memory = Memor;
            }
            public override string Display()
            {
                return base.Display()+ ($"GPU {GPU} Производитель {Proizvoditel} Объём памяти {Memory}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CP<int> cp = new CP<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox9.Text) ,Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            listBox1.Items.Add(cp.Display());//Добавляем данные в listbox            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Videomap<int> vp = new Videomap<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox6.Text), textBox7.Text, Convert.ToInt32(textBox8.Text));
            listBox1.Items.Add(vp.Display());
        }
    }
}
