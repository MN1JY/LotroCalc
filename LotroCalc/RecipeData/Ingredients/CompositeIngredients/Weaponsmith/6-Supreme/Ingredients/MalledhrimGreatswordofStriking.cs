﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._6_Supreme
{
    public class MalledhrimGreatswordofStriking : SupremeIngredients
    {
        public static string DisplayName = "Malledhrim Greatsword of Striking";

        public MalledhrimGreatswordofStriking(int count)
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
            return new MalledhrimGreatswordofStriking(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = DarkIronHilt.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = DarkIronBlade.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = DarkSteelGuard.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}