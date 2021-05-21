using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentStrategicPattern
{
    public class BKashPaymentStrategy : IPaymentStrategy
    {
        public void pay()
        {
            Console.WriteLine("Pay with BKash is successful");
        }
    }
}
