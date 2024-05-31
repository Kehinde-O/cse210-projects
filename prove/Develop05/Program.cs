using System;

class Program
{
    ////Exceed Requirement
    // 1. Added a check to not award a point for already completed Goals [Simple Goal, Checklist Goal]
    // 2. Added a functionality to return appropriate message when trying to load a goal that does not exist
    // 3. Added a functionality to return appropriate message when trying to record event when no goal exist
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}