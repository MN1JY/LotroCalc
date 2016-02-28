using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._1_Apprentice
{
    public abstract class ApprenticeIngredients : ScholarCompIngredients
    {
        protected ApprenticeIngredients()
        {
            Tier = ProfessionTierEnum.Apprentice;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(GoldDye.DisplayName, new GoldDye(1));
            dict.Add(LesserAthelasEssence.DisplayName, new LesserAthelasEssence(1));
            dict.Add(LesserCelebrantSalve.DisplayName, new LesserCelebrantSalve(1));
            dict.Add(LesserConhuithDraught.DisplayName, new LesserConhuithDraught(1));
            dict.Add(LesserHealingDraught.DisplayName, new LesserHealingDraught(1));
            dict.Add(LesserLhinestadDraught.DisplayName, new LesserLhinestadDraught(1));
            dict.Add(LesserMilkthistleDraught.DisplayName, new LesserMilkthistleDraught(1));
            dict.Add(PeaGreenWallPaint.DisplayName, new PeaGreenWallPaint(1));
            dict.Add(ScrollOfMinorBattleLore.DisplayName, new ScrollOfMinorBattleLore(1));
            dict.Add(ScrollOfMinorCookingLore.DisplayName, new ScrollOfMinorCookingLore(1));
            dict.Add(ScrollOfMinorJewellerLore.DisplayName, new ScrollOfMinorJewellerLore(1));
            dict.Add(ScrollOfMinorMetalworkingLore.DisplayName, new ScrollOfMinorMetalworkingLore(1));
            dict.Add(ScrollOfMinorScholarLore.DisplayName, new ScrollOfMinorScholarLore(1));
            dict.Add(ScrollOfMinorTailoringLore.DisplayName, new ScrollOfMinorTailoringLore(1));
            dict.Add(ScrollOfMinorWardingLore.DisplayName, new ScrollOfMinorWardingLore(1));
            dict.Add(ScrollOfMinorWeaponsmithingLore.DisplayName, new ScrollOfMinorWeaponsmithingLore(1));
            dict.Add(ScrollOfMinorWoodworkingLore.DisplayName, new ScrollOfMinorWoodworkingLore(1));
            dict.Add(SiennaDye.DisplayName, new SiennaDye(1));
        }
    }
}