using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._2_Journeyman
{
    public abstract class JourneymanIngredients : JewelerIngredients
    {
        protected JourneymanIngredients()
        {
            Tier = ProfessionTierEnum.Journeyman;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AverageAmuletoftheFrostraven.DisplayName, new AverageAmuletoftheFrostraven(1));
            dict.Add(AverageAmuletoftheMottledwingRaven.DisplayName, new AverageAmuletoftheMottledwingRaven(1));
            dict.Add(AverageAmuletoftheWildpawbear.DisplayName, new AverageAmuletoftheWildpawbear(1));
            dict.Add(BasicAmuletoftheBlackBear.DisplayName, new BasicAmuletoftheBlackBear(1));
            dict.Add(BasicAmuletoftheBloodraven.DisplayName, new BasicAmuletoftheBloodraven(1));
            dict.Add(BasicAmuletoftheMottledwingRaven.DisplayName, new BasicAmuletoftheMottledwingRaven(1));
            dict.Add(BloodstoneEarringofFate.DisplayName, new BloodstoneEarringofFate(1));
            dict.Add(BloodstoneRingofTactics.DisplayName, new BloodstoneRingofTactics(1));
            dict.Add(BloodstoneRingofWillpower.DisplayName, new BloodstoneRingofWillpower(1));
            dict.Add(EngravedBloodstoneEarringofCombat.DisplayName, new EngravedBloodstoneEarringofCombat(1));
            dict.Add(EngravedBloodstoneEarringofPower.DisplayName, new EngravedBloodstoneEarringofPower(1));
            dict.Add(EngravedBloodstoneEarringofPrecision.DisplayName, new EngravedBloodstoneEarringofPrecision(1));
            dict.Add(EngravedBloodstoneFlintRunestone.DisplayName, new EngravedBloodstoneFlintRunestone(1));
            dict.Add(EngravedBloodstoneRing.DisplayName, new EngravedBloodstoneRing(1));
            dict.Add(EngravedBloodstoneRingofTactics.DisplayName, new EngravedBloodstoneRingofTactics(1));
            dict.Add(EngravedOpalBraceletofMorale.DisplayName, new EngravedOpalBraceletofMorale(1));
            dict.Add(EngravedOpalBraceletofSuccour.DisplayName, new EngravedOpalBraceletofSuccour(1));
            dict.Add(EngravedOpalNecklaceofEvasion.DisplayName, new EngravedOpalNecklaceofEvasion(1));
            dict.Add(EngravedOpalNecklaceofMorale.DisplayName, new EngravedOpalNecklaceofMorale(1));
            dict.Add(FaintEdhelharnToken.DisplayName, new FaintEdhelharnToken(1));
            dict.Add(GlitteringSilverBracelet.DisplayName, new GlitteringSilverBracelet(1));
            dict.Add(GlitteringSilverEarring.DisplayName, new GlitteringSilverEarring(1));
            dict.Add(GlitteringSilverFlintRunestone.DisplayName, new GlitteringSilverFlintRunestone(1));
            dict.Add(GlitteringSilverNecklace.DisplayName, new GlitteringSilverNecklace(1));
            dict.Add(GlitteringSilverRing.DisplayName, new GlitteringSilverRing(1));
            dict.Add(MinorStrikingRune.DisplayName, new MinorStrikingRune(1));
            dict.Add(MinorVanquishingRune.DisplayName, new MinorVanquishingRune(1));
            dict.Add(OpalBraceletofAgility.DisplayName, new OpalBraceletofAgility(1));
            dict.Add(OpalBraceletofBlocking.DisplayName, new OpalBraceletofBlocking(1));
            dict.Add(OpalFlintRunestone.DisplayName, new OpalFlintRunestone(1));
            dict.Add(OpalNecklaceofHealing.DisplayName, new OpalNecklaceofHealing(1));
            dict.Add(OpalNecklaceofMight.DisplayName, new OpalNecklaceofMight(1));
            dict.Add(PolishedBloodstone.DisplayName, new PolishedBloodstone(1));
            dict.Add(PolishedOpal.DisplayName, new PolishedOpal(1));
            dict.Add(SilverBracelet.DisplayName, new SilverBracelet(1));
            dict.Add(SilverEarring.DisplayName, new SilverEarring(1));
            dict.Add(SilverFlintRunestone.DisplayName, new SilverFlintRunestone(1));
            dict.Add(SilverNecklace.DisplayName, new SilverNecklace(1));
            dict.Add(SilverRing.DisplayName, new SilverRing(1));
        }
    }
}