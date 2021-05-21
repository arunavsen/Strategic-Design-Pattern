using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentStrategicPattern
{
    public class PaymentMethodContext
    {
        private IPaymentStrategy PaymentStrategy;

        public void setStrategy(IPaymentStrategy paymentStrategy)
        {
            this.PaymentStrategy = paymentStrategy;
        }

        public void executeStrategy()
        {
            PaymentStrategy.pay();
        }
    }
}
