
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

using Naturia.Items.Plants.MonsteraAdansonii;

namespace Naturia.Tiles.Plants.MonsteraAdansoniiTile
{
	public class MonsteraAdansoniiTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoFail[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
			TileObjectData.newTile.UsesCustomCanPlace = true;
			TileObjectData.newTile.LavaDeath = true;
			TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
			TileObjectData.newTile.CoordinateWidth = 16;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
			
			TileObjectData.newTile.Width = 2;
			TileObjectData.newTile.Height = 3;

			soundType = SoundID.Grass;
			disableSmartCursor = true;

			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Monstera Adansonii");
			AddMapEntry(new Color(255, 255, 100), name);
			//adjTiles = new int[] { TileID.Sunflower };
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(i * 16, j * 16, 32, 16, ModContent.ItemType<Items.Plants.MonsteraAdansonii.MonsteraAdansonii>());
		}
	}
}