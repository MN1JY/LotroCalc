using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._1_Apprentice;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._2_Journeyman;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._3_Expert;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._4_Artisan;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._5_Master;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._6_Supreme;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._7_Westfold;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._8_Eastemnet;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._9_Westemnet;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith
{
    public abstract class WeaponsmithIngredients : CompositeIngredients 
    {
        public Boolean ForgeRequired { get; protected set; }
        public Boolean SuperiorForgeRequired { get; protected set; }

        protected WeaponsmithIngredients()
        {
            ForgeRequired = false;
            SuperiorForgeRequired = false;
        }

        public override string FormatIngredientType()
	    {
		    return "Weaponsmith";
	    }

        public static void GetWeaponsmithRecipes(ref SortedDictionary<string, Ingredient> dict)
        {
            var dictTemp = new SortedDictionary<string, Ingredient>();

            GetWeaponsmithIngredients(ref dictTemp);

            foreach (Ingredient ing in dictTemp.Values)
                if (ing.IsUserRecipe)
                    dict.Add(ing.Name, ing);
        }

        public static void GetWeaponsmithIngredients(ref SortedDictionary<string, Ingredient> dict)
	    {
            ApprenticeIngredients.GetIngredients(ref dict);
            JourneymanIngredients.GetIngredients(ref dict);
            ExpertIngredients.GetIngredients(ref dict);
            ArtisanIngredients.GetIngredients(ref dict);
            MasterIngredients.GetIngredients(ref dict);
            SupremeIngredients.GetIngredients(ref dict);
            WestfoldIngredients.GetIngredients(ref dict);
            EastemnetIngredients.GetIngredients(ref dict);
            WestemnetIngredients.GetIngredients(ref dict);
        }
    }
}