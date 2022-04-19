using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;

using Naturia.NPCs.Insects.Mantis;

namespace Naturia.Tiles.TerrariumTile
{
	class PrayingMantisCageTile : ModTile
	{
		public override void SetDefaults() 
		{
			Main.tileLighted[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			animationFrameHeight = 36;
			TileObjectData.newTile.UsesCustomCanPlace = true;
			TileObjectData.newTile.Width = 3;
			TileObjectData.newTile.Height = 2;
			TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
			TileObjectData.newTile.CoordinateWidth = 16;
			TileObjectData.newTile.CoordinatePadding = 2;
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table | AnchorType.SolidTile | AnchorType.SolidWithTop, TileObjectData.newTile.Width, 0);
			TileObjectData.newTile.Origin = new Point16(0, 1);
			TileObjectData.addTile(Type);
			dustType = 13;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Critter Cage");
			AddMapEntry(new Color(200, 200, 200), name);
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = .33f;
			g = .025f;
			b = 1.15f;
		}

		public override void AnimateTile(ref int frame, ref int frameCounter)
		{
			frameCounter++;
			if (frameCounter >= 10) //replace 10 with duration of frame in ticks
			{
				frameCounter = 0;
				frame++;
				frame %= 21;
			}
		}


		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(i * 16, j * 16, 48, 32, ModContent.ItemType<PrayingMantisCageItem>());
		}
	}

	internal class PrayingMantisCageItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Praying Mantis Cage");
		}

		public override void SetDefaults() {
			//item.useStyle = 1;
			//item.useTurn = true;
			//item.useAnimation = 15;
			//item.useTime = 10;
			//item.autoReuse = true;
			//item.maxStack = 99;
			//item.consumable = true;
			//item.createTile = 285 + type - 2174;
			//item.width = 12;
			//item.height = 12;

			item.CloneDefaults(ItemID.GlowingSnailCage);
			item.createTile = ModContent.TileType<PrayingMantisCageTile>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Terrarium);
			recipe.AddIngredient(ModContent.ItemType<NPCs.Insects.Mantis.PrayingMantisItem>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
