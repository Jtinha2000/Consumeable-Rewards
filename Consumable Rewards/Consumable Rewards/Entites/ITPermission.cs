namespace GroupItemPermissions
{
    sealed public class ITPermission
    {
        public string Name { get; set; }
        public bool Needspermission { get; set; }
        public string NeededPermission { get; set; }
        public ushort ConsumebleId { get; set; }
        public string ConsumeMessage { get; set; }
        public bool HasConsumeMessage { get; set; }
        public bool RewardHasGroup { get; set; }
        public bool RewardHasItem { get; set; }
        public ushort ItemId { get; set; }
        public int ItemAmount { get; set; }
        public string Permission { get; set; }
        public bool RewardHasExperience { get; set; }
        public int ExperienceAmount { get; set; }
        public bool GiveReputation { get; set; }
        public bool RunsAcommand { get; set; }
        public int ReputationAmount { get; set; }
        public string Command { get; set; }

        public ITPermission()
        {

        }

        public ITPermission(string name, bool needspermission, ushort consumebleId, string consumeMessage, bool hasConsumeMessage, bool rewardHasGroup, bool rewardHasItem, ushort itemId, int itemAmount, string permission, bool rewardHasExperience, int experienceAmount, bool giveReputation, bool runsAcommand, int reputationAmount, string command, string neededPermission)
        {
            Name = name;
            Needspermission = needspermission;
            ConsumebleId = consumebleId;
            ConsumeMessage = consumeMessage;
            HasConsumeMessage = hasConsumeMessage;
            RewardHasGroup = rewardHasGroup;
            RewardHasItem = rewardHasItem;
            ItemId = itemId;
            ItemAmount = itemAmount;
            Permission = permission;
            RewardHasExperience = rewardHasExperience;
            ExperienceAmount = experienceAmount;
            GiveReputation = giveReputation;
            RunsAcommand = runsAcommand;
            ReputationAmount = reputationAmount;
            Command = command;
            NeededPermission = neededPermission;
        }
    }
}