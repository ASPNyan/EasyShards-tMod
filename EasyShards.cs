using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace EasyShards
{
    public class EasyShards : Mod
    {
    

        public override void AddRecipeGroups()
		{
			RecipeGroup nonEvilSand = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Non-Evil Sand", new int[]
    	    {
	    	    ItemID.SandBlock,
		        ItemID.PearlsandBlock
    	    });
            Terraria.RecipeGroup.RegisterGroup("EasyShards:Non-EvilSands", nonEvilSand);

            RecipeGroup evilSand = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Sand", new int[]
			{
                ItemID.CrimsandBlock,
                ItemID.EbonsandBlock
			});
	        RecipeGroup.RegisterGroup("EasyShards:EvilSands", evilSand);

			RecipeGroup evilStone = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Stone", new int[]
    	    {
	    	    ItemID.CrimstoneBlock,
		        ItemID.EbonstoneBlock
    	    });
	        RecipeGroup.RegisterGroup("EasyShards:EvilStones", evilStone);

			RecipeGroup evilSpreader = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Spreader", new int[]
    	    {
	    	    ItemID.VilePowder,
		        ItemID.ViciousPowder,
				ItemID.PurpleSolution,
				ItemID.RedSolution,
				ItemID.UnholyWater,
				ItemID.BloodWater
    	    });
	        RecipeGroup.RegisterGroup("EasyShards:EvilSpreaders", evilSpreader);

			RecipeGroup pureSpreader = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Pure/Holy Spreader", new int[]
    	    {
	    	    ItemID.PurificationPowder,
		        ItemID.ViciousPowder,
				ItemID.GreenSolution,
				ItemID.BlueSolution,
				ItemID.HolyWater
    	    });
	        RecipeGroup.RegisterGroup("EasyShards:PureHolySpreaders", pureSpreader);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 15);
            recipe.AddRecipeGroup("EasyShards:Non-EvilSands", 15);
			recipe.AddIngredient(ItemID.PixieDust, 3);
			recipe.AddIngredient(ItemID.SoulofLight, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.LightShard, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("EasyShards:EvilStones", 15);
            recipe.AddRecipeGroup("EasyShards:EvilSands", 15);
			recipe.AddIngredient(ItemID.Vertebrae, 3);
			recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.DarkShard, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("EasyShards:EvilStones", 15);
            recipe.AddRecipeGroup("EasyShards:EvilSands", 15);
			recipe.AddIngredient(ItemID.RottenChunk, 3);
			recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.DarkShard, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("EasyShards:EvilSpreaders", 1);
			recipe.AddIngredient(ItemID.LightShard, 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.DarkShard, 2);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("EasyShards:PureHolySpreaders", 1);
			recipe.AddIngredient(ItemID.DarkShard, 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.LightShard, 2);
			recipe.AddRecipe();
        }
    }
}