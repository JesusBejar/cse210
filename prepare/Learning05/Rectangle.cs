public class Rectangle : Shape
{
    private int _length ; 
    private int _width ; 
    public Rectangle (string color, int length, int width) : base (color)
    {
        this._length = length;
        this._width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}