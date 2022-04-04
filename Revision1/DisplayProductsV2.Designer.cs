namespace Revision1
{
    partial class DisplayProductsV2
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
            this.labelSearchByName = new System.Windows.Forms.Label();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.PRODUCT_DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.labelSearchByType = new System.Windows.Forms.Label();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.kryptonComboBox2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePRODUCT_JOIN_PICTURE = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTJOINPICTUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSearch)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePRODUCT_JOIN_PICTURE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTJOINPICTUREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchByName
            // 
            this.labelSearchByName.AutoSize = true;
            this.labelSearchByName.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchByName.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchByName.Location = new System.Drawing.Point(13, 12);
            this.labelSearchByName.Name = "labelSearchByName";
            this.labelSearchByName.Size = new System.Drawing.Size(105, 34);
            this.labelSearchByName.TabIndex = 2;
            this.labelSearchByName.Text = "By Name:";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.ColumnHeadersVisible = false;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pictureDataGridViewImageColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.pRODUCTTYPEDataGridViewTextBoxColumn,
            this.PRODUCT_DESCRIPTION,
            this.DeleteColumn});
            this.kryptonDataGridView1.DataSource = this.bindingSourcePRODUCT_JOIN_PICTURE;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.HideOuterBorders = true;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.RowTemplate.Height = 100;
            this.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1119, 746);
            this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonDataGridView1.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.TabIndex = 20;
            this.kryptonDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellContentClick);
            // 
            // PRODUCT_DESCRIPTION
            // 
            this.PRODUCT_DESCRIPTION.DataPropertyName = "PRODUCT_DESCRIPTION";
            this.PRODUCT_DESCRIPTION.HeaderText = "PRODUCT_DESCRIPTION";
            this.PRODUCT_DESCRIPTION.Name = "PRODUCT_DESCRIPTION";
            this.PRODUCT_DESCRIPTION.Width = 600;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.FillWeight = 50F;
            this.DeleteColumn.HeaderText = "DeleteColumn";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Text = "Add To Cart";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelLeft.Controls.Add(this.panelSearch);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(309, 746);
            this.panelLeft.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.kryptonComboBox2);
            this.panelSearch.Controls.Add(this.labelSortBy);
            this.panelSearch.Controls.Add(this.kryptonComboBox1);
            this.panelSearch.Controls.Add(this.labelSearchByType);
            this.panelSearch.Controls.Add(this.kryptonButton2);
            this.panelSearch.Controls.Add(this.labelSearchByName);
            this.panelSearch.Controls.Add(this.kryptonTextBox1);
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            this.panelSearch.Size = new System.Drawing.Size(300, 213);
            this.panelSearch.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelSearch.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelSearch.TabIndex = 4;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 132;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "Tous"});
            this.kryptonComboBox1.Location = new System.Drawing.Point(134, 61);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(140, 33);
            this.kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 12;
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonComboBox1.TabIndex = 7;
            // 
            // labelSearchByType
            // 
            this.labelSearchByType.AutoSize = true;
            this.labelSearchByType.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchByType.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchByType.Location = new System.Drawing.Point(13, 61);
            this.labelSearchByType.Name = "labelSearchByType";
            this.labelSearchByType.Size = new System.Drawing.Size(93, 34);
            this.labelSearchByType.TabIndex = 6;
            this.labelSearchByType.Text = "By Type:";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonButton2.Location = new System.Drawing.Point(0, 164);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(300, 49);
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 12;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 4;
            this.kryptonButton2.Values.Text = "Search";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(134, 12);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(140, 31);
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 12;
            this.kryptonTextBox1.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Location = new System.Drawing.Point(309, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 746);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Fuchsia;
            this.panelRight.Controls.Add(this.kryptonDataGridView1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(310, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1119, 746);
            this.panelRight.TabIndex = 6;
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.BackColor = System.Drawing.Color.Transparent;
            this.labelSortBy.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortBy.Location = new System.Drawing.Point(13, 108);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(147, 34);
            this.labelSortBy.TabIndex = 8;
            this.labelSortBy.Text = "Sort Result By:";
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox2.DropDownWidth = 132;
            this.kryptonComboBox2.Items.AddRange(new object[] {
            "Tous"});
            this.kryptonComboBox2.Location = new System.Drawing.Point(156, 109);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.Size = new System.Drawing.Size(118, 33);
            this.kryptonComboBox2.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox2.StateCommon.ComboBox.Border.Rounding = 12;
            this.kryptonComboBox2.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox2.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonComboBox2.TabIndex = 9;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Width = 200;
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
            // bindingSourcePRODUCT_JOIN_PICTURE
            // 
            this.bindingSourcePRODUCT_JOIN_PICTURE.DataSource = typeof(DTO.PRODUCT_JOIN_PICTURE);
            // 
            // pRODUCTJOINPICTUREBindingSource
            // 
            this.pRODUCTJOINPICTUREBindingSource.DataSource = typeof(DTO.PRODUCT_JOIN_PICTURE);
            // 
            // DisplayProductsV2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1429, 746);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft);
            this.Name = "DisplayProductsV2";
            this.Text = "DisplayProductsV2";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelSearch)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePRODUCT_JOIN_PICTURE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTJOINPICTUREBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pRODUCTJOINPICTUREBindingSource;
        private System.Windows.Forms.Label labelSearchByName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelRight;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.Label labelSearchByType;
        private System.Windows.Forms.BindingSource bindingSourcePRODUCT_JOIN_PICTURE;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_DESCRIPTION;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn DeleteColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private System.Windows.Forms.Label labelSortBy;
    }
}