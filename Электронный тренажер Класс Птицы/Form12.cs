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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (textBox1.Text == "ВГБДА") { points = points + 1; textBox1.ForeColor = Color.Green; } else { textBox1.ForeColor = Color.Red; }
            if (comboBox1.Text == "Верно только Б") { points = points + 1; comboBox1.ForeColor = Color.Green; } else { comboBox1.ForeColor = Color.Red; }

            label2.Text = "Количество баллов=" + Convert.ToString(points);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 Form11 = new Form11();
            Form11.Show();
            Hide();
        }
    }
}
