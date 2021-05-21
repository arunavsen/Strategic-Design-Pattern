using System;

namespace PaymentStrategicPattern
{
    public class NagadPaymentStrategy : IPaymentStrategy
    {
        public void pay()
        {
            Console.WriteLine("Pay with Nagad is successful");
        }
    }
}