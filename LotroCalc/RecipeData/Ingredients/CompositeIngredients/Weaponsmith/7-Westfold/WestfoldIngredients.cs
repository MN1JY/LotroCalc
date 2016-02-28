using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._7_Westfold
{
    public abstract class WestfoldIngredients : WeaponsmithIngredients 
    {
        protected WestfoldIngredients()
        {
            Tier = ProfessionTierEnum.Westfold;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(CalenardThrowingHatchet.DisplayName, new CalenardThrowingHatchet(1));
            dict.Add(CalenardCaltrops.DisplayName, new CalenardCaltrops(1));
            dict.Add(CalenardMarbles.DisplayName, new CalenardMarbles(1));
            dict.Add(CalenardStrongTrap.DisplayName, new CalenardStrongTrap(1));
            dict.Add(SuperiorCalenardBearTrap.DisplayName, new SuperiorCalenardBearTrap(1));
            dict.Add(SuperiorCalenardLureTrap.DisplayName, new SuperiorCalenardLureTrap(1));
            dict.Add(SuperiorCalenardQuickTrap.DisplayName, new SuperiorCalenardQuickTrap(1));
            dict.Add(SuperiorCalenardTripwireTrap.DisplayName, new SuperiorCalenardTripwireTrap(1));
            dict.Add(CalenardDagger.DisplayName, new CalenardDagger(1));
            dict.Add(CalenardSword.DisplayName, new CalenardSword(1));
        }
    }
}