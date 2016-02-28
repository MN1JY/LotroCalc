using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._1_Apprentice;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._2_Journeyman
{
    public abstract class JourneymanIngredients : CookIngredients
    {
        protected JourneymanIngredients()
        {
            Tier = ProfessionTierEnum.Journeyman;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AshCampfireKit.DisplayName, new AshCampfireKit(1));
            dict.Add(BarleyStew.DisplayName, new BarleyStew(1));
            dict.Add(BlueberryAle.DisplayName, new BlueberryAle(1));
            dict.Add(BlueberryMuffins.DisplayName, new BlueberryMuffins(1));
            dict.Add(BlueberryPieFilling.DisplayName, new BlueberryPieFilling(1));
            dict.Add(BlueberryTart.DisplayName, new BlueberryTart(1));
            dict.Add(BlueBock.DisplayName, new BlueBock(1));
            dict.Add(BowlofConeyStock.DisplayName, new BowlofConeyStock(1));
            dict.Add(BowlOfOatmeal.DisplayName, new BowlOfOatmeal(1));
            dict.Add(BreakfastTable.DisplayName, new BreakfastTable(1));
            dict.Add(CarrotStew.DisplayName, new CarrotStew(1));
            dict.Add(CatfishCakes.DisplayName, new CatfishCakes(1));
            dict.Add(CompleteHobbitBreakfast.DisplayName, new CompleteHobbitBreakfast(1));
            dict.Add(ConeyPie.DisplayName, new ConeyPie(1));
            dict.Add(ConeyStew.DisplayName, new ConeyStew(1));
            dict.Add(HornblowersPie.DisplayName, new HornblowersPie(1));
            dict.Add(LuteStringsOfGreaterSubtlety.DisplayName, new LuteStringsOfGreaterSubtlety(1));
            dict.Add(MarinatedConey.DisplayName, new MarinatedConey(1));
            dict.Add(MushroomStew.DisplayName, new MushroomStew(1));
            dict.Add(OnionStew.DisplayName, new OnionStew(1));
            dict.Add(PorkSausage.DisplayName, new PorkSausage(1));
            dict.Add(PotOfCrudeHoneyAndOats.DisplayName, new PotOfCrudeHoneyAndOats(1));
            dict.Add(PreparedGoldingHops.DisplayName, new PreparedGoldingHops(1));
            dict.Add(SausagesAndMash.DisplayName, new SausagesAndMash(1));
            dict.Add(SpicedPotatoes.DisplayName, new SpicedPotatoes(1));
            dict.Add(StuffedCabbage.DisplayName, new StuffedCabbage(1));
        }
    }
}