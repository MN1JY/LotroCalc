using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._8_Eastemnet
{
    public abstract class EastemnetIngredients : CookIngredients
    {
        protected EastemnetIngredients()
        {
            Tier = ProfessionTierEnum.Eastemnet;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BagofEastemnetCoffeeGrounds.DisplayName, new BagofEastemnetCoffeeGrounds(1));
            dict.Add(BagofEastemnetCrumbs.DisplayName, new BagofEastemnetCrumbs(1));
            dict.Add(BowlOfDuckStock.DisplayName, new BowlOfDuckStock(1));
            dict.Add(BowlofEastemnetWater.DisplayName, new BowlofEastemnetWater(1));
            dict.Add(BowlOfMashedTurnips.DisplayName, new BowlOfMashedTurnips(1));
            dict.Add(BowlOfStewedTurnips.DisplayName, new BowlOfStewedTurnips(1));
            dict.Add(CherryFilling.DisplayName, new CherryFilling(1));
            dict.Add(CherryRhubarbCrumble.DisplayName, new CherryRhubarbCrumble(1));
            dict.Add(CherryRyeMuffinx10.DisplayName, new CherryRyeMuffinx10(1));
            dict.Add(CreamTurnipSoup.DisplayName, new CreamTurnipSoup(1));
            dict.Add(CrispRoastDuckandPotatox10.DisplayName, new CrispRoastDuckandPotatox10(1));
            dict.Add(CupofBoldRiddermarkCoffee.DisplayName, new CupofBoldRiddermarkCoffee(1));
            dict.Add(CupofMediumRiddermarkCoffee.DisplayName, new CupofMediumRiddermarkCoffee(1));
            dict.Add(CupofMildRiddermarkCoffee.DisplayName, new CupofMildRiddermarkCoffee(1));
            dict.Add(CupofEastemnetCoffee.DisplayName, new CupofEastemnetCoffee(1));
            dict.Add(CupOfRyeFlour.DisplayName, new CupOfRyeFlour(1));
            dict.Add(CupofSuperiorEastemnetCoffee.DisplayName, new CupofSuperiorEastemnetCoffee(1));
            dict.Add(CutofEastemnetMeat.DisplayName, new CutofEastemnetMeat(1));
            dict.Add(DuckandOxtailSoup.DisplayName, new DuckandOxtailSoup(1));
            dict.Add(DuckPie.DisplayName, new DuckPie(1));
            dict.Add(DuckStew.DisplayName, new DuckStew(1));
            dict.Add(FeastofCormare.DisplayName, new FeastofCormare(1));
            dict.Add(GrandFeastofCormare.DisplayName, new GrandFeastofCormare(1));
            dict.Add(HerbandNutRoll.DisplayName, new HerbandNutRoll(1));
            dict.Add(JarOfCherryJam.DisplayName, new JarOfCherryJam(1));
            dict.Add(LargeEastemnetRepast.DisplayName, new LargeEastemnetRepast(1));
            dict.Add(MediumEastemnetRepast.DisplayName, new MediumEastemnetRepast(1));
            dict.Add(NeepsAntatties.DisplayName, new NeepsAntatties(1));
            dict.Add(OakCampfireKit.DisplayName, new OakCampfireKit(1));
            dict.Add(PotofEastemnetHoneyandOats.DisplayName, new PotofEastemnetHoneyandOats(1));
            dict.Add(RabbitwithBaconandTurnips.DisplayName, new RabbitwithBaconandTurnips(1));
            dict.Add(RyeFlourOatcakex10.DisplayName, new RyeFlourOatcakex10(1));
            dict.Add(SmallEastemnetRepast.DisplayName, new SmallEastemnetRepast(1));
            dict.Add(SuperiorRoastWildDuckwithCherrySauce.DisplayName, new SuperiorRoastWildDuckwithCherrySauce(1));
            dict.Add(SuperiorVegetablePasty.DisplayName, new SuperiorVegetablePasty(1));
            dict.Add(TurnipandBaconCasserolex10.DisplayName, new TurnipandBaconCasserolex10(1));
            dict.Add(TurnipBaconTurnover.DisplayName, new TurnipBaconTurnover(1));
            dict.Add(VegetablePotPie.DisplayName, new VegetablePotPie(1));
            dict.Add(WarmCherryStew.DisplayName, new WarmCherryStew(1));
        }

    }
}