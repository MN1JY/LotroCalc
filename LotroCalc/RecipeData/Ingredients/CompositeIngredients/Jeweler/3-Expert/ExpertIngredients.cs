using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._3_Expert
{
    public abstract class ExpertIngredients : JewelerIngredients
    {
        protected ExpertIngredients()
        {
            Tier = ProfessionTierEnum.Expert;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AdvancedAmuletoftheFrostlynx.DisplayName, new AdvancedAmuletoftheFrostlynx(1));
            dict.Add(AdvancedAmuletoftheOnyxLynx.DisplayName, new AdvancedAmuletoftheOnyxLynx(1));
            dict.Add(EngravedRubyEarringofCombat.DisplayName, new EngravedRubyEarringofCombat(1));
            dict.Add(EngravedRubyEarringofPrecision.DisplayName, new EngravedRubyEarringofPrecision(1));
            dict.Add(EngravedRubyRingofTactics.DisplayName, new EngravedRubyRingofTactics(1));
            dict.Add(EngravedRubyEarringofWillpower.DisplayName, new EngravedRubyEarringofWillpower(1));
            dict.Add(EngravedRubyObsidianRunestone.DisplayName, new EngravedRubyObsidianRunestone(1));
            dict.Add(EngravedRubyRingofVitality.DisplayName, new EngravedRubyRingofVitality(1));
            dict.Add(EngravedSapphireBraceletofAgility.DisplayName, new EngravedSapphireBraceletofAgility(1));
            dict.Add(EngravedSapphireNecklaceofHealing.DisplayName, new EngravedSapphireNecklaceofHealing(1));
            dict.Add(EngravedSapphireBraceletofSuccour.DisplayName, new EngravedSapphireBraceletofSuccour(1));
            dict.Add(EngravedSapphireNecklaceofMight.DisplayName, new EngravedSapphireNecklaceofMight(1));
            dict.Add(EtchedRubyEarringofWillpowerGuild.DisplayName, new EtchedRubyEarringofWillpowerGuild(1));
            dict.Add(EtchedRubyRingofVitalityGuild.DisplayName, new EtchedRubyRingofVitalityGuild(1));
            dict.Add(EtchedRubyObsidianRunestone.DisplayName, new EtchedRubyObsidianRunestone(1));
            dict.Add(EtchedSapphireBraceletofAgilityGuild.DisplayName, new EtchedSapphireBraceletofAgilityGuild(1));
            dict.Add(EtchedSapphireBraceletofMightGuild.DisplayName, new EtchedSapphireBraceletofMightGuild(1));
            dict.Add(EtchedSapphireNecklaceofMightGuild.DisplayName, new EtchedSapphireNecklaceofMightGuild(1));
            dict.Add(EtchedSapphireNecklaceofEvasionGuild.DisplayName, new EtchedSapphireNecklaceofEvasionGuild(1));
            dict.Add(GlitteringGoldBracelet.DisplayName, new GlitteringGoldBracelet(1));
            dict.Add(GlitteringGoldEarring.DisplayName, new GlitteringGoldEarring(1));
            dict.Add(GlitteringGoldFlintRunestone.DisplayName, new GlitteringGoldFlintRunestone(1));
            dict.Add(GlitteringGoldNecklace.DisplayName, new GlitteringGoldNecklace(1));
            dict.Add(GlitteringGoldRing.DisplayName, new GlitteringGoldRing(1));
            dict.Add(GlossyEdhelharnToken.DisplayName, new GlossyEdhelharnToken(1));
            dict.Add(GoldBracelet.DisplayName, new GoldBracelet(1));
            dict.Add(GoldEarring.DisplayName, new GoldEarring(1));
            dict.Add(GoldFlintRunestone.DisplayName, new GoldFlintRunestone(1));
            dict.Add(GoldNecklace.DisplayName, new GoldNecklace(1));
            dict.Add(GoldObsidianRunestone.DisplayName, new GoldObsidianRunestone(1));
            dict.Add(GoldRing.DisplayName, new GoldRing(1));
            dict.Add(ImprovedPolishedRuby.DisplayName, new ImprovedPolishedRuby(1));
            dict.Add(ImprovedPolishedSapphire.DisplayName, new ImprovedPolishedSapphire(1));
            dict.Add(LesserAmuletoftheBlackBear.DisplayName, new LesserAmuletoftheBlackBear(1));
            dict.Add(LesserAmuletoftheFrostlynx.DisplayName, new LesserAmuletoftheFrostlynx(1));
            dict.Add(LesserAmuletoftheWildpawbear.DisplayName, new LesserAmuletoftheWildpawbear(1));
            dict.Add(MediumExpertSymbol.DisplayName, new MediumExpertSymbol(1));
            dict.Add(PolishedRuby.DisplayName, new PolishedRuby(1));
            dict.Add(PolishedSapphire.DisplayName, new PolishedSapphire(1));
            dict.Add(RubyEarringofFate.DisplayName, new RubyEarringofFate(1));
            dict.Add(RubyRingofTactics.DisplayName, new RubyRingofTactics(1));
            dict.Add(RubyRingofWillpower.DisplayName, new RubyRingofWillpower(1));
            dict.Add(SapphireBraceletofAgility.DisplayName, new SapphireBraceletofAgility(1));
            dict.Add(SapphireBraceletofBlocking.DisplayName, new SapphireBraceletofBlocking(1));
            dict.Add(SapphireNecklaceofMight.DisplayName, new SapphireNecklaceofMight(1));
            dict.Add(SapphireNecklaceofHealing.DisplayName, new SapphireNecklaceofHealing(1));
            dict.Add(SapphireObsidianRunestone.DisplayName, new SapphireObsidianRunestone(1));
            dict.Add(SmallExpertSymbol.DisplayName, new SmallExpertSymbol(1));
            dict.Add(StarryChandelier.DisplayName, new StarryChandelier(1));
            dict.Add(StrikingRune.DisplayName, new StrikingRune(1));
            dict.Add(StrongAmuletofthePolarBear.DisplayName, new StrongAmuletofthePolarBear(1));
            dict.Add(StrongAmuletoftheSpottedLynx.DisplayName, new StrongAmuletoftheSpottedLynx(1));
            dict.Add(StrongAmuletoftheWildpawbear.DisplayName, new StrongAmuletoftheWildpawbear(1));
            dict.Add(VanquishingRune.DisplayName, new VanquishingRune(1));
        }
    }
}