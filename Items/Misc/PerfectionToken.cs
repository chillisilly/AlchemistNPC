using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using AlchemistNPC;

namespace AlchemistNPC.Items.Misc
{
	public class PerfectionToken : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Perfection Token");
			Tooltip.SetDefault("While this is in your inventory, your next weapon/tool reforge would get best possible result"
			+"\nConsumes in process"
			+"\nNot compatible with Thorium Mod's Bard and Healer items");
			DisplayName.AddTranslation(GameCulture.Russian, "Значок Совершенства");
            Tooltip.AddTranslation(GameCulture.Russian, "Если находится в инвентаре, ваше следующая перековка будет иметь наилучший результат\nБудет потрачен в процессе\nНесовместим с предметами Барда и Лекаря из Ториума");
        }

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 1000000;
			item.maxStack = 99;
			item.rare = 5;
		}
	}
}
