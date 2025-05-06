using System;
namespace Payment_Gateway_Adapter_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use PayFast
            IPaymentProcessor payFastProcessor = new PayFastAdapter(new PayFastAPI());
            payFastProcessor.ProcessPayment(100m);

            // Use PayPal via adapter
            IPaymentProcessor payPalProcessor = new PayPalAdapter(new PayPalAPI());
            payPalProcessor.ProcessPayment(150m);

            Console.ReadLine();
        }
    }
}
