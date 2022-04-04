using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PRODUCT
    {
        public int ID_PRODUCT { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string PRODUCT_DESCRIPTION { get; set; }

        public override string ToString()
        {
            return "ID_PRODUCT" + ID_PRODUCT + "\n" + 
                   "PRODUCT_NAME : " + PRODUCT_NAME + "\n" +
                   "PRODUCT_TYPE : " + PRODUCT_TYPE + "\n" +
                   "PRODUCT_DESCRIPTION : " + PRODUCT_DESCRIPTION + "\n";
        }
    }
}
