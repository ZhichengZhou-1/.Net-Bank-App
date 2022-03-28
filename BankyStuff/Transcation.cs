using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace BankyStuff
{
    public class Transcation
    {
        public decimal Amount { get; }

        public string AmountForHumans { get
            {
                return ((int)Amount).ToWords();
            } 
        }
        public DateTime Date { get; set; }
        public string Notes { get; }

        public Transcation(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
          
        }

    }
}
