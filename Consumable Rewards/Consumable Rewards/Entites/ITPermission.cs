namespace GroupItemPermissions
{
    sealed public class ITPermission
    {
        public string Name { get; set; }
        public ushort Id { get; set; }
        public string ConsumeMessage { get; set; }
        public bool HasConsumeMessage { get; set; }
        public bool RewardHasGroup { get; set; }
        public string Permission { get; set; }
        public bool RewardHasExperience { get; set; }
        public int ExperienceAmount { get; set; }

        public ITPermission()
        {

        }

        public ITPermission(string name, ushort id, string consumeMessage, bool hasConsumeMessage, bool rewardHasGroup, string permission, bool rewardHasExperience, int esperienceAmount)
        {
            Name = name;
            Id = id;
            ConsumeMessage = consumeMessage;
            HasConsumeMessage = hasConsumeMessage;
            RewardHasGroup = rewardHasGroup;
            Permission = permission;
            RewardHasExperience = rewardHasExperience;
            ExperienceAmount = esperienceAmount;
        }
    }
}