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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;

            if ((comboBox1.Text == "Нервная")&& (comboBox2.Text == "Кровеносная")&& (comboBox3.Text == "Пищеварительная")&&(comboBox4.Text == "Выделительная")) { points = points + 1;}
            if (comboBox1.Text == "Нервная"){comboBox1.ForeColor = Color.Green;}
            if (comboBox2.Text == "Кровеносная") { comboBox2.ForeColor = Color.Green;}
            if (comboBox3.Text == "Пищеварительная") {comboBox3.ForeColor = Color.Green;}
            if (comboBox4.Text == "Выделительная") {comboBox4.ForeColor = Color.Green; }

            if ((comboBox1.Text == "Кровеносная") || (comboBox1.Text == "Пищеварительная") || (comboBox1.Text == "Выделительная")) { comboBox1.ForeColor = Color.Red; }
            if ((comboBox2.Text == "Нервная") || (comboBox2.Text == "Пищеварительная") || (comboBox2.Text == "Выделительная")) { comboBox2.ForeColor = Color.Red; }
            if ((comboBox3.Text == "Нервная") || (comboBox3.Text == "Кровеносная") || (comboBox3.Text == "Выделительная")) { comboBox3.ForeColor = Color.Red; }
            if ((comboBox4.Text == "Нервная") || (comboBox4.Text == "Кровеносная") || (comboBox4.Text == "Пищеварительная")) { comboBox4.ForeColor = Color.Red; } 
 

            if ((textBox2.Text == "АГ") && (textBox1.Text == "ВБ")) { points = points + 1;}
            if (textBox2.Text == "АГ") { textBox1.ForeColor = Color.Green; } else { textBox1.ForeColor = Color.Red; }
            if (textBox1.Text == "ВБ") {textBox2.ForeColor = Color.Green; } else { textBox2.ForeColor = Color.Red; }
           
            if (radioButton4.Checked==true) {points=points+1; radioButton4.ForeColor=Color.Green;}
            if (radioButton1.Checked == true) { radioButton1.ForeColor = Color.Red; }
            if (radioButton2.Checked == true) { radioButton2.ForeColor = Color.Red; }
            if (radioButton3.Checked == true) { radioButton3.ForeColor = Color.Red; }

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
            Hide();
            Form6 Form6 = new Form6();
            Form6.Show();
        }
    }
}
