using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using Naturia.Tiles;

namespace Naturia.Items.Flowers.EmperorsStaff
{
	public class EmperorsStaffCeiling : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emperor's Staff");
			Tooltip.SetDefault("Can be placed in the ceiling");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<Tiles.Flowers.EmperorsStaffTile.EmperorsStaffCeilingTile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<EmperorsStaff>(), 1);
			recipe.AddIngredient(ItemID.Chain, 2);
			recipe.AddTile(ModContent.TileType<FloristsCounterTile>());
			recipe.SetResult(this);
;			recipe.AddRecipe();
		}
	}
}