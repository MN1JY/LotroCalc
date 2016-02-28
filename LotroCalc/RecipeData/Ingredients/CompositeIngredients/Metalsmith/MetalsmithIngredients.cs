using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._1_Apprentice;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._2_Journeyman;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._3_Expert;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._4_Artisan;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._5_Master;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._6_Supreme;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._7_Westfold;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._8_Eastemnet;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._9_Westemnet;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith
{
    public abstract class MetalsmithIngredients : CompositeIngredients
    {
        public Boolean ForgeRequired { get; protected set; }
        public Boolean SuperiorForgeRequired { get; protected set; }

        protected MetalsmithIngredients()
        {
            SuperiorForgeRequired = false;
        }

        public override string FormatIngredientType()
	    {
		    return "Metalworking";
	    }

        public static void GetMetalworkingRecipes(ref SortedDictionary<string, Ingredient> dict)
        {
            var dictTemp = new SortedDictionary<string, Ingredient>();

            GetMetalworkingIngredients(ref dictTemp);

            foreach (Ingredient ing in dictTemp.Values)
                if (ing.IsUserRecipe)
                    dict.Add(ing.Name, ing);
        }

        public static void GetMetalworkingIngredients(ref SortedDictionary<string, Ingredient> dict)
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