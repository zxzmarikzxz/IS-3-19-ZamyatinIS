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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.ShowDialog();
        }
    }
}
