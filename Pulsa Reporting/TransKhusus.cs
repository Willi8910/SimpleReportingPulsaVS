using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jual_Pulsa
{
    [Serializable]
    public class TransKhusus
    {
        public DateTime Tanggal { get; set; }

        List<SubTransaction> pakai = new List<SubTransaction>();
        public List<SubTransaction> Pakai
        {
            get { return pakai; }
            set { pakai = value; }
        }
        List<SubTransaction> salah = new List<SubTransaction>();
        public List<SubTransaction> Salah
        {
            get { return salah; }
            set { salah = value; }
        }

        private List<INT> bonus = new List<INT>();

        public List<INT> Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        private List<INT> rugi = new List<INT>();
        public List<INT> Rugi
        {
            get { return rugi; }
            set { rugi = value; }
        }

      
    }
}
