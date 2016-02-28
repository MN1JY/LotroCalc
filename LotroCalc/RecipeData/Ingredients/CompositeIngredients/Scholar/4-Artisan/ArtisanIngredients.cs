using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._4_Artisan
{
    public abstract class ArtisanIngredients : ScholarCompIngredients
    {
        protected ArtisanIngredients()
        {
            Tier = ProfessionTierEnum.Artisan;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BowChantBreachfinder.DisplayName, new BowChantBreachfinder(1));
            dict.Add(BowChantFoefinder.DisplayName, new BowChantFoefinder(1));
            dict.Add(BowChantShieldbane.DisplayName, new BowChantShieldbane(1));
            dict.Add(BurgundyDye.DisplayName, new BurgundyDye(1));
            dict.Add(DarkGreenDye.DisplayName, new DarkGreenDye(1));
            dict.Add(ImprovedRefinedAthelasEssence.DisplayName, new ImprovedRefinedAthelasEssence(1));
            dict.Add(ImprovedRefinedCelebrantSalveGuild.DisplayName, new ImprovedRefinedCelebrantSalveGuild(1));
            dict.Add(ImprovedTurqoiseDye.DisplayName, new ImprovedTurqoiseDye(1));
            dict.Add(ImprovedVioletDye.DisplayName, new ImprovedVioletDye(1));
            dict.Add(MajorBookofBeasts.DisplayName, new MajorBookofBeasts(1));
            dict.Add(MajorBookofNature.DisplayName, new MajorBookofNature(1));
            dict.Add(MajorBookoftheDunedain.DisplayName, new MajorBookoftheDunedain(1));
            dict.Add(MajorBookoftheWhisperdraw.DisplayName, new MajorBookoftheWhisperdraw(1));
            dict.Add(MajorBookoftheWindrider.DisplayName, new MajorBookoftheWindrider(1));
            dict.Add(MasterArtisanJewelersJournal.DisplayName, new MasterArtisanJewelersJournal(1));
            dict.Add(MasterArtisanMetalworkersJournal.DisplayName, new MasterArtisanMetalworkersJournal(1));
            dict.Add(MasterArtisanTailorsJournal.DisplayName, new MasterArtisanTailorsJournal(1));
            dict.Add(MasterArtisanWeaponsmithsJournal.DisplayName, new MasterArtisanWeaponsmithsJournal(1));
            dict.Add(MasterArtisanWoodworkersJournal.DisplayName, new MasterArtisanWoodworkersJournal(1));
            dict.Add(MediumArtisanScroll.DisplayName, new MediumArtisanScroll(1));
            dict.Add(PaleYellowWallPaint.DisplayName, new PaleYellowWallPaint(1));
            dict.Add(PinkWallPaint.DisplayName, new PinkWallPaint(1));
            dict.Add(PlatinumInlay.DisplayName, new PlatinumInlay(1));
            dict.Add(RefinedAthelasEssence.DisplayName, new RefinedAthelasEssence(1));
            dict.Add(RefinedAthelasExtract.DisplayName, new RefinedAthelasExtract(1));
            dict.Add(RefinedCelebrantOintment.DisplayName, new RefinedCelebrantOintment(1));
            dict.Add(RefinedCelebrantSalve.DisplayName, new RefinedCelebrantSalve(1));
            dict.Add(RefinedConhuithDraught.DisplayName, new RefinedConhuithDraught(1));
            dict.Add(RefinedFireOils.DisplayName, new RefinedFireOils(1));
            dict.Add(RefinedHealingDraught.DisplayName, new RefinedHealingDraught(1));
            dict.Add(RefinedLhinestadDraught.DisplayName, new RefinedLhinestadDraught(1));
            dict.Add(RefinedMilkthistleDraught.DisplayName, new RefinedMilkthistleDraught(1));
            dict.Add(ScholarsWrit.DisplayName, new ScholarsWrit(1));
            dict.Add(ScrollofElderBattleLore.DisplayName, new ScrollofElderBattleLore(1));
            dict.Add(ScrollofElderCookingLore.DisplayName, new ScrollofElderCookingLore(1));
            dict.Add(ScrollofElderJewellerLore.DisplayName, new ScrollofElderJewellerLore(1));
            dict.Add(ScrollofElderMetalworkingLore.DisplayName, new ScrollofElderMetalworkingLore(1));
            dict.Add(ScrollofElderScholarLore.DisplayName, new ScrollofElderScholarLore(1));
            dict.Add(ScrollofElderTailoringLore.DisplayName, new ScrollofElderTailoringLore(1));
            dict.Add(ScrollofElderWardingLore.DisplayName, new ScrollofElderWardingLore(1));
            dict.Add(ScrollofElderWeaponsmithingLore.DisplayName, new ScrollofElderWeaponsmithingLore(1));
            dict.Add(ScrollofElderWoodworkingLore.DisplayName, new ScrollofElderWoodworkingLore(1));
            dict.Add(SmallArtisanScroll.DisplayName, new SmallArtisanScroll(1));
            dict.Add(YellowEnamel.DisplayName, new YellowEnamel(1));
        }
    }
}