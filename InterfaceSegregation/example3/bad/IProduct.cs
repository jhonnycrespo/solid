// Let's say we are tasked with modeling a newly-opened clothing store that sells jeans.
// At the moment, that's all they will sell. Now we, being smart programmers, think that
// we should model this so that if the store wants to sell different products in the future,
// we can model them appropriately. So, we create an interface for the products and a class for Jeans:

namespace InterfaceSegregation.example3.bad
{
    public interface IProduct
    {
        int ID { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
        int Inseam { get; set; }
        int WaistSize { get; set; }
    }

    public class Jeans : IProduct
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
    }

    // ust a week later, the owner of the store comes to us and tells us that they're now
    // going to sell baseball caps. So, wanting to use the interface we already created,
    // we implement BaseballCap:

    public class BaseballCap : IProduct
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
        public int HatSize { get; set; }
    }

    // But wait! Why does a baseball cap have an inseam or waist size? Those properties
    // don't make sense for a baseball cap, but because they were defined in IProduct,
    // BaseballCap must implement them.
}
