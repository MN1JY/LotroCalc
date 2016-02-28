using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._1_Apprentice
{
    public class BarleySoup : ApprenticeIngredients
    {
        public static string DisplayName = "Barley Soup";

        public BarleySoup(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 6;
            OvenRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new BarleySoup(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = FarmedIngredients.BundleOfSpringBarley;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = BowlOfPorkStock.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}
