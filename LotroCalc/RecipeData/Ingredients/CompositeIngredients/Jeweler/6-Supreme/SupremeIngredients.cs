using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._6_Supreme
{
    public abstract class SupremeIngredients : JewelerIngredients
    {
        protected SupremeIngredients()
        {
            Tier = ProfessionTierEnum.Supreme;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AquamarineBracelet.DisplayName, new AquamarineBracelet(1));
            dict.Add(AquamarineEarring.DisplayName, new AquamarineEarring(1));
            dict.Add(AquamarineFlintRunestone.DisplayName, new AquamarineFlintRunestone(1));
            dict.Add(AquamarineNecklace.DisplayName, new AquamarineNecklace(1));
            dict.Add(AquamarineRing.DisplayName, new AquamarineRing(1));
            dict.Add(AquamarineRingofTactics.DisplayName, new AquamarineRingofTactics(1));
            dict.Add(AureateBandofMorale.DisplayName, new AureateBandofMorale(1));
            dict.Add(AureateBandofTactics.DisplayName, new AureateBandofTactics(1));
            dict.Add(AureateBraceletofMorale.DisplayName, new AureateBraceletofMorale(1));
            dict.Add(AureateBraceletofPower.DisplayName, new AureateBraceletofPower(1));
            dict.Add(AureateHoopofCombat.DisplayName, new AureateHoopofCombat(1));
            dict.Add(AureateHoopofPrecision.DisplayName, new AureateHoopofPrecision(1));
            dict.Add(AureateHoopofWillpower.DisplayName, new AureateHoopofWillpower(1));
            dict.Add(AureateStrandofMight.DisplayName, new AureateStrandofMight(1));
            dict.Add(AureateStrandofMorale.DisplayName, new AureateStrandofMorale(1));
            dict.Add(BerylPendant.DisplayName, new BerylPendant(1));
            dict.Add(CraftedChampionsRuneoftheThirdAge.DisplayName, new CraftedChampionsRuneoftheThirdAge(1));
            dict.Add(CraftedFlintRunestoneoftheThirdAge.DisplayName, new CraftedFlintRunestoneoftheThirdAge(1));
            dict.Add(CraftedIcyRunestoneoftheThirdAge.DisplayName, new CraftedIcyRunestoneoftheThirdAge(1));
            dict.Add(CraftedObsidianRunestoneoftheThirdAge.DisplayName, new CraftedObsidianRunestoneoftheThirdAge(1));
            dict.Add(DawnroseBraceletofPower.DisplayName, new DawnroseBraceletofPower(1));
            dict.Add(DawnroseBraceletofSuccour.DisplayName, new DawnroseBraceletofSuccour(1));
            dict.Add(DawnroseEarringofCombat.DisplayName, new DawnroseEarringofCombat(1));
            dict.Add(DawnroseEarringofPrecision.DisplayName, new DawnroseEarringofPrecision(1));
            dict.Add(DawnroseEarringofWillpower.DisplayName, new DawnroseEarringofWillpower(1));
            dict.Add(DawnroseNecklaceofEvasion.DisplayName, new DawnroseNecklaceofEvasion(1));
            dict.Add(DawnroseNecklaceofMorale.DisplayName, new DawnroseNecklaceofMorale(1));
            dict.Add(DawnroseObsidianRunestone.DisplayName, new DawnroseObsidianRunestone(1));
            dict.Add(DawnroseRingofPower.DisplayName, new DawnroseRingofPower(1));
            dict.Add(DawnroseRingofTactics.DisplayName, new DawnroseRingofTactics(1));
            dict.Add(DunedainStar.DisplayName, new DunedainStar(1));
            dict.Add(FightersGreenwoodBracelet.DisplayName, new FightersGreenwoodBracelet(1));
            dict.Add(FightersGreenwoodEarring.DisplayName, new FightersGreenwoodEarring(1));
            dict.Add(FightersGreenwoodNecklace.DisplayName, new FightersGreenwoodNecklace(1));
            dict.Add(FightersGreenwoodRing.DisplayName, new FightersGreenwoodRing(1));
            dict.Add(FlintRunestoneoftheGaladhrim.DisplayName, new FlintRunestoneoftheGaladhrim(1));
            dict.Add(FlintRunestoneoftheGoldenHost.DisplayName, new FlintRunestoneoftheGoldenHost(1));
            dict.Add(GlowingAureateBandofMoraleGuild.DisplayName, new GlowingAureateBandofMoraleGuild(1));
            dict.Add(GlowingAureateBandofTacticsGuild.DisplayName, new GlowingAureateBandofTacticsGuild(1));
            dict.Add(GlowingAureateBraceletofMoraleGuild.DisplayName, new GlowingAureateBraceletofMoraleGuild(1));
            dict.Add(GlowingAureateBraceletofPowerGuild.DisplayName, new GlowingAureateBraceletofPowerGuild(1));
            dict.Add(GlowingAureateHoopofCombatGuild.DisplayName, new GlowingAureateHoopofCombatGuild(1));
            dict.Add(GlowingAureateHoopofPrecisionGuild.DisplayName, new GlowingAureateHoopofPrecisionGuild(1));
            dict.Add(GlowingAureateHoopofWillpowerGuild.DisplayName, new GlowingAureateHoopofWillpowerGuild(1));
            dict.Add(GlowingAureateStrandofMightGuild.DisplayName, new GlowingAureateStrandofMightGuild(1));
            dict.Add(GlowingAureateStrandofMoraleGuild.DisplayName, new GlowingAureateStrandofMoraleGuild(1));
            dict.Add(GrandAmuletoftheAshenEagle.DisplayName, new GrandAmuletoftheAshenEagle(1));
            dict.Add(GrandAmuletoftheOnyxLynx.DisplayName, new GrandAmuletoftheOnyxLynx(1));
            dict.Add(GrandAmuletoftheSpottedLynx.DisplayName, new GrandAmuletoftheSpottedLynx(1));
            dict.Add(IcyRunestoneoftheGaladhrim.DisplayName, new IcyRunestoneoftheGaladhrim(1));
            dict.Add(IcyRunestoneoftheGoldenHost.DisplayName, new IcyRunestoneoftheGoldenHost(1));
            dict.Add(KhazadcopperBracelet.DisplayName, new KhazadcopperBracelet(1));
            dict.Add(KhazadcopperEarring.DisplayName, new KhazadcopperEarring(1));
            dict.Add(KhazadcopperFlintRunestone.DisplayName, new KhazadcopperFlintRunestone(1));
            dict.Add(KhazadcopperIcyRunestone.DisplayName, new KhazadcopperIcyRunestone(1));
            dict.Add(KhazadcopperNecklace.DisplayName, new KhazadcopperNecklace(1));
            dict.Add(KhazadcopperObsidianRunestone.DisplayName, new KhazadcopperObsidianRunestone(1));
            dict.Add(KhazadcopperRing.DisplayName, new KhazadcopperRing(1));
            dict.Add(KhazadgoldBracelet.DisplayName, new KhazadgoldBracelet(1));
            dict.Add(KhazadgoldIcyRunestone.DisplayName, new KhazadgoldIcyRunestone(1));
            dict.Add(KhazadgoldEarring.DisplayName, new KhazadgoldEarring(1));
            dict.Add(KhazadgoldRing.DisplayName, new KhazadgoldRing(1));
            dict.Add(KhazadgoldNecklace.DisplayName, new KhazadgoldNecklace(1));
            dict.Add(LargeSupremeSymbol.DisplayName, new LargeSupremeSymbol(1));
            dict.Add(MediumSupremeSymbol.DisplayName, new MediumSupremeSymbol(1));
            dict.Add(ObsidianRunestoneoftheGaladhrim.DisplayName, new ObsidianRunestoneoftheGaladhrim(1));
            dict.Add(ObsidianRunestoneoftheGoldenHost.DisplayName, new ObsidianRunestoneoftheGoldenHost(1));
            dict.Add(PerfectFlintRunestoneoftheGaladhrimGuild.DisplayName, new PerfectFlintRunestoneoftheGaladhrimGuild(1));
            dict.Add(PerfectIcyRunestoneoftheGaladhrimGuild.DisplayName, new PerfectIcyRunestoneoftheGaladhrimGuild(1));
            dict.Add(PerfectObsidianRunestoneoftheGaladhrimGuild.DisplayName, new PerfectObsidianRunestoneoftheGaladhrimGuild(1));
            dict.Add(PhilosophersGreenwoodBracelet.DisplayName, new PhilosophersGreenwoodBracelet(1));
            dict.Add(PhilosophersGreenwoodEarring.DisplayName, new PhilosophersGreenwoodEarring(1));
            dict.Add(PhilosophersGreenwoodNecklace.DisplayName, new PhilosophersGreenwoodNecklace(1));
            dict.Add(PhilosophersGreenwoodRing.DisplayName, new PhilosophersGreenwoodRing(1));
            dict.Add(PolishedAquamarine.DisplayName, new PolishedAquamarine(1));
            dict.Add(PolishedAquamarinesGuild.DisplayName, new PolishedAquamarinesGuild(1));
            dict.Add(PolishedDawnRose.DisplayName, new PolishedDawnRose(1));
            dict.Add(PolishedDawnrosesGuild.DisplayName, new PolishedDawnrosesGuild(1));
            dict.Add(ReforgedChampionsRuneoftheSecondAge.DisplayName, new ReforgedChampionsRuneoftheSecondAge(1));
            dict.Add(ReforgedChampionsRuneoftheSecondAgeLevel65.DisplayName, new ReforgedChampionsRuneoftheSecondAgeLevel65(1));
            dict.Add(ReforgedFlintRunestoneoftheSecondAgeLevel60.DisplayName, new ReforgedFlintRunestoneoftheSecondAgeLevel60(1));
            dict.Add(ReforgedFlintRunestoneoftheSecondAgeLevel65.DisplayName, new ReforgedFlintRunestoneoftheSecondAgeLevel65(1));
            dict.Add(ReforgedIcyRunestoneoftheSecondAgeLevel60.DisplayName, new ReforgedIcyRunestoneoftheSecondAgeLevel60(1));
            dict.Add(ReforgedIcyRunestoneoftheSecondAgeLevel65.DisplayName, new ReforgedIcyRunestoneoftheSecondAgeLevel65(1));
            dict.Add(ReforgedObsidianRunestoneoftheSecondAgeLevel60.DisplayName, new ReforgedObsidianRunestoneoftheSecondAgeLevel60(1));
            dict.Add(ReforgedObsidianRunestoneoftheSecondAgeLevel65.DisplayName, new ReforgedObsidianRunestoneoftheSecondAgeLevel65(1));
            dict.Add(RoyalCirclet.DisplayName, new RoyalCirclet(1));
            dict.Add(SmallSupremeSymbol.DisplayName, new SmallSupremeSymbol(1));
            dict.Add(SparklingEdhelharnToken.DisplayName, new SparklingEdhelharnToken(1));
            dict.Add(SublimeDawnroseBraceletGuild.DisplayName, new SublimeDawnroseBraceletGuild(1));
            dict.Add(SublimeDawnroseEarringGuild.DisplayName, new SublimeDawnroseEarringGuild(1));
            dict.Add(SublimeDawnroseNecklaceGuild.DisplayName, new SublimeDawnroseNecklaceGuild(1));
            dict.Add(SublimeDawnroseObsidianRunestoneGuild.DisplayName, new SublimeDawnroseObsidianRunestoneGuild(1));
            dict.Add(SublimeDawnroseRingGuild.DisplayName, new SublimeDawnroseRingGuild(1));
            dict.Add(SuperbAmuletoftheFrostlynx.DisplayName, new SuperbAmuletoftheFrostlynx(1));
            dict.Add(SuperbAmuletoftheOnyxLynx.DisplayName, new SuperbAmuletoftheOnyxLynx(1));
            dict.Add(SuperbAmuletoftheSnowcrestEagle.DisplayName, new SuperbAmuletoftheSnowcrestEagle(1));
            dict.Add(TurtleshellBracelet.DisplayName, new TurtleshellBracelet(1));
            dict.Add(WanderersGreenwoodBracelet.DisplayName, new WanderersGreenwoodBracelet(1));
            dict.Add(WanderersGreenwoodEarring.DisplayName, new WanderersGreenwoodEarring(1));
            dict.Add(WanderersGreenwoodNecklace.DisplayName, new WanderersGreenwoodNecklace(1));
            dict.Add(WanderersGreenwoodRing.DisplayName, new WanderersGreenwoodRing(1));
        }
    }
}