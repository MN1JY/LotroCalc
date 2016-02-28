using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._2_Journeyman
{
    public abstract class JourneymanIngredients : TailorIngredients 
    {
        protected JourneymanIngredients()
        {
            Tier = ProfessionTierEnum.Journeyman;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(CrudeBurglarTools.DisplayName, new CrudeBurglarTools(1));
            dict.Add(DwarfmakeLinenArmour.DisplayName, new DwarfmakeLinenArmour(1));
            dict.Add(DwarfmakeLinenGloves.DisplayName, new DwarfmakeLinenGloves(1));
            dict.Add(DwarfmakeLinenLeggings.DisplayName, new DwarfmakeLinenLeggings(1));
            dict.Add(DwarfmakeLinenShoes.DisplayName, new DwarfmakeLinenShoes(1));
            dict.Add(DwarfmakeLinenShoulderGuards.DisplayName, new DwarfmakeLinenShoulderGuards(1));
            dict.Add(FancyDwarfmakeQuiver.DisplayName, new FancyDwarfmakeQuiver(1));
            dict.Add(FineQuiver.DisplayName, new FineQuiver(1));
            dict.Add(LargeWhiteLeafBorderRug.DisplayName, new LargeWhiteLeafBorderRug(1));
            dict.Add(LeatherBrace.DisplayName, new LeatherBrace(1));
            dict.Add(LeatherGuard.DisplayName, new LeatherGuard(1));
            dict.Add(HeavyLeatherArmour.DisplayName, new HeavyLeatherArmour(1));
            dict.Add(HeavyLeatherGloves.DisplayName, new HeavyLeatherGloves(1));
            dict.Add(HeavyLeatherHelm.DisplayName, new HeavyLeatherHelm(1));
            dict.Add(HeavyLeatherLeggings.DisplayName, new HeavyLeatherLeggings(1));
            dict.Add(HeavyLeatherShoes.DisplayName, new HeavyLeatherShoes(1));
            dict.Add(HeavyLeatherShoulderGuards.DisplayName, new HeavyLeatherShoulderGuards(1));
            dict.Add(HeavyQuiltedArmour.DisplayName, new HeavyQuiltedArmour(1));
            dict.Add(HeavyQuiltedCloak.DisplayName, new HeavyQuiltedCloak(1));
            dict.Add(HeavyQuiltedGloves.DisplayName, new HeavyQuiltedGloves(1));
            dict.Add(HeavyQuiltedHood.DisplayName, new HeavyQuiltedHood(1));
            dict.Add(HeavyQuiltedLeggings.DisplayName, new HeavyQuiltedLeggings(1));
            dict.Add(HeavyQuiltedRobe.DisplayName, new HeavyQuiltedRobe(1));
            dict.Add(HeavyQuiltedShoes.DisplayName, new HeavyQuiltedShoes(1));
            dict.Add(HeavyQuiltedShoulderGuards.DisplayName, new HeavyQuiltedShoulderGuards(1));
            dict.Add(LeatherArmour.DisplayName, new LeatherArmour(1));
            dict.Add(LeatherGloves.DisplayName, new LeatherGloves(1));
            dict.Add(LeatherHelm.DisplayName, new LeatherHelm(1));
            dict.Add(LeatherLeggings.DisplayName, new LeatherLeggings(1));
            dict.Add(LeatherShoes.DisplayName, new LeatherShoes(1));
            dict.Add(LeatherShoulderGuards.DisplayName, new LeatherShoulderGuards(1));
            dict.Add(LinenArmour.DisplayName, new LinenArmour(1));
            dict.Add(LinenCloak.DisplayName, new LinenCloak(1));
            dict.Add(LinenGloves.DisplayName, new LinenGloves(1));
            dict.Add(LinenHat.DisplayName, new LinenHat(1));
            dict.Add(LinenLeggings.DisplayName, new LinenLeggings(1));
            dict.Add(LinenRobe.DisplayName, new LinenRobe(1));
            dict.Add(LinenShoes.DisplayName, new LinenShoes(1));
            dict.Add(LinenShoulderGuards.DisplayName, new LinenShoulderGuards(1));
            dict.Add(LooseDwarfmakeLinenArmour.DisplayName, new LooseDwarfmakeLinenArmour(1));
            dict.Add(LooseDwarfmakeLinenGloves.DisplayName, new LooseDwarfmakeLinenGloves(1));
            dict.Add(LooseDwarfmakeLinenLeggings.DisplayName, new LooseDwarfmakeLinenLeggings(1));
            dict.Add(LooseDwarfmakeLinenShoes.DisplayName, new LooseDwarfmakeLinenShoes(1));
            dict.Add(LooseDwarfmakeLinenShoulderGuards.DisplayName, new LooseDwarfmakeLinenShoulderGuards(1));
            dict.Add(LooseLinenArmour.DisplayName, new LooseLinenArmour(1));
            dict.Add(LooseLinenCloak.DisplayName, new LooseLinenCloak(1));
            dict.Add(LooseLinenGloves.DisplayName, new LooseLinenGloves(1));
            dict.Add(LooseLinenHood.DisplayName, new LooseLinenHood(1));
            dict.Add(LooseLinenLeggings.DisplayName, new LooseLinenLeggings(1));
            dict.Add(LooseLinenRobe.DisplayName, new LooseLinenRobe(1));
            dict.Add(LooseLinenShoes.DisplayName, new LooseLinenShoes(1));
            dict.Add(LooseLinenShoulderGuards.DisplayName, new LooseLinenShoulderGuards(1));
            dict.Add(MinorCommonerHeraldArmaments.DisplayName, new MinorCommonerHeraldArmaments(1));
            dict.Add(MinorMaidatarmsHeraldArmaments.DisplayName, new MinorMaidatarmsHeraldArmaments(1));
            dict.Add(MinorManatarmsHeraldArmaments.DisplayName, new MinorManatarmsHeraldArmaments(1));
            dict.Add(MinorPilgrimHeraldArmaments.DisplayName, new MinorPilgrimHeraldArmaments(1));
            dict.Add(MinorShieldmaidenHeraldArmaments.DisplayName, new MinorShieldmaidenHeraldArmaments(1));
            dict.Add(MinorSquireHeraldArmaments.DisplayName, new MinorSquireHeraldArmaments(1));
            dict.Add(MinorSwordswomanHeraldArmaments.DisplayName, new MinorSwordswomanHeraldArmaments(1));
            dict.Add(QuiltedArmour.DisplayName, new QuiltedArmour(1));
            dict.Add(QuiltedCloak.DisplayName, new QuiltedCloak(1));
            dict.Add(QuiltedGloves.DisplayName, new QuiltedGloves(1));
            dict.Add(QuiltedHat.DisplayName, new QuiltedHat(1));
            dict.Add(QuiltedLeggings.DisplayName, new QuiltedLeggings(1));
            dict.Add(QuiltedRobe.DisplayName, new QuiltedRobe(1));
            dict.Add(QuiltedShoes.DisplayName, new QuiltedShoes(1));
            dict.Add(QuiltedShoulderGuards.DisplayName, new QuiltedShoulderGuards(1));
            dict.Add(SturdyElvenQuiver.DisplayName, new SturdyElvenQuiver(1));
            dict.Add(StudentsRunesatchelofDagor.DisplayName, new StudentsRunesatchelofDagor(1));
            dict.Add(StudentsRunesatchelofNestad.DisplayName, new StudentsRunesatchelofNestad(1));
            dict.Add(StudentsRunesatchelofThalas.DisplayName, new StudentsRunesatchelofThalas(1));
            dict.Add(SuperbDwarfmakeLeatherArmour.DisplayName, new SuperbDwarfmakeLeatherArmour(1));
            dict.Add(SuperbDwarfmakeLeatherGloves.DisplayName, new SuperbDwarfmakeLeatherGloves(1));
            dict.Add(SuperbDwarfmakeLeatherLeggings.DisplayName, new SuperbDwarfmakeLeatherLeggings(1));
            dict.Add(SuperbDwarfmakeLeatherShoes.DisplayName, new SuperbDwarfmakeLeatherShoes(1));
            dict.Add(SuperbDwarfmakeLeatherShoulderGuards.DisplayName, new SuperbDwarfmakeLeatherShoulderGuards(1));
            dict.Add(SuperbLeatherArmour.DisplayName, new SuperbLeatherArmour(1));
            dict.Add(SuperbLeatherGloves.DisplayName, new SuperbLeatherGloves(1));
            dict.Add(SuperbLeatherHelm.DisplayName, new SuperbLeatherHelm(1));
            dict.Add(SuperbLeatherLeggings.DisplayName, new SuperbLeatherLeggings(1));
            dict.Add(SuperbLeatherShoes.DisplayName, new SuperbLeatherShoes(1));
            dict.Add(SuperbLeatherShoulderGuards.DisplayName, new SuperbLeatherShoulderGuards(1));
            dict.Add(ToughDwarfmakeLeatherArmour.DisplayName, new ToughDwarfmakeLeatherArmour(1));
            dict.Add(ToughDwarfmakeLeatherGloves.DisplayName, new ToughDwarfmakeLeatherGloves(1));
            dict.Add(ToughDwarfmakeLeatherLeggings.DisplayName, new ToughDwarfmakeLeatherLeggings(1));
            dict.Add(ToughDwarfmakeLeatherShoes.DisplayName, new ToughDwarfmakeLeatherShoes(1));
            dict.Add(ToughDwarfmakeLeatherShoulderGuards.DisplayName, new ToughDwarfmakeLeatherShoulderGuards(1));
            dict.Add(ToughLeatherArmour.DisplayName, new ToughLeatherArmour(1));
            dict.Add(ToughLeatherGloves.DisplayName, new ToughLeatherGloves(1));
            dict.Add(ToughLeatherHelm.DisplayName, new ToughLeatherHelm(1));
            dict.Add(ToughLeatherLeggings.DisplayName, new ToughLeatherLeggings(1));
            dict.Add(ToughLeatherPad.DisplayName, new ToughLeatherPad(1));
            dict.Add(ToughLeatherShoes.DisplayName, new ToughLeatherShoes(1));
            dict.Add(ToughLeatherShoulderGuards.DisplayName, new ToughLeatherShoulderGuards(1));
        }
    }
}