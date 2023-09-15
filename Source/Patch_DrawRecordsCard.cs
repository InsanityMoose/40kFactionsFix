using System;
using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace _40kFactionsFix
{
    [HarmonyPatch(typeof(PermitsCardUtility), nameof(PermitsCardUtility.DrawRecordsCard))]
    public static class Patch_DrawRecordsCard
    {
        public static void Prefix(Rect rect, Pawn pawn)
        {
            foreach (Faction faction in Find.FactionManager.AllFactionsVisible)
            {
                if (!faction.IsPlayer && !faction.def.permanentEnemy && !faction.temporary)
                {
                    foreach (RoyalTitlePermitDef allDef in DefDatabase<RoyalTitlePermitDef>.AllDefs)
                    {
                        if (allDef.faction == faction.def)
                        {
                            if(PermitsCardUtility.selectedFaction == null) PermitsCardUtility.selectedFaction = faction;
                            break;
                        }
                    }
                }
            }
        }
    }
}
