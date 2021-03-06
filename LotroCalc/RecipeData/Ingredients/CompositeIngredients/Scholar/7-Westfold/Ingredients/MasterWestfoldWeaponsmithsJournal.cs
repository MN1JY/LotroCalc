﻿
using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._7_Westfold
{
   public class MasterWestfoldWeaponsmithsJournal : WestfoldIngredients
   {
       public static string DisplayName = "Master Westfold Weaponsmith's Journal";

       public MasterWestfoldWeaponsmithsJournal(int count)
       {
           Name = DisplayName;
           QuantityRequested = count;
           QuantityProduced = 1;
           CraftingExperience = 14;
           SuperiorStudyRequired = true;
           IsUserRecipe = true;
       }

       public override object Clone()
       {
           return new MasterWestfoldWeaponsmithsJournal(QuantityRequested);
       }

       public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
       {
           var recipe = new SortedDictionary<string, Ingredient>();
           Ingredient ing;
           string ingName;

           ingName = TomeofWisdom.DisplayName;
           ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
           ing.QuantityRequested = 1 * QuantityRequested;
           recipe.Add(ingName, ing);

           ingName = ProspectorIngredients.CrackedRhiHelvarchSigil;
           ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
           ing.QuantityRequested = 1 * QuantityRequested;
           recipe.Add(ingName, ing);

           return recipe;
       }
   }
}
