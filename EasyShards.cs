using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace EasyShards
{
    public class EasyShards : ModSystem
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
				ItemID.GreenSolution,
				ItemID.BlueSolution,
				ItemID.HolyWater
    	    });
	        RecipeGroup.RegisterGroup("EasyShards:PureHolySpreaders", pureSpreader);

			RecipeGroup evilDrop = new RecipeGroup(() => "Vertebrae or Rotten Chunk", new int[] {
				ItemID.Vertebrae,
				ItemID.RottenChunk
			});
			RecipeGroup.RegisterGroup("EasyShards:EvilDrop", evilDrop);
        }

        public override void AddRecipes() {
				
            Recipe lightShard = Recipe.Create(ItemID.LightShard, 1);
            lightShard.AddIngredient(ItemID.PearlstoneBlock, 15);
            lightShard.AddRecipeGroup("EasyShards:Non-EvilSands", 15);
			lightShard.AddIngredient(ItemID.PixieDust, 3);
			lightShard.AddIngredient(ItemID.SoulofLight, 1);
			lightShard.AddTile(TileID.MythrilAnvil);
			lightShard.Register();

			Recipe darkShard = Recipe.Create(ItemID.DarkShard, 1);
			darkShard.AddRecipeGroup("EasyShards:EvilStones", 15);
            darkShard.AddRecipeGroup("EasyShards:EvilSands", 15);
			darkShard.AddRecipeGroup("EasyShards:EvilDrop", 3);
			darkShard.AddIngredient(ItemID.SoulofNight, 1);
			darkShard.AddTile(TileID.MythrilAnvil);
			darkShard.Register();

			Recipe lightToDark = Recipe.Create(ItemID.DarkShard, 2);
			lightToDark.AddRecipeGroup("EasyShards:EvilSpreaders", 1);
			lightToDark.AddIngredient(ItemID.LightShard, 2);
			lightToDark.AddTile(TileID.MythrilAnvil);
			lightToDark.Register();

			Recipe darkToLight = Recipe.Create(ItemID.LightShard, 2);
			darkToLight.AddRecipeGroup("EasyShards:PureHolySpreaders", 1);
			darkToLight.AddIngredient(ItemID.DarkShard, 2);
			darkToLight.AddTile(TileID.MythrilAnvil);
			darkToLight.Register();
        }
    }
}