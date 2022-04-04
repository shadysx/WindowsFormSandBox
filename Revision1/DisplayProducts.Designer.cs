namespace Revision1
{
    partial class DisplayProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.iDPRODUCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pICTUREURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTJOINPICTUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTJOINPICTUREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Picture,
            this.iDPRODUCTDataGridViewTextBoxColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.pRODUCTTYPEDataGridViewTextBoxColumn,
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn,
            this.pICTUREURLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTJOINPICTUREBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 200;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Picture.MinimumWidth = 600;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Picture.Width = 600;
            // 
            // iDPRODUCTDataGridViewTextBoxColumn
            // 
            this.iDPRODUCTDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUCT";
            this.iDPRODUCTDataGridViewTextBoxColumn.HeaderText = "ID_PRODUCT";
            this.iDPRODUCTDataGridViewTextBoxColumn.Name = "iDPRODUCTDataGridViewTextBoxColumn";
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            // 
            // pRODUCTTYPEDataGridViewTextBoxColumn
            // 
            this.pRODUCTTYPEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_TYPE";
            this.pRODUCTTYPEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_TYPE";
            this.pRODUCTTYPEDataGridViewTextBoxColumn.Name = "pRODUCTTYPEDataGridViewTextBoxColumn";
            // 
            // pRODUCTDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_DESCRIPTION";
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "PRODUCT_DESCRIPTION";
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.Name = "pRODUCTDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // pICTUREURLDataGridViewTextBoxColumn
            // 
            this.pICTUREURLDataGridViewTextBoxColumn.DataPropertyName = "PICTURE_URL";
            this.pICTUREURLDataGridViewTextBoxColumn.HeaderText = "PICTURE_URL";
            this.pICTUREURLDataGridViewTextBoxColumn.Name = "pICTUREURLDataGridViewTextBoxColumn";
            // 
            // pRODUCTJOINPICTUREBindingSource
            // 
            this.pRODUCTJOINPICTUREBindingSource.DataSource = typeof(DTO.PRODUCT_JOIN_PICTURE);
            // 
            // DisplayProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DisplayProducts";
            this.Text = "Products Display";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DisplayProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTJOINPICTUREBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pRODUCTJOINPICTUREBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pICTUREURLDataGridViewTextBoxColumn;
    }
}