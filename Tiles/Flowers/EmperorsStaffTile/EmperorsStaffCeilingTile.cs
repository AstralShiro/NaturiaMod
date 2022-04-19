
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

using Naturia.Items.Flowers.EmperorsStaff;

namespace Naturia.Tiles.Flowers.EmperorsStaffTile
{
	public class EmperorsStaffCeilingTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoFail[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
		
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
			TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
			TileObjectData.newTile.AnchorBottom = default(AnchorData);
			TileObjectData.addTile(Type);
			soundType = SoundID.Grass;
			disableSmartCursor = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Emperor's Staff");
			AddMapEntry(new Color(255, 50, 50), name);
			//adjTiles = new int[] { TileID.Sunflower };
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(i * 16, j * 16, 32, 16, ModContent.ItemType<Items.Flowers.EmperorsStaff.EmperorsStaffCeiling>());
		}

	}
}