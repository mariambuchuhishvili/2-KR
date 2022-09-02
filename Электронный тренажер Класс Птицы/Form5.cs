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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            if ((textBox1.Text == "В") && (textBox2.Text == "А") && (textBox3.Text == "Б") && (textBox4.Text == "Г")) { points = points + 1;}
            if (textBox1.Text == "В") {textBox1.ForeColor = Color.Green;} else {textBox1.ForeColor = Color.Red;} 
            if (textBox2.Text == "А") {textBox2.ForeColor = Color.Green;} else {textBox2.ForeColor = Color.Red;}
            if (textBox3.Text == "Б") {textBox3.ForeColor = Color.Green;} else {textBox3.ForeColor = Color.Red;} 
            if (textBox4.Text == "Г") {textBox4.ForeColor = Color.Green;} else {textBox4.ForeColor = Color.Red;}

            if ((checkBox2.Checked == true) && (checkBox3.Checked == true) && (checkBox6.Checked == true)) { points = points + 1;}
            if (checkBox2.Checked == true) {checkBox2.ForeColor = Color.Green;}
            if (checkBox3.Checked == true) {checkBox3.ForeColor = Color.Green;}
            if (checkBox6.Checked == true) {checkBox6.ForeColor = Color.Green;}
            if (checkBox1.Checked == true) { checkBox1.ForeColor = Color.Red;}
            if (checkBox4.Checked == true) { checkBox4.ForeColor = Color.Red;}
            if (checkBox5.Checked == true) { checkBox5.ForeColor = Color.Red;}

            if (radioButton2.Checked == true) { points = points + 1; radioButton2.ForeColor = Color.Green; }
            if (radioButton1.Checked == true) { radioButton1.ForeColor = Color.Red; }
            if (radioButton3.Checked == true) { radioButton3.ForeColor = Color.Red; }
            if (radioButton4.Checked == true) { radioButton4.ForeColor = Color.Red; }

            if (textBox5.Text == "ВЕЖМ") { points = points + 1; textBox5.ForeColor = Color.Green; } else { textBox5.ForeColor = Color.Red; }

            label2.Text = "Количество баллов=" + Convert.ToString(points);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            Hide();
        }
    }
}
