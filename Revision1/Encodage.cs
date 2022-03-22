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
    public partial class Encodage : Form
    {
        //Change

        public Encodage()
        {
            InitializeComponent();
        }
        private void btAjouterSection_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.SEC sec = new DTO.SEC();
                sec.SEC_DES = this.textBox1.Text;
                sec.SEC_CDE = this.textBox2.Text;
                sec.SEC_CDE_DOM = this.textBox3.Text;
                sec.SEC_FK_TYP_ENS = Convert.ToInt32(this.textBox4.Text);
                BL.BL_SEC.Insert(sec);
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                MessageBox.Show("Ajouté avec succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
