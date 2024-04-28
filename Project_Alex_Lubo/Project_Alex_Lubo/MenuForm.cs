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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        label1Form label1form;
        label2form label2form;
        label3form label3form;
        private void label1_Click(object sender, EventArgs e)
        {
             if(label1form == null)
            {
                label1form = new label1Form();
                label1form.FormClosed += Label1Form_FormClosed;
                label1form.MdiParent = this;
                label1form.Show();
            }
            else
            {
                label1form.Activate();
            }
        }

        private void Label1Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            label1form = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2form == null)
            {
                label2form = new label2form();
                label2form.FormClosed += Label2Form_FormClosed;
                label2form.MdiParent = this;
                label2form.Dock = DockStyle.Fill;
                label2form.Show();
            }
            else
            {
                label2form.Activate();
            }
        }
        private void Label2Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            label2form = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

            if (label3form == null)
            {
                label3form = new label3form();
                label3form.FormClosed += Label3Form_FormClosed;
                label3form.MdiParent = this;
                label3form.Dock = DockStyle.Fill;
                label3form.Show();
            }
            else
            {
                label3form.Activate();
            }
        }
        private void Label3Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            label3form = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
                
        }
    }
}
