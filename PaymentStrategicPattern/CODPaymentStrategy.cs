using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentStrategicPattern
{
    public class CODPaymentStrategy : IPaymentStrategy
    {
        public void pay()
        {
            Console.WriteLine("Pay with COD is successful");
        }
    }
}
