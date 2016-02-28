using System.Collections.Generic;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions
{
    public class ProspectorIngredients : SimpleIngredients
    {
        public static string Adamant = "Adamant";
        public static string Agate = "Agate";
        public static string Amethyst = "Amethyst";
        public static string AncientNickelOre = "Ancient Nickel Ore";
        public static string Aquamarine = "Aquamarine";
        public static string Beryl = "Beryl";
        public static string Bloodstone = "Bloodstone";
        public static string ChunksOfAncientIronOre = "Chunk Of Ancient Iron Ore";
        public static string ChunksOfAncientNickelOre = "Chunks Of Ancient Nickel Ore";
	    public static string ChunksOfAncientSilverOre = "Chunk Of Ancient Silver Ore";
	    public static string ChunksOfBarrowIronOre = "Chunk Of Barrow-iron Ore";
	    public static string ChunksOfCopperOre = "Chunk Of Copper Ore";
        public static string ChunksOfDwarfIronOre = "Chunk Of Dwarf-iron Ore";
        public static string ChunksOfEorlingasSkarn = "Chunk Of Eorlingas Skarn";
        public static string ChunksOfGoldOre = "Chunk Of Gold Ore";
        public static string ChunksOfHighGradeSkarnOre = "Chunk Of High-Grade Skarn Ore";
        public static string ChunksOfHighGradeRiddermarkOre = "Chunk Of High-Grade Riddermark Ore";
        public static string ChunkOfLime = "Chunk Of Lime";
        public static string ChunksOfLowGradeSkarnOre = "Chunk Of Low-Grade Skarn Ore";
        public static string ChunksOfLowGradeRiddermarkOre = "Chunk Of Low-Grade Riddermark Ore";
        public static string ChunksOfKhazadCopperOre = "Chunk Of Khazad-Copper Ore";
        public static string ChunksOfKhazadGoldOre = "Chunk Of Khazad-Gold Ore";
	    public static string ChunksOfKhazadIronOre = "Chunk Of Khazad-iron Ore";
	    public static string ChunksOfKhazadTinOre = "Chunk Of Khazad-Tin Ore";
	    public static string ChunksOfPlatinumOre = "Chunk Of Platinum Ore";
	    public static string ChunksOfRichIronOre = "Chunk Of Rich Iron Ore";
	    public static string ChunksOfSilverOre = "Chunk Of Silver Ore";
        public static string ChunksOfTinOre = "Chunk Of Tin Ore";
        public static string CrackedRhiHelvarchSigil = "Cracked Rhi Helvarch Sigil";
        public static string DawnRose = "Dawn-rose";
        public static string Emerald = "Emerald";
        public static string GreenGarnet = "Green Garnet";
        public static string Moonstone = "Moonstone";
        public static string Opal = "Opal";
        public static string PieceOfSienna = "Piece Of Sienna";
        public static string PieceOfUmber = "Piece Of Umber";
        public static string PileOfCopperSalts = "Pile Of Copper Salts";
        public static string PileOfAncientIronOxide = "Pile Of Ancient Iron Oxide";
        public static string RedAgate = "Red Agate";
        public static string Ruby = "Ruby";
        public static string Sapphire = "Sapphire";

        public ProspectorIngredients(string ingredientName, int count, ProfessionTierEnum level)
	    {
		    Name = ingredientName;
		    QuantityRequested = count;
		    Tier = level;
	    }


	    public override object Clone()
	    {
            return new ProspectorIngredients(Name, QuantityRequested, Tier);
	    }


        public override string FormatIngredientType()
	    {
		    return "Prospector";
	    }


	    public static void GetProspectorIngredients(ref SortedDictionary<string, Ingredient> dictIng)
	    {
	        //************************************
		    ProfessionTierEnum level = ProfessionTierEnum.Apprentice;
            dictIng.Add(Agate, new ProspectorIngredients(Agate, 1, level));
            dictIng.Add(Amethyst, new ProspectorIngredients(Amethyst, 1, level));
            dictIng.Add(ChunksOfCopperOre, new ProspectorIngredients(ChunksOfCopperOre, 1, level));
            dictIng.Add(ChunksOfTinOre, new ProspectorIngredients(ChunksOfTinOre, 1, level));
            dictIng.Add(PileOfCopperSalts, new ProspectorIngredients(PileOfCopperSalts, 1, level));
            dictIng.Add(PieceOfSienna, new ProspectorIngredients(PieceOfSienna, 1, level));
            dictIng.Add(PieceOfUmber, new ProspectorIngredients(PieceOfUmber, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Journeyman;
            dictIng.Add(Bloodstone, new ProspectorIngredients(Bloodstone, 1, level));
            dictIng.Add(ChunksOfBarrowIronOre, new ProspectorIngredients(ChunksOfBarrowIronOre, 1, level));
            dictIng.Add(ChunksOfSilverOre, new ProspectorIngredients(ChunksOfSilverOre, 1, level));
            dictIng.Add(Opal, new ProspectorIngredients(Opal, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Expert;
            dictIng.Add(ChunksOfGoldOre, new ProspectorIngredients(ChunksOfGoldOre, 1, level));
            dictIng.Add(ChunksOfRichIronOre, new ProspectorIngredients(ChunksOfRichIronOre, 1, level));
            dictIng.Add(Ruby, new ProspectorIngredients(Ruby, 1, level));
            dictIng.Add(Sapphire, new ProspectorIngredients(Sapphire, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Artisan;
            dictIng.Add(Adamant, new ProspectorIngredients(Adamant, 1, level));
            dictIng.Add(ChunksOfPlatinumOre, new ProspectorIngredients(ChunksOfPlatinumOre, 1, level));
            dictIng.Add(ChunksOfDwarfIronOre, new ProspectorIngredients(ChunksOfDwarfIronOre, 1, level));
            dictIng.Add(PileOfAncientIronOxide, new ProspectorIngredients(PileOfAncientIronOxide, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Master;
            dictIng.Add(AncientNickelOre, new ProspectorIngredients(AncientNickelOre, 1, level));
            dictIng.Add(Beryl, new ProspectorIngredients(Beryl, 1, level));
            dictIng.Add(ChunksOfAncientIronOre, new ProspectorIngredients(ChunksOfAncientIronOre, 1, level));
            dictIng.Add(ChunksOfAncientNickelOre, new ProspectorIngredients(ChunksOfAncientNickelOre, 1, level));
            dictIng.Add(ChunksOfAncientSilverOre, new ProspectorIngredients(ChunksOfAncientSilverOre, 1, level));
            dictIng.Add(Moonstone, new ProspectorIngredients(Moonstone, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Supreme;
            dictIng.Add(Aquamarine, new ProspectorIngredients(Aquamarine, 1, level));
            dictIng.Add(ChunkOfLime, new ProspectorIngredients(ChunkOfLime, 1, level));
            dictIng.Add(ChunksOfKhazadCopperOre, new ProspectorIngredients(ChunksOfKhazadCopperOre, 1, level));
            dictIng.Add(ChunksOfKhazadGoldOre, new ProspectorIngredients(ChunksOfKhazadGoldOre, 1, level));
            dictIng.Add(ChunksOfKhazadIronOre, new ProspectorIngredients(ChunksOfKhazadIronOre, 1, level));
            dictIng.Add(ChunksOfKhazadTinOre, new ProspectorIngredients(ChunksOfKhazadTinOre, 1, level));
            dictIng.Add(DawnRose, new ProspectorIngredients(DawnRose, 1, level));

            //************************************
            level = ProfessionTierEnum.Westfold;
            dictIng.Add(GreenGarnet, new ProspectorIngredients(GreenGarnet, 1, level));
            dictIng.Add(ChunksOfLowGradeSkarnOre, new ProspectorIngredients(ChunksOfLowGradeSkarnOre, 1, level));
            dictIng.Add(ChunksOfHighGradeSkarnOre, new ProspectorIngredients(ChunksOfHighGradeSkarnOre, 1, level));
            dictIng.Add(CrackedRhiHelvarchSigil, new ProspectorIngredients(CrackedRhiHelvarchSigil, 1, level));

            //************************************
            level = ProfessionTierEnum.Eastemnet;
            dictIng.Add(RedAgate, new ProspectorIngredients(RedAgate, 1, level));
            dictIng.Add(ChunksOfLowGradeRiddermarkOre, new ProspectorIngredients(ChunksOfLowGradeRiddermarkOre, 1, level));
            dictIng.Add(ChunksOfHighGradeRiddermarkOre, new ProspectorIngredients(ChunksOfHighGradeRiddermarkOre, 1, level));

            //************************************
            level = ProfessionTierEnum.Westemnet;
            dictIng.Add(ChunksOfEorlingasSkarn, new ProspectorIngredients(ChunksOfEorlingasSkarn, 1, level));
            dictIng.Add(Emerald, new ProspectorIngredients(Emerald, 1, level));
        }

    }
}