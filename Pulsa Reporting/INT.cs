using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jual_Pulsa
{
    [Serializable]
    public class INT
    {
        public string Keterangan { get; set;}
        public int Number { get; set; }

        public INT(int nilai, string nama)
        {
            Number = nilai;
            Keterangan = nama;
        }

        public static int ToInt(INT num)
        {
            return num.Number;
        }
        public static INT ToINT(int num)
        {
            INT ina = new INT();
            ina.Number = num;
            return ina;
        }

        public INT()
        {

        }
        public INT(INT ses)
        {
            Number = ses.Number;
        }

        public int ToInt()
        {
            return Number;
        }
    }
}
