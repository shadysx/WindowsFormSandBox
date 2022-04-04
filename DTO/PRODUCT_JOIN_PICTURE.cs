using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Net;

namespace DTO
{
    public class PRODUCT_JOIN_PICTURE
    {
        public int ID_PRODUCT { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string PRODUCT_DESCRIPTION { get; set; }

        public string PICTURE_URL { get; set; }

        public Image Picture {

            get
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(PICTURE_URL);
                MemoryStream ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
        }

        public override string ToString()
        {
            return "Name : " + PRODUCT_NAME + "\n"  + 
                   "Type : " + PRODUCT_TYPE + "\n" +
                   "Desc : " + PRODUCT_DESCRIPTION + "\n" +
                   "URL : " + PICTURE_URL + "\n";
        }
    }
}
