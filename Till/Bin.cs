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
    public double TotalBinCash()
    {
        return _count * _value;
    }
    public void Exchange(int amount)
    {
        if (_count + amount >= 0)
        {
            _count += amount;
        }
        else
        {
            string error = "";
        }
    }
}