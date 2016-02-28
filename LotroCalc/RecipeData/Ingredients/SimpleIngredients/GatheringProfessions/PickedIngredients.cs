using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions
{
    public class PickedIngredients : SimpleIngredients
    {
        public static string IndigoPlant = "Indigo Plant";
        public static string WoadPlant = "Woad Plant";

        public PickedIngredients(string ingredientName, int count, ProfessionTierEnum level)
	    {
		    Name = ingredientName;
		    QuantityRequested = count;
		    Tier = level;
	    }

	    public override object Clone()
	    {
            return new PickedIngredients(Name, QuantityRequested, Tier);
	    }


        public override string FormatIngredientType()
	    {
		    return "Picked";
	    }


        public static void GePickedIngredients(ref SortedDictionary<string, Ingredient> dictIng)
        {
            //************************************
            ProfessionTierEnum level = ProfessionTierEnum.Apprentice;


            //************************************
            level = ProfessionTierEnum.Journeyman;

            //************************************
            level = ProfessionTierEnum.Expert;
            dictIng.Add(WoadPlant, new PickedIngredients(WoadPlant, 1, level));

            //************************************
            level = ProfessionTierEnum.Artisan;
            dictIng.Add(IndigoPlant, new PickedIngredients(IndigoPlant, 1, level));

            //************************************
            level = ProfessionTierEnum.Master;

            //************************************
            level = ProfessionTierEnum.Supreme;
        }
    }
}