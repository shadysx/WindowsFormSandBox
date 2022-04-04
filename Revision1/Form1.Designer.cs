namespace Revision1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonSandBox = new FontAwesome.Sharp.IconButton();
            this.iconButtonSections = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButtonEtudiants = new FontAwesome.Sharp.IconButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.iconButtonSandBox);
            this.panel1.Controls.Add(this.iconButtonSections);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButtonEtudiants);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 798);
            this.panel1.TabIndex = 0;
            // 
            // iconButtonSandBox
            // 
            this.iconButtonSandBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSandBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSandBox.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.iconButtonSandBox.IconColor = System.Drawing.Color.Black;
            this.iconButtonSandBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSandBox.IconSize = 36;
            this.iconButtonSandBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSandBox.Location = new System.Drawing.Point(0, 104);
            this.iconButtonSandBox.Name = "iconButtonSandBox";
            this.iconButtonSandBox.Size = new System.Drawing.Size(212, 52);
            this.iconButtonSandBox.TabIndex = 3;
            this.iconButtonSandBox.Text = "SandBox";
            this.iconButtonSandBox.UseVisualStyleBackColor = true;
            this.iconButtonSandBox.Click += new System.EventHandler(this.iconButtonSandBox_Click);
            // 
            // iconButtonSections
            // 
            this.iconButtonSections.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSections.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconButtonSections.IconColor = System.Drawing.Color.Black;
            this.iconButtonSections.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSections.IconSize = 36;
            this.iconButtonSections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSections.Location = new System.Drawing.Point(0, 52);
            this.iconButtonSections.Name = "iconButtonSections";
            this.iconButtonSections.Size = new System.Drawing.Size(212, 52);
            this.iconButtonSections.TabIndex = 2;
            this.iconButtonSections.Text = "Sections";
            this.iconButtonSections.UseVisualStyleBackColor = true;
            this.iconButtonSections.Click += new System.EventHandler(this.iconButtonSections_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 36;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 746);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(212, 52);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Quitter";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButtonEtudiants
            // 
            this.iconButtonEtudiants.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonEtudiants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEtudiants.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButtonEtudiants.IconColor = System.Drawing.Color.Black;
            this.iconButtonEtudiants.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEtudiants.IconSize = 36;
            this.iconButtonEtudiants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEtudiants.Location = new System.Drawing.Point(0, 0);
            this.iconButtonEtudiants.Name = "iconButtonEtudiants";
            this.iconButtonEtudiants.Size = new System.Drawing.Size(212, 52);
            this.iconButtonEtudiants.TabIndex = 0;
            this.iconButtonEtudiants.Text = "Encodage";
            this.iconButtonEtudiants.UseVisualStyleBackColor = true;
            this.iconButtonEtudiants.Click += new System.EventHandler(this.iconButtonEtudiants_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DTO.SEC);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 798);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 798);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButtonEtudiants;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonSections;
        private FontAwesome.Sharp.IconButton iconButtonSandBox;
    }
}

