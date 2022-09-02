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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 Form15 = new Form15();
            Form15.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (comboBox1.Text == "Условия обитания") { points = points + 1; comboBox1.ForeColor = Color.Green; } else { comboBox1.ForeColor = Color.Red; }

            if (comboBox2.Text == "Отряд соколообразных") { points = points + 1; comboBox2.ForeColor = Color.Green; } else { comboBox2.ForeColor = Color.Red; }
             
            label2.Text = "Количество баллов=" + Convert.ToString(points);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
