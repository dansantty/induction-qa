using System;

namespace InductionQA
{
    public class TicketFly
    {

        public double GetDiscount(double price)
        {


            price = price * 0.80;


            return price;
        }

        public double DoPayment(double price)
        {
            return price;
        }

    }
}
