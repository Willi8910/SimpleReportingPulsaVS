using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jual_Pulsa
{
    [Serializable]
    public class SubTransaction
    {
       public Pulsa Pulse { get; set; }
       public int Unit { get; set; }
       public int SubHarga { get; set; }
       public int SubUntung { get; set; }
    }
}
