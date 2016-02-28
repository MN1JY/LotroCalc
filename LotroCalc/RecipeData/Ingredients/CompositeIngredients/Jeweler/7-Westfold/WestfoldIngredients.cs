using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._7_Westfold.Ingredients;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._7_Westfold
{
    public abstract class WestfoldIngredients : JewelerIngredients
    {
        protected WestfoldIngredients()
        {
            Tier = ProfessionTierEnum.Westfold;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BraceletofTheodred.DisplayName, new BraceletofTheodred(1));
            dict.Add(BraceletoftheRider.DisplayName, new BraceletoftheRider(1));
            dict.Add(CalenardNecklace.DisplayName, new CalenardNecklace(1));
            dict.Add(DunlendingEarring.DisplayName, new DunlendingEarring(1));
            dict.Add(DunlendingRing.DisplayName, new DunlendingRing(1));
            dict.Add(EarringofTheodred.DisplayName, new EarringofTheodred(1));
            dict.Add(EarringoftheRider.DisplayName, new EarringoftheRider(1));
            dict.Add(GreenGarnetBracelet.DisplayName, new GreenGarnetBracelet(1));
            dict.Add(GreenGarnetNecklace.DisplayName, new GreenGarnetNecklace(1));
            dict.Add(LargeWestfoldSymbol.DisplayName, new LargeWestfoldSymbol(1));
            dict.Add(MediumWestfoldSymbol.DisplayName, new MediumWestfoldSymbol(1));
            dict.Add(NecklaceofTheodred.DisplayName, new NecklaceofTheodred(1));
            dict.Add(NecklaceoftheRider.DisplayName, new NecklaceoftheRider(1));
            dict.Add(PolishedGreenGarnet.DisplayName, new PolishedGreenGarnet(1));
            dict.Add(RingoftheRider.DisplayName, new RingoftheRider(1));
            dict.Add(RingofTheodred.DisplayName, new RingofTheodred(1));
            dict.Add(SmallWestfoldSymbol.DisplayName, new SmallWestfoldSymbol(1));
            dict.Add(VitreousEdhelharnToken.DisplayName, new VitreousEdhelharnToken(1));
            dict.Add(WestfoldBracelet.DisplayName, new WestfoldBracelet(1));
        }
    }
}