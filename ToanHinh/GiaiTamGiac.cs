using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanHinh
{
    class GiaiTamGiac
    {
        public string tentamgiac;
        public double dientich;
        public string tenduongcao;
        public double dodaiduongcao;
        public string tencanhday;
        public double dodaicanhday;
        public double dienTichCaoDay( )
        {
            double dt = dodaicanhday * dodaiduongcao / 2;
            return dt;
        }
    }
}
