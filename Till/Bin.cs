// dotnet new console -o Till --use-program-main 
// Use this to make new things with diffrent names. 

class Bin
{
    // fields
    private string _denomination; 
    private double _value;
    private int _count;

    // methods
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }
    public int GetCount()
    {
        return _count;
    }
    public double GetValue()
    {
        return _value;
    }
    public Transact(int delta)
    {
        _count = delta;
    }
}