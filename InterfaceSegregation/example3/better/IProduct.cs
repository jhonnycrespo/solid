// So what's the solution? Refactor! But how?

// Well, what properties do both BaseballCap and Jeans need? Those properties can
// become the new IProduct interface:

namespace InterfaceSegregation.example3.better
{
    interface IProduct
    {
        int ID { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
    }

    // We currently sell jeans, but Inseam and WaistSize can apply to any type of pants,
    // so let's create an IPants interface:

    public interface IPants
    {
        int Inseam { get; set; }
        int WaistSize { get; set; }
    }

    // We should be willing to bet that baseball caps won't be the only kinds of hats
    // we'll sell, so we also make a focused IHat interface:

    public interface IHat
    {
        int HatSize { get; set; }
    }

    // Now we can implement both Jeans and BaseballCap:

    public class Jeans : IProduct, IPants
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
    }

    public class BaseballCap : IProduct, IHat
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int HatSize { get; set; }
    }

    // Each class now has only properties that they need. Now we are upholding the
    // Interface Segregation Principle!
}
