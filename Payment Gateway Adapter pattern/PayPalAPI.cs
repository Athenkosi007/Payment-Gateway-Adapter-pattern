using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Gateway_Adapter_pattern
{
    public class PayPalAPI
    {
        public void SendPayment(double usdAmount)
        {
            Console.WriteLine($"Processing payment of ${usdAmount} via PayPal.");
        }

    }
}
