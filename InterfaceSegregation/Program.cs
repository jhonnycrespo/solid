// This principle states that a client shouldn't be forced to depend on methods it doesn't use.

// Now what does this mean, suppose there is one database for storing data
// of all types of employees (i.e.Permanent, non-permanent), now what will be the best
// approach for our interface?

// Now all types of employee class will inherit this interface for saving data.
public interface IEmployeeDatabase
{
    bool AddEmployeeDetails();

    // This is fine right? Now suppose that the company one day tells to you that they
    // want to read only data of permanent employees. What you will do, just add one
    // method to this interface?

    // But now we are breaking something.We are forcing non-permanent employee class
    // to show their details from database.
    bool ShowEmployeeDetails(int employeeId);
}

// So, the solution is to give this responsibility to another interface.
// And non-permanent employee will implement only IAddOperation and permanent employee
// will implement both the interface.
public interface IAddOperation
{
    bool AddEmployeeDetails();
}

public interface IGetOperation
{
    bool ShowEmployeeDetails(int employeeId);
}

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
