using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Provider;
using SDG.Framework;
using Rocket.Core;
using SDG.Unturned;
using Rocket.Core.Plugins;
using Rocket.API;
using Rocket.Unturned;


namespace GroupItemPermissions
{
    public class Configuração : IRocketPluginConfiguration
    {
        public List<ITPermission> Permissions = new List<ITPermission>();

        public void LoadDefaults()
        {
            Permissions.Add(new ITPermission("Medical Consumeble Rewards", true, 1230, "Sim", true, true , true, 12309, 100, "A", true, 10, true, true, 10, $"Heal", "A"));
        }
    }
}