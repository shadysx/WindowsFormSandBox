namespace Revision1
{
    partial class Main
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
            this.panelTabs = new System.Windows.Forms.Panel();
            this.iconButtonShop = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdminPanel = new FontAwesome.Sharp.IconButton();
            this.panelTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTabs.Controls.Add(this.iconButtonAdminPanel);
            this.panelTabs.Controls.Add(this.iconButtonShop);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabs.Location = new System.Drawing.Point(0, 0);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(200, 861);
            this.panelTabs.TabIndex = 0;
            // 
            // iconButtonShop
            // 
            this.iconButtonShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonShop.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonShop.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonShop.IconColor = System.Drawing.Color.Black;
            this.iconButtonShop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonShop.Location = new System.Drawing.Point(0, 0);
            this.iconButtonShop.Name = "iconButtonShop";
            this.iconButtonShop.Size = new System.Drawing.Size(200, 50);
            this.iconButtonShop.TabIndex = 1;
            this.iconButtonShop.Text = "Shop";
            this.iconButtonShop.UseVisualStyleBackColor = true;
            this.iconButtonShop.Click += new System.EventHandler(this.iconButtonShop_Click);
            // 
            // iconButtonAdminPanel
            // 
            this.iconButtonAdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAdminPanel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAdminPanel.IconChar = FontAwesome.Sharp.IconChar.Skull;
            this.iconButtonAdminPanel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButtonAdminPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdminPanel.Location = new System.Drawing.Point(0, 50);
            this.iconButtonAdminPanel.Name = "iconButtonAdminPanel";
            this.iconButtonAdminPanel.Size = new System.Drawing.Size(200, 50);
            this.iconButtonAdminPanel.TabIndex = 2;
            this.iconButtonAdminPanel.Text = "Admin";
            this.iconButtonAdminPanel.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 861);
            this.Controls.Add(this.panelTabs);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTabs;
        private FontAwesome.Sharp.IconButton iconButtonShop;
        private FontAwesome.Sharp.IconButton iconButtonAdminPanel;
    }
}