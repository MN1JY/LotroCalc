using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._7_Westfold
{
    public class BirchCampfireKit : WestfoldIngredients
    {
        public static string DisplayName = "Birch Campfire Kit";

        public BirchCampfireKit(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 4;
            CraftingExperience = 6;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new BirchCampfireKit(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = ForesterIngredients.GnarledBirchBranches;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.KindlingMaterial;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}
