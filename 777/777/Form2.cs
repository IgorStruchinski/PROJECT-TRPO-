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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form5 MyForm5 = new Form5();
            MyForm5.ShowDialog();
            Close();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form6 MyForm6 = new Form6();
            MyForm6.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form7 MyForm7 = new Form7();
            MyForm7.ShowDialog();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form8 MyForm8 = new Form8();
            MyForm8.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form9 MyForm9 = new Form9();
            MyForm9.ShowDialog();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
