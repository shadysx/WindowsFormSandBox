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
    public partial class DisplayProducts : KryptonForm
    {
        public DisplayProducts()
        {
            InitializeComponent();
            
            var result = DAL.DAL_PRODUCT.SelectAll();

            Label[] labels = new Label[result.Count];
            PictureBox[] pictureBoxes = new PictureBox[result.Count];

            for (int i = 0; i < result.Count; i++)
            { 
                labels[i] = new Label();
                labels[i].Text = result[i].PRODUCT_NAME;
                labels[i].Location = new Point(0, i * 15);
                labels[i].Size = new Size(100, 15);
                this.Controls.Add(labels[i]);
                pictureBoxes[i] = new PictureBox();
                pictureBoxes[i].ImageLocation = "https://media.ldlc.com/r374/ld/products/00/05/92/87/LD0005928757_1.jpg";
                pictureBoxes[i].Location = new Point(150, i * 50);
                pictureBoxes[i].Size = new Size(100, 100);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pictureBoxes[i]);
                
            }
        }
    }
}
