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
        public int PercentageAmount { get; set; }
        public int FlatAmount { get; set; }
        
    }
}
