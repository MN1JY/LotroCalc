using System.Collections.Generic;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._3_Expert
{
    public abstract class ExpertIngredients : CookIngredients
    {
        protected ExpertIngredients()
        {
            Tier = ProfessionTierEnum.Expert;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BagOfCrumbs.DisplayName, new BagOfCrumbs(1));
            dict.Add(BeefStew.DisplayName, new BeefStew(1));
            dict.Add(BowlOfHeartyStock.DisplayName, new BowlOfHeartyStock(1));
            dict.Add(CutOfMarinatedBeef.DisplayName, new CutOfMarinatedBeef(1));
            dict.Add(DeliciousCrispyBacon.DisplayName, new DeliciousCrispyBacon(1));
            dict.Add(FullBreakfast.DisplayName, new FullBreakfast(1));
            dict.Add(HardTackRation.DisplayName, new HardTackRation(1));
            dict.Add(HeartyBarleySoup.DisplayName, new HeartyBarleySoup(1));
            dict.Add(HeartyCarrotSoup.DisplayName, new HeartyCarrotSoup(1));
            dict.Add(HeartyMushroomSoup.DisplayName, new HeartyMushroomSoup(1));
            dict.Add(HeartyOnionSoup.DisplayName, new HeartyOnionSoup(1));
            dict.Add(Honeybrew.DisplayName, new Honeybrew(1));
            dict.Add(ImprovedHeartyStock.DisplayName, new ImprovedHeartyStock(1));
            dict.Add(ImprovedMarinatedBeef.DisplayName, new ImprovedMarinatedBeef(1));
            dict.Add(ImprovedStrawberryFilling.DisplayName, new ImprovedStrawberryFilling(1));
            dict.Add(MediumExpertRepast.DisplayName, new MediumExpertRepast(1));
            dict.Add(PerchFillet.DisplayName, new PerchFillet(1));
            dict.Add(PorkChops.DisplayName, new PorkChops(1));
            dict.Add(PotOfHoneyAndOats.DisplayName, new PotOfHoneyAndOats(1));
            dict.Add(PreparedPrideOfChetwoodHops.DisplayName, new PreparedPrideOfChetwoodHops(1));
            dict.Add(RoastBeef.DisplayName, new RoastBeef(1));
            dict.Add(SeasonedBeefWithCauliflower.DisplayName, new SeasonedBeefWithCauliflower(1));
            dict.Add(ShireSpiceAle.DisplayName, new ShireSpiceAle(1));
            dict.Add(SmallExpertRepast.DisplayName, new SmallExpertRepast(1));
            dict.Add(SmallFeastingTable.DisplayName, new SmallFeastingTable(1));
            dict.Add(StrawberryPieFilling.DisplayName, new StrawberryPieFilling(1));
            dict.Add(StrawberryTart.DisplayName, new StrawberryTart(1));
            dict.Add(SteakAndKidneyPie.DisplayName, new SteakAndKidneyPie(1));
            dict.Add(SuperiorBeefStewGuild.DisplayName, new SuperiorBeefStewGuild(1));
            dict.Add(SuperiorHardTackRationGuild.DisplayName, new SuperiorHardTackRationGuild(1));
            dict.Add(SuperiorSteakAndKidneyPieGuild.DisplayName, new SuperiorSteakAndKidneyPieGuild(1));
            dict.Add(VegetableMedley.DisplayName, new VegetableMedley(1));
            dict.Add(YewCampfireKit.DisplayName, new YewCampfireKit(1));

        }
    }
}