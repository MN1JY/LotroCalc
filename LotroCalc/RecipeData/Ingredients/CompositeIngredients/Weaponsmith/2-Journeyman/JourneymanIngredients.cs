using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._2_Journeyman
{
    public abstract class JourneymanIngredients : WeaponsmithIngredients 
    {
        protected JourneymanIngredients()
        {
            Tier = ProfessionTierEnum.Journeyman;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BalancedSteelHilt.DisplayName, new BalancedSteelHilt(1));
            dict.Add(BearTrap.DisplayName, new BearTrap(1));
            dict.Add(Caltrops.DisplayName, new Caltrops(1));
            dict.Add(QuickTrap.DisplayName, new QuickTrap(1));
            dict.Add(BasicShieldspikeKits.DisplayName, new BasicShieldspikeKits(1));
            dict.Add(StunDust.DisplayName, new StunDust(1));
            dict.Add(Doubletraps.DisplayName, new Doubletraps(1));
            dict.Add(ForgedSteelAxe.DisplayName, new ForgedSteelAxe(1));
            dict.Add(ForgedSteelDagger.DisplayName, new ForgedSteelDagger(1));
            dict.Add(ForgedSteelGreatsword.DisplayName, new ForgedSteelGreatsword(1));
            dict.Add(ForgedSteelHalberd.DisplayName, new ForgedSteelHalberd(1));
            dict.Add(ForgedSteelHeadsmansAxe.DisplayName, new ForgedSteelHeadsmansAxe(1));
            dict.Add(ForgedSteelMace.DisplayName, new ForgedSteelMace(1));
            dict.Add(ForgedSteelSword.DisplayName, new ForgedSteelSword(1));
            dict.Add(JourneymanWesternesseShieldspikeKits.DisplayName, new JourneymanWesternesseShieldspikeKits(1));
            dict.Add(HeavyIronAxe.DisplayName, new HeavyIronAxe(1));
            dict.Add(HeavyIronDagger.DisplayName, new HeavyIronDagger(1));
            dict.Add(HeavyIronGreatsword.DisplayName, new HeavyIronGreatsword(1));
            dict.Add(HeavyIronHalberd.DisplayName, new HeavyIronHalberd(1));
            dict.Add(HeavyIronHeadsmansAxe.DisplayName, new HeavyIronHeadsmansAxe(1));
            dict.Add(HeavyIronMace.DisplayName, new HeavyIronMace(1));
            dict.Add(HeavyIronSword.DisplayName, new HeavyIronSword(1));
            dict.Add(IronAxe.DisplayName, new IronAxe(1));
            dict.Add(IronBlade.DisplayName, new IronBlade(1));
            dict.Add(IronDagger.DisplayName, new IronDagger(1));
            dict.Add(IronGreatsword.DisplayName, new IronGreatsword(1));
            dict.Add(IronHilt.DisplayName, new IronHilt(1));
            dict.Add(IronSword.DisplayName, new IronSword(1));
            dict.Add(IronThrowingAxe.DisplayName, new IronThrowingAxe(1));
            dict.Add(SteelAxe.DisplayName, new SteelAxe(1));
            dict.Add(SteelBlade.DisplayName, new SteelBlade(1));
            dict.Add(SteelDagger.DisplayName, new SteelDagger(1));
            dict.Add(SteelGreatsword.DisplayName, new SteelGreatsword(1));
            dict.Add(SteelSword.DisplayName, new SteelSword(1));
            dict.Add(SteelThrowingAxe.DisplayName, new SteelThrowingAxe(1));
            dict.Add(TinyBagofMarbles.DisplayName, new TinyBagofMarbles(1));
        }
    }
}