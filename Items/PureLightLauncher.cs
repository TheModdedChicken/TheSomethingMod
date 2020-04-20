using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheSomethingMod.Items
{
	public class PureLightLauncher : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pure Light Launcher"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This item launches Pure Light Energy.");
		}

		//public override string Texture => "Terraria/Item_" + ItemID.ShadowbeamStaff;

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.ShadowbeamStaff);
			//item.color = Color.Brown;
			item.damage = 500;
			item.width = 50;
			item.height = 50;
			item.useTime = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.mana = 0;
			item.useAmmo = mod.ItemType("PureLightEnergy");
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpectreBar, 50);
			recipe.AddIngredient(ItemID.SoulofLight, 200);
			recipe.AddIngredient(ItemID.Megashark, 1);
			recipe.AddIngredient(ItemID.Lens, 50);
			recipe.AddIngredient(ItemID.LightningBug, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}