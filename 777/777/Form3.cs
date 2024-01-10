using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _777
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form10 MyForm10 = new Form10();
            MyForm10.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form11 MyForm11 = new Form11();
            MyForm11.ShowDialog();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form12 MyForm12 = new Form12();
            MyForm12.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form13 MyForm13 = new Form13();
            MyForm13.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
