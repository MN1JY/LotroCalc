using System.Collections.Generic;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._4_Artisan
{
    public abstract class ArtisanIngredients : CookIngredients
    {
        protected ArtisanIngredients()
        {
            Tier = ProfessionTierEnum.Artisan;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(ApplePieFilling.DisplayName, new ApplePieFilling(1));
            dict.Add(AppleSauce.DisplayName, new AppleSauce(1));
            dict.Add(BagofCrunchyCrumbs.DisplayName, new BagofCrunchyCrumbs(1));
            dict.Add(BowlofChickenStock.DisplayName, new BowlofChickenStock(1));
            dict.Add(BreakfastBarleyWithFruit.DisplayName, new BreakfastBarleyWithFruit(1));
            dict.Add(BucketOfWinterBarleyMash.DisplayName, new BucketOfWinterBarleyMash(1));
            dict.Add(ChickenBarleySoup.DisplayName, new ChickenBarleySoup(1));
            dict.Add(ChickenCarrotSoup.DisplayName, new ChickenCarrotSoup(1));
            dict.Add(ChickenMushroomSoup.DisplayName, new ChickenMushroomSoup(1));
            dict.Add(ChickenOnionSoup.DisplayName, new ChickenOnionSoup(1));
            dict.Add(CupOfWinterBarleyFlour.DisplayName, new CupOfWinterBarleyFlour(1));
            dict.Add(CutofTenderMeat.DisplayName, new CutofTenderMeat(1));
            dict.Add(GoldenMulletChowder.DisplayName, new GoldenMulletChowder(1));
            dict.Add(HobbitonOmlet.DisplayName, new HobbitonOmlet(1));
            dict.Add(HoneyRoastedChicken.DisplayName, new HoneyRoastedChicken(1));
            dict.Add(ImprovedApplePieFilling.DisplayName, new ImprovedApplePieFilling(1));
            dict.Add(ImprovedMarinatedChickenCutlets.DisplayName, new ImprovedMarinatedChickenCutlets(1));
            dict.Add(ImprovedRaspberryFilling.DisplayName, new ImprovedRaspberryFilling(1));
            dict.Add(ImprovedWinterBarleyFlour.DisplayName, new ImprovedWinterBarleyFlour(1));
            dict.Add(LebethronCampfireKit.DisplayName, new LebethronCampfireKit(1));
            dict.Add(MarinatedChickenCutlet.DisplayName, new MarinatedChickenCutlet(1));
            dict.Add(MediumArtisanRepast.DisplayName, new MediumArtisanRepast(1));
            dict.Add(PotOfSmoothHoneyAndOats.DisplayName, new PotOfSmoothHoneyAndOats(1));
            dict.Add(PreparedGreenHillHops.DisplayName, new PreparedGreenHillHops(1));
            dict.Add(RaspberryPieFilling.DisplayName, new RaspberryPieFilling(1));
            dict.Add(RaspberryTart.DisplayName, new RaspberryTart(1));
            dict.Add(RoastedChicken.DisplayName, new RoastedChicken(1));
            dict.Add(SaltedBeefDelights.DisplayName, new SaltedBeefDelights(1));
            dict.Add(ShireRations.DisplayName, new ShireRations(1));
            dict.Add(SmallArtisanRepast.DisplayName, new SmallArtisanRepast(1));
            dict.Add(LargeFeastingTable.DisplayName, new LargeFeastingTable(1));
            dict.Add(SpicedApplePie.DisplayName, new SpicedApplePie(1));
            dict.Add(StewOfKings.DisplayName, new StewOfKings(1));
            dict.Add(StrawberryStout.DisplayName, new StrawberryStout(1));
            dict.Add(StrawberryDessertWine.DisplayName, new StrawberryDessertWine(1));
            dict.Add(SuperiorShireRations.DisplayName, new SuperiorShireRations(1));
            dict.Add(SuperiorSpicedApplePie.DisplayName, new SuperiorSpicedApplePie(1));
            dict.Add(SuperiorStewOfKings.DisplayName, new SuperiorStewOfKings(1));
            dict.Add(WoodenKeg.DisplayName, new WoodenKeg(1));
            dict.Add(WinterBerryAle.DisplayName, new WinterBerryAle(1));
        }
    }
}