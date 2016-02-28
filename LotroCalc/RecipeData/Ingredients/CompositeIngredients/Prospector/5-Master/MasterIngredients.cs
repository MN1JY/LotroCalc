using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._5_Master
{
    public abstract class MasterIngredients : ProspectorCompIngredients
    {
        protected MasterIngredients()
        {
            Tier = ProfessionTierEnum.Master;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AncientIronIngot.DisplayName, new AncientIronIngot(1));
            dict.Add(AncientNickelIngot.DisplayName, new AncientNickelIngot(1));
            dict.Add(AncientSilverIngot.DisplayName, new AncientSilverIngot(1));
            dict.Add(AncientSteelIngot.DisplayName, new AncientSteelIngot(1));
            dict.Add(ElvenSteelIngot.DisplayName, new ElvenSteelIngot(1));

        }
    }
}