using System.Collections.Generic;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._5_Master
{
    public abstract class MasterIngredients : CookIngredients
    {
        protected MasterIngredients()
        {
            Tier = ProfessionTierEnum.Master;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BagofTastyCrumbs.DisplayName, new BagofTastyCrumbs(1));
            dict.Add(BakedFlounder.DisplayName, new BakedFlounder(1));
            dict.Add(BasswithCarrotsandOnions.DisplayName, new BasswithCarrotsandOnions(1));
            dict.Add(BlackAshCampfireKit.DisplayName, new BlackAshCampfireKit(1));
            dict.Add(BlackberryAle.DisplayName, new BlackberryAle(1));
            dict.Add(BlackberryPieFilling.DisplayName, new BlackberryPieFilling(1));
            dict.Add(BlackberryTart.DisplayName, new BlackberryTart(1));
            dict.Add(BowlOfBeefStock.DisplayName, new BowlOfBeefStock(1));
            dict.Add(CreamOfBarleySoup.DisplayName, new CreamOfBarleySoup(1));
            dict.Add(CreamOfCarrotSoup.DisplayName, new CreamOfCarrotSoup(1));
            dict.Add(CreamOfMushroomSoup.DisplayName, new CreamOfMushroomSoup(1));
            dict.Add(CreamOfOnionSoup.DisplayName, new CreamOfOnionSoup(1));
            dict.Add(CupOfTastyFrosting.DisplayName, new CupOfTastyFrosting(1));
            dict.Add(CutOfTastyMeat.DisplayName, new CutOfTastyMeat(1));
            dict.Add(DeliciousSteak.DisplayName, new DeliciousSteak(1));
            dict.Add(FeastOfRohan.DisplayName, new FeastOfRohan(1));
            dict.Add(FlounderFillet.DisplayName, new FlounderFillet(1));
            dict.Add(FlounderwithBacon.DisplayName, new FlounderwithBacon(1));
            dict.Add(FruitRoll.DisplayName, new FruitRoll(1));
            dict.Add(GoldenRoastPotatoes.DisplayName, new GoldenRoastPotatoes(1));
            dict.Add(ImprovedBlackberryPieFilling.DisplayName, new ImprovedBlackberryPieFilling(1));
            dict.Add(ImprovedTastyFrosting.DisplayName, new ImprovedTastyFrosting(1));
            dict.Add(LargeMasterRepast.DisplayName, new LargeMasterRepast(1));
            dict.Add(Lembas.DisplayName, new Lembas(1));
            dict.Add(MasterfulMash.DisplayName, new MasterfulMash(1));
            dict.Add(MediumMasterRepast.DisplayName, new MediumMasterRepast(1));
            dict.Add(PerfectPie.DisplayName, new PerfectPie(1));
            dict.Add(PotOfTastyHoneyAndOats.DisplayName, new PotOfTastyHoneyAndOats(1));
            dict.Add(PreparedUmbelHops.DisplayName, new PreparedUmbelHops(1));
            dict.Add(SmallMasterRepast.DisplayName, new SmallMasterRepast(1));
            dict.Add(SuperiorLembas.DisplayName, new SuperiorLembas(1));
            dict.Add(SuperiorPerfectPie.DisplayName, new SuperiorPerfectPie(1));
            dict.Add(SuperiorUltimateCarrotCake.DisplayName, new SuperiorUltimateCarrotCake(1));
            dict.Add(UltimateCarrotCake.DisplayName, new UltimateCarrotCake(1));
            dict.Add(UltimateHoneybrew.DisplayName, new UltimateHoneybrew(1));
        }
    }
}