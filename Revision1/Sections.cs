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
    public partial class Sections : Form
    {
        public Sections()
        {
            InitializeComponent();

        }

        


        private void Sections_Load(object sender, EventArgs e)
        {
            //Style
                //Take 50% of width on resize
            panelSectionsLeft.Dock = DockStyle.Left;
            panelSectionsRight.Dock = DockStyle.Right;
            this.panelSectionsLeft.Width = Convert.ToInt32(this.Width * 0.5);
            this.panelSectionsRight.Width = Convert.ToInt32(this.Width * 0.5);

            //DataGridView
            this.bindingSourceSEC.DataSource = BL.BL_SEC.SelectAll();
            this.bindingSourceTYPE_ENS.DataSource = BL.BL_TYP_ENS.SelectAll();
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            /*dataGridView1.ColumnHeadersVisible = false;*/
        }

        private void Sections_Resize(object sender, EventArgs e)
        {
            this.panelSectionsLeft.Width = Convert.ToInt32(this.Width * 0.5);
            this.panelSectionsRight.Width = Convert.ToInt32(this.Width * 0.5);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
