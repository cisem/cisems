﻿/*
Potion of Treasure Finding - Allows you to sometimes find extra treasure from monsters in Mount Hyjal, Vashj'ir, Deepholm, Twilight Highlands and Uldum.  Lasts 1 hour. Created by Cisem
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

namespace  PoTF
{
    public class PoTF : HBPlugin
    {
        public override Version Version { get { return new Version(1, 0, 0); } }

        public override string Author
        {
            get { return "Cisem"; }
        }

        public override string Name
        {
            get { return " Potion of Treasure Finding "; }
        }

        public override string ButtonText
        {
            get
            {
                return "Potion of Treasure Finding";
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
            foreach (WoWItem Crystal in StyxWoW.Me.BagItems)
            {
										if (StyxWoW.Me.Combat)
                if (Crystal.Name.Contains("Potion of Treasure Finding"))
                {
                    if (Crystal.Cooldown == 0)
                    {
                        Logging.Write("Using Potion of Treasure Finding. Allows you to sometimes find extra treasure from monsters in Mount Hyjal, Vashj'ir, Deepholm, Twilight Highlands and Uldum.  Lasts 1 hour.");
                        Crystal.Use();
                    }
                }
            }
        }

        public override void Initialize()
        {
        }
    }
}