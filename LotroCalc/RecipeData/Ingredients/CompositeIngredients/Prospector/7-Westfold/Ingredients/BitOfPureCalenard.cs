using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._7_Westfold.Ingredients
{
    public class BitOfPureCalenard : WestfoldIngredients
    {
        public static string DisplayName = "Bit Of Pure Calenard";

        public BitOfPureCalenard(int count)
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
            return new BitOfPureCalenard(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = ProspectorIngredients.ChunksOfHighGradeSkarnOre;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}