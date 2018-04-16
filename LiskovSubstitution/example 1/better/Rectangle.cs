namespace LiskovSubstitution.example_1.better
{
    public class Quadrilaterals
    {
        public virtual int Height { get; set; }

        public virtual int Width { get; set; }

        public int GetArea()
        {
            return Height * Width;
        }
    }

    public class Rectangle : Quadrilaterals
    {
    }

    public class Square : Quadrilaterals
    {
        public override int Height
        {
            get => base.Height;
            set => SetWidthAndHeight(value);
        }

        public override int Width
        {
            get => base.Width;
            set => SetWidthAndHeight(value);
        }

        private void SetWidthAndHeight(int value)
        {
            base.Height = value;
            base.Width = value;
        }
    }
}
