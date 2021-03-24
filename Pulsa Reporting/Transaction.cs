using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jual_Pulsa
{
    [Serializable]
   public class Transaction
    {
       public DateTime Tanggal { get; set; }
       private List<SubTransaction> listSTrans = new List<SubTransaction>();

       public List<SubTransaction> ListSTrans
       {
           get { return listSTrans; }
           set 
           { 
               listSTrans = value;
               int tUnit = 0, tH = 0, tUntung = 0;
               foreach( SubTransaction St in listSTrans)
               {
                   tUnit += St.Unit;
                   tH += St.SubHarga;
                   tUntung += St.SubUntung;
               }
           }
       }
       public int TotalUnit { get; set; }
       public int TotalHarga { get; set; }
       public int TotalUntung { get; set; }
    }
}
