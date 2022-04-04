using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;


namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "AMD RYZEN 5 3600";
            string type = "CPU";



            
            //All lines

            var result = DAL.DAL_PRODUCT_JOIN_PICTURE.SelectAll();

            //Order

            result = result.Where(x => x.PRODUCT_NAME.Contains(name)).ToList();

            // filter result by name



            // and then by type
            //var result = DAL.DAL_PRODUCT_JOIN_PICTURE.SelectAll();

            // filter result by name
            /*var result2 = from p in result
                          where p.PRODUCT_NAME == name
                          select p;*/

            //Console.WriteLine(result2.Where(p => p.PRODUCT_NAME == name).ToList()[0]);


            foreach (var item in result)
            {
                Console.WriteLine(item.PRODUCT_NAME);
            }

            Console.Read();

        }

        
    }
}
