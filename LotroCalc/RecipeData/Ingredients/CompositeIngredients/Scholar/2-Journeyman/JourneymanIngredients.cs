using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._2_Journeyman
{
    public abstract class JourneymanIngredients : ScholarCompIngredients
    {
        protected JourneymanIngredients()
        {
            Tier = ProfessionTierEnum.Journeyman;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(FireOil.DisplayName, new FireOil(1));
            dict.Add(GreyDye.DisplayName, new GreyDye(1));
            dict.Add(GreyEnamel.DisplayName, new GreyEnamel(1));
            dict.Add(MasterJourneymanJewellersJournal.DisplayName, new MasterJourneymanJewellersJournal(1));
            dict.Add(MasterJourneymanMetalworkersJournal.DisplayName, new MasterJourneymanMetalworkersJournal(1));
            dict.Add(MasterJourneymanTailorsJournal.DisplayName, new MasterJourneymanTailorsJournal(1));
            dict.Add(MasterJourneymanWeaponsmithsJournal.DisplayName, new MasterJourneymanWeaponsmithsJournal(1));
            dict.Add(MasterJourneymanWoodworkersJournal.DisplayName, new MasterJourneymanWoodworkersJournal(1));
            dict.Add(MinorBookOfTheWhisperDraw.DisplayName, new MinorBookOfTheWhisperDraw(1));
            dict.Add(MinorBookOfTheWindRider.DisplayName, new MinorBookOfTheWindRider(1));
            dict.Add(MinorBookOfBeasts.DisplayName, new MinorBookOfBeasts(1));
            dict.Add(MinorBookOfNature.DisplayName, new MinorBookOfNature(1));
            dict.Add(MinorBookOfTheDunedain.DisplayName, new MinorBookOfTheDunedain(1));
            dict.Add(OliveDye.DisplayName, new OliveDye(1));
            dict.Add(ScrollOfLesserBattleLore.DisplayName, new ScrollOfLesserBattleLore(1));
            dict.Add(ScrollOfLesserCookingLore.DisplayName, new ScrollOfLesserCookingLore(1));
            dict.Add(ScrollOfLesserJewellerLore.DisplayName, new ScrollOfLesserJewellerLore(1));
            dict.Add(ScrollOfLesserMetalworkingLore.DisplayName, new ScrollOfLesserMetalworkingLore(1));
            dict.Add(ScrollOfLesserScholarLore.DisplayName, new ScrollOfLesserScholarLore(1));
            dict.Add(ScrollOfLesserTailoringLore.DisplayName, new ScrollOfLesserTailoringLore(1));
            dict.Add(ScrollOfLesserWardingLore.DisplayName, new ScrollOfLesserWardingLore(1));
            dict.Add(ScrollOfLesserWeaponsmithingLore.DisplayName, new ScrollOfLesserWeaponsmithingLore(1));
            dict.Add(ScrollOfLesserWoodworkingLore.DisplayName, new ScrollOfLesserWoodworkingLore(1));
            dict.Add(SilverInlay.DisplayName, new SilverInlay(1));
            dict.Add(SimpleAthelasEssence.DisplayName, new SimpleAthelasEssence(1));
            dict.Add(SimpleCelebrantSalve.DisplayName, new SimpleCelebrantSalve(1));
            dict.Add(SimpleConhuithDraught.DisplayName, new SimpleConhuithDraught(1));
            dict.Add(SimpleHealingDraught.DisplayName, new SimpleHealingDraught(1));
            dict.Add(SimpleLhinestadDraught.DisplayName, new SimpleLhinestadDraught(1));
            dict.Add(SimpleMilkthistleDraught.DisplayName, new SimpleMilkthistleDraught(1));
            dict.Add(UmberDye.DisplayName, new UmberDye(1));
        }
    }
}