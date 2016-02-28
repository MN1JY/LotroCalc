using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._1_Apprentice;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._2_Journeyman;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._3_Expert;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._4_Artisan;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._5_Master;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._6_Supreme;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._7_Westfold;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._8_Eastemnet;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._9_Westemnet;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor
{
    public abstract class TailorIngredients : CompositeIngredients 
    {
        public Boolean WorkbenchRequired { get; protected set; }
        public Boolean SuperiorWorkbenchRequired { get; protected set; }

        protected TailorIngredients()
        {
            WorkbenchRequired = false;
            SuperiorWorkbenchRequired = false;
        }

        public override string FormatIngredientType()
	    {
		    return "Tailoring";
	    }

        public static void GetTailorRecipes(ref SortedDictionary<string, Ingredient> dict)
        {
            var dictTemp = new SortedDictionary<string, Ingredient>();

            GetTailorIngredients(ref dictTemp);

            foreach (Ingredient ing in dictTemp.Values)
                if (ing.IsUserRecipe)
                    dict.Add(ing.Name, ing);
        }

        public static void GetTailorIngredients(ref SortedDictionary<string, Ingredient> dict)
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