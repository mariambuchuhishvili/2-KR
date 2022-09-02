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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;

            if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked = true)) { points = points + 1;}
            if (checkBox1.Checked == true) { checkBox1.ForeColor = Color.Green; }
            if (checkBox2.Checked == true) { checkBox2.ForeColor = Color.Green; }
            if (checkBox3.Checked == true) { checkBox3.ForeColor = Color.Green; }
            if (checkBox5.Checked == true) { checkBox5.ForeColor = Color.Red; }

            if (comboBox1.Text == "Верно только А") { points = points + 1; comboBox1.ForeColor = Color.Green; } else { comboBox1.ForeColor = Color.Red; }
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
            Form13 Form13 = new Form13();
            Form13.Show();
            Hide();
        }
    }
}
