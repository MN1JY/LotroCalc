using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._4_Artisan
{
    public abstract class ArtisanIngredients : JewelerIngredients
    {
        protected ArtisanIngredients()
        {
            Tier = ProfessionTierEnum.Artisan;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AdamantBraceletofAgility.DisplayName, new AdamantBraceletofAgility(1));
            dict.Add(AdamantBraceletofMorale.DisplayName, new AdamantBraceletofMorale(1));
            dict.Add(AdamantEarringofCombat.DisplayName, new AdamantEarringofCombat(1));
            dict.Add(AdamantEarringofPrecision.DisplayName, new AdamantEarringofPrecision(1));
            dict.Add(AdamantEarringofWillpower.DisplayName, new AdamantEarringofWillpower(1));
            dict.Add(AdamantFlintRunestone.DisplayName, new AdamantFlintRunestone(1));
            dict.Add(AdamantNecklaceofMight.DisplayName, new AdamantNecklaceofMight(1));
            dict.Add(AdamantNecklaceofMorale.DisplayName, new AdamantNecklaceofMorale(1));
            dict.Add(AdamantRingofTactics.DisplayName, new AdamantRingofTactics(1));
            dict.Add(AdamantRingofVitality.DisplayName, new AdamantRingofVitality(1));
            dict.Add(Dwarfjewel.DisplayName, new Dwarfjewel(1));
            dict.Add(EngravedAdamantBraceletofAgility.DisplayName, new EngravedAdamantBraceletofAgility(1));
            dict.Add(EngravedAdamantBraceletofMorale.DisplayName, new EngravedAdamantBraceletofMorale(1));
            dict.Add(EngravedAdamantEarringofWillpower.DisplayName, new EngravedAdamantEarringofWillpower(1));
            dict.Add(EngravedAdamantEarringofCombat.DisplayName, new EngravedAdamantEarringofCombat(1));
            dict.Add(EngravedAdamantEarringofPrecision.DisplayName, new EngravedAdamantEarringofPrecision(1));
            dict.Add(EngravedAdamantIcyRunestone.DisplayName, new EngravedAdamantIcyRunestone(1));
            dict.Add(EngravedAdamantNecklaceofMight.DisplayName, new EngravedAdamantNecklaceofMight(1));
            dict.Add(EngravedAdamantNecklaceofMorale.DisplayName, new EngravedAdamantNecklaceofMorale(1));
            dict.Add(EngravedAdamantRingofMorale.DisplayName, new EngravedAdamantRingofMorale(1));
            dict.Add(EngravedAdamantRingofTactics.DisplayName, new EngravedAdamantRingofTactics(1));
            dict.Add(EtchedAdamantBraceletofAgilityGuild.DisplayName, new EtchedAdamantBraceletofAgilityGuild(1));
            dict.Add(EtchedAdamantBraceletofMoraleGuild.DisplayName, new EtchedAdamantBraceletofMoraleGuild(1));
            dict.Add(EtchedAdamantBraceletGuild.DisplayName, new EtchedAdamantBraceletGuild(1));
            dict.Add(EtchedAdamantEarringGuild.DisplayName, new EtchedAdamantEarringGuild(1));
            dict.Add(EtchedAdamantEarringofCombatGuild.DisplayName, new EtchedAdamantEarringofCombatGuild(1));
            dict.Add(EtchedAdamantEarringofPrecisionGuild.DisplayName, new EtchedAdamantEarringofPrecisionGuild(1));
            dict.Add(EtchedAdamantEarringofWillpowerGuild.DisplayName, new EtchedAdamantEarringofWillpowerGuild(1));
            dict.Add(EtchedAdamantNecklaceGuild.DisplayName, new EtchedAdamantNecklaceGuild(1));
            dict.Add(EtchedAdamantNecklaceofMightGuild.DisplayName, new EtchedAdamantNecklaceofMightGuild(1));
            dict.Add(EtchedAdamantNecklaceofMoraleGuild.DisplayName, new EtchedAdamantNecklaceofMoraleGuild(1));
            dict.Add(EtchedAdamantRingGuild.DisplayName, new EtchedAdamantRingGuild(1));
            dict.Add(EtchedAdamantRingofMoraleGuild.DisplayName, new EtchedAdamantRingofMoraleGuild(1));
            dict.Add(EtchedAdamantRingofTacticsGuild.DisplayName, new EtchedAdamantRingofTacticsGuild(1));
            dict.Add(EtchedAdamantIcyRunestoneGuild.DisplayName, new EtchedAdamantIcyRunestoneGuild(1));
            dict.Add(ExcellentAmuletoftheFrostlynx.DisplayName, new ExcellentAmuletoftheFrostlynx(1));
            dict.Add(ExcellentAmuletoftheOnyxLynx.DisplayName, new ExcellentAmuletoftheOnyxLynx(1));
            dict.Add(ExcellentAmuletoftheSpottedLynx.DisplayName, new ExcellentAmuletoftheSpottedLynx(1));
            dict.Add(GlitteringPlatinumEarring.DisplayName, new GlitteringPlatinumEarring(1));
            dict.Add(GlitteringPlatinumObsidianRunestone.DisplayName, new GlitteringPlatinumObsidianRunestone(1));
            dict.Add(GlitteringPlatinumRing.DisplayName, new GlitteringPlatinumRing(1));
            dict.Add(GlitteringWhiteGoldBracelet.DisplayName, new GlitteringWhiteGoldBracelet(1));
            dict.Add(GlitteringWhiteGoldNecklace.DisplayName, new GlitteringWhiteGoldNecklace(1));
            dict.Add(GreaterAmuletoftheBloodraven.DisplayName, new GreaterAmuletoftheBloodraven(1));
            dict.Add(ImprovedPolishedAdamant.DisplayName, new ImprovedPolishedAdamant(1));
            dict.Add(MajorStrikingRune.DisplayName, new MajorStrikingRune(1));
            dict.Add(MajorVanquishingRune.DisplayName, new MajorVanquishingRune(1));
            dict.Add(MediumArtisanSymbol.DisplayName, new MediumArtisanSymbol(1));
            dict.Add(PlatinumBracelet.DisplayName, new PlatinumBracelet(1));
            dict.Add(PlatinumNecklace.DisplayName, new PlatinumNecklace(1));
            dict.Add(PointedChandelier.DisplayName, new PointedChandelier(1));
            dict.Add(PolishedAdamant.DisplayName, new PolishedAdamant(1));
            dict.Add(SilverCandlestand.DisplayName, new SilverCandlestand(1));
            dict.Add(ShiningEdhelharnToken.DisplayName, new ShiningEdhelharnToken(1));
            dict.Add(SmallArtisanSymbol.DisplayName, new SmallArtisanSymbol(1));
            dict.Add(WhiteGoldEarring.DisplayName, new WhiteGoldEarring(1));
            dict.Add(WhiteGoldFlintRunestone.DisplayName, new WhiteGoldFlintRunestone(1));
            dict.Add(WhiteGoldIcyRunestone.DisplayName, new WhiteGoldIcyRunestone(1));
            dict.Add(WhiteGoldObsidianRunestone.DisplayName, new WhiteGoldObsidianRunestone(1));
            dict.Add(WhiteGoldRing.DisplayName, new WhiteGoldRing(1));
        }
    }
}