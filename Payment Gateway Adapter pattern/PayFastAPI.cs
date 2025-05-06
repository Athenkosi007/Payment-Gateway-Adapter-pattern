using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Gateway_Adapter_pattern
{
    public class PayFastAPI
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} via PayFast.");
        }
        
         
    }
}
