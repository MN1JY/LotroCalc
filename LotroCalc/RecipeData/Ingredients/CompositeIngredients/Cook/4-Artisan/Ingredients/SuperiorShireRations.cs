﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._4_Artisan
{
    public class SuperiorShireRations : ArtisanIngredients
    {
        public static string DisplayName = "Superior Shire Rations (Guild)";

        public SuperiorShireRations(int count)
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
            return new SuperiorShireRations(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = MarinatedChickenCutlet.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = MediumArtisanRepast.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = FarmedIngredients.ShireApple;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.SharpCheeseWheel;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}
