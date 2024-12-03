using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingReceipt
{
   public class Receipt
    {
        public string Item { get; set; }
        public int Qty {  get; set; }
        public double Price { get; set; }
        public string SubTotal { get { return string.Format("₱{0}", Price * Qty); } }
    }
}
