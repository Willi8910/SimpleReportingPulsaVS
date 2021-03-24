using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jual_Pulsa
{
    [Serializable]
    public class PulsaMkios : Pulsa
    {
        public int Stok { get; set; }
        public int MinStok { get; set; }

        public PulsaMkios(Operator Type, string Code, int Awal, int Jual, int Stock, int minStock) : base(Type,Code,Awal,Jual)
        {
            Stok = Stock;
            MinStok = minStock;
        }
        public override void AddUnit(int jumlah)
        {
            Stok -= jumlah;
        }

        public override void EditUnit(int stokk, int ministok)
        {
            Stok = stokk;
            MinStok = ministok;
        }

        public override int getStock()
        {
            return Stok;
        }
        public override bool CheckStok(int Unit)
        {
            if(Stok < Unit)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
