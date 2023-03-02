public class Rectangle : Shape
{
    private int _length ; 
    private int _width ; 
    public Rectangle (string color, int length, int width) : base (color)
    {
        this._length = width;
        this._width = width;
    }

    public override float GetArea()
    {
        return _length * _width;
    }
}