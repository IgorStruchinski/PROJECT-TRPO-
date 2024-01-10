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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12.ActiveForm.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12.ActiveForm.Hide();
            Form8 MyForm8 = new Form8();
            MyForm8.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Password = "tangens";

            if (Password == textBox1.Text)
            {
                MessageBox.Show("Верно");

            }
            else

            {
                MessageBox.Show("Неверно");
            }
        }
    }
}
