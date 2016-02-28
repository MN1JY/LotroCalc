using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._1_Apprentice;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._2_Journeyman;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._3_Expert;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._4_Artisan;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._5_Master;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._6_Supreme;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._7_Westfold;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._8_Eastemnet;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._9_Westemnet;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook
{

    public abstract class CookIngredients : CompositeIngredients
    {
        public Boolean SuperiorOvenRequired { get; protected set; }
        public Boolean OvenRequired { get; protected set; }
        public Boolean CampFireRequired { get; protected set; }

        protected CookIngredients()
        {
            SuperiorOvenRequired = false;
            OvenRequired = false;
            CampFireRequired = false;
        }

        public override string FormatIngredientType()
	    {
		    return "Cooking";
	    }

        public static void GetCookingRecipes(ref SortedDictionary<string, Ingredient> dict)
        {
            var dictTemp = new SortedDictionary<string, Ingredient>();

            GetCookingIngredients(ref dictTemp);

            foreach (Ingredient ing in dictTemp.Values)
                if (ing.IsUserRecipe)
                    dict.Add(ing.Name, ing);
        }

        public static void GetCookingIngredients(ref SortedDictionary<string, Ingredient> dict)
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