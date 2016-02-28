using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._1_Apprentice;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._2_Journeyman;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._3_Expert;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._4_Artisan;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._5_Master;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._6_Supreme;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._7_Westfold;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._8_Eastemnet;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._9_Westemnet;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar
{

    public abstract class ScholarCompIngredients : CompositeIngredients
    {
        public Boolean StudyRequired { get; protected set; }
        public Boolean SuperiorStudyRequired { get; protected set; }

        protected ScholarCompIngredients()
        {
            StudyRequired = false;
            SuperiorStudyRequired = false;
        }

        public override string FormatIngredientType()
        {
            return "Scholar";
        }

        public static void GetScholarRecipes(ref SortedDictionary<string, Ingredient> dict)
        {
            var dictTemp = new SortedDictionary<string, Ingredient>();

            GetScholarIngredients(ref dictTemp);

            foreach (Ingredient ing in dictTemp.Values)
                if (ing.IsUserRecipe)
                    dict.Add(ing.Name, ing);
        }

        public static void GetScholarIngredients(ref SortedDictionary<string, Ingredient> dict)
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