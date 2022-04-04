using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DTO;

namespace Revision1
{
    public partial class DisplayProductsV2 : KryptonForm
    {
        public DisplayProductsV2()
        {
            InitializeComponent();

            //Initial product display (all)
            this.bindingSourcePRODUCT_JOIN_PICTURE.DataSource = DAL.DAL_PRODUCT_JOIN_PICTURE.SelectAll();

            //Compobox 1
            List<PRODUCT_JOIN_PICTURE> types = new List<PRODUCT_JOIN_PICTURE>();
            types = DAL.DAL_PRODUCT_JOIN_PICTURE.SelectAllUniqueProductTypes();
            types.Add(new PRODUCT_JOIN_PICTURE() { PRODUCT_TYPE = "All" });
            this.kryptonComboBox1.DataSource = types;
            this.kryptonComboBox1.DisplayMember = "PRODUCT_TYPE";
            this.kryptonComboBox1.ValueMember = "PRODUCT_TYPE";
            this.kryptonComboBox1.SelectedIndex = types.Count - 1;

            //Compobox 2
            this.kryptonComboBox2.DataSource = new List<String>() { "Dont Sort", "Name", "Type", "Price"};


        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        //Should be in BLL?
        private void UpdateProducts()
        {
            //No filter
            var result = DAL.DAL_PRODUCT_JOIN_PICTURE.SelectAll();

            if (kryptonTextBox1 != null && kryptonTextBox1.Text != "")
            {
                result = result.Where(x => x.PRODUCT_NAME.ToLower().Contains(kryptonTextBox1.Text.ToLower())).ToList();
            }

            if (kryptonComboBox1.SelectedValue.ToString() != "All")
            {
                result = result.Where(x => x.PRODUCT_TYPE.ToLower().Contains(kryptonComboBox1.SelectedValue.ToString().ToLower())).ToList();
            }

            if (kryptonComboBox2.SelectedValue.ToString() != "Dont Sort")
            {
                if (kryptonComboBox2.SelectedValue.ToString() == "Name")
                    result = result.OrderBy(x => x.PRODUCT_NAME).ToList();

                if (kryptonComboBox2.SelectedValue.ToString() == "Type")
                    result = result.OrderBy(x => x.PRODUCT_TYPE).ToList();

                //if (kryptonComboBox2.SelectedValue.ToString() == "Price")
                    //result = result.OrderBy(x => x.PRODUCT_TYPE).ToList();


            }

            this.bindingSourcePRODUCT_JOIN_PICTURE.DataSource = result;
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.kryptonDataGridView1.Columns[e.ColumnIndex].Name == "DeleteColumn")
            {
                if (MessageBox.Show("Add to cart?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Successfully added {this.kryptonDataGridView1.Rows[e.RowIndex].Cells[1].Value} to your cart");
            }
        }
    }
}
