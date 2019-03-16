using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Doctor
{
    public class patiens
    {

        public long MaBN { get; set; }
        public string CMND { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public patiens(long maBN, string cMND, string hoten, string diachi)
        {
            MaBN = maBN;
            CMND = cMND;
            Hoten = hoten;
            Diachi = diachi;
        }
        public patiens()
        {

        }
    }
}
