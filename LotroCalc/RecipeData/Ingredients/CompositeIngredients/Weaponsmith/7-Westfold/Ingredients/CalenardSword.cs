﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._7_Westfold.Ingredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._7_Westfold
{
    public class CalenardSword : WestfoldIngredients
    {
        public static string DisplayName = "Calenard Sword";

        public CalenardSword(int count)
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
            return new CalenardSword(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = LowQualityCalenardIngot.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}


