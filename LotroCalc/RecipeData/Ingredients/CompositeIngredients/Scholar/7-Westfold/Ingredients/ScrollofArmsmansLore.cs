
using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._7_Westfold;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._7_Westfold
{
   public class ScrollofArmsmansLore : WestfoldIngredients
   {
       public static string DisplayName = "Scroll of Armsman's Lore";

       public ScrollofArmsmansLore(int count)
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
           return new ScrollofArmsmansLore(QuantityRequested);
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

           return recipe;
       }
   }
}
