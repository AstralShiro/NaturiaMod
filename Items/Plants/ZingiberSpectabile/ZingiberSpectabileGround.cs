using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using Naturia.Tiles;
using Naturia.Items.Plants.ZingiberSpectabile;

namespace Naturia.Items.Plants.ZingiberSpectabile
{
	public class ZingiberSpectabileGround : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Monstera Adansonii");
			Tooltip.SetDefault("Can be placed in the ground");
		}

		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 58;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<Tiles.Plants.ZingiberSpectabileTile.ZingiberSpectabileGroundTile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<ZingiberSpectabile>(), 1);
			recipe.AddIngredient(ItemID.ClayPot, 1);
			recipe.AddTile(ModContent.TileType<FloristsCounterTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}