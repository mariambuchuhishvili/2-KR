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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          int points = 0;
          if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true) { points = points + 1; }
          if (checkBox1.Checked == true) { checkBox1.ForeColor = Color.Green; }
          if (checkBox2.Checked == true) { checkBox2.ForeColor = Color.Green; }
          if (checkBox3.Checked == true) { checkBox3.ForeColor = Color.Green; }
          if (checkBox4.Checked == true) { checkBox4.ForeColor = Color.Red; }
            if (textBox1.Text == "АВГБДА") { points = points+1; textBox1.ForeColor = Color.Green;} else {textBox1.ForeColor=Color.Red;}
          label2.Text = "Количество баллов=" + Convert.ToString(points);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            Hide();
        }
    }
}
