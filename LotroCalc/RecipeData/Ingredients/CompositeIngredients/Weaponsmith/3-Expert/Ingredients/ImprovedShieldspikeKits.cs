﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._3_Expert;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._3_Expert
{
    public class ImprovedShieldspikeKits : ExpertIngredients
    {
        public static string DisplayName = "Improved Shield-spike Kits";

        public ImprovedShieldspikeKits(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 2;
            CraftingExperience = 6;
            ForgeRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new ImprovedShieldspikeKits(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = RichIronIngot.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.HighGradeSteelSpikeMould;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}