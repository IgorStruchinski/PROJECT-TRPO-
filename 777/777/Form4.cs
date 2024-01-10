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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String UserName = "Igor";
            String Password = "1234";

            if (UserName ==textBox1.Text && Password== textBox2.Text) 
            {
                MessageBox.Show("Успешно");
                Form4.ActiveForm.Hide();
                Form1 MyForm1 = new Form1();
                MyForm1.ShowDialog();
                Close();
            }
            else

            {
                MessageBox.Show("Некоректные логин или пароль");
            }
        }
    }
}
