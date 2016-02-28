using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._5_Master
{
    public abstract class MasterIngredients : ScholarCompIngredients
    {
        protected MasterIngredients()
        {
            Tier = ProfessionTierEnum.Master;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AncientSilverInlay.DisplayName, new AncientSilverInlay(1));
            dict.Add(BowChantMajorBreachfinder.DisplayName, new BowChantMajorBreachfinder(1));
            dict.Add(BowChantMajorFoefinder.DisplayName, new BowChantMajorFoefinder(1));
            dict.Add(BowChantMajorShieldbane.DisplayName, new BowChantMajorShieldbane(1));
            dict.Add(DistilledAthelasEssence.DisplayName, new DistilledAthelasEssence(1));
            dict.Add(DistilledCelebrantOintmentGuild.DisplayName, new DistilledCelebrantOintmentGuild(1));
            dict.Add(DistilledCelebrantSalve.DisplayName, new DistilledCelebrantSalve(1));
            dict.Add(DistilledConhuithDraught.DisplayName, new DistilledConhuithDraught(1));
            dict.Add(DistilledHealingDraught.DisplayName, new DistilledHealingDraught(1));
            dict.Add(DistilledLhinestadDraught.DisplayName, new DistilledLhinestadDraught(1));
            dict.Add(DistilledMilkthistleDraught.DisplayName, new DistilledMilkthistleDraught(1));
            dict.Add(GrandMasterJewellersJournal.DisplayName, new GrandMasterJewellersJournal(1));
            dict.Add(GrandMasterMetalworkersJournal.DisplayName, new GrandMasterMetalworkersJournal(1));
            dict.Add(GrandMasterTailorsJournal.DisplayName, new GrandMasterTailorsJournal(1));
            dict.Add(GrandMasterWeaponsmithsJournal.DisplayName, new GrandMasterWeaponsmithsJournal(1));
            dict.Add(GrandMasterWoodworkersJournal.DisplayName, new GrandMasterWoodworkersJournal(1));
            dict.Add(LargeMasterScroll.DisplayName, new LargeMasterScroll(1));
            dict.Add(LavenderWallPaint.DisplayName, new LavenderWallPaint(1));
            dict.Add(MediumMasterScroll.DisplayName, new MediumMasterScroll(1));
            dict.Add(OfMysteriesMostProfound.DisplayName, new OfMysteriesMostProfound(1));
            dict.Add(OrangeDye.DisplayName, new OrangeDye(1));
            dict.Add(PumpkinOrangeWallPaint.DisplayName, new PumpkinOrangeWallPaint(1));
            dict.Add(RedDye.DisplayName, new RedDye(1));
            dict.Add(RedEnamel.DisplayName, new RedEnamel(1));
            dict.Add(RefinedLightOils.DisplayName, new RefinedLightOils(1));
            dict.Add(RustDye.DisplayName, new RustDye(1));
            dict.Add(ScrollofAncientBattleLore.DisplayName, new ScrollofAncientBattleLore(1));
            dict.Add(ScrollofAncientWardingLore.DisplayName, new ScrollofAncientWardingLore(1));
            dict.Add(ScrollofAncientCookingLore.DisplayName, new ScrollofAncientCookingLore(1));
            dict.Add(ScrollofAncientJewellerLore.DisplayName, new ScrollofAncientJewellerLore(1));
            dict.Add(ScrollofAncientMetalworkingLore.DisplayName, new ScrollofAncientMetalworkingLore(1));
            dict.Add(ScrollofAncientScholarLore.DisplayName, new ScrollofAncientScholarLore(1));
            dict.Add(ScrollofAncientTailoringLore.DisplayName, new ScrollofAncientTailoringLore(1));
            dict.Add(ScrollofAncientWeaponsmithingLore.DisplayName, new ScrollofAncientWeaponsmithingLore(1));
            dict.Add(ScrollofAncientWoodworkingLore.DisplayName, new ScrollofAncientWoodworkingLore(1));
            dict.Add(SmallMasterScroll.DisplayName, new SmallMasterScroll(1));
            dict.Add(StudyoftheUnknown.DisplayName, new StudyoftheUnknown(1));

        }
    }
}