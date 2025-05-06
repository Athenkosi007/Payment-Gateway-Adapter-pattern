using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Gateway_Adapter_pattern
{
    public class PayPalAdapter: IPaymentProcessor
    {
        private readonly PayPalAPI _payPalAPI;

        public PayPalAdapter(PayPalAPI payPalAPI)
        {
            _payPalAPI = payPalAPI;
        }

        public void ProcessPayment(decimal amount)
        {
            //Convert decimal to double 
            _payPalAPI.SendPayment((double)amount);
     
        }
        
    }

    public class PayFastAdapter : IPaymentProcessor
    {
        private readonly PayFastAPI _payFastAPI;

        public PayFastAdapter(PayFastAPI payFastAPI)
        {
            _payFastAPI = payFastAPI;
        }

        public void ProcessPayment(decimal amount)
        {
            _payFastAPI.MakePayment(amount);
        }
    }
}
