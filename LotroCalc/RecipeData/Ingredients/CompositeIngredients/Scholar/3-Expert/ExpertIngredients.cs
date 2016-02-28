using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._3_Expert
{
    public abstract class ExpertIngredients : ScholarCompIngredients
    {
        protected ExpertIngredients()
        {
            Tier = ProfessionTierEnum.Expert;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BlueEnamel.DisplayName, new BlueEnamel(1));
            dict.Add(BookOfBeasts.DisplayName, new BookOfBeasts(1));
            dict.Add(BookOfNature.DisplayName, new BookOfNature(1));
            dict.Add(BookoftheDunedain.DisplayName, new BookoftheDunedain(1));
            dict.Add(BookOfTheWhisperDraw.DisplayName, new BookOfTheWhisperDraw(1));
            dict.Add(BookOfTheWindRider.DisplayName, new BookOfTheWindRider(1));
            dict.Add(BowChantMinorBreachFinder.DisplayName, new BowChantMinorBreachFinder(1));
            dict.Add(BowChantMinorFoeFinder.DisplayName, new BowChantMinorFoeFinder(1));
            dict.Add(BowChantMinorShieldBane.DisplayName, new BowChantMinorShieldBane(1));
            dict.Add(GoldInlay.DisplayName, new GoldInlay(1));
            dict.Add(GreaterAthelasEssence.DisplayName, new GreaterAthelasEssence(1));
            dict.Add(GreaterAthelasExtract.DisplayName, new GreaterAthelasExtract(1));
            dict.Add(GreaterCelebrantOintment.DisplayName, new GreaterCelebrantOintment(1));
            dict.Add(GreaterCelebrantSalve.DisplayName, new GreaterCelebrantSalve(1));
            dict.Add(GreaterConhuithDraught.DisplayName, new GreaterConhuithDraught(1));
            dict.Add(GreaterHealingDraught.DisplayName, new GreaterHealingDraught(1));
            dict.Add(GreaterLhinestadDraught.DisplayName, new GreaterLhinestadDraught(1));
            dict.Add(GreaterMilkthistleDraught.DisplayName, new GreaterMilkthistleDraught(1));
            dict.Add(ImprovedGoldDye.DisplayName, new ImprovedGoldDye(1));
            dict.Add(ImprovedGreaterAthelasEssence.DisplayName, new ImprovedGreaterAthelasEssence(1));
            dict.Add(ImprovedGreaterCelebrantSalve.DisplayName, new ImprovedGreaterCelebrantSalve(1));
            dict.Add(ImprovedGreyDye.DisplayName, new ImprovedGreyDye(1));
            dict.Add(ImprovedOliveDye.DisplayName, new ImprovedOliveDye(1));
            dict.Add(ImprovedSiennaDye.DisplayName, new ImprovedSiennaDye(1));
            dict.Add(ImprovedUmberDye.DisplayName, new ImprovedUmberDye(1));
            dict.Add(LightOil.DisplayName, new LightOil(1));
            dict.Add(MasterExpertJewellersJournal.DisplayName, new MasterExpertJewellersJournal(1));
            dict.Add(MasterExpertTailorsJournal.DisplayName, new MasterExpertTailorsJournal(1));
            dict.Add(MasterExpertWeaponsmithsJournal.DisplayName, new MasterExpertWeaponsmithsJournal(1));
            dict.Add(MasterExpertWoodworkersJournal.DisplayName, new MasterExpertWoodworkersJournal(1));
            dict.Add(MediumExpertScroll.DisplayName, new MediumExpertScroll(1));
            dict.Add(NavyDye.DisplayName, new NavyDye(1));
            dict.Add(ScrollOfBattleLore.DisplayName, new ScrollOfBattleLore(1));
            dict.Add(ScrollOfCookingLore.DisplayName, new ScrollOfCookingLore(1));
            dict.Add(ScrollOfJewellerLore.DisplayName, new ScrollOfJewellerLore(1));
            dict.Add(ScrollOfMetalworkingLore.DisplayName, new ScrollOfMetalworkingLore(1));
            dict.Add(ScrollOfScholarLore.DisplayName, new ScrollOfScholarLore(1));
            dict.Add(ScrollOfTailoringLore.DisplayName, new ScrollOfTailoringLore(1));
            dict.Add(ScrollOfWeaponsmithingLore.DisplayName, new ScrollOfWeaponsmithingLore(1));
            dict.Add(ScrollOfWoodworkingLore.DisplayName, new ScrollOfWoodworkingLore(1));
            dict.Add(ScrollOfWardingLore.DisplayName, new ScrollOfWardingLore(1));
            dict.Add(SkyBlueWallPaint.DisplayName, new SkyBlueWallPaint(1));
            dict.Add(SmallExpertScroll.DisplayName, new SmallExpertScroll(1));
            dict.Add(TurquoiseDye.DisplayName, new TurquoiseDye(1));
            dict.Add(VioletDye.DisplayName, new VioletDye(1));

        }
    }
}