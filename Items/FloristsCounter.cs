using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Naturia.Items
{
	public class FloristsCounter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Florist's Counter");
			Tooltip.SetDefault("Crafting station for craft all the Naturia's stuff");
		}

		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 26;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<Tiles.FloristsCounterTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ClayPot, 1);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
;			recipe.AddRecipe();
		}
	}
}