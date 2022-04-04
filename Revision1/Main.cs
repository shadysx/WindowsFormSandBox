using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace Revision1
{
    public partial class Main : KryptonForm
    {
        bool admin = true;   

        private Form activeChildForm;
        public Main()
        {
            InitializeComponent();
            CheckIfAdmin();
        }

        private void OpenChildForm(Form childForm, Button btnSender)
        {
            this.activeChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButtonShop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DisplayProductsV2(), (Button)sender);
        }
        private void CheckIfAdmin()
        {
            if (admin == true)
            {
                iconButtonAdminPanel.Visible = true;
            }
            else
            {
                iconButtonAdminPanel.Visible = false;
            }
        }
    }
}
