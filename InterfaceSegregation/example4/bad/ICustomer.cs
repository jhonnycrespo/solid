// Here is an example of a banking customer for a bank with the following types of customers:

// 1. Corporate customer: For corporate people.
// 2. Retail customer: For individual, daily banking.
// 3. Potential customer: They are just a bank customer that does not yet hold a
// product of the bank and it is just a record that is different from corporate and retail.

// The developer of a system defines an interface for a customer as in the following
// that doesn't follow the ISP rule.

namespace InterfaceSegregation.example4.bad
{
    interface ICustomer
    {
    }
}
