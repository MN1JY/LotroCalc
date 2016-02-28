using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._1_Apprentice;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._5_Master
{
    public abstract class MasterIngredients : MetalsmithIngredients
    {
        protected MasterIngredients()
        {
            Tier = ProfessionTierEnum.Master;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AncientIronCookingSupplies.DisplayName, new AncientIronCookingSupplies(1));
            dict.Add(AncientIronFarmingTools.DisplayName, new AncientIronFarmingTools(1));
            dict.Add(AncientIronForestersAxe.DisplayName, new AncientIronForestersAxe(1));
            dict.Add(AncientIronJewellersTools.DisplayName, new AncientIronJewellersTools(1));
            dict.Add(AncientIronProspectorsTools.DisplayName, new AncientIronProspectorsTools(1));
            dict.Add(AncientIronScholarsGlass.DisplayName, new AncientIronScholarsGlass(1));
            dict.Add(AncientIronSmithingHammer.DisplayName, new AncientIronSmithingHammer(1));
            dict.Add(AncientIronTailorsTools.DisplayName, new AncientIronTailorsTools(1));
            dict.Add(AncientIronWoodworkingTools.DisplayName, new AncientIronWoodworkingTools(1));
            dict.Add(AncientArmourPlate.DisplayName, new AncientArmourPlate(1));
            dict.Add(AncientSteelChainLink.DisplayName, new AncientSteelChainLink(1));
            dict.Add(AncientSteelCookingSupplies.DisplayName, new AncientSteelCookingSupplies(1));
            dict.Add(AncientSteelFarmingTools.DisplayName, new AncientSteelFarmingTools(1));
            dict.Add(AncientSteelForestersAxe.DisplayName, new AncientSteelForestersAxe(1));
            dict.Add(AncientSteelJewellersTools.DisplayName, new AncientSteelJewellersTools(1));
            dict.Add(AncientSteelProspectorsTools.DisplayName, new AncientSteelProspectorsTools(1));
            dict.Add(AncientSteelScale.DisplayName, new AncientSteelScale(1));
            dict.Add(AncientSteelScholarsGlass.DisplayName, new AncientSteelScholarsGlass(1));
            dict.Add(AncientSteelSmithingHammer.DisplayName, new AncientSteelSmithingHammer(1));
            dict.Add(AncientSteelTailorsTools.DisplayName, new AncientSteelTailorsTools(1));
            dict.Add(AncientSteelWoodworkingTools.DisplayName, new AncientSteelWoodworkingTools(1));
            dict.Add(BalancedWardensShieldoftheElvenKnight.DisplayName, new BalancedWardensShieldoftheElvenKnight(1));
            dict.Add(BalancedWardensShieldOfTheElvenSoldier.DisplayName, new BalancedWardensShieldOfTheElvenSoldier(1));
            dict.Add(CrestOfValour.DisplayName, new CrestOfValour(1));
            dict.Add(DwarfmakeKnightsArmour.DisplayName, new DwarfmakeKnightsArmour(1));
            dict.Add(DwarfmakeKnightsBoots.DisplayName, new DwarfmakeKnightsBoots(1));
            dict.Add(DwarfmakeKnightsGloves.DisplayName, new DwarfmakeKnightsGloves(1));
            dict.Add(DwarfmakeKnightsLeggings.DisplayName, new DwarfmakeKnightsLeggings(1));
            dict.Add(DwarfmakeKnightsShoulderGuards.DisplayName, new DwarfmakeKnightsShoulderGuards(1));
            dict.Add(ElfcraftBrace.DisplayName, new ElfcraftBrace(1));
            dict.Add(ElvenKnightsArmour.DisplayName, new ElvenKnightsArmour(1));
            dict.Add(ElvenKnightsBoots.DisplayName, new ElvenKnightsBoots(1));
            dict.Add(ElvenKnightsGloves.DisplayName, new ElvenKnightsGloves(1));
            dict.Add(ElvenKnightsHeavyShield.DisplayName, new ElvenKnightsHeavyShield(1));
            dict.Add(ElvenKnightsHelm.DisplayName, new ElvenKnightsHelm(1));
            dict.Add(ElvenKnightsLeggings.DisplayName, new ElvenKnightsLeggings(1));
            dict.Add(ElvenKnightsLightShield.DisplayName, new ElvenKnightsLightShield(1));
            dict.Add(ElvenKnightsShield.DisplayName, new ElvenKnightsShield(1));
            dict.Add(ElvenKnightsShoulderGuards.DisplayName, new ElvenKnightsShoulderGuards(1));
            dict.Add(ElvenSoldiersArmour.DisplayName, new ElvenSoldiersArmour(1));
            dict.Add(ElvenSoldiersBoots.DisplayName, new ElvenSoldiersBoots(1));
            dict.Add(ElvenSoldiersGloves.DisplayName, new ElvenSoldiersGloves(1));
            dict.Add(ElvenSoldiersHeavyShield.DisplayName, new ElvenSoldiersHeavyShield(1));
            dict.Add(ElvenSoldiersHelm.DisplayName, new ElvenSoldiersHelm(1));
            dict.Add(ElvenSoldiersLeggings.DisplayName, new ElvenSoldiersLeggings(1));
            dict.Add(ElvenSoldiersLightShield.DisplayName, new ElvenSoldiersLightShield(1));
            dict.Add(ElvenSoldiersShield.DisplayName, new ElvenSoldiersShield(1));
            dict.Add(ElvenSoldiersShoulderGuards.DisplayName, new ElvenSoldiersShoulderGuards(1));
            dict.Add(HardenedElvenKnightsHeavyShield.DisplayName, new HardenedElvenKnightsHeavyShield(1));
            dict.Add(HeavyElvenSoldiersArmour.DisplayName, new HeavyElvenSoldiersArmour(1));
            dict.Add(HeavyElvenSoldiersBoots.DisplayName, new HeavyElvenSoldiersBoots(1));
            dict.Add(HeavyElvenSoldiersGloves.DisplayName, new HeavyElvenSoldiersGloves(1));
            dict.Add(HeavyElvenSoldiersHelm.DisplayName, new HeavyElvenSoldiersHelm(1));
            dict.Add(HeavyElvenSoldiersLeggings.DisplayName, new HeavyElvenSoldiersLeggings(1));
            dict.Add(HeavyElvenSoldiersShoulderGuards.DisplayName, new HeavyElvenSoldiersShoulderGuards(1));
            dict.Add(IconofHeroes.DisplayName, new IconofHeroes(1));
            dict.Add(ImprovedAncientArmourPlate.DisplayName, new ImprovedAncientArmourPlate(1));
            dict.Add(ImprovedAncientSteelChain.DisplayName, new ImprovedAncientSteelChain(1));
            dict.Add(ImprovedAncientSteelScales.DisplayName, new ImprovedAncientSteelScales(1));
            dict.Add(ImprovedElfcraftBrace.DisplayName, new ImprovedElfcraftBrace(1));
            dict.Add(KnightsArmour.DisplayName, new KnightsArmour(1));
            dict.Add(KnightsBoots.DisplayName, new KnightsBoots(1));
            dict.Add(KnightsGloves.DisplayName, new KnightsGloves(1));
            dict.Add(KnightsLeggings.DisplayName, new KnightsLeggings(1));
            dict.Add(KnightsShoulderGuards.DisplayName, new KnightsShoulderGuards(1));
            dict.Add(LargeMasterCrest.DisplayName, new LargeMasterCrest(1));
            dict.Add(MammuttiArmour.DisplayName, new MammuttiArmour(1));
            dict.Add(MammuttiBoots.DisplayName, new MammuttiBoots(1));
            dict.Add(MammuttiGloves.DisplayName, new MammuttiGloves(1));
            dict.Add(MammuttiHelm.DisplayName, new MammuttiHelm(1));
            dict.Add(MammuttiLeggings.DisplayName, new MammuttiLeggings(1));
            dict.Add(MammuttiShoulderGuards.DisplayName, new MammuttiShoulderGuards(1));
            dict.Add(MastersChisel.DisplayName, new MastersChisel(1));
            dict.Add(MastersSharpChisel.DisplayName, new MastersSharpChisel(1));
            dict.Add(MediumMasterCrest.DisplayName, new MediumMasterCrest(1));
            dict.Add(MirroredElvenKnightsArmour.DisplayName, new MirroredElvenKnightsArmour(1));
            dict.Add(MirroredElvenKnightsBoots.DisplayName, new MirroredElvenKnightsBoots(1));
            dict.Add(MirroredElvenKnightsGloves.DisplayName, new MirroredElvenKnightsGloves(1));
            dict.Add(MirroredElvenKnightsHelm.DisplayName, new MirroredElvenKnightsHelm(1));
            dict.Add(MirroredElvenKnightsLeggings.DisplayName, new MirroredElvenKnightsLeggings(1));
            dict.Add(MirroredElvenKnightsShoulderGuards.DisplayName, new MirroredElvenKnightsShoulderGuards(1));
            dict.Add(PolishedDwarfmakeKnightsArmour.DisplayName, new PolishedDwarfmakeKnightsArmour(1));
            dict.Add(PolishedDwarfmakeKnightsBoots.DisplayName, new PolishedDwarfmakeKnightsBoots(1));
            dict.Add(PolishedDwarfmakeKnightsGloves.DisplayName, new PolishedDwarfmakeKnightsGloves(1));
            dict.Add(PolishedDwarfmakeKnightsLeggings.DisplayName, new PolishedDwarfmakeKnightsLeggings(1));
            dict.Add(PolishedDwarfmakeKnightsShoulderGuards.DisplayName, new PolishedDwarfmakeKnightsShoulderGuards(1));
            dict.Add(PolishedElvenKnightsArmour.DisplayName, new PolishedElvenKnightsArmour(1));
            dict.Add(PolishedElvenKnightsBoots.DisplayName, new PolishedElvenKnightsBoots(1));
            dict.Add(PolishedElvenKnightsGloves.DisplayName, new PolishedElvenKnightsGloves(1));
            dict.Add(PolishedElvenKnightsHelm.DisplayName, new PolishedElvenKnightsHelm(1));
            dict.Add(PolishedElvenKnightsLeggings.DisplayName, new PolishedElvenKnightsLeggings(1));
            dict.Add(PolishedElvenKnightsShoulderGuards.DisplayName, new PolishedElvenKnightsShoulderGuards(1));
            dict.Add(PolishedKnightsArmour.DisplayName, new PolishedKnightsArmour(1));
            dict.Add(PolishedKnightsBoots.DisplayName, new PolishedKnightsBoots(1));
            dict.Add(PolishedKnightsGloves.DisplayName, new PolishedKnightsGloves(1));
            dict.Add(PolishedKnightsLeggings.DisplayName, new PolishedKnightsLeggings(1));
            dict.Add(PolishedKnightsShoulderGuards.DisplayName, new PolishedKnightsShoulderGuards(1));
            dict.Add(SmallMasterCrest.DisplayName, new SmallMasterCrest(1));
            dict.Add(SuperiorBalancedWardensShieldOfTheElvenKnight.DisplayName, new SuperiorBalancedWardensShieldOfTheElvenKnight(1));
            dict.Add(SuperiorElvenKnightsLightShield.DisplayName, new SuperiorElvenKnightsLightShield(1));
            dict.Add(Terassydan.DisplayName, new Terassydan(1));
            dict.Add(WardensShieldOfTheElvenKnight.DisplayName, new WardensShieldOfTheElvenKnight(1));
            dict.Add(WardensShieldOfTheElvenSoldier.DisplayName, new WardensShieldOfTheElvenSoldier(1));
        }
    }
}