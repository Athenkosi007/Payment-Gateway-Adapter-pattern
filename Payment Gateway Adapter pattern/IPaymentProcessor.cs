using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Gateway_Adapter_pattern
{
   public interface IPaymentProcessor
   {
        void ProcessPayment(decimal amount);
   }
}
