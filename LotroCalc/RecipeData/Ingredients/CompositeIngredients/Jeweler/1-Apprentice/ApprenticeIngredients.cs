using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._1_Apprentice
{
    public abstract class ApprenticeIngredients : JewelerIngredients
    {
        protected ApprenticeIngredients()
        {
            Tier = ProfessionTierEnum.Apprentice;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AgateBraceletofBlocking.DisplayName, new AgateBraceletofBlocking(1));
            dict.Add(AgateBraceletofMorale.DisplayName, new AgateBraceletofMorale(1));
            dict.Add(AgateFlintRunestone.DisplayName, new AgateFlintRunestone(1));
            dict.Add(AgateNecklaceofMorale.DisplayName, new AgateNecklaceofMorale(1));
            dict.Add(AgateNecklaceofQuickness.DisplayName, new AgateNecklaceofQuickness(1));
            dict.Add(AmethystEarringofCombat.DisplayName, new AmethystEarringofCombat(1));
            dict.Add(AmethystEarringofMorale.DisplayName, new AmethystEarringofMorale(1));
            dict.Add(AmethystEarringofPrecision.DisplayName, new AmethystEarringofPrecision(1));
            dict.Add(AmethystRingofMorale.DisplayName, new AmethystRingofMorale(1));
            dict.Add(AmethystRingofTactics.DisplayName, new AmethystRingofTactics(1));
            dict.Add(CopperBracelet.DisplayName, new CopperBracelet(1));
            dict.Add(CopperEarring.DisplayName, new CopperEarring(1));
            dict.Add(CopperFlintRunestone.DisplayName, new CopperFlintRunestone(1));
            dict.Add(CopperNecklace.DisplayName, new CopperNecklace(1));
            dict.Add(CopperRing.DisplayName, new CopperRing(1));
            dict.Add(DullEdhelharnToken.DisplayName, new DullEdhelharnToken(1));
            dict.Add(GlitteringCopperBracelet.DisplayName, new GlitteringCopperBracelet(1));
            dict.Add(GlitteringCopperEarring.DisplayName, new GlitteringCopperEarring(1));
            dict.Add(GlitteringCopperNecklace.DisplayName, new GlitteringCopperNecklace(1));
            dict.Add(GlitteringCopperRing.DisplayName, new GlitteringCopperRing(1));
            dict.Add(PolishedAgate.DisplayName, new PolishedAgate(1));
            dict.Add(PolishedAmethyst.DisplayName, new PolishedAmethyst(1));
            dict.Add(WeakAmuletoftheBloodraven.DisplayName, new WeakAmuletoftheBloodraven(1));
            dict.Add(WornAmuletoftheFrostraven.DisplayName, new WornAmuletoftheFrostraven(1));
        }
    }
}