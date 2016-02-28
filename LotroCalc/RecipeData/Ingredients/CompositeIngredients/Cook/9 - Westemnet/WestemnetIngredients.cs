using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;


namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._9_Westemnet
{
    public abstract class WestemnetIngredients : CookIngredients
    {
        protected WestemnetIngredients()
        {
            Tier = ProfessionTierEnum.Westemnet;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AppleandPearSoup.DisplayName, new AppleandPearSoup(1));
            dict.Add(BagofWestemnetCoffeeGrounds.DisplayName, new BagofWestemnetCoffeeGrounds(1));
            dict.Add(BakedBeanSoup.DisplayName, new BakedBeanSoup(1));
            dict.Add(BakedPearPudding.DisplayName, new BakedPearPudding(1));
            dict.Add(BeansonToast.DisplayName, new BeansonToast(1));
            dict.Add(BlackberryandPearScrumble.DisplayName, new BlackberryandPearScrumble(1));
            dict.Add(BowlOfVegetaleStock.DisplayName, new BowlOfVegetaleStock(1));
            dict.Add(BowlofPoachedPears.DisplayName, new BowlofPoachedPears(1));
            dict.Add(CheddarPearPie.DisplayName, new CheddarPearPie(1));
            dict.Add(CupofBakedBeans.DisplayName, new CupofBakedBeans(1));
            dict.Add(CupofWestemnetCoffee.DisplayName, new CupofWestemnetCoffee(1));
            dict.Add(HeartyVenisonVegetableSoup.DisplayName, new HeartyVenisonVegetableSoup(1));
            dict.Add(JarofPearPreserves.DisplayName, new JarofPearPreserves(1));
            dict.Add(LargeWestemnetRepast.DisplayName, new LargeWestemnetRepast(1));
            dict.Add(MediumWestemnetRepast.DisplayName, new MediumWestemnetRepast(1));
            dict.Add(SausageandBeanCasserole.DisplayName, new SausageandBeanCasserole(1));
            dict.Add(SmallWestemnetRepast.DisplayName, new SmallWestemnetRepast(1));
            dict.Add(VegetableandBeanSoup.DisplayName, new VegetableandBeanSoup(1));
            dict.Add(VenisonandBeanBake.DisplayName, new VenisonandBeanBake(1));
            dict.Add(VenisonwithPearSauce.DisplayName, new VenisonwithPearSauce(1));
            dict.Add(VenisonSausage.DisplayName, new VenisonSausage(1));
        }
    }
}
