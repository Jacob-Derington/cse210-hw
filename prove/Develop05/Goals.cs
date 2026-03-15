public abstract class Goals
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    
    public string Name => _name;
    public string Description => _description;
    public int PointValue => _pointValue;

    public Goals(string Name, string Description, int PointValue)
    {
        _name = Name;
        _description = Description;
        _pointValue = PointValue;
    }
    
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStatus();
} 