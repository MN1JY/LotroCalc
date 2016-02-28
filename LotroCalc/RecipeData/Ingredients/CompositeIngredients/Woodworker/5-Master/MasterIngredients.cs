using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker._5_Master
{
    public abstract class MasterIngredients : WoodworkerIngredients
    {
        protected MasterIngredients()
        {
            Tier = ProfessionTierEnum.Master;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BlackAshBow.DisplayName, new BlackAshBow(1));
            dict.Add(BlackAshBowstaff.DisplayName, new BlackAshBowstaff(1));
            dict.Add(BlackAshClub.DisplayName, new BlackAshClub(1));
            dict.Add(BlackAshCrossbow.DisplayName, new BlackAshCrossbow(1));
            dict.Add(BlackAshGreatClub.DisplayName, new BlackAshGreatClub(1));
            dict.Add(BlackAshGreatHammer.DisplayName, new BlackAshGreatHammer(1));
            dict.Add(BlackAshJavelin.DisplayName, new BlackAshJavelin(1));
            dict.Add(BlackAshHaft.DisplayName, new BlackAshHaft(1));
            dict.Add(BlackAshSpear.DisplayName, new BlackAshSpear(1));
            dict.Add(BlackAshStaff.DisplayName, new BlackAshStaff(1));
            dict.Add(CarvedBlackAshBow.DisplayName, new CarvedBlackAshBow(1));
            dict.Add(CarvedBlackAshClub.DisplayName, new CarvedBlackAshClub(1));
            dict.Add(CarvedBlackAshCrossbow.DisplayName, new CarvedBlackAshCrossbow(1));
            dict.Add(CarvedBlackAshGreatClub.DisplayName, new CarvedBlackAshGreatClub(1));
            dict.Add(CarvedBlackAshHammer.DisplayName, new CarvedBlackAshHammer(1));
            dict.Add(CarvedBlackAshJavelin.DisplayName, new CarvedBlackAshJavelin(1));
            dict.Add(CarvedBlackAshSpear.DisplayName, new CarvedBlackAshSpear(1));
            dict.Add(CarvedBlackAshStaff.DisplayName, new CarvedBlackAshStaff(1));
            dict.Add(CombatHorn.DisplayName, new CombatHorn(1));
            dict.Add(CompositeBlackAshBrace.DisplayName, new CompositeBlackAshBrace(1));
            dict.Add(CompositeBlackAshShaft.DisplayName, new CompositeBlackAshShaft(1));
            dict.Add(ImprovedBlackAshBowstaffGuild.DisplayName, new ImprovedBlackAshBowstaffGuild(1));
            dict.Add(ImprovedBlackAshHaftGuild.DisplayName, new ImprovedBlackAshHaftGuild(1));
            dict.Add(ImprovedCompositeBlackAshBraceGuild.DisplayName, new ImprovedCompositeBlackAshBraceGuild(1));
            dict.Add(ImprovedCompositeBlackAshShaftGuild.DisplayName, new ImprovedCompositeBlackAshShaftGuild(1));
            dict.Add(Kerialaulu.DisplayName, new Kerialaulu(1));
            dict.Add(LargeMasterCarving.DisplayName, new LargeMasterCarving(1));
            dict.Add(MajorFistCarving.DisplayName, new MajorFistCarving(1));
            dict.Add(MajorShieldCarving.DisplayName, new MajorShieldCarving(1));
            dict.Add(MajorSpearCarving.DisplayName, new MajorSpearCarving(1));
            dict.Add(MasterBlazonedCrestOfFocus.DisplayName, new MasterBlazonedCrestOfFocus(1));
            dict.Add(MasterBlazonedCrestOfHope.DisplayName, new MasterBlazonedCrestOfHope(1));
            dict.Add(MasterBlazonedCrestOfVictory.DisplayName, new MasterBlazonedCrestOfVictory(1));
            dict.Add(MasterBlazonedCrestOfWar.DisplayName, new MasterBlazonedCrestOfWar(1));
            dict.Add(MediumMasterCarving.DisplayName, new MediumMasterCarving(1));
            dict.Add(OrnateBlackAshBowGuild.DisplayName, new OrnateBlackAshBowGuild(1));
            dict.Add(OrnateBlackAshClubGuild.DisplayName, new OrnateBlackAshClubGuild(1));
            dict.Add(OrnateBlackAshCrossbowGuild.DisplayName, new OrnateBlackAshCrossbowGuild(1));
            dict.Add(OrnateBlackAshGreatClubGuild.DisplayName, new OrnateBlackAshGreatClubGuild(1));
            dict.Add(OrnateBlackAshHammerGuild.DisplayName, new OrnateBlackAshHammerGuild(1));
            dict.Add(OrnateBlackAshJavelinGuild.DisplayName, new OrnateBlackAshJavelinGuild(1));
            dict.Add(OrnateBlackAshSpearGuild.DisplayName, new OrnateBlackAshSpearGuild(1));
            dict.Add(OrnateBlackAshStaffGuild.DisplayName, new OrnateBlackAshStaffGuild(1));
            dict.Add(ReinforcedBlackAshBow.DisplayName, new ReinforcedBlackAshBow(1));
            dict.Add(ReinforcedBlackAshClub.DisplayName, new ReinforcedBlackAshClub(1));
            dict.Add(ReinforcedBlackAshCrossbow.DisplayName, new ReinforcedBlackAshCrossbow(1));
            dict.Add(ReinforcedBlackAshGreatClub.DisplayName, new ReinforcedBlackAshGreatClub(1));
            dict.Add(ReinforcedBlackAshHammer.DisplayName, new ReinforcedBlackAshHammer(1));
            dict.Add(ReinforcedBlackAshJavelin.DisplayName, new ReinforcedBlackAshJavelin(1));
            dict.Add(ReinforcedBlackAshSpear.DisplayName, new ReinforcedBlackAshSpear(1));
            dict.Add(ReinforcedBlackAshStaff.DisplayName, new ReinforcedBlackAshStaff(1));
            dict.Add(Satakieli.DisplayName, new Satakieli(1));
            dict.Add(SmallMasterCarving.DisplayName, new SmallMasterCarving(1));
            dict.Add(SmoothBlackAshBow.DisplayName, new SmoothBlackAshBow(1));
            dict.Add(SmoothBlackAshClub.DisplayName, new SmoothBlackAshClub(1));
            dict.Add(SmoothBlackAshCrossbow.DisplayName, new SmoothBlackAshCrossbow(1));
            dict.Add(SmoothBlackAshGreatClub.DisplayName, new SmoothBlackAshGreatClub(1));
            dict.Add(SmoothBlackAshHammer.DisplayName, new SmoothBlackAshHammer(1));
            dict.Add(SmoothBlackAshJavelin.DisplayName, new SmoothBlackAshJavelin(1));
            dict.Add(SmoothBlackAshSpear.DisplayName, new SmoothBlackAshSpear(1));
            dict.Add(SmoothBlackAshStaff.DisplayName, new SmoothBlackAshStaff(1));
            dict.Add(SuperiorBeleriandDrum.DisplayName, new SuperiorBeleriandDrum(1));
            dict.Add(SuperiorBeleriandFlute.DisplayName, new SuperiorBeleriandFlute(1));
            dict.Add(SuperiorBeleriandHarp.DisplayName, new SuperiorBeleriandHarp(1));
            dict.Add(SuperiorBeleriandLute.DisplayName, new SuperiorBeleriandLute(1));
            dict.Add(SuperiorBeleriandTheorbo.DisplayName, new SuperiorBeleriandTheorbo(1));
            dict.Add(SuperiorDwarfmakeDrum.DisplayName, new SuperiorDwarfmakeDrum(1));
            dict.Add(SuperiorDwarfmakeFlute.DisplayName, new SuperiorDwarfmakeFlute(1));
            dict.Add(SuperiorDwarfmakeHarp.DisplayName, new SuperiorDwarfmakeHarp(1));
            dict.Add(SuperiorDwarfmakeLute.DisplayName, new SuperiorDwarfmakeLute(1));
            dict.Add(SuperiorDwarfmakeTheorbo.DisplayName, new SuperiorDwarfmakeTheorbo(1));
            dict.Add(SuperiorWesternesseDrum.DisplayName, new SuperiorWesternesseDrum(1));
            dict.Add(SuperiorWesternesseFlute.DisplayName, new SuperiorWesternesseFlute(1));
            dict.Add(SuperiorWesternesseHarp.DisplayName, new SuperiorWesternesseHarp(1));
            dict.Add(SuperiorWesternesseLute.DisplayName, new SuperiorWesternesseLute(1));
            dict.Add(SuperiorWesternesseTheorbo.DisplayName, new SuperiorWesternesseTheorbo(1));
            dict.Add(Vaitivoima.DisplayName, new Vaitivoima(1));
            dict.Add(Viol.DisplayName, new Viol(1));
        }
    }
}