using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._1_Apprentice
{
    public class BowlOfPorkStock : ApprenticeIngredients
    {
        public static string DisplayName = "Bowl Of Pork Stock";

        public BowlOfPorkStock(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            CraftingExperience = 4;
            IsUserRecipe = false;
        }

        public override object Clone()
        {
            return new BowlOfPorkStock(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = SupplierIngredients.BottleOfWater;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.PorkShank;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.ScoopOfLard;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}
