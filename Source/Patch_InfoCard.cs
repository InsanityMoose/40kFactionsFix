using System;
using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;


namespace _40kFactionsFix
{
    [HarmonyPatch(typeof(Dialog_InfoCard), nameof(Dialog_InfoCard.DoWindowContents))]
    public static class Patch_DoWindowContents
    {
        public static void Prefix(Rect inRect)
        {
            foreach (Faction faction in Find.FactionManager.AllFactionsVisible)
            {
                if (!faction.IsPlayer && !faction.def.permanentEnemy && !faction.temporary)
                {
                    foreach (RoyalTitlePermitDef allDef in DefDatabase<RoyalTitlePermitDef>.AllDefs)
                    {
                        if (allDef.faction == faction.def)
                        {
                            if (PermitsCardUtility.selectedFaction == null) PermitsCardUtility.selectedFaction = faction;
                            break;
                        }
                    }
                }
            }
        }
    }
}
