/*
Crystal of Insanity - Increases all stats by 500 for 1 hour
Created by Phelon EDIT BY CISEM
http://cisems.wordpress.com
*/
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Styx.Plugins;
using Styx.Common;
using Styx.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using Styx;
using Styx.Helpers;
using Styx.Pathing;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;

namespace  BattleStandardofCoordination
{
    public class UltimatePlayerReport : HBPlugin
    {
        public override Version Version { get { return new Version(1, 0, 1); } }

        public override string Author
        {
            get { return "Phelon"; }
        }

        public override string Name
        {
            get { return "Battle Standard of Coordination"; }
        }

        public override string ButtonText
        {
            get
            {
                return "Battle Standard of Coordination";
            }
        }
        public override bool WantButton
        {
            get
            {
                return true;
            }
        }

        public override void OnButtonPress()
        {
        }

        public override void Pulse()
        {
								if (StyxWoW.Me.Combat)
            foreach (WoWItem banner in StyxWoW.Me.BagItems)
            {

                if (banner.Name.Contains("Battle Standard of Coordination"))
                {
                    if (banner.Cooldown == 0)
                    {
                        Logging.Write("Using Battle Standard of Coordination. Increases the experience, honor and reputation gain from killing monsters for all guild members that stay within 100 yards of the Battle Standard by 15%.  Lasts 15 min.");
                        banner.Use();
                    }
                }
            }
		}
        public override void Initialize()
        {
        }
    }
}