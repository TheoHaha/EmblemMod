// The source code of this mod has a lot of comments, most of which are directed to me, the author.

using Terraria.ModLoader;
using Terraria.ID; // So I can reference Terraria items by their name and instantly understand what's what.

namespace EmblemMod
{
    public class EmblemMod : Mod
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this); // Defining a 'ModRecipe' variable called 'recipe' so I can use it to add as many recipes as I want. Can be named whatever but it's best to be left as is.
			recipe.AddIngredient(ItemID.SorcererEmblem);
			recipe.AddIngredient(ItemID.WarriorEmblem);
			recipe.AddIngredient(ItemID.RangerEmblem);
			recipe.AddIngredient(null, "ThrowerEmblem");
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.SummonerEmblem);
			recipe.AddRecipe(); // Don't forget to put this in the end of every new recipe so that it's actually added in the game.
			
			recipe = new ModRecipe(this); // No need to write 'ModRecipe' again since the variable 'recipe' has already been defined.
			recipe.AddIngredient(ItemID.SummonerEmblem);
			recipe.AddIngredient(ItemID.WarriorEmblem);
			recipe.AddIngredient(ItemID.RangerEmblem);
			recipe.AddIngredient(null, "ThrowerEmblem");
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.SorcererEmblem);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SorcererEmblem);
			recipe.AddIngredient(ItemID.SummonerEmblem);
			recipe.AddIngredient(ItemID.RangerEmblem);
			recipe.AddIngredient(null, "ThrowerEmblem");
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.WarriorEmblem);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SorcererEmblem);
			recipe.AddIngredient(ItemID.WarriorEmblem);
			recipe.AddIngredient(ItemID.SummonerEmblem);
			recipe.AddIngredient(null, "ThrowerEmblem");
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.RangerEmblem);
			recipe.AddRecipe();

            // What's interesting about this method is that the order I put the "recipe.AddIngredient"s that's the order the appropriate ingredients appear in-game in the crafting menu.
            // The order of the materials doesn't matter and doesn't affect anything, I just find it pretty neat.
		}
	}
}
