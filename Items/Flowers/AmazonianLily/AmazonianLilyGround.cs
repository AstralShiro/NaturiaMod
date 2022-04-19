using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using Naturia.Tiles.Flowers.AmazonianLilyTile;

using Naturia.Tiles;

namespace Naturia.Items.Flowers.AmazonianLily
{
	public class AmazonianLilyGround : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amazonian Lily");
			Tooltip.SetDefault("Can be placed in the ground");
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
			item.createTile = TileType<Tiles.Flowers.AmazonianLilyTile.AmazonianLilyGroundTile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<AmazonianLily>(), 1);
			recipe.AddIngredient(ItemID.ClayPot, 1);
			recipe.AddTile(ModContent.TileType<FloristsCounterTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}