using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._7_Westfold.Ingredients
{
    public class PieceOfBrushedLeather : WestfoldIngredients
    {
        public static string DisplayName = "Piece Of Brushed Leather";

        public PieceOfBrushedLeather(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 6;
            WorkbenchRequired = true;
            IsUserRecipe = false;
        }

        public override object Clone()
        {
            return new PieceOfBrushedLeather(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = MobDropIngredients.LargeHide;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}