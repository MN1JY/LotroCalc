﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._6_Supreme
{
    public class DefendersAxe : SupremeIngredients
    {
        public static string DisplayName = "Defender's Axe";

        public DefendersAxe(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 8;
            SuperiorForgeRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new DefendersAxe(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = DarkBronzeHilt.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = DarkBronzeBlade.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = DarkBronzeGuard.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}