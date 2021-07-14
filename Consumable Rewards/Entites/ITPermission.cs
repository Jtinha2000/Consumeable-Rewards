namespace GroupItemPermissions
{
    sealed public class ITPermission
    {
        public string Name { get; set; }
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

        public ITPermission()
        {

        }

        public ITPermission(string name, ushort id, string consumeMessage, bool rewardHasItem, ushort ItemID, int itemamount, bool hasConsumeMessage, bool rewardHasGroup, string permission, bool rewardHasExperience, int esperienceAmount)
        {
            Name = name;
            ConsumebleId = id;
            ConsumeMessage = consumeMessage;
            HasConsumeMessage = hasConsumeMessage;
            RewardHasGroup = rewardHasGroup;
            RewardHasItem = rewardHasItem;
            ItemId = ItemID;
            ItemAmount = itemamount;
            Permission = permission;
            RewardHasExperience = rewardHasExperience;
            ExperienceAmount = esperienceAmount;
        }
    }
}