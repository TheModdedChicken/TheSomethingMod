using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheSomethingMod.Items
{
    public class PureLightEnergy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pure Light Energy"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This item is ammo for the Pure Light Launcher.");
		}

		public override void SetDefaults()
		{
			item.ammo = mod.ItemType("PureLightEnergy");
			item.consumable = true;
			item.maxStack = 99999;
			item.width = 50;
			item.height = 50;
			item.value = 10000;
			item.rare = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 25);
			recipe.AddIngredient(ItemID.Lens, 25);
			recipe.AddIngredient(ItemID.LightningBug, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
