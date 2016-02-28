using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions
{
    public class FishingIngredients : SimpleIngredients
    {
        public static string LargemouthBass = "Largemouth Bass";
        public static string Catfish = "Catfish";
        public static string Dace = "Dace";
        public static string Flounder = "Flounder";
        public static string GoldenMullet = "Golden Mullet";
        public static string Perch = "Perch";

        public FishingIngredients(string ingredientName, int count, ProfessionTierEnum level)
	    {
		    Name = ingredientName;
		    QuantityRequested = count;
		    Tier = level;
	    }

	    public override object Clone()
	    {
            return new FishingIngredients(Name, QuantityRequested, Tier);
	    }


        public override string FormatIngredientType()
	    {
		    return "Fishing";
	    }


	    public static void GetFishingIngredients(ref SortedDictionary<string, Ingredient> dictIng)
	    {
		    //************************************
            ProfessionTierEnum level = ProfessionTierEnum.Apprentice;
            dictIng.Add(Dace, new MobDropIngredients(Dace, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Journeyman;
            dictIng.Add(Catfish, new MobDropIngredients(Catfish, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Expert;
            dictIng.Add(Perch, new MobDropIngredients(Perch, 1, level));

            //************************************
            level = ProfessionTierEnum.Artisan;
            dictIng.Add(GoldenMullet, new MobDropIngredients(GoldenMullet, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Master;
            dictIng.Add(LargemouthBass, new MobDropIngredients(LargemouthBass, 1, level));
            dictIng.Add(Flounder, new MobDropIngredients(Flounder, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Supreme;
        }
    }
}