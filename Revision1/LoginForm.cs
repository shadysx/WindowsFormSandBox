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
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
            // Palette https://colorhunt.co/palette/241e925432d37b6cf6e5a5ff
            var color1 = Color.FromArgb(36, 30, 146);

            //Window Colors
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = color1;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = color1;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = color1;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = color1;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = color1;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = color1;
            this.BackColor = color1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (kryptonTextBox1.Text == "admin" && kryptonTextBox2.Text == "password")
            {
                success = true;
                MessageBox.Show("Welcome ");
                this.Close();
            }
            else
            {
                MessageBox.Show("Retry");
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            this.ActiveControl = label1;

            //login

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
