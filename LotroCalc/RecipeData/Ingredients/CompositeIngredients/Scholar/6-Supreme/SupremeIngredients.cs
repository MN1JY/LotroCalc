using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._6_Supreme
{
    public abstract class SupremeIngredients : ScholarCompIngredients
    {
        protected SupremeIngredients()
        {
            Tier = ProfessionTierEnum.Supreme;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BowChantGreaterBreachfinder.DisplayName, new BowChantGreaterBreachfinder(1));
            dict.Add(BowChantGreaterFoefinder.DisplayName, new BowChantGreaterFoefinder(1));
            dict.Add(BowChantGreaterShieldbane.DisplayName, new BowChantGreaterShieldbane(1));
            dict.Add(BowChantSupremeBreachfinder.DisplayName, new BowChantSupremeBreachfinder(1));
            dict.Add(BowChantSupremeFoefinder.DisplayName, new BowChantSupremeFoefinder(1));
            dict.Add(BowChantSupremeShieldbane.DisplayName, new BowChantSupremeShieldbane(1));
            dict.Add(BurntOrangeWallPaint.DisplayName, new BurntOrangeWallPaint(1));
            dict.Add(CraftedLoremastersBookoftheThirdAge.DisplayName, new CraftedLoremastersBookoftheThirdAge(1));
            dict.Add(CraftedMinstrelsSongbookoftheThirdAge.DisplayName, new CraftedMinstrelsSongbookoftheThirdAge(1));
            dict.Add(ImprovedInfusedAthelasEssence.DisplayName, new ImprovedInfusedAthelasEssence(1));
            dict.Add(GreaterSupremeBattleTonic.DisplayName, new GreaterSupremeBattleTonic(1));
            dict.Add(ImprovedInfusedCelebrantSalve.DisplayName, new ImprovedInfusedCelebrantSalve(1));
            dict.Add(InfusedAthelasEssence.DisplayName, new InfusedAthelasEssence(1));
            dict.Add(InfusedAthelasExtract.DisplayName, new InfusedAthelasExtract(1));
            dict.Add(InfusedCelebrantOintment.DisplayName, new InfusedCelebrantOintment(1));
            dict.Add(InfusedCelebrantSalve.DisplayName, new InfusedCelebrantSalve(1));
            dict.Add(InfusedConhuithDraught.DisplayName, new InfusedConhuithDraught(1));
            dict.Add(InfusedHealingDraught.DisplayName, new InfusedHealingDraught(1));
            dict.Add(InfusedLhinestadDraught.DisplayName, new InfusedLhinestadDraught(1));
            dict.Add(InfusedMilkthistleDraught.DisplayName, new InfusedMilkthistleDraught(1));
            dict.Add(KhazadGoldInlay.DisplayName, new KhazadGoldInlay(1));
            dict.Add(LargeSupremeScroll.DisplayName, new LargeSupremeScroll(1));
            dict.Add(MediumSupremeScroll.DisplayName, new MediumSupremeScroll(1));
            dict.Add(OrangeDye.DisplayName, new OrangeDye(1));
            dict.Add(PotentAthelasEssence.DisplayName, new PotentAthelasEssence(1));
            dict.Add(PotentCelebrantSalve.DisplayName, new PotentCelebrantSalve(1));
            dict.Add(PureCelebrantOintment.DisplayName, new PureCelebrantOintment(1));
            dict.Add(PureFireoil.DisplayName, new PureFireoil(1));
            dict.Add(PureLightoil.DisplayName, new PureLightoil(1));
            dict.Add(RecordoftheRaceofMan.DisplayName, new RecordoftheRaceofMan(1));
            dict.Add(RecordofDurin.DisplayName, new RecordofDurin(1));
            dict.Add(RecordoftheElflords.DisplayName, new RecordoftheElflords(1));
            dict.Add(ReforgedLoremastersBookoftheSecondAge.DisplayName, new ReforgedLoremastersBookoftheSecondAge(1));
            dict.Add(ReforgedMinstrelsSongbookoftheSecondAge.DisplayName, new ReforgedMinstrelsSongbookoftheSecondAge(1));
            dict.Add(ScrollofSupremeBattleLore.DisplayName, new ScrollofSupremeBattleLore(1));
            dict.Add(ScrollofSupremeCookingLore.DisplayName, new ScrollofSupremeCookingLore(1));
            dict.Add(ScrollofSupremeJewellerLore.DisplayName, new ScrollofSupremeJewellerLore(1));
            dict.Add(ScrollofSupremeMetalworkingLore.DisplayName, new ScrollofSupremeMetalworkingLore(1));
            dict.Add(ScrollofSupremeScholarLore.DisplayName, new ScrollofSupremeScholarLore(1));
            dict.Add(ScrollofSupremeTailoringLore.DisplayName, new ScrollofSupremeTailoringLore(1));
            dict.Add(ScrollofSupremeWardingLore.DisplayName, new ScrollofSupremeWardingLore(1));
            dict.Add(ScrollofSupremeWeaponsmithingLore.DisplayName, new ScrollofSupremeWeaponsmithingLore(1));
            dict.Add(ScrollofSupremeWoodworkingLore.DisplayName, new ScrollofSupremeWoodworkingLore(1));
            dict.Add(SmallSupremeScroll.DisplayName, new SmallSupremeScroll(1));
            dict.Add(SteepedAthelasEssence.DisplayName, new SteepedAthelasEssence(1));
            dict.Add(SteepedCelebrantSalve.DisplayName, new SteepedCelebrantSalve(1));
            dict.Add(SteepedConhuithDraught.DisplayName, new SteepedConhuithDraught(1));
            dict.Add(SteepedHealingDraught.DisplayName, new SteepedHealingDraught(1));
            dict.Add(SteepedLhinestadDraught.DisplayName, new SteepedLhinestadDraught(1));
            dict.Add(SteepedMilkthistleDraught.DisplayName, new SteepedMilkthistleDraught(1));
            dict.Add(SupremeBattleTonic.DisplayName, new SupremeBattleTonic(1));
            dict.Add(SupremeMasterJewellersJournal.DisplayName, new SupremeMasterJewellersJournal(1));
            dict.Add(SupremeMasterMetalworkersJournal.DisplayName, new SupremeMasterMetalworkersJournal(1));
            dict.Add(SupremeMasterTailorsJournal.DisplayName, new SupremeMasterTailorsJournal(1));
            dict.Add(SupremeMasterWeaponsmithsJournal.DisplayName, new SupremeMasterWeaponsmithsJournal(1));
            dict.Add(SupremeMasterWoodworkersJournal.DisplayName, new SupremeMasterWoodworkersJournal(1));
            dict.Add(WhiteDye.DisplayName, new WhiteDye(1));
            dict.Add(WhiteEnamel.DisplayName, new WhiteEnamel(1));
        }
    }
}