﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._4_Artisan
{
    public class BowChantShieldbane : ArtisanIngredients
    {
        public static string DisplayName = "Bow Chant: Shield-bane";

        public BowChantShieldbane(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 3;
            CraftingExperience = 4;
            SuperiorStudyRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new BowChantShieldbane(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = ScholarIngredients.FragmentOfDunedainScript;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.QuillAndInkSet;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}



