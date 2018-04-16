using System;

// Have a look at the code below, can you guess what the problem is?

// Customer class should do customer datavalidations, call the customer data access layer, etc.
// But if you see the catch block closely it also doing LOGGING activity. In simple words its
// over loaded with lot of responsibility.

// So tomorrow if add a new logger like event viewer I need to go and change
// the “Customer” class, that’s very ODD.

namespace SingleResponsability.wrong
{
    class Customer
    {
        public void Add()
        {
            try
            {
                // database code goes here
            }
            catch (Exception e)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", e.ToString());
            }
        }
    }
}
