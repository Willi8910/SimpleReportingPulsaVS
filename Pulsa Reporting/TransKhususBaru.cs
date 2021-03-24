using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jual_Pulsa
{
    [Serializable]
    public class TransKhususBaru
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

        private List<INT> pakeLain = new List<INT>();

        public List<INT> PakeLain
        {
            get { return pakeLain; }
            set { pakeLain = value; }
        }

        public static TransKhususBaru Change(TransKhusus Trb)
        {
            TransKhususBaru Baru = new TransKhususBaru();
            Baru.Bonus = Trb.Bonus;
            Baru.Pakai = Trb.Pakai;
            Baru.Rugi = Trb.Rugi;
            Baru.Salah = Trb.Salah;
            Baru.Tanggal = Trb.Tanggal;

            return Baru;
        }
    }
}
