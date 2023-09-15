
using RimWorld;
using UnityEngine;
using Verse;

namespace _40kFactionsFix
{
    [StaticConstructorOnStartup]
    public class ModMain : Mod
    {
        public ModMain(ModContentPack content) : base(content)
        {
            Log.Message("[40kFactionsFix] Loading");
        }
    }
}
