using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EasyShards;

public class EasyShards : ModSystem
{
    private const string NonEvilSands = "EasyShards:Non-EvilSands";
    private const string EvilSands = "EasyShards:EvilSands";
    private const string EvilStones = "EasyShards:EvilStones";
    private const string EvilSpreaders = "EasyShards:EvilSpreaders";
    private const string PureHolySpreaders = "EasyShards:PureHolySpreaders";
    private const string EvilDrop = "EasyShards:EvilDrop";
    
    public override void AddRecipeGroups()
    {
        RecipeGroup nonEvilSand = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Non-Evil Sand",
            ItemID.SandBlock, ItemID.PearlsandBlock);
        RecipeGroup.RegisterGroup(NonEvilSands, nonEvilSand);

        RecipeGroup evilSand = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Sand",
            ItemID.CrimsandBlock, ItemID.EbonsandBlock);
        RecipeGroup.RegisterGroup(EvilSands, evilSand);
 
        RecipeGroup evilStone = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Stone",
            ItemID.CrimstoneBlock, ItemID.EbonstoneBlock);
        RecipeGroup.RegisterGroup(EvilStones, evilStone);

        RecipeGroup evilSpreader = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Spreader",
            ItemID.VilePowder, ItemID.ViciousPowder, ItemID.PurpleSolution, ItemID.RedSolution, ItemID.UnholyWater, ItemID.BloodWater);
        RecipeGroup.RegisterGroup(EvilSpreaders, evilSpreader);

        RecipeGroup pureSpreader = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Pure/Holy Spreader",
            ItemID.PurificationPowder, ItemID.GreenSolution, ItemID.BlueSolution, ItemID.HolyWater);
        RecipeGroup.RegisterGroup(PureHolySpreaders, pureSpreader);

        RecipeGroup evilDrop = new RecipeGroup(() => "Vertebrae or Rotten Chunk",
            ItemID.Vertebrae, ItemID.RottenChunk);
        RecipeGroup.RegisterGroup(EvilDrop, evilDrop);
    }

    public override void AddRecipes() 
    {
        Recipe lightShard = Recipe.Create(ItemID.LightShard);
        lightShard.AddRecipeGroup(NonEvilSands, 15);
        lightShard.AddIngredient(ItemID.PearlstoneBlock, 15);
        lightShard.AddIngredient(ItemID.PixieDust, 3);
        lightShard.AddIngredient(ItemID.SoulofLight);
        lightShard.AddTile(TileID.MythrilAnvil);
        lightShard.Register();

        Recipe darkShard = Recipe.Create(ItemID.DarkShard);
        darkShard.AddRecipeGroup(EvilSands, 15);
        darkShard.AddRecipeGroup(EvilStones, 15);
        darkShard.AddRecipeGroup(EvilDrop, 3);
        darkShard.AddIngredient(ItemID.SoulofNight);
        darkShard.AddTile(TileID.MythrilAnvil);
        darkShard.Register();

        Recipe lightToDark = Recipe.Create(ItemID.DarkShard, 2);
        lightToDark.AddRecipeGroup(EvilSpreaders);
        lightToDark.AddIngredient(ItemID.LightShard, 2);
        lightToDark.AddTile(TileID.MythrilAnvil);
        lightToDark.Register();

        Recipe darkToLight = Recipe.Create(ItemID.LightShard, 2);
        darkToLight.AddRecipeGroup(PureHolySpreaders);
        darkToLight.AddIngredient(ItemID.DarkShard, 2);
        darkToLight.AddTile(TileID.MythrilAnvil);
        darkToLight.Register();
    }
}