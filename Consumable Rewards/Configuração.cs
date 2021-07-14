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
            Permissions.Add(new ITPermission("Permissão e dinheiro ao consumir Medkit", 15, "Você ganhou a permissão", true, 363, 1, true, true, "Permiss", true, 1000));
        }
    }
}