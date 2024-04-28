using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alex_Lubo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Admin" && textBox2.Text == "Password")
            {
                MenuForm menuform = new MenuForm();
                menuform.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Въвелисте грешни данни! Моля пробвайте пак.");
            }
        }
    }
}
