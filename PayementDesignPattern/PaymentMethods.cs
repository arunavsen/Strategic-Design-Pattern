using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayementDesignPattern
{
    // Single Responsibility Principle Violation
    // Open Close Principle Violation
    public class PaymentMethods
    {
        private string selectPaymentMethod;

        public void setSelectedPaymentMethod(string s)
        {
            this.selectPaymentMethod = s;
        }

        public void pay()
        {
            switch (selectPaymentMethod)
            {
                case "COD":
                    payWithCOD();
                    break;
                case "BKash":
                    payWithBKash();
                    break;
                case "Nagad":
                    payWithNagad();
                    break;
                case "SureCash":
                    payWithSureCash();
                    break;
                case "Rocket":
                    payWithRocket();
                    break;
                case "Nexus":
                    payWithNexus();
                    break;
            }
        }

        private void payWithNexus()
        {
            Console.WriteLine("Pay with Nexus is successful");
        }

        private void payWithRocket()
        {
            Console.WriteLine("Pay with Rocket is successful");
        }

        private void payWithSureCash()
        {
            Console.WriteLine("Pay with SureCash is successful");
        }

        private void payWithNagad()
        {
            Console.WriteLine("Pay with Nagad is successful");
        }

        private void payWithCOD()
        {
            Console.WriteLine("Pay with COD is successful");
        }

        private void payWithBKash()
        {
            Console.WriteLine("Pay with BKash is successful");
        }
    }
}
