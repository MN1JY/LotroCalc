using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker._2_Journeyman
{
    public abstract class JourneymanIngredients : WoodworkerIngredients
    {
        protected JourneymanIngredients()
        {
            Tier = ProfessionTierEnum.Journeyman;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AshBow.DisplayName, new AshBow(1));
            dict.Add(AshBowstaff.DisplayName, new AshBowstaff(1));
            dict.Add(AshBrace.DisplayName, new AshBrace(1));
            dict.Add(AshClub.DisplayName, new AshClub(1));
            dict.Add(AshCrossbow.DisplayName, new AshCrossbow(1));
            dict.Add(AshGreatClub.DisplayName, new AshGreatClub(1));
            dict.Add(AshHaft.DisplayName, new AshHaft(1));
            dict.Add(AshHammer.DisplayName, new AshHammer(1));
            dict.Add(AshJavelin.DisplayName, new AshJavelin(1));
            dict.Add(AshShaft.DisplayName, new AshShaft(1));
            dict.Add(AshSpear.DisplayName, new AshSpear(1));
            dict.Add(AshStaff.DisplayName, new AshStaff(1));
            dict.Add(HeavyAshBow.DisplayName, new HeavyAshBow(1));
            dict.Add(HeavyAshClub.DisplayName, new HeavyAshClub(1));
            dict.Add(HeavyAshCrossbow.DisplayName, new HeavyAshCrossbow(1));
            dict.Add(HeavyAshHammer.DisplayName, new HeavyAshHammer(1));
            dict.Add(HeavyAshGreatClub.DisplayName, new HeavyAshGreatClub(1));
            dict.Add(HeavyAshJavelin.DisplayName, new HeavyAshJavelin(1));
            dict.Add(HeavyAshSpear.DisplayName, new HeavyAshSpear(1));
            dict.Add(HeavyAshStaff.DisplayName, new HeavyAshStaff(1));
            dict.Add(MinorFistCarving.DisplayName, new MinorFistCarving(1));
            dict.Add(MinorShieldCarving.DisplayName, new MinorShieldCarving(1));
            dict.Add(MinorSpearCarving.DisplayName, new MinorSpearCarving(1));
            dict.Add(ScholarsSmallBentwoodBookshelf.DisplayName, new ScholarsSmallBentwoodBookshelf(1));
            dict.Add(SimpleDrum.DisplayName, new SimpleDrum(1));
            dict.Add(SimpleFlute.DisplayName, new SimpleFlute(1));
            dict.Add(SimpleHarp.DisplayName, new SimpleHarp(1));
            dict.Add(SimpleLute.DisplayName, new SimpleLute(1));
            dict.Add(SimpleTheorbo.DisplayName, new SimpleTheorbo(1));
            dict.Add(SmoothAshBow.DisplayName, new SmoothAshBow(1));
            dict.Add(SmoothAshClub.DisplayName, new SmoothAshClub(1));
            dict.Add(SmoothAshCrossbow.DisplayName, new SmoothAshCrossbow(1));
            dict.Add(SmoothAshJavelin.DisplayName, new SmoothAshJavelin(1));
            dict.Add(SmoothAshGreatClub.DisplayName, new SmoothAshGreatClub(1));
            dict.Add(SmoothAshHammer.DisplayName, new SmoothAshHammer(1));
            dict.Add(SmoothAshSpear.DisplayName, new SmoothAshSpear(1));
            dict.Add(SmoothAshStaff.DisplayName, new SmoothAshStaff(1));
            dict.Add(StoutAshBow.DisplayName, new StoutAshBow(1));
            dict.Add(StoutAshClub.DisplayName, new StoutAshClub(1));
            dict.Add(StoutAshCrossbow.DisplayName, new StoutAshCrossbow(1));
            dict.Add(StoutAshJavelin.DisplayName, new StoutAshJavelin(1));
            dict.Add(StoutAshSpear.DisplayName, new StoutAshSpear(1));
            dict.Add(StoutAshStaff.DisplayName, new StoutAshStaff(1));
            dict.Add(StoutAshGreatClub.DisplayName, new StoutAshGreatClub(1));
            dict.Add(StoutAshHammer.DisplayName, new StoutAshHammer(1));
        }
    }
}