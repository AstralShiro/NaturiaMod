using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Naturia.Items.Flowers.EmperorsStaff
{
	public class EmperorsStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emperor's Staff");
			Tooltip.SetDefault("Used for craft the forniture");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
		}
	}
}