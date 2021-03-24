using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jual_Pulsa
{
    [Serializable]
    public class CheckDate
    {
        private DateTime starting;

        public DateTime Starting
        {
            get { return starting; }
            set {
                starting = value; 
                if(Ending != null)
                {
                    Wordy = Starting.Day.ToString() + " - " + Ending.Day.ToString();
                }
            }
        }
        private DateTime ending;

        public DateTime Ending
        {
            get { return ending; }
            set { 
                ending = value;
                if (Starting != null)
                {
                    Wordy = Starting.Day.ToString() + " - " + Ending.Day.ToString();
                }
            }
        }
        public string Wordy { get; private set; }

        public CheckDate(DateTime Start, DateTime End)
        {
            Starting = Start;
            Ending = End;
        }
        public CheckDate()
        {

        }
    }
}
