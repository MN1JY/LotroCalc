using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._7_Westfold.Ingredients;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._7_Westfold
{
    public abstract class WestfoldIngredients : CookIngredients
    {
        protected WestfoldIngredients()
        {
            Tier = ProfessionTierEnum.Westfold;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AppleandCheesePie.DisplayName, new AppleandCheesePie(1));
            dict.Add(BaconwrappedFlapjack.DisplayName, new BaconwrappedFlapjack(1));
            dict.Add(BagofRoastedCoffeeGrounds.DisplayName, new BagofRoastedCoffeeGrounds(1));
            dict.Add(BagOfCrispyCrumbs.DisplayName, new BagOfCrispyCrumbs(1));
            dict.Add(Bannock.DisplayName, new Bannock(1));
            dict.Add(BilberryPie.DisplayName, new BilberryPie(1));
            dict.Add(BirchCampfireKit.DisplayName, new BirchCampfireKit(1));
            dict.Add(BlackPudding.DisplayName, new BlackPudding(1));
            dict.Add(BowlOfLeekStock.DisplayName, new BowlOfLeekStock(1));
            dict.Add(BowlOfSpringWater.DisplayName, new BowlOfSpringWater(1));
            dict.Add(BreadAndButterPudding.DisplayName, new BreadAndButterPudding(1));
            dict.Add(BreadedOxtail.DisplayName, new BreadedOxtail(1));
            dict.Add(CauliflowerAndChicken.DisplayName, new CauliflowerAndChicken(1));
            dict.Add(ChickenPie.DisplayName, new ChickenPie(1));
            dict.Add(CockaLeekieSoup.DisplayName, new CockaLeekieSoup(1));
            dict.Add(CottagePie.DisplayName, new CottagePie(1));
            dict.Add(CupOfBlackBarleyFlour.DisplayName, new CupOfBlackBarleyFlour(1));
            dict.Add(CupOfBreadCrumbs.DisplayName, new CupOfBreadCrumbs(1));
            dict.Add(CupOfOatmeal.DisplayName, new CupOfOatmeal(1));
            dict.Add(CupofSecondBreakfastBlendCoffee.DisplayName, new CupofSecondBreakfastBlendCoffee(1));
            dict.Add(CutofSpicyMeat.DisplayName, new CutofSpicyMeat(1));
            dict.Add(GrandFeastofLithe.DisplayName, new GrandFeastofLithe(1));
            dict.Add(LoafOfBarleyBread.DisplayName, new LoafOfBarleyBread(1));
            dict.Add(LargeWestfoldRepast.DisplayName, new LargeWestfoldRepast(1));
            dict.Add(MediumWestfoldRepast.DisplayName, new MediumWestfoldRepast(1));
            dict.Add(OatyBeef.DisplayName, new OatyBeef(1));
            dict.Add(OxtailStew.DisplayName, new OxtailStew(1));
            dict.Add(PotatoScone.DisplayName, new PotatoScone(1));
            dict.Add(PotofScrumptiousHoneyandOats.DisplayName, new PotofScrumptiousHoneyandOats(1));
            dict.Add(RarebitMuffin.DisplayName, new RarebitMuffin(1));
            dict.Add(RohanHotpot.DisplayName, new RohanHotpot(1));
            dict.Add(RohanPasty.DisplayName, new RohanPasty(1));
            dict.Add(SeedCake.DisplayName, new SeedCake(1));
            dict.Add(SmallWestfoldRepast.DisplayName, new SmallWestfoldRepast(1));
            dict.Add(SpicedBeefStew.DisplayName, new SpicedBeefStew(1));
            dict.Add(SuperiorAppleAndCheesePie.DisplayName, new SuperiorAppleAndCheesePie(1));
            dict.Add(SuperiorRohanPasties.DisplayName, new SuperiorRohanPasties(1));
            dict.Add(SuperiorToadsintheHole.DisplayName, new SuperiorToadsintheHole(1));
            dict.Add(ToadInTheHole.DisplayName, new ToadInTheHole(1));
            dict.Add(WhitePudding.DisplayName, new WhitePudding(1));
            dict.Add(WildMushroomSoup.DisplayName, new WildMushroomSoup(1));
        }
    }
}