using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients
{
    public abstract class CompositeIngredients : Ingredient
    {
        public ProfessionTierEnum Tier;

        public int QuantityProduced { get; protected set; }
        public int CraftingExperience;

        public abstract SortedDictionary<string, Ingredient> GetRecipeIngredients();

        protected CompositeIngredients()
        {
            QuantityProduced = 1;
        }

        public static void GetCompositeRecipes(ref SortedDictionary<string, Ingredient> dict)
	    {
            CookIngredients.GetCookingRecipes(ref dict);
            ProspectorCompIngredients.GetProspectingRecipes(ref dict);
            ForesterCompIngredients.GetForesterRecipes(ref dict);
            MetalsmithIngredients.GetMetalworkingRecipes(ref dict);
            ScholarCompIngredients.GetScholarRecipes(ref dict);
            JewelerIngredients.GetJewelerRecipes(ref dict);
            TailorIngredients.GetTailorRecipes(ref dict);
            WeaponsmithIngredients.GetWeaponsmithRecipes(ref dict);
            WoodworkerIngredients.GetWoodworkerRecipes(ref dict);
	    }

        public static void GetCompositeIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            CookIngredients.GetCookingIngredients(ref dict);
            ProspectorCompIngredients.GetProspectingIngredients(ref dict);
            ForesterCompIngredients.GetForesterIngredients(ref dict);
            MetalsmithIngredients.GetMetalworkingIngredients(ref dict);
            ScholarCompIngredients.GetScholarIngredients(ref dict);
            JewelerIngredients.GetJewelerIngredients(ref dict);
            TailorIngredients.GetTailorIngredients(ref dict);
            WeaponsmithIngredients.GetWeaponsmithIngredients(ref dict);
            WoodworkerIngredients.GetWoodworkerIngredients(ref dict);
        }

    }
}