using System;

namespace CivVIDrafter
{
    public class Civilization
    {
        public string Name { get; }
        public string Leader { get; }
        public DLC Pack { get; }

        public Civilization(string name, string leader, DLC pack)
        {
            Name = name;
            Leader = leader;
            Pack = pack;
        }

        public override string ToString() => $"{Name}, {Leader}";
    }

    [Flags]
    public enum DLC
    {
        Vanilla = 1,
        ScenarioPacks = 2,
        GatheringStorm = 4,
        RiseAndFall = 8,
        NewFrontierPass = 16,
        LeaderPass = 32
    }

}

