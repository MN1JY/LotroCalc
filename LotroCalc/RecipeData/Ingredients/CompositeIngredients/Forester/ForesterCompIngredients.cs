using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._1_Apprentice;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._2_Journeyman;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._3_Expert;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._4_Artisan;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._5_Master;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._6_Supreme;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._7_Westfold;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._8_Eastemnet;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._9_Westemnet;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester
{
    public abstract class ForesterCompIngredients : CompositeIngredients
    {
        public Boolean WorkbenchRequired { get; protected set; }
        public Boolean SuperiorWorkbenchRequired { get; protected set; }

        protected ForesterCompIngredients()
        {
            SuperiorWorkbenchRequired = true;
        }

        public override string FormatIngredientType()
	    {
		    return "Forester";
	    }

        public static void GetForesterRecipes(ref SortedDictionary<string, Ingredient> dict)
        {
            var dictTemp = new SortedDictionary<string, Ingredient>();

            GetForesterIngredients(ref dictTemp);

            foreach (Ingredient ing in dictTemp.Values)
                if (ing.IsUserRecipe)
                    dict.Add(ing.Name, ing);
        }

        public static void GetForesterIngredients(ref SortedDictionary<string, Ingredient> dict)
	    {
            ApprenticeIngredients.GetIngredients(ref dict);
            JourneymanIngredients.GetIngredients(ref dict);
            ExpertIngredients.GetIngredients(ref dict);
            ArtisanIngredients.GetIngredients(ref dict);
            MasterIngredients.GetIngredients(ref dict);
            SupremeIngredients.GetIngredients(ref dict);
            WestfoldIngredients.GetIngredients(ref dict);
            EastemnetIngredients.GetIngredients(ref dict);
            WestemnetIngredients.GetIngredients(ref dict);
        }
    }
}