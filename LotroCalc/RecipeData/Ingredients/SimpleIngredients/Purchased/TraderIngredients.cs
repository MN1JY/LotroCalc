using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased
{
    public class TraderIngredients : SimpleIngredients
    {
        public static string LegendaryShard = "Legendary Shard";
        public static string LegendaryFragment = "Legendary Fragment";
        public static string CompendiumOfMiddleEarthVolume1 = "Compendium Of Middle-Earth Volume I";
        public static string CompendiumOfMiddleEarthVolume2 = "Compendium Of Middle-Earth Volume II";
        public static string CompendiumOfMiddleEarthVolume3 = "Compendium Of Middle-Earth Volume III";
        public static string CompendiumOfMiddleEarthVolume4 = "Compendium Of Middle-Earth Volume IV";

	    public TraderIngredients(string ingredientName, int count)
	    {
		    Name = ingredientName;
		    QuantityRequested = count;
	    }


	    public override object Clone()
	    {
		    return new TraderIngredients(Name, QuantityRequested);
	    }


        public override string FormatIngredientType()
	    {
		    return "Trader";
	    }


	    public static void GetTraderIngredients(ref SortedDictionary<string, Ingredient> dictIng)
	    {
            dictIng.Add(CompendiumOfMiddleEarthVolume1, new TraderIngredients(CompendiumOfMiddleEarthVolume1, 1));
            dictIng.Add(CompendiumOfMiddleEarthVolume2, new TraderIngredients(CompendiumOfMiddleEarthVolume2, 1));
            dictIng.Add(CompendiumOfMiddleEarthVolume3, new TraderIngredients(CompendiumOfMiddleEarthVolume3, 1));
            dictIng.Add(CompendiumOfMiddleEarthVolume4, new TraderIngredients(CompendiumOfMiddleEarthVolume4, 1));
            dictIng.Add(LegendaryShard, new TraderIngredients(LegendaryShard, 1));
            dictIng.Add(LegendaryFragment, new TraderIngredients(LegendaryFragment, 1));
        }
    }
}