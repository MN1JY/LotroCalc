﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._6_Supreme
{
    public class PotentAthelasEssence : SupremeIngredients
    {
        public static string DisplayName = "Potent Athelas Essence (Guild)";

        public PotentAthelasEssence(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 25;
            CraftingExperience = 12;
            SuperiorStudyRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new PotentAthelasEssence(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = SupplierIngredients.LargeGlassPhial;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = LargeSupremeScroll.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = ScholarIngredients.TatteredKhuzdulParchment;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.BundleOfPotentAthelasLeaves;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}