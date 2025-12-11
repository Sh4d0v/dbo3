using System.Collections.Generic;

namespace Intersect.Server.Entities;
public class PlayerAchievementProgress
{
    public string Id { get; set; } = "";
    public int Current { get; set; } = 0;
}

public class PlayerAchievements
{
    // unlocked achievement ids
    public HashSet<string> Unlocked { get; set; } = new HashSet<string>();

    // progress for achievements that track numbers
    public Dictionary<string, PlayerAchievementProgress> Progress { get; set; } = new Dictionary<string, PlayerAchievementProgress>();
}