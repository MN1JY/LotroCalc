﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._6_Supreme
{
    public class MalledhrimPauldronsoftheTwilight : SupremeIngredients
    {
        public static string DisplayName = "Malledhrim Pauldrons of the Twilight";

        public MalledhrimPauldronsoftheTwilight(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 14;
            SuperiorForgeRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new MalledhrimPauldronsoftheTwilight(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = BlackenedIronMesh.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = BlackenedIronPlate.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = BlackenedSteelBrace.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}