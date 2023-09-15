using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using Verse;

namespace _40kFactionsFix
{
	[StaticConstructorOnStartup]
	public static class Static
	{
		static Static()
		{
			Harmony h = new Harmony("_40kFactionsFix");
			h.PatchAll();
		}
	}
}
