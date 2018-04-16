// Putting in simple words the “Customer” class is now closed for any new modification
// but it’s open for extensions when new customer types are added to the project.

namespace OpenClosed.example_one.correct
{
    class Customer
    {
        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }
    }

    class SilverCustomer : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 50;
        }
    }

    class GoldCustomer : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 100;
        }
    }
}
