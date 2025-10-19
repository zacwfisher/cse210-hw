using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _target)
        {
            return Points + _bonus;
        }
        return Points;
    }

    public override string DisplayStatus() => $"Completed {_timesCompleted}/{_target}";
}