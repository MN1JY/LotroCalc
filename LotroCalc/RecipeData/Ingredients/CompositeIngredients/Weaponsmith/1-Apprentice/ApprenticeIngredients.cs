using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._1_Apprentice
{
    public abstract class ApprenticeIngredients : WeaponsmithIngredients 
    {
        protected ApprenticeIngredients()
        {
            Tier = ProfessionTierEnum.Apprentice;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BronzeAxe.DisplayName, new BronzeAxe(1));
            dict.Add(BronzeBlade.DisplayName, new BronzeBlade(1));
            dict.Add(BronzeDagger.DisplayName, new BronzeDagger(1));
            dict.Add(BronzeGreatsword.DisplayName, new BronzeGreatsword(1));
            dict.Add(BronzeHilt.DisplayName, new BronzeHilt(1));
            dict.Add(BronzeSword.DisplayName, new BronzeSword(1));
            dict.Add(BronzeThrowingAxes.DisplayName, new BronzeThrowingAxes(1));
            dict.Add(HeavyBronzeAxe.DisplayName, new HeavyBronzeAxe(1));
            dict.Add(HeavyBronzeDagger.DisplayName, new HeavyBronzeDagger(1));
            dict.Add(HeavyBronzeGreatsword.DisplayName, new HeavyBronzeGreatsword(1));
            dict.Add(HeavyBronzeHeadsmansAxe.DisplayName, new HeavyBronzeHeadsmansAxe(1));
            dict.Add(HeavyBronzeMace.DisplayName, new HeavyBronzeMace(1));
            dict.Add(HeavyBronzeSword.DisplayName, new HeavyBronzeSword(1));
        }
    }
}