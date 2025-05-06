# PaymentGatewayAdapter

This is a simple C# example of the **Adapter Design Pattern**.

The project simulates integrating two payment gateways, **PayFast** and **PayPal**, under a single interface. Each gateway has a different API, so adapters are created to make them compatible with the checkout system.

The `IPaymentProcessor` interface defines a common `ProcessPayment()` method. Both `PayFastAdapter` and `PayPalAdapter` implement this interface, allowing the checkout system to process payments without caring about the specific gateway.


## Example Output

Processing payment of R100.00 via PayFast.
Processing payment of $150 via PayPal.
