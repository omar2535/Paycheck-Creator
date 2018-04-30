using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaycheckCreator
{
    class DeductionItem
    {
        public string NameOfDeduction { get; set; }
        public double PercentageAmount { get; set; }
        public double FlatAmount { get; set; }
        
    }
}
