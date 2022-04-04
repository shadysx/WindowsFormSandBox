using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;
using DTO;


namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {


            //All Lines
            var products = DAL_PRODUCT.SelectAll();
            var pictures = DAL_PICTURE.SelectAll();

            var innerJoin = products.Join(// outer sequence 
                      pictures,  // inner sequence 
                      pro => pro.ID_PRODUCT,    // outerKeySelector
                      pic => pic.ID_PRODUCT,  // innerKeySelector
                      (pro, pic) => new  // result selector
                      {
                          ProductName = pro.PRODUCT_NAME,
                          ProductType = pro.PRODUCT_TYPE,
                          ProductDescription = pro.PRODUCT_TYPE,
                          PicturesUrl = pic.PICTURE_URL
                      });

           
            foreach (var item in innerJoin)
                Console.WriteLine(item);

            Console.ReadLine();
   

        }

        
    }
}
