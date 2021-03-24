using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jual_Pulsa
{
    [Serializable]
    public class Pulsa
    {
        public Operator Operand { get; set; }
        public string Kode { get; set; }
        public int Modal { get; set; }
        public int Harga { get; set; }
        public int Untung { get; private set; }

        public Pulsa(Operator Type, string Code, int Awal, int Jual)
        {
            Operand = Type;
            Kode = Code;
            Modal = Awal;
            Harga = Jual;
            Untung = Jual - Awal;
        }
        
        public virtual void AddUnit(int jumlah)
        {

        }
        public virtual void EditUnit(int stokk, int ministok)
        {

        }
        public virtual int getStock()
        {
            return 0;
        }

        public virtual bool CheckStok(int Unit)
        {
            return true;
        }

        public void getUntung()
        {
            Untung = Harga - Modal;
        }
    }
}
