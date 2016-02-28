
using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._2_Journeyman;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._2_Journeyman
{
    public class SilverIngot : JourneymanIngredients
    {
        public static string DisplayName = "Silver Ingot";

        public SilverIngot(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 8;
            ForgeRequired = true;
            IsUserRecipe = false;
        }

        public override object Clone()
        {
            return new SilverIngot(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
        var recipe = new SortedDictionary<string, Ingredient>();
        Ingredient ing;
        string ingName;

        ingName = ProspectorIngredients.ChunksOfSilverOre;
        ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
        ing.QuantityRequested = 2 * QuantityRequested;
        recipe.Add(ingName, ing);

        return recipe;
        }
    }
}
