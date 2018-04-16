// "we must make sure that new derived classes are extending the base classes
// without changing their behavior".

// "we must make sure that Square classes are extending the Rectangle without
// changing their behavior"
namespace LiskovSubstitution.example_1.bad
{
    public class Rectangle
    {
        public int Width { get; protected set; }

        public int Height { get; protected set; }

        public virtual void SetWidth(int width)
        {
            Width = width;
        }

        public virtual void SetHeight(int height)
        {
            Height = height;
        }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    // Width = Height is a rule only for squares, not for Rectangle.
    public class Square : Rectangle
    {
        // Here we are changing the behavior of Rectangle by assigning the width to
        // Rectangle Height
        public override void SetWidth(int width)
        {
            Width = width;
            Height = width;
        }

        // Here we are changing the behavior of Rectangle by assigning the width to
        // Rectangle Width
        public override void SetHeight(int height)
        {
            Height = height;
            Width = height;
        }
    }
}
