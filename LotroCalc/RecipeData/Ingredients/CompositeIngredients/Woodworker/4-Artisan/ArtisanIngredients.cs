using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker._4_Artisan
{
    public abstract class ArtisanIngredients : WoodworkerIngredients
    {
        protected ArtisanIngredients()
        {
            Tier = ProfessionTierEnum.Artisan;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(ArtisanBlazonedCrestOfFocus.DisplayName, new ArtisanBlazonedCrestOfFocus(1));
            dict.Add(ArtisanBlazonedCrestOfHope.DisplayName, new ArtisanBlazonedCrestOfHope(1));
            dict.Add(ArtisanBlazonedCrestOfVictory.DisplayName, new ArtisanBlazonedCrestOfVictory(1));
            dict.Add(ArtisanBlazonedCrestOfWar.DisplayName, new ArtisanBlazonedCrestOfWar(1));
            dict.Add(BattleHorn.DisplayName, new BattleHorn(1));
            dict.Add(CarvedLebethronBow.DisplayName, new CarvedLebethronBow(1));
            dict.Add(CarvedLebethronClub.DisplayName, new CarvedLebethronClub(1));
            dict.Add(CarvedLebethronCrossbow.DisplayName, new CarvedLebethronCrossbow(1));
            dict.Add(CarvedLebethronGreatClub.DisplayName, new CarvedLebethronGreatClub(1));
            dict.Add(CarvedLebethronHammer.DisplayName, new CarvedLebethronHammer(1));
            dict.Add(CarvedLebethronJavelin.DisplayName, new CarvedLebethronJavelin(1));
            dict.Add(CarvedLebethronSpear.DisplayName, new CarvedLebethronSpear(1));
            dict.Add(CarvedLebethronStaff.DisplayName, new CarvedLebethronStaff(1));
            dict.Add(FistCarving.DisplayName, new FistCarving(1));
            dict.Add(ImprovedLebethronBowstaffGuild.DisplayName, new ImprovedLebethronBowstaffGuild(1));
            dict.Add(ImprovedLebethronHaftGuild.DisplayName, new ImprovedLebethronHaftGuild(1));
            dict.Add(ImprovedReinforcedLebethronBraceGuild.DisplayName, new ImprovedReinforcedLebethronBraceGuild(1));
            dict.Add(ImprovedReinforcedLebethronShaftGuild.DisplayName, new ImprovedReinforcedLebethronShaftGuild(1));
            dict.Add(LebethronBow.DisplayName, new LebethronBow(1));
            dict.Add(LebethronBowstaff.DisplayName, new LebethronBowstaff(1));
            dict.Add(LebethronClub.DisplayName, new LebethronClub(1));
            dict.Add(LebethronCrossbow.DisplayName, new LebethronCrossbow(1));
            dict.Add(LebethronFishingRod.DisplayName, new LebethronFishingRod(1));
            dict.Add(LebethronGreatClub.DisplayName, new LebethronGreatClub(1));
            dict.Add(LebethronHammer.DisplayName, new LebethronHammer(1));
            dict.Add(LebethronHaft.DisplayName, new LebethronHaft(1));
            dict.Add(LebethronJavelin.DisplayName, new LebethronJavelin(1));
            dict.Add(LebethronSpear.DisplayName, new LebethronSpear(1));
            dict.Add(LebethronStaff.DisplayName, new LebethronStaff(1));
            dict.Add(MediumArtisanCarving.DisplayName, new MediumArtisanCarving(1));
            dict.Add(OrnateLebethronBowGuild.DisplayName, new OrnateLebethronBowGuild(1));
            dict.Add(OrnateLebethronClubGuild.DisplayName, new OrnateLebethronClubGuild(1));
            dict.Add(OrnateLebethronCrossbowGuild.DisplayName, new OrnateLebethronCrossbowGuild(1));
            dict.Add(OrnateLebethronGreatClubGuild.DisplayName, new OrnateLebethronGreatClubGuild(1));
            dict.Add(OrnateLebethronHammerGuild.DisplayName, new OrnateLebethronHammerGuild(1));
            dict.Add(OrnateLebethronJavelinGuild.DisplayName, new OrnateLebethronJavelinGuild(1));
            dict.Add(OrnateLebethronSpearGuild.DisplayName, new OrnateLebethronSpearGuild(1));
            dict.Add(OrnateLebethronStaffGuild.DisplayName, new OrnateLebethronStaffGuild(1));
            dict.Add(ReinforcedLebethronBow.DisplayName, new ReinforcedLebethronBow(1));
            dict.Add(ReinforcedLebethronBrace.DisplayName, new ReinforcedLebethronBrace(1));
            dict.Add(ReinforcedLebethronClub.DisplayName, new ReinforcedLebethronClub(1));
            dict.Add(ReinforcedLebethronCrossbow.DisplayName, new ReinforcedLebethronCrossbow(1));
            dict.Add(ReinforcedLebethronGreatClub.DisplayName, new ReinforcedLebethronGreatClub(1));
            dict.Add(ReinforcedLebethronHammer.DisplayName, new ReinforcedLebethronHammer(1));
            dict.Add(ReinforcedLebethronJavelin.DisplayName, new ReinforcedLebethronJavelin(1));
            dict.Add(ReinforcedLebethronShaft.DisplayName, new ReinforcedLebethronShaft(1));
            dict.Add(ReinforcedLebethronSpear.DisplayName, new ReinforcedLebethronSpear(1));
            dict.Add(ReinforcedLebethronStaff.DisplayName, new ReinforcedLebethronStaff(1));
            dict.Add(ScholarsCupboard.DisplayName, new ScholarsCupboard(1));
            dict.Add(ScholarsRoundTable.DisplayName, new ScholarsRoundTable(1));
            dict.Add(ShieldCarving.DisplayName, new ShieldCarving(1));
            dict.Add(SmallArtisanCarving.DisplayName, new SmallArtisanCarving(1));
            dict.Add(SmoothLebethronBow.DisplayName, new SmoothLebethronBow(1));
            dict.Add(SmoothLebethronClub.DisplayName, new SmoothLebethronClub(1));
            dict.Add(SmoothLebethronCrossbow.DisplayName, new SmoothLebethronCrossbow(1));
            dict.Add(SmoothLebethronGreatClub.DisplayName, new SmoothLebethronGreatClub(1));
            dict.Add(SmoothLebethronHammer.DisplayName, new SmoothLebethronHammer(1));
            dict.Add(SmoothLebethronJavelin.DisplayName, new SmoothLebethronJavelin(1));
            dict.Add(SmoothLebethronSpear.DisplayName, new SmoothLebethronSpear(1));
            dict.Add(SmoothLebethronStaff.DisplayName, new SmoothLebethronStaff(1));
            dict.Add(SpearCarving.DisplayName, new SpearCarving(1));
            dict.Add(SuperiorDrum.DisplayName, new SuperiorDrum(1));
            dict.Add(SuperiorFlute.DisplayName, new SuperiorFlute(1));
            dict.Add(SuperiorHarp.DisplayName, new SuperiorHarp(1));
            dict.Add(SuperiorLute.DisplayName, new SuperiorLute(1));
            dict.Add(SuperiorTheorbo.DisplayName, new SuperiorTheorbo(1));
            dict.Add(WoodFigurine.DisplayName, new WoodFigurine(1));
        }
    }
}