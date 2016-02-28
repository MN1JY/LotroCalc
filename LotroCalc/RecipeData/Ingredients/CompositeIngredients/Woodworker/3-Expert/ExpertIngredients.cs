using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker._3_Expert
{
    public abstract class ExpertIngredients : WoodworkerIngredients
    {
        protected ExpertIngredients()
        {
            Tier = ProfessionTierEnum.Expert;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(CarvedYewBow.DisplayName, new CarvedYewBow(1));
            dict.Add(CarvedYewClub.DisplayName, new CarvedYewClub(1));
            dict.Add(CarvedYewCrossbow.DisplayName, new CarvedYewCrossbow(1));
            dict.Add(CarvedYewGreatClub.DisplayName, new CarvedYewGreatClub(1));
            dict.Add(CarvedYewHammer.DisplayName, new CarvedYewHammer(1));
            dict.Add(CarvedYewJavelin.DisplayName, new CarvedYewJavelin(1));
            dict.Add(CarvedYewSpear.DisplayName, new CarvedYewSpear(1));
            dict.Add(CarvedYewStaff.DisplayName, new CarvedYewStaff(1));
            dict.Add(CraftedDrum.DisplayName, new CraftedDrum(1));
            dict.Add(CraftedFlute.DisplayName, new CraftedFlute(1));
            dict.Add(CraftedHarp.DisplayName, new CraftedHarp(1));
            dict.Add(CraftedLute.DisplayName, new CraftedLute(1));
            dict.Add(CraftedTheorbo.DisplayName, new CraftedTheorbo(1));
            dict.Add(EtchedYewBow.DisplayName, new EtchedYewBow(1));
            dict.Add(EtchedYewBrace.DisplayName, new EtchedYewBrace(1));
            dict.Add(EtchedYewClub.DisplayName, new EtchedYewClub(1));
            dict.Add(EtchedYewCrossbow.DisplayName, new EtchedYewCrossbow(1));
            dict.Add(EtchedYewGreatClub.DisplayName, new EtchedYewGreatClub(1));
            dict.Add(EtchedYewHammer.DisplayName, new EtchedYewHammer(1));
            dict.Add(EtchedYewJavelin.DisplayName, new EtchedYewJavelin(1));
            dict.Add(EtchedYewShaft.DisplayName, new EtchedYewShaft(1));
            dict.Add(EtchedYewSpear.DisplayName, new EtchedYewSpear(1));
            dict.Add(EtchedYewStaff.DisplayName, new EtchedYewStaff(1));
            dict.Add(ExpertBlazonedCrestOfFocus.DisplayName, new ExpertBlazonedCrestOfFocus(1));
            dict.Add(ExpertBlazonedCrestOfHope.DisplayName, new ExpertBlazonedCrestOfHope(1));
            dict.Add(ExpertBlazonedCrestOfVictory.DisplayName, new ExpertBlazonedCrestOfVictory(1));
            dict.Add(ExpertBlazonedCrestOfWar.DisplayName, new ExpertBlazonedCrestOfWar(1));
            dict.Add(HeavyYewBow.DisplayName, new HeavyYewBow(1));
            dict.Add(HeavyYewClub.DisplayName, new HeavyYewClub(1));
            dict.Add(HeavyYewCrossbow.DisplayName, new HeavyYewCrossbow(1));
            dict.Add(HeavyYewGreatClub.DisplayName, new HeavyYewGreatClub(1));
            dict.Add(HeavyYewHammer.DisplayName, new HeavyYewHammer(1));
            dict.Add(HeavyYewJavelin.DisplayName, new HeavyYewJavelin(1));
            dict.Add(HeavyYewSpear.DisplayName, new HeavyYewSpear(1));
            dict.Add(HeavyYewStaff.DisplayName, new HeavyYewStaff(1));
            dict.Add(ImprovedEtchedYewBraceGuild.DisplayName, new ImprovedEtchedYewBraceGuild(1));
            dict.Add(ImprovedEtchedYewShaftGuild.DisplayName, new ImprovedEtchedYewShaftGuild(1));
            dict.Add(ImprovedYewBowstaffGuild.DisplayName, new ImprovedYewBowstaffGuild(1));
            dict.Add(ImprovedYewHaftGuild.DisplayName, new ImprovedYewHaftGuild(1));
            dict.Add(LesserFistCarving.DisplayName, new LesserFistCarving(1));
            dict.Add(LesserShieldCarving.DisplayName, new LesserShieldCarving(1));
            dict.Add(LesserSpearCarving.DisplayName, new LesserSpearCarving(1));
            dict.Add(MediumExpertCarving.DisplayName, new MediumExpertCarving(1));
            dict.Add(OrnateYewBowGuild.DisplayName, new OrnateYewBowGuild(1));
            dict.Add(OrnateYewCrossbowGuild.DisplayName, new OrnateYewCrossbowGuild(1));
            dict.Add(OrnateYewClubGuild.DisplayName, new OrnateYewClubGuild(1));
            dict.Add(OrnateYewGreatClubGuild.DisplayName, new OrnateYewGreatClubGuild(1));
            dict.Add(OrnateYewHammerGuild.DisplayName, new OrnateYewHammerGuild(1));
            dict.Add(OrnateYewJavelinGuild.DisplayName, new OrnateYewJavelinGuild(1));
            dict.Add(OrnateYewSpearGuild.DisplayName, new OrnateYewSpearGuild(1));
            dict.Add(OrnateYewStaffGuild.DisplayName, new OrnateYewStaffGuild(1));
            dict.Add(RedScholarsBookshelf.DisplayName, new RedScholarsBookshelf(1));
            dict.Add(ScholarsBentwoodBookshelf.DisplayName, new ScholarsBentwoodBookshelf(1));
            dict.Add(ScholarsPointedBookshelf.DisplayName, new ScholarsPointedBookshelf(1));
            dict.Add(SmallExpertCarving.DisplayName, new SmallExpertCarving(1));
            dict.Add(YewBow.DisplayName, new YewBow(1));
            dict.Add(YewBowstaff.DisplayName, new YewBowstaff(1));
            dict.Add(YewClub.DisplayName, new YewClub(1));
            dict.Add(YewCrossbow.DisplayName, new YewCrossbow(1));
            dict.Add(YewGreatClub.DisplayName, new YewGreatClub(1));
            dict.Add(YewHaft.DisplayName, new YewHaft(1));
            dict.Add(YewHammer.DisplayName, new YewHammer(1));
            dict.Add(YewJavelin.DisplayName, new YewJavelin(1));
            dict.Add(YewFishingRod.DisplayName, new YewFishingRod(1));
            dict.Add(YewSpear.DisplayName, new YewSpear(1));
            dict.Add(YewStaff.DisplayName, new YewStaff(1));
        }
    }
}