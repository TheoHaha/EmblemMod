using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EmblemMod.Items
{
	public class ThrowerEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thrower Emblem");
			Tooltip.SetDefault("15% increased throwing damage");
		}
		public override void SetDefaults()
		{
			item.rare = 4;
			item.accessory = true;
			item.value = Item.sellPrice(0, 2, 0, 0);
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.thrownDamage += 0.15f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); //Instead of 'this' I have to write 'mod' in the parenthesis. This is because we're in 'ModItem' and not 'Mod'.
			recipe.AddIngredient(ItemID.SorcererEmblem);
			recipe.AddIngredient(ItemID.WarriorEmblem);
			recipe.AddIngredient(ItemID.RangerEmblem);
			recipe.AddIngredient(ItemID.SummonerEmblem);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}