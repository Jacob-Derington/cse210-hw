public class Eternal : Goals
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override int RecordEvent() => _pointValue;

    public override bool IsComplete() => false;

    public override string GetStatus() => "[∞]";
}