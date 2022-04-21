using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;

//Flowers
using Naturia.Tiles.Flowers.EmperorsStaffTile;
using Naturia.Tiles.Flowers.AmazonianLilyTile;

//Plants
using Naturia.Tiles.Plants.MonsteraAdansoniiTile;
using Naturia.Tiles.Plants.ZingiberSpectabileTile;
using Naturia.Tiles.Plants.RedGingerTile;

namespace Naturia.World
{
	public static class NaturiaGenPass
	{
		#region GENPASS: Flowers
		public static void FlowersPass(GenerationProgress progress)
		{
			progress.Message = "Naturia: Adding flowers...";
				///Emperor's Staff				
				{
				for (int i = 0; i < Main.maxTilesX * 252; i++) 
				{
					int num3 = WorldGen.genRand.Next(25, Main.maxTilesX - 250);
					int num4 = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY);
					Tile tile = Main.tile[num3, num4];
					if (tile.type == TileID.Mud && tile.active()) {
						WorldGen.PlaceObject(num3, num4 - 1, ModContent.TileType<EmperorsStaffTile>());
						NetMessage.SendObjectPlacment(-1, num3, num4 - 1, ModContent.TileType<EmperorsStaffTile>(), 0, 0, -1, -1);
					}
				}
				///Amazonian Lily
				for (int i = 0; i < Main.maxTilesX * 252; i++) 
				{
					int num3 = WorldGen.genRand.Next(25, Main.maxTilesX - 250);
					int num4 = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY);
					Tile tile = Main.tile[num3, num4];
					if (tile.type == TileID.Mud && tile.active()) {
						WorldGen.PlaceObject(num3, num4 - 1, ModContent.TileType<AmazonianLilyTile>());
						NetMessage.SendObjectPlacment(-1, num3, num4 - 1, ModContent.TileType<AmazonianLilyTile>(), 0, 0, -1, -1);
					}
				}
			}
			/*else if
			}*/
		}
		#endregion GENPASS: Flowers
		public static void PlantsPass(GenerationProgress progress)
		{
			progress.Message = "Naturia: Adding plants...";
				///Monstera Adansonii
			for (int i = 0; i < Main.maxTilesX * 252; i++) 
			{
				int num3 = WorldGen.genRand.Next(25, Main.maxTilesX - 250);
				int num4 = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY);
				Tile tile = Main.tile[num3, num4];
				if (tile.type == TileID.Mud && tile.active())
				{
					WorldGen.PlaceObject(num3, num4 - 1, ModContent.TileType<MonsteraAdansoniiTile>());
					NetMessage.SendObjectPlacment(-1, num3, num4 - 1, ModContent.TileType<MonsteraAdansoniiTile>(), 0, 0, -1, -1);
				}
			}
			///Zingiber Spectabile
			for (int i = 0; i < Main.maxTilesX * 252; i++) 
			{
				int num3 = WorldGen.genRand.Next(25, Main.maxTilesX - 250);
				int num4 = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY);
				Tile tile = Main.tile[num3, num4];
				if (tile.type == TileID.Mud && tile.active()) 
				{
					WorldGen.PlaceObject(num3, num4 - 1, ModContent.TileType<ZingiberSpectabileTile>());
					NetMessage.SendObjectPlacment(-1, num3, num4 - 1, ModContent.TileType<ZingiberSpectabileTile>(), 0, 0, -1, -1);
				}
			}
			///Red Ginger
			for (int i = 0; i < Main.maxTilesX * 252; i++) 
			{
				int num3 = WorldGen.genRand.Next(25, Main.maxTilesX - 250);
				int num4 = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY);
				Tile tile = Main.tile[num3, num4];
				if (tile.type == TileID.Mud && tile.active()) 
				{
					WorldGen.PlaceObject(num3, num4 - 1, ModContent.TileType<RedGingerTile>());
					NetMessage.SendObjectPlacment(-1, num3, num4 - 1, ModContent.TileType<RedGingerTile>(), 0, 0, -1, -1);
				}
			}
		}
	}
}
