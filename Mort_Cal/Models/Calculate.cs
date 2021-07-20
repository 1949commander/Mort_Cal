using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mort_Cal.Models
{
    public class Calculate
    {
        public decimal amount { get; set; }
        public decimal interest { get; set; }
        public int period { get; set;  }
        public decimal total_amt { get; set; }
        public decimal monthly_payment { get; set; }
    }
}
