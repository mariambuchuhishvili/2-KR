using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Электронный_тренажер_Класс_Птицы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();//открыть 2 форму
            Hide();// скрыть эту форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 Form4 = new Form4();
            Form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 Form6 = new Form6();
            Form6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 Form11 = new Form11();
            Form11.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 Form13 = new Form13();
            Form13.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form15 Form15 = new Form15();
            Form15.Show();
            Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form17 Form17 = new Form17();
            Form17.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form19 Form19 = new Form19();
            Form19.Show();
            Hide();
        }
    }
}
