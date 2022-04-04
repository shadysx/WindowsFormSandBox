using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace Revision1
{
    public partial class Sandbox : Form
    {
        public Sandbox()
        {
            InitializeComponent();
            dataGridView1.DataSource = LoadShopData();
        }

        //Cette fonction renvoie une liste d'object anonymes
        public static object LoadShopData()
        {
            List<PRODUCT> products = DAL_PRODUCT.SelectAll();
            List<PICTURE> pictures = DAL_PICTURE.SelectAll();

            var innerJoin = products.Join(
                      pictures,  
                      pro => pro.ID_PRODUCT,   
                      pic => pic.ID_PRODUCT, 
                      (pro, pic) => new 
                      {
                          ProductName = pro.PRODUCT_NAME,
                          ProductType = pro.PRODUCT_TYPE,
                          ProductDescription = pro.PRODUCT_TYPE,
                          PicturesUrl = pic.PICTURE_URL,
                          PicturesImage = pic.Picture
                      });

            return innerJoin.ToList();
        }
    }
}
