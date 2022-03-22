namespace Revision1
{
    partial class Sections
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSectionsLeft = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSectionsRight = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tYPENSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPENSDESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceTYPE_ENS = new System.Windows.Forms.BindingSource(this.components);
            this.sECIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECDESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECCDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECCDEDOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECFKTYPENSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSEC = new System.Windows.Forms.BindingSource(this.components);
            this.panelSectionsLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSectionsRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTYPE_ENS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSEC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSectionsLeft
            // 
            this.panelSectionsLeft.BackColor = System.Drawing.Color.Indigo;
            this.panelSectionsLeft.Controls.Add(this.dataGridView1);
            this.panelSectionsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSectionsLeft.Location = new System.Drawing.Point(0, 0);
            this.panelSectionsLeft.Name = "panelSectionsLeft";
            this.panelSectionsLeft.Size = new System.Drawing.Size(675, 813);
            this.panelSectionsLeft.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sECIDDataGridViewTextBoxColumn,
            this.sECDESDataGridViewTextBoxColumn,
            this.sECCDEDataGridViewTextBoxColumn,
            this.sECCDEDOMDataGridViewTextBoxColumn,
            this.sECFKTYPENSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceSEC;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(675, 813);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelSectionsRight
            // 
            this.panelSectionsRight.BackColor = System.Drawing.Color.MediumPurple;
            this.panelSectionsRight.Controls.Add(this.dataGridView2);
            this.panelSectionsRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSectionsRight.Location = new System.Drawing.Point(675, 0);
            this.panelSectionsRight.Name = "panelSectionsRight";
            this.panelSectionsRight.Size = new System.Drawing.Size(708, 813);
            this.panelSectionsRight.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tYPENSIDDataGridViewTextBoxColumn,
            this.tYPENSDESDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSourceTYPE_ENS;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.Size = new System.Drawing.Size(708, 813);
            this.dataGridView2.TabIndex = 0;
            // 
            // tYPENSIDDataGridViewTextBoxColumn
            // 
            this.tYPENSIDDataGridViewTextBoxColumn.DataPropertyName = "TYP_ENS_ID";
            this.tYPENSIDDataGridViewTextBoxColumn.FillWeight = 30.07519F;
            this.tYPENSIDDataGridViewTextBoxColumn.HeaderText = "TYP_ENS_ID";
            this.tYPENSIDDataGridViewTextBoxColumn.Name = "tYPENSIDDataGridViewTextBoxColumn";
            // 
            // tYPENSDESDataGridViewTextBoxColumn
            // 
            this.tYPENSDESDataGridViewTextBoxColumn.DataPropertyName = "TYP_ENS_DES";
            this.tYPENSDESDataGridViewTextBoxColumn.FillWeight = 169.9248F;
            this.tYPENSDESDataGridViewTextBoxColumn.HeaderText = "TYP_ENS_DES";
            this.tYPENSDESDataGridViewTextBoxColumn.Name = "tYPENSDESDataGridViewTextBoxColumn";
            // 
            // bindingSourceTYPE_ENS
            // 
            this.bindingSourceTYPE_ENS.DataSource = typeof(DTO.TYP_ENS);
            // 
            // sECIDDataGridViewTextBoxColumn
            // 
            this.sECIDDataGridViewTextBoxColumn.DataPropertyName = "SEC_ID";
            this.sECIDDataGridViewTextBoxColumn.FillWeight = 67.56472F;
            this.sECIDDataGridViewTextBoxColumn.HeaderText = "SEC_ID";
            this.sECIDDataGridViewTextBoxColumn.Name = "sECIDDataGridViewTextBoxColumn";
            // 
            // sECDESDataGridViewTextBoxColumn
            // 
            this.sECDESDataGridViewTextBoxColumn.DataPropertyName = "SEC_DES";
            this.sECDESDataGridViewTextBoxColumn.FillWeight = 158.2278F;
            this.sECDESDataGridViewTextBoxColumn.HeaderText = "SEC_DES";
            this.sECDESDataGridViewTextBoxColumn.Name = "sECDESDataGridViewTextBoxColumn";
            // 
            // sECCDEDataGridViewTextBoxColumn
            // 
            this.sECCDEDataGridViewTextBoxColumn.DataPropertyName = "SEC_CDE";
            this.sECCDEDataGridViewTextBoxColumn.FillWeight = 67.56472F;
            this.sECCDEDataGridViewTextBoxColumn.HeaderText = "SEC_CDE";
            this.sECCDEDataGridViewTextBoxColumn.Name = "sECCDEDataGridViewTextBoxColumn";
            // 
            // sECCDEDOMDataGridViewTextBoxColumn
            // 
            this.sECCDEDOMDataGridViewTextBoxColumn.DataPropertyName = "SEC_CDE_DOM";
            this.sECCDEDOMDataGridViewTextBoxColumn.FillWeight = 67.56472F;
            this.sECCDEDOMDataGridViewTextBoxColumn.HeaderText = "SEC_CDE_DOM";
            this.sECCDEDOMDataGridViewTextBoxColumn.Name = "sECCDEDOMDataGridViewTextBoxColumn";
            // 
            // sECFKTYPENSDataGridViewTextBoxColumn
            // 
            this.sECFKTYPENSDataGridViewTextBoxColumn.DataPropertyName = "SEC_FK_TYP_ENS";
            this.sECFKTYPENSDataGridViewTextBoxColumn.FillWeight = 139.078F;
            this.sECFKTYPENSDataGridViewTextBoxColumn.HeaderText = "SEC_FK_TYP_ENS";
            this.sECFKTYPENSDataGridViewTextBoxColumn.Name = "sECFKTYPENSDataGridViewTextBoxColumn";
            // 
            // bindingSourceSEC
            // 
            this.bindingSourceSEC.DataSource = typeof(DTO.SEC);
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1383, 813);
            this.Controls.Add(this.panelSectionsRight);
            this.Controls.Add(this.panelSectionsLeft);
            this.Name = "Sections";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Sections_Load);
            this.Resize += new System.EventHandler(this.Sections_Resize);
            this.panelSectionsLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSectionsRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTYPE_ENS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSEC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSectionsLeft;
        private System.Windows.Forms.Panel panelSectionsRight;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceSEC;
        private System.Windows.Forms.BindingSource bindingSourceTYPE_ENS;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECDESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECCDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECCDEDOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECFKTYPENSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPENSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPENSDESDataGridViewTextBoxColumn;
    }
}