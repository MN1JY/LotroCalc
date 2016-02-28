using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._6_Supreme
{
    public class SuperiorRackOfLambWithMintSauce : SupremeIngredients
    {
        public static string DisplayName = "Superior Rack Of Lamb With Mint Sauce (Guild)";

        public SuperiorRackOfLambWithMintSauce(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 25;
            CraftingExperience = 12;
            SuperiorOvenRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new SuperiorRackOfLambWithMintSauce(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = LargeSupremeRepast.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = JarOfMintSauce.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.RackofLamb;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.PinchOfMixedHerbs;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}
