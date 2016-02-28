using System.Collections.Generic;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._6_Supreme
{
    public abstract class SupremeIngredients : ProspectorCompIngredients
    {
        protected SupremeIngredients()
        {
            Tier = ProfessionTierEnum.Supreme;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(KhazadBronzeIngot.DisplayName, new KhazadBronzeIngot(1));
            dict.Add(KhazadCopperIngot.DisplayName, new KhazadCopperIngot(1));
            dict.Add(KhazadGoldIngot.DisplayName, new KhazadGoldIngot(1));
            dict.Add(KhazadIronIngot.DisplayName, new KhazadIronIngot(1));
            dict.Add(KhazadSteelIngot.DisplayName, new KhazadSteelIngot(1));
            dict.Add(KhazadTinIngot.DisplayName, new KhazadTinIngot(1));
            dict.Add(MithrilInfusedKhazadGoldIngot.DisplayName, new MithrilInfusedKhazadGoldIngot(1));
            dict.Add(MithrilInfusedKhazadSteelIngot.DisplayName, new MithrilInfusedKhazadSteelIngot(1));
        }
    }
}