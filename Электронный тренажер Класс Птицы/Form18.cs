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
    public partial class Form18 : Form
    {
        public Form18()
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
            Form17 Form17 = new Form17();
            Form17.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;

            if (radioButton4.Checked == true) { points = points + 1; radioButton4.ForeColor = Color.Green; }

            if (radioButton1.Checked == true) {  radioButton1.ForeColor = Color.Red; }
            if (radioButton2.Checked == true) { radioButton2.ForeColor = Color.Red; }
            if (radioButton3.Checked == true) { radioButton3.ForeColor = Color.Red; }
            

            label2.Text = "Количество баллов=" + Convert.ToString(points);
        }
    }
}
