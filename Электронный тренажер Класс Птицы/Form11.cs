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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 Form12 = new Form12();
            Form12.Show();
            Hide();
        }
    }
}
