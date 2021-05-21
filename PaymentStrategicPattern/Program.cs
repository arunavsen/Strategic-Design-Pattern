using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentStrategicPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentMethodContext context = new PaymentMethodContext();

            int Amount = 200;

            string selectedMethod = "Nagad";

            if (selectedMethod.Equals("COD") && Amount > 500)
            {
                context.setStrategy(new CODPaymentStrategy());
                context.executeStrategy();
            }else if (selectedMethod.Equals("BKash"))
            {
                context.setStrategy(new BKashPaymentStrategy());
                context.executeStrategy();
            }
            else if (selectedMethod.Equals("Nagad"))
            {
                context.setStrategy(new NagadPaymentStrategy());
                context.executeStrategy();
            }
            else
            {
                Console.WriteLine("Sorry! Minimum 500tk order is required for COD");
            }

        }
    }
}
