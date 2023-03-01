public abstract class Shape 
{
    private string _color ;

    public string GetColor() 
    {
        return _color;
    }

    public void SetColor(string color) 
    {
        _color = color;
    }

    public Shape (string color, int sides)
    {
        this._color = color;
    }

    public abstract float GetArea ();
}