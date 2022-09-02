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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;

            if (checkBox1.Checked == true && checkBox5.Checked == true) { points = points + 1; }
            if (checkBox1.Checked == true){ checkBox1.ForeColor=Color.Green;}
            if (checkBox2.Checked){checkBox2.ForeColor=Color.Red;}
            if (checkBox5.Checked == true){checkBox5.ForeColor=Color.Green;}

            if (radioButton1.Checked==true){radioButton1.ForeColor=Color.Red;}
            if (radioButton2.Checked==true){radioButton2.ForeColor=Color.Red;}
            if (radioButton3.Checked == true) { points = points + 1; radioButton3.ForeColor = Color.Green; }
            
            label2.Text = "Количество баллов=" + Convert.ToString(points);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
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
            Form19 Form19 = new Form19();
            Form19.Show();
            Hide();
        }
    }
}
