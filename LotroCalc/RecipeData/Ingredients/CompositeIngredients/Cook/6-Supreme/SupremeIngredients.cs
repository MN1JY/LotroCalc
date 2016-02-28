using System.Collections.Generic;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._6_Supreme
{
    public abstract class SupremeIngredients : CookIngredients
    {
        protected SupremeIngredients()
        {
            Tier = ProfessionTierEnum.Supreme;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BagofDeliciousCrumbs.DisplayName, new BagofDeliciousCrumbs(1));
            dict.Add(BagofHeartyCrumbs.DisplayName, new BagofHeartyCrumbs(1));
            dict.Add(BallOfDough.DisplayName, new BallOfDough(1));
            dict.Add(BowlOfFreshWater.DisplayName, new BowlOfFreshWater(1));
            dict.Add(BowlOfLambStock.DisplayName, new BowlOfLambStock(1));
            dict.Add(BowlOfMashedRoyalTaters.DisplayName, new BowlOfMashedRoyalTaters(1));
            dict.Add(BowlOfWater.DisplayName, new BowlOfWater(1));
            dict.Add(BreadAndJam.DisplayName, new BreadAndJam(1));
            dict.Add(BubbleAndSqueak.DisplayName, new BubbleAndSqueak(1));
            dict.Add(ButteredSconeAndJam.DisplayName, new ButteredSconeAndJam(1));
            dict.Add(CauliflowerCheese.DisplayName, new CauliflowerCheese(1));
            dict.Add(CupOfBlackTea.DisplayName, new CupOfBlackTea(1));
            dict.Add(CupOfGreenTea.DisplayName, new CupOfGreenTea(1));
            dict.Add(CupOfRedTea.DisplayName, new CupOfRedTea(1));
            dict.Add(CupOfWhiteTea.DisplayName, new CupOfWhiteTea(1));
            dict.Add(CutofDeliciousMeat.DisplayName, new CutofDeliciousMeat(1));
            dict.Add(CutofLeanMeat.DisplayName, new CutofLeanMeat(1));
            dict.Add(FeastOfEthuilwereth.DisplayName, new FeastOfEthuilwereth(1));
            dict.Add(FeastOfHarvestmath.DisplayName, new FeastOfHarvestmath(1));
            dict.Add(FeastOfLithe.DisplayName, new FeastOfLithe(1));
            dict.Add(GaladhrimRation.DisplayName, new GaladhrimRation(1));
            dict.Add(GoldenWoodRoast.DisplayName, new GoldenWoodRoast(1));
            dict.Add(GreenPeaSoup.DisplayName, new GreenPeaSoup(1));
            dict.Add(GreenPeasWithMint.DisplayName, new GreenPeasWithMint(1));
            dict.Add(HoneyCake.DisplayName, new HoneyCake(1));
            dict.Add(ImprovedBlackberryJam.DisplayName, new ImprovedBlackberryJam(1));
            dict.Add(ImprovedMashedRoyalTaters.DisplayName, new ImprovedMashedRoyalTaters(1));
            dict.Add(ImprovedMintSauce.DisplayName, new ImprovedMintSauce(1));
            dict.Add(JarOfBlackberryJam.DisplayName, new JarOfBlackberryJam(1));
            dict.Add(JarOfMintSauce.DisplayName, new JarOfMintSauce(1));
            dict.Add(LambAndBarleySoup.DisplayName, new LambAndBarleySoup(1));
            dict.Add(LambAndCarrotSoup.DisplayName, new LambAndCarrotSoup(1));
            dict.Add(LambAndMushroomSoup.DisplayName, new LambAndMushroomSoup(1));
            dict.Add(LambAndOnionSoup.DisplayName, new LambAndOnionSoup(1));
            dict.Add(LambHotpot.DisplayName, new LambHotpot(1));
            dict.Add(LargeSupremeRepast.DisplayName, new LargeSupremeRepast(1));
            dict.Add(LothlorienWaybread.DisplayName, new LothlorienWaybread(1));
            dict.Add(MallornCampfireKit.DisplayName, new MallornCampfireKit(1));
            dict.Add(MediumSupremeRepast.DisplayName, new MediumSupremeRepast(1));
            dict.Add(MushyGreenPeas.DisplayName, new MushyGreenPeas(1));
            dict.Add(OnionAndMushroomOmelet.DisplayName, new OnionAndMushroomOmelet(1));
            dict.Add(PotOfDeliciousHoneyAndOats.DisplayName, new PotOfDeliciousHoneyAndOats(1));
            dict.Add(PotOfSweetHoneyAndOats.DisplayName, new PotOfSweetHoneyAndOats(1));
            dict.Add(RackOfLambWithMintSauce.DisplayName, new RackOfLambWithMintSauce(1));
            dict.Add(ShepherdsPie.DisplayName, new ShepherdsPie(1));
            dict.Add(SmallSupremeRepast.DisplayName, new SmallSupremeRepast(1));
            dict.Add(StrawberryRhubarbFilling.DisplayName, new StrawberryRhubarbFilling(1));
            dict.Add(StrawberryRhubarbTart.DisplayName, new StrawberryRhubarbTart(1));
            dict.Add(SuperiorBreadAndJam.DisplayName, new SuperiorBreadAndJam(1));
            dict.Add(SuperiorGaladhrimRation.DisplayName, new SuperiorGaladhrimRation(1));
            dict.Add(SuperiorGoldenWoodRoast.DisplayName, new SuperiorGoldenWoodRoast(1));
            dict.Add(SuperiorLothlorienWaybread.DisplayName, new SuperiorLothlorienWaybread(1));
            dict.Add(SuperiorRackOfLambWithMintSauce.DisplayName, new SuperiorRackOfLambWithMintSauce(1));
            dict.Add(SuperiorShepherdsPie.DisplayName, new SuperiorShepherdsPie(1));
        }
    }
}