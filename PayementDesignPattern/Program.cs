using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayementDesignPattern
{
    // Open Close Principle Violation
    class Program
    {
        static void Main(string[] args)
        {
            PaymentMethods paymentMethods = new PaymentMethods();

            int amount = 200;

            string selectedMode = "Nagad";

            if (selectedMode.Equals("COD") && amount > 500)
            {
                paymentMethods
                    .setSelectedPaymentMethod("COD");
                paymentMethods.pay();
            }
            else if(selectedMode.Equals("BKash"))
            {
                paymentMethods.setSelectedPaymentMethod("BKash");
                paymentMethods.pay();
            }
            else if (selectedMode.Equals("Nagad"))
            {
                paymentMethods.setSelectedPaymentMethod("Nagad");
                paymentMethods.pay();
            }
            else if (selectedMode.Equals("SureCash"))
            {
                paymentMethods.setSelectedPaymentMethod("SureCash");
                paymentMethods.pay();
            }
            else if (selectedMode.Equals("Rocket"))
            {
                paymentMethods.setSelectedPaymentMethod("Rocket");
                paymentMethods.pay();
            }
            else if (selectedMode.Equals("Nexus"))
            {
                paymentMethods.setSelectedPaymentMethod("Nexus");
                paymentMethods.pay();
            }
            else
            {
                Console.WriteLine("Sorry! Minimum 500tk is required.");
            }
        }
    }
}
