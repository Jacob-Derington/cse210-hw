public class Simple : Goals
{
    private bool _completed;

    public Simple(string name, string description, int points) : base(name, description, points)
    {
        _completed = false;
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _pointValue;
        }
        return 0;
    }
    public void SetCompleted(bool completed)
    {
        _completed = completed;
    }

    public override bool IsComplete() => _completed;
    public override string GetStatus() => _completed ? "[x]" : "[ ]";
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_description}|{_pointValue}|{_completed}";
    }
}