using HarmonyLib;
using Verse;

namespace Dryad_Caravan
{
	public class Mod : Verse.Mod
	{
		public Mod(ModContentPack content) : base(content)
		{
#if DEBUG
			Harmony.DEBUG = true;
#endif
			new Harmony("Garethp.rimworld.Dryad_Caravan.main").PatchAll();
		}
	}
}