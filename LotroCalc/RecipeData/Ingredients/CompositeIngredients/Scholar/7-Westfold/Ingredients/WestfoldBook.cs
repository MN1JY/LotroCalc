using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._7_Westfold.Ingredients
{
    public class WestfoldBook : WestfoldIngredients
    {
        public static string DisplayName = "Westfold Book";

        public WestfoldBook(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 8;
            SuperiorStudyRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new WestfoldBook(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = ScrollOfInsight.DisplayName;
            ing = (Ingredient) DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 2*QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}