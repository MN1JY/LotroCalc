using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._1_Apprentice;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._2_Journeyman;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._3_Expert;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._4_Artisan;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._5_Master;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._6_Supreme;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._7_Westfold;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._8_Eastemnet;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._9_Westemnet;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler
{
    public abstract class JewelerIngredients : CompositeIngredients
    {
        public Boolean WorkbenchRequired { get; protected set; }
        public Boolean SuperiorWorkbenchRequired { get; protected set; }

        protected JewelerIngredients()
        {
            SuperiorWorkbenchRequired = false;
            WorkbenchRequired = false;
        }

        public override string FormatIngredientType()
	    {
		    return "Jeweler";
	    }

        public static void GetJewelerRecipes(ref SortedDictionary<string, Ingredient> dict)
        {
            var dictTemp = new SortedDictionary<string, Ingredient>();

            GetJewelerIngredients(ref dictTemp);

            foreach (Ingredient ing in dictTemp.Values)
                if (ing.IsUserRecipe)
                    dict.Add(ing.Name, ing);
        }

        public static void GetJewelerIngredients(ref SortedDictionary<string, Ingredient> dict)
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