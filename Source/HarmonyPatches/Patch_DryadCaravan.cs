using System;
using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;
using Verse.AI.Group;

namespace Dryad_Caravan.HarmonyPatches
{
	[HarmonyPatch(typeof(PawnDiedOrDownedThoughtsUtility), nameof(PawnDiedOrDownedThoughtsUtility.TryGiveThoughts), new Type[] { typeof(Pawn), typeof(DamageInfo?), typeof(PawnDiedOrDownedThoughtsKind) })]
	
	public class Patch_DryadLost
	{
		public static void Prefix(Pawn victim,
			DamageInfo? dinfo,
			PawnDiedOrDownedThoughtsKind thoughtsKind)
		{

			if (thoughtsKind == PawnDiedOrDownedThoughtsKind.Lost)
			{
				victim.Kill(dinfo);
			}
		}
	}
}