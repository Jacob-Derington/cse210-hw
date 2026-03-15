public class Checklist : Goals
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public Checklist(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted++;
            if (_timesCompleted == _target)
            {
                return _pointValue + _bonus;
            }
            return _pointValue;
        }
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override string GetStatus() => $"[{_timesCompleted}/{_target}]";
}