using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using Naturia.Tiles;

namespace Naturia.Items.Flowers.AmazonianLily
{
	public class AmazonianLilyWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amazonian Lily");
			Tooltip.SetDefault("Can be placed in the wall");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 34;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<Tiles.Flowers.AmazonianLilyTile.AmazonianLilyWallTile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<AmazonianLily>(), 1);
			recipe.AddIngredient(ItemID.WoodPlatform, 1);
			recipe.AddTile(ModContent.TileType<FloristsCounterTile>());
			recipe.SetResult(this);
;			recipe.AddRecipe();
		}
	}
}