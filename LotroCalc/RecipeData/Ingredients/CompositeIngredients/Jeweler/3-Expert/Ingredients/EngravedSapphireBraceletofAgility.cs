﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._3_Expert;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._3_Expert
{
    public class EngravedSapphireBraceletofAgility : ExpertIngredients
    {
        public static string DisplayName = "Engraved Sapphire Bracelet of Agility";

        public EngravedSapphireBraceletofAgility(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 12;
            WorkbenchRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new EngravedSapphireBraceletofAgility(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = GoldIngot.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 4 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = MobDropIngredients.RubyShard;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = PolishedSapphire.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}