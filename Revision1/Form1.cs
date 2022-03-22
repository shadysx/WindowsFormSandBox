using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision1
{
    public partial class Form1 : Form
    {
        private Form activeChildForm;
        public Form1()
        {
            InitializeComponent();
            this.activeChildForm = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = BL.BL_SEC.SelectAll();
        }

        private void OpenChildForm(Form childForm, Button btnSender)
        {
            this.activeChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonEtudiants_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Encodage(), (Button)sender);
        }

        private void iconButtonSections_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sections(), (Button)sender);
        }

        private void iconButtonSandBox_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sandbox(), (Button)sender);
        }
    }
}
