using Microsoft.Win32;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

using Naturia.World;

namespace Naturia
{
	public class MyWorld : ModWorld
	{
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{

			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Final Cleanup"));
			if (ShiniesIndex == -1) {
				// Shinies pass removed by some other mod.
				return;
			}

			tasks.Insert(ShiniesIndex + 1, new PassLegacy("Putting Flowers", NaturiaGenPass.FlowersPass));

			tasks.Insert(ShiniesIndex + 1, new PassLegacy("Putting Plants", NaturiaGenPass.PlantsPass));
		}
	}
}