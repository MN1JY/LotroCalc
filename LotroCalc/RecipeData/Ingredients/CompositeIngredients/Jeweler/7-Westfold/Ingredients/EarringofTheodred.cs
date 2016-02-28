
using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._7_Westfold.Ingredients;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._7_Westfold;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._7_Westfold
{
   public class EarringofTheodred : WestfoldIngredients
   {
       public static string DisplayName = "Earring of Theodred";

       public EarringofTheodred(int count)
       {
           Name = DisplayName;
           QuantityRequested = count;
           QuantityProduced = 1;
           CraftingExperience = 14;
           SuperiorWorkbenchRequired = true;
           IsUserRecipe = true;
       }

       public override object Clone()
       {
           return new EarringofTheodred(QuantityRequested);
       }

       public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
       {
           var recipe = new SortedDictionary<string, Ingredient>();
           Ingredient ing;
           string ingName;

           ingName = HighQualityCalenardIngotsmelting.DisplayName;
           ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
           ing.QuantityRequested = 2 * QuantityRequested;
           recipe.Add(ingName, ing);

           ingName = PolishedGreenGarnet.DisplayName;
           ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
           ing.QuantityRequested = 1 * QuantityRequested;
           recipe.Add(ingName, ing);

           ingName = ProspectorIngredients.CrackedRhiHelvarchSigil;
           ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
           ing.QuantityRequested = 1 * QuantityRequested;
           recipe.Add(ingName, ing);

           ingName = LargeWestfoldSymbol.DisplayName;
           ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
           ing.QuantityRequested = 1 * QuantityRequested;
           recipe.Add(ingName, ing);

           return recipe;
       }
   }
}
