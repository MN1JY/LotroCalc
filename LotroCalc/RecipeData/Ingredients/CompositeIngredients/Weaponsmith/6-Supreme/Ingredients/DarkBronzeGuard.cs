﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._6_Supreme;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._6_Supreme
{
    public class DarkBronzeGuard : SupremeIngredients
    {
        public static string DisplayName = "Dark Bronze Guard";

        public DarkBronzeGuard(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 4;
            SuperiorForgeRequired = true;
            IsUserRecipe = false;
        }

        public override object Clone()
        {
            return new DarkBronzeGuard(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = KhazadBronzeIngot.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 3 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}