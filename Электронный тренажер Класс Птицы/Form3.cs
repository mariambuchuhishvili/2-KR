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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();// скрыть эту форму
            Form1 Form1 = new Form1();
            Form1.Show(); // показать форму 1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0; // переменная для подсчета баллов
            string answer1 = "крылья"; // строковые переменные хранящие ответ на 3 вопрос
            string answer2 = "Крылья";
            // проверка ответов 
            //если ответы правильные то они окрашиваются в зеленный
            if (checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox6.Checked == true) { points = points + 1;}
            if (checkBox1.Checked == true) {checkBox1.ForeColor = Color.Green;}
            if (checkBox3.Checked == true) {checkBox3.ForeColor = Color.Green;}
            if (checkBox4.Checked == true) {checkBox4.ForeColor = Color.Green;}
            if (checkBox6.Checked == true) {checkBox6.ForeColor = Color.Green;}
            if (checkBox2.Checked == true) { checkBox2.ForeColor = Color.Red; }
            if (checkBox5.Checked == true) { checkBox4.ForeColor = Color.Red; }
            
            if (radioButton1.Checked == true) { points = points + 1; radioButton1.ForeColor = Color.Green; }
            if (radioButton2.Checked == true) { radioButton2.ForeColor = Color.Red; }
            if (radioButton3.Checked == true) { radioButton3.ForeColor = Color.Red; }

            if (textBox1.Text == answer1 || textBox1.Text == answer2) { points = points + 1; textBox1.ForeColor = Color.Green; }  else { textBox1.ForeColor = Color.Red; }
            
           // вывод баллов в Label
            label2.Text = "Количество баллов=" + Convert.ToString(points);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();// скрыть эту форму
            Form2 Form2 = new Form2();
            Form2.Show(); // показать форму 2
        }
    }
}
