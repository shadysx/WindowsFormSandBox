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
    public class PICTURE
    {
        
        public int ID_PICTURE { get; set; }

        public string PICTURE_URL { get; set; }

        public int ID_PRODUCT { get; set; }

        public Image Picture
        {

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
            return "ID_PICTURE : " + ID_PICTURE + "\n" +
                   "PICTURE_URL : " + PICTURE_URL + "\n" +
                   "ID_PRODUCT : " + ID_PRODUCT + "\n";
        }
    }
}
