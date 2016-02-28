using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._7_Westfold.Ingredients
{
    public class CupOfOatmeal : WestfoldIngredients
    {
        public static string DisplayName = "Cup Of Oatmeal";

        public CupOfOatmeal(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 2;
            IsUserRecipe = false;
        }

        public override object Clone()
        {
            return new CupOfOatmeal(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = FarmedIngredients.BundleOfBlackBarley;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}