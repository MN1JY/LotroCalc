using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._5_Master
{
    public abstract class MasterIngredients : JewelerIngredients
    {
        protected MasterIngredients()
        {
            Tier = ProfessionTierEnum.Master;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AncientSilverBracelet.DisplayName, new AncientSilverBracelet(1));
            dict.Add(AncientSilverEarring.DisplayName, new AncientSilverEarring(1));
            dict.Add(AncientSilverFlintRunestone.DisplayName, new AncientSilverFlintRunestone(1));
            dict.Add(AncientSilverIcyRunestone.DisplayName, new AncientSilverIcyRunestone(1));
            dict.Add(AncientSilverNecklace.DisplayName, new AncientSilverNecklace(1));
            dict.Add(AncientSilverObsidianRunestone.DisplayName, new AncientSilverObsidianRunestone(1));
            dict.Add(AncientSilverRing.DisplayName, new AncientSilverRing(1));
            dict.Add(BerylBraceletofMorale.DisplayName, new BerylBraceletofMorale(1));
            dict.Add(BerylBraceletofSuccour.DisplayName, new BerylBraceletofSuccour(1));
            dict.Add(BerylEarringofCombat.DisplayName, new BerylEarringofCombat(1));
            dict.Add(BerylEarringofPrecision.DisplayName, new BerylEarringofPrecision(1));
            dict.Add(BerylEarringofWillpower.DisplayName, new BerylEarringofWillpower(1));
            dict.Add(BerylIcyRunestone.DisplayName, new BerylIcyRunestone(1));
            dict.Add(BerylNecklaceofEvasion.DisplayName, new BerylNecklaceofEvasion(1));
            dict.Add(BerylNecklaceofMorale.DisplayName, new BerylNecklaceofMorale(1));
            dict.Add(BerylRingofTactics.DisplayName, new BerylRingofTactics(1));
            dict.Add(BerylRingofVitality.DisplayName, new BerylRingofVitality(1));
            dict.Add(BrilliantEdhelharnToken.DisplayName, new BrilliantEdhelharnToken(1));
            dict.Add(Dwarfring.DisplayName, new Dwarfring(1));
            dict.Add(Dwarfnecklace.DisplayName, new Dwarfnecklace(1));
            dict.Add(EngravedBerylBraceletofAgility.DisplayName, new EngravedBerylBraceletofAgility(1));
            dict.Add(EngravedBerylBraceletofMorale.DisplayName, new EngravedBerylBraceletofMorale(1));
            dict.Add(EngravedBerylEarringofCombat.DisplayName, new EngravedBerylEarringofCombat(1));
            dict.Add(EngravedBerylEarringofPrecision.DisplayName, new EngravedBerylEarringofPrecision(1));
            dict.Add(EngravedBerylEarringofWillpower.DisplayName, new EngravedBerylEarringofWillpower(1));
            dict.Add(EngravedBerylFlintRunestone.DisplayName, new EngravedBerylFlintRunestone(1));
            dict.Add(EngravedBerylNecklaceofMight.DisplayName, new EngravedBerylNecklaceofMight(1));
            dict.Add(EngravedBerylNecklaceofHealing.DisplayName, new EngravedBerylNecklaceofHealing(1));
            dict.Add(EngravedBerylRingofMorale.DisplayName, new EngravedBerylRingofMorale(1));
            dict.Add(EngravedBerylRingofTactics.DisplayName, new EngravedBerylRingofTactics(1));
            dict.Add(EtchedBerylBraceletGuild.DisplayName, new EtchedBerylBraceletGuild(1));
            dict.Add(EtchedBerylEarringGuild.DisplayName, new EtchedBerylEarringGuild(1));
            dict.Add(EtchedBerylEarringofCombatGuild.DisplayName, new EtchedBerylEarringofCombatGuild(1));
            dict.Add(EtchedBerylEarringofPrecisionGuild.DisplayName, new EtchedBerylEarringofPrecisionGuild(1));
            dict.Add(EtchedBerylEarringofWillpowerGuild.DisplayName, new EtchedBerylEarringofWillpowerGuild(1));
            dict.Add(EtchedBerylFlintRunestoneGuild.DisplayName, new EtchedBerylFlintRunestoneGuild(1));
            dict.Add(EtchedBerylNecklaceGuild.DisplayName, new EtchedBerylNecklaceGuild(1));
            dict.Add(EtchedBerylNecklaceofHealingGuild.DisplayName, new EtchedBerylNecklaceofHealingGuild(1));
            dict.Add(EtchedBerylNecklaceofMightGuild.DisplayName, new EtchedBerylNecklaceofMightGuild(1));
            dict.Add(EtchedBerylRingGuild.DisplayName, new EtchedBerylRingGuild(1));
            dict.Add(EtchedBerylRingofMoraleGuild.DisplayName, new EtchedBerylRingofMoraleGuild(1));
            dict.Add(EtchedBerylRingofTacticsGuild.DisplayName, new EtchedBerylRingofTacticsGuild(1));
            dict.Add(EtchedBerylBraceletofAgilityGuild.DisplayName, new EtchedBerylBraceletofAgilityGuild(1));
            dict.Add(EtchedBerylBraceletofMoraleGuild.DisplayName, new EtchedBerylBraceletofMoraleGuild(1));
            dict.Add(ExaltedAmuletoftheAshenEagle.DisplayName, new ExaltedAmuletoftheAshenEagle(1));
            dict.Add(ExaltedAmuletoftheOnyxLynx.DisplayName, new ExaltedAmuletoftheOnyxLynx(1));
            dict.Add(ExaltedAmuletoftheSpottedLynx.DisplayName, new ExaltedAmuletoftheSpottedLynx(1));
            dict.Add(GlitteringAncientSilverBracelet.DisplayName, new GlitteringAncientSilverBracelet(1));
            dict.Add(GlitteringAncientSilverEarring.DisplayName, new GlitteringAncientSilverEarring(1));
            dict.Add(GlitteringAncientSilverNecklace.DisplayName, new GlitteringAncientSilverNecklace(1));
            dict.Add(GlitteringAncientSilverObsidianRunestone.DisplayName, new GlitteringAncientSilverObsidianRunestone(1));
            dict.Add(GlitteringAncientSilverRing.DisplayName, new GlitteringAncientSilverRing(1));
            dict.Add(LargeMasterSymbolGuild.DisplayName, new LargeMasterSymbolGuild(1));
            dict.Add(MediumMasterSymbolGuild.DisplayName, new MediumMasterSymbolGuild(1));
            dict.Add(PolishedBeryl.DisplayName, new PolishedBeryl(1));
            dict.Add(PolishedBerylsGuild.DisplayName, new PolishedBerylsGuild(1));
            dict.Add(PolishedMoonstone.DisplayName, new PolishedMoonstone(1));
            dict.Add(SmallMasterSymbolGuild.DisplayName, new SmallMasterSymbolGuild(1));
            dict.Add(SupremeAmuletoftheFrostLynx.DisplayName, new SupremeAmuletoftheFrostLynx(1));
            dict.Add(SupremeAmuletoftheOnyxLynx.DisplayName, new SupremeAmuletoftheOnyxLynx(1));
            dict.Add(SupremeAmuletoftheSnowcrestEagle.DisplayName, new SupremeAmuletoftheSnowcrestEagle(1));
            dict.Add(TinyAmuletofthePolarBear.DisplayName, new TinyAmuletofthePolarBear(1));
        }
    }
}