using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.SimpleIngredients
{
    public abstract class SimpleIngredients : Ingredient
    {
        public ProfessionTierEnum Tier;
        public static void GetSimpleIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            FarmedIngredients.GetFarmedIngredients(ref dict);
            ForesterIngredients.GetForesterIngredients(ref dict);
            FishingIngredients.GetFishingIngredients(ref dict);
            PickedIngredients.GePickedIngredients(ref dict);
            ProspectorIngredients.GetProspectorIngredients(ref dict);
            MobDropIngredients.GetMobDropIngredients(ref dict);
            ScholarIngredients.GetScholarIngredients(ref dict);
            TraderIngredients.GetTraderIngredients(ref dict);
            SupplierIngredients.GetSupplierIngredients(ref dict);
        }
    }
}