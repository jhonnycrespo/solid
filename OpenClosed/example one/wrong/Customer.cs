// https://www.codeproject.com/Articles/703634/SOLID-architecture-principles-using-simple-Csharp

// I have added a simple customer type property to the class. This property
// decided if this is a “Gold” ora “Silver” customer.

// Depending on the same it calculates discount. Have a look at the “GetDiscount”
// function which returns discount accordingly. 1 for Gold customer and 2 for Silver customer.

// The problem is if we add a new customer type we need to go and add one more “IF” condition
// in the “getDiscount” function, in other words we need to change the customer class.

// If we are changing the customer class again and again, we need to ensure that the previous
// conditions with new one’s are tested again , existing client’s which are referencing this
// class are working properly as before.

// In other words we are “MODIFYING” the current customer code for every change and every time
// we modify we need to ensure that all the previous functionalities and connected client are
// working as before.

// How about rather than “MODIFYING” we go for “EXTENSION”. In other words every time a
// new customer type needs to be added we create a new class as shown in the below. So whatever
// is the current code they are untouched and we just need to test and check the new classes.

namespace OpenClosed.example_one.wrong
{
    class Customer
    {
        private int Type { get; set; }

        public double GetDiscount(double totalSales)
        {
            if (Type == 1)
            {
                return totalSales - 100;
            }
            else
            {
                return totalSales - 50;
            }
        }
    }
}
