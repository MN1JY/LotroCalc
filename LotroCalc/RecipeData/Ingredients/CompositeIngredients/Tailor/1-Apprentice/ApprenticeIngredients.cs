using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._1_Apprentice
{
    public abstract class ApprenticeIngredients : TailorIngredients 
    {
        protected ApprenticeIngredients()
        {
            Tier = ProfessionTierEnum.Apprentice;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(HeavyClothArmour.DisplayName, new HeavyClothArmour(1));
            dict.Add(HeavyClothCloak.DisplayName, new HeavyClothCloak(1));
            dict.Add(HeavyClothGloves.DisplayName, new HeavyClothGloves(1));
            dict.Add(HeavyClothHat.DisplayName, new HeavyClothHat(1));
            dict.Add(HeavyClothLeggings.DisplayName, new HeavyClothLeggings(1));
            dict.Add(HeavyClothRobe.DisplayName, new HeavyClothRobe(1));
            dict.Add(HeavyClothShoes.DisplayName, new HeavyClothShoes(1));
            dict.Add(HeavyClothShoulderGuards.DisplayName, new HeavyClothShoulderGuards(1));
            dict.Add(HeavyPaddedArmour.DisplayName, new HeavyPaddedArmour(1));
            dict.Add(HeavyPaddedGloves.DisplayName, new HeavyPaddedGloves(1));
            dict.Add(HeavyPaddedHelm.DisplayName, new HeavyPaddedHelm(1));
            dict.Add(HeavyPaddedLeggings.DisplayName, new HeavyPaddedLeggings(1));
            dict.Add(HeavyPaddedShoes.DisplayName, new HeavyPaddedShoes(1));
            dict.Add(HeavyPaddedShoulderGuards.DisplayName, new HeavyPaddedShoulderGuards(1));
            dict.Add(LeatherBinding.DisplayName, new LeatherBinding(1));
            dict.Add(LeatherPad.DisplayName, new LeatherPad(1));
            dict.Add(PaddedArmour.DisplayName, new PaddedArmour(1));
            dict.Add(PaddedGloves.DisplayName, new PaddedGloves(1));
            dict.Add(PaddedHelm.DisplayName, new PaddedHelm(1));
            dict.Add(PaddedLeggings.DisplayName, new PaddedLeggings(1));
            dict.Add(PaddedShoes.DisplayName, new PaddedShoes(1));
            dict.Add(PaddedShoulderGuards.DisplayName, new PaddedShoulderGuards(1));
            dict.Add(RoughClothArmour.DisplayName, new RoughClothArmour(1));
            dict.Add(RoughClothCloak.DisplayName, new RoughClothCloak(1));
            dict.Add(RoughClothGloves.DisplayName, new RoughClothGloves(1));
            dict.Add(RoughClothHat.DisplayName, new RoughClothHat(1));
            dict.Add(RoughClothLeggings.DisplayName, new RoughClothLeggings(1));
            dict.Add(RoughClothRobe.DisplayName, new RoughClothRobe(1));
            dict.Add(RoughClothShoes.DisplayName, new RoughClothShoes(1));
            dict.Add(RoughClothShoulderGuards.DisplayName, new RoughClothShoulderGuards(1));
            dict.Add(SmallTreeShadowRug.DisplayName, new SmallTreeShadowRug(1));
        }
    }
}