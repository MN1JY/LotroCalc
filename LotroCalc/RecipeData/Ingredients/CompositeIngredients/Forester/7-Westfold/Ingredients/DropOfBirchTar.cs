using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._7_Westfold.Ingredients
{
    public class DropOfBirchTar : WestfoldIngredients
    {
        public static string DisplayName = "Drop Of Birch-Tar";

        public DropOfBirchTar(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 6;
            WorkbenchRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new DropOfBirchTar(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = ForesterIngredients.BirchSapwoodBranch;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}