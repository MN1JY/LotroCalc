using System.Collections.Generic;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._1_Apprentice
{
    public abstract class ApprenticeIngredients : CookIngredients
    {
        protected ApprenticeIngredients()
        {
            Tier = ProfessionTierEnum.Apprentice;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(ApprenticesAle.DisplayName, new ApprenticesAle(1));
            dict.Add(BarleySoup.DisplayName, new BarleySoup(1));
            dict.Add(BoldStout.DisplayName, new BoldStout(1));
            dict.Add(BowlOfPorkStock.DisplayName, new BowlOfPorkStock(1));
            dict.Add(BucketOfSpringBarleyMash.DisplayName, new BucketOfSpringBarleyMash(1));
            dict.Add(CarrotSoup.DisplayName, new CarrotSoup(1));
            dict.Add(CarrotSticks.DisplayName, new CarrotSticks(1));
            dict.Add(CookedCarrots.DisplayName, new CookedCarrots(1));
            dict.Add(CupOfSpringBarleyFlour.DisplayName, new CupOfSpringBarleyFlour(1));
            dict.Add(EggsAndOnions.DisplayName, new EggsAndOnions(1));
            dict.Add(FriedDacewithMushrooms.DisplayName, new FriedDacewithMushrooms(1));
            dict.Add(FriedMushrooms.DisplayName, new FriedMushrooms(1));
            dict.Add(HardBiscuits.DisplayName, new HardBiscuits(1));
            dict.Add(LuteStringsOfMinorSubtlety.DisplayName, new LuteStringsOfMinorSubtlety(1));
            dict.Add(LuteStringsOfSubtlety.DisplayName, new LuteStringsOfSubtlety(1));
            dict.Add(MushroomPie.DisplayName, new MushroomPie(1));
            dict.Add(MushroomSoup.DisplayName, new MushroomSoup(1));
            dict.Add(OnionSoup.DisplayName, new OnionSoup(1));
            dict.Add(PieCrust.DisplayName, new PieCrust(1));
            dict.Add(PreparedNorthDownsHops.DisplayName, new PreparedNorthDownsHops(1));
            dict.Add(RoastPork.DisplayName, new RoastPork(1));
            dict.Add(RowanCampfireKit.DisplayName, new RowanCampfireKit(1));
            dict.Add(SandsonsFamousHardboiledEggs.DisplayName, new SandsonsFamousHardboiledEggs(1));
            dict.Add(ShirePudding.DisplayName, new ShirePudding(1));
        }
    }
}