using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._7_Westfold.Ingredients;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._7_Westfold
{
    public abstract class WestfoldIngredients : ScholarCompIngredients
    {
        protected WestfoldIngredients()
        {
            Tier = ProfessionTierEnum.Westfold;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BookOfKnowledge.DisplayName, new BookOfKnowledge(1));
            dict.Add(BowChantWestfoldBreachfinder.DisplayName, new BowChantWestfoldBreachfinder(1));
            dict.Add(BowChantWestfoldFoefinder.DisplayName, new BowChantWestfoldFoefinder(1));
            dict.Add(BowChantWestfoldShieldBane.DisplayName, new BowChantWestfoldShieldBane(1));
            dict.Add(CalenardInlay.DisplayName, new CalenardInlay(1));
            dict.Add(CraftedLoremastersBookoftheThirdAge.DisplayName, new CraftedLoremastersBookoftheThirdAge(1));
            dict.Add(DunlandBook.DisplayName, new DunlandBook(1));
            dict.Add(InspiredNote.DisplayName, new InspiredNote(1));
            dict.Add(LargeWestfoldScroll.DisplayName, new LargeWestfoldScroll(1));
            dict.Add(MasterWestfoldCooksJournal.DisplayName, new MasterWestfoldCooksJournal(1));
            dict.Add(MasterWestfoldJewellersJournal.DisplayName, new MasterWestfoldJewellersJournal(1));
            dict.Add(MasterWestfoldMetalsmithsJournal.DisplayName, new MasterWestfoldMetalsmithsJournal(1));
            dict.Add(MasterWestfoldScholarsJournal.DisplayName, new MasterWestfoldScholarsJournal(1));
            dict.Add(MasterWestfoldTailorsJournal.DisplayName, new MasterWestfoldTailorsJournal(1));
            dict.Add(MasterWestfoldWeaponsmithsJournal.DisplayName, new MasterWestfoldWeaponsmithsJournal(1));
            dict.Add(MasterWestfoldWoodworkersJournal.DisplayName, new MasterWestfoldWoodworkersJournal(1));
            dict.Add(MediumWestfoldScroll.DisplayName, new MediumWestfoldScroll(1));
            dict.Add(PotentFireOil.DisplayName, new PotentFireOil(1));
            dict.Add(PotentLightOil.DisplayName, new PotentLightOil(1));
            dict.Add(RohirricAthelasEssence.DisplayName, new RohirricAthelasEssence(1));
            dict.Add(RohirricCelebrantSalve.DisplayName, new RohirricCelebrantSalve(1));
            dict.Add(ScrollofArmsmansLore.DisplayName, new ScrollofArmsmansLore(1));
            dict.Add(ScrollofExplorersLore.DisplayName, new ScrollofExplorersLore(1));
            dict.Add(ScrollofArmourersLore.DisplayName, new ScrollofArmourersLore(1));
            dict.Add(ScrollofDunlendingBattleLore.DisplayName, new ScrollofDunlendingBattleLore(1));
            dict.Add(ScrollofDunlendingWardingLore.DisplayName, new ScrollofDunlendingWardingLore(1));
            dict.Add(ScrollofHistoriansLore.DisplayName, new ScrollofHistoriansLore(1));
            dict.Add(ScrollOfInsight.DisplayName, new ScrollOfInsight(1));
            dict.Add(ScrollofTinkersLore.DisplayName, new ScrollofTinkersLore(1));
            dict.Add(ScrollofWoodsmansLore.DisplayName, new ScrollofWoodsmansLore(1));
            dict.Add(ScrollofYeomansLore.DisplayName, new ScrollofYeomansLore(1));
            dict.Add(SmallWestfoldScroll.DisplayName, new SmallWestfoldScroll(1));
            dict.Add(TomeofWisdom.DisplayName, new TomeofWisdom(1));
            dict.Add(WestfoldBattleTonic.DisplayName, new WestfoldBattleTonic(1));
            dict.Add(WestfoldBook.DisplayName, new WestfoldBook(1));
            dict.Add(WestfoldBookoftheWindrider.DisplayName, new WestfoldBookoftheWindrider(1));
            dict.Add(WestfoldBookoftheWhisperdraw.DisplayName, new WestfoldBookoftheWhisperdraw(1));
            dict.Add(WestfoldPotionofFervour.DisplayName, new WestfoldPotionofFervour(1));
            dict.Add(WestfoldPotionofFocus.DisplayName, new WestfoldPotionofFocus(1));
            dict.Add(WestfoldOverpowerTactics.DisplayName, new WestfoldOverpowerTactics(1));
        }
    }
}