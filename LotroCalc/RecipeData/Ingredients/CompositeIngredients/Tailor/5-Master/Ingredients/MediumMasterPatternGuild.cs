﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._5_Master;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._5_Master
{
    public class MediumMasterPatternGuild : MasterIngredients
    {
        public static string DisplayName = "Medium Master Pattern (Guild)";

        public MediumMasterPatternGuild(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 35;
            SuperiorWorkbenchRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new MediumMasterPatternGuild(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = SupplierIngredients.BoltOfElvenCloth;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 2 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = PieceOfExceptionalLeather.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 9 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}