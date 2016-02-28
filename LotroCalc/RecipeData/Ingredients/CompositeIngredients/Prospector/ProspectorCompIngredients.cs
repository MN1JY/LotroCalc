using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._1_Apprentice;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._2_Journeyman;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._3_Expert;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._4_Artisan;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._5_Master;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._6_Supreme;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._7_Westfold;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._8_Eastemnet;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._9_Westemnet;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector
{

    public abstract class ProspectorCompIngredients : CompositeIngredients
    {
        public Boolean ForgeRequired { get; protected set; }
        public Boolean SuperiorForgeRequired { get; protected set; }

        protected ProspectorCompIngredients()
        {
            ForgeRequired = false;
            SuperiorForgeRequired = false;
        }

        public override string FormatIngredientType()
        {
            return "Prospecting";
        }

        public static void GetProspectingRecipes(ref SortedDictionary<string, Ingredient> dict)
        {
            var dictTemp = new SortedDictionary<string, Ingredient>();

            GetProspectingIngredients(ref dictTemp);

            foreach (Ingredient ing in dictTemp.Values)
                if (ing.IsUserRecipe)
                    dict.Add(ing.Name, ing);
        }

        public static void GetProspectingIngredients(ref SortedDictionary<string, Ingredient> dict)
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