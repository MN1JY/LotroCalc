using System.Collections.Generic;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._1_Apprentice
{
    public class BronzeIngots : ApprenticeIngredients
    {
        public static string DisplayName = "Bronze Ingot";

        public BronzeIngots(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 2;
            CraftingExperience = 6;
            ForgeRequired = true;
            IsUserRecipe = false;
        }

        public override object Clone()
        {
            return new BronzeIngots(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = CopperIngots.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = TinIngot.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}
