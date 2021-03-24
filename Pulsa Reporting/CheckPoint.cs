using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jual_Pulsa
{
    [Serializable]
    public class CheckPoint
    {
        public int Bulan { get; set; }
        public int Tahun { get; set; }
        private List<CheckDate> listCheck = new List<CheckDate>();

        public List<CheckDate> ListCheck
        {
            get { return listCheck; }
            set { listCheck = value; }
        }
        public CheckPoint()
        {

        }
        public CheckPoint(int bln, int Year)
        {
            Bulan = bln;
            Tahun = Year;
        }
    }
}
