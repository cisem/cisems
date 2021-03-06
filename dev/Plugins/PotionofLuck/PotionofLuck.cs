﻿/*
Potion of Luck - Allows you to sometimes find extra treasure from monsters in Pandaria.  Lasts 20 min
Created by Cisem
http://www.cisem.se
*/
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media;
using System;
using Styx.Helpers;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;
using System.IO;
using System.Xml.Linq;
using Styx.Plugins;
using Styx;
using Styx.CommonBot;
using Styx.Common.Helpers;
using Styx.CommonBot.POI;
using Styx.CommonBot.Profiles;
using Styx.CommonBot.Database;
using Styx.Common;
using Styx.CommonBot.Frames;
using System.Collections.Generic;
using System.Diagnostics;

namespace COIhelper
{
    public partial class COIhelper : HBPlugin
    {
        public override string Name { get { return "Potion of Luck"; } }
        public override string Author { get { return "Cisem"; } }
        public override Version Version { get { return new Version(1, 1); } }
        public override bool WantButton { get { return true; } }
        public override string ButtonText { get { return "No Config"; } }

        public bool coiBuff()
        {
            if (Me.HasAura("Potion of Luck")) { return true; }
            return false;
        }

        public static void slog(string format, params object[] args)
        { Logging.Write("[COI]:" + format, args); }
        private static LocalPlayer Me { get { return StyxWoW.Me; } }

        public override void OnEnable() 
        {
            Logging.Write(Colors.Lime, "Potion of Luck 1.1");
        }

        public override void Pulse()
        {
            PotionofLuck();
        }

        public bool PotionofLuck()
        {
            WoWItem coiB = Me.BagItems.FirstOrDefault(h => h.Entry == 93351);
            if ((coiB != null) && (coiB.CooldownTimeLeft.TotalMilliseconds <= 0) && !Me.Mounted && !coiBuff())
            {
                coiB.Use();
                Logging.Write(Colors.CornflowerBlue, "Using Potion of Luck");
            }
        return false;
        }
    }
}
