using System;

public class SimpleGoal : Goal
{
    private bool _completed = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override bool IsComplete() => _completed;

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return Points;
        }
        return 0;
    }

    public override string DisplayStatus() => _completed ? "[X]" : "[]";
}

