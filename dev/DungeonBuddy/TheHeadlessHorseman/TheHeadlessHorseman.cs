//#define USE_DUNGEONBUDDY_DLL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using CommonBehaviors.Actions;
using Styx;
using Styx.Common.Helpers;
using Styx.CommonBot;
using Styx.CommonBot.Frames;
using Styx.Helpers;
 
 
using Styx.Pathing;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;
using Styx.TreeSharp;

#if USE_DUNGEONBUDDY_DLL
using Bots.DungeonBuddyDll;
using Bots.DungeonBuddyDll.Attributes;
using Bots.DungeonBuddyDll.Helpers;
using Action = Styx.TreeSharp.Action;

namespace Bots.DungeonBuddyDll.Dungeon_Scripts.Classic
#else
    using Bots.DungeonBuddy.Attributes;
    using Bots.DungeonBuddy.Helpers;
    using Action = Styx.TreeSharp.Action;
    namespace Bots.DungeonBuddy.Dungeon_Scripts.Classic
#endif
{
    public class ScarletMonastery : Dungeon
    {
        public override uint DungeonId { get { return 285; } }     
    }
}