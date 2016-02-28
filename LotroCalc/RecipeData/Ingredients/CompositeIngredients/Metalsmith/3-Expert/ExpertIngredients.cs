using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._3_Expert
{
    public abstract class ExpertIngredients : MetalsmithIngredients
    {
        protected ExpertIngredients()
        {
            Tier = ProfessionTierEnum.Expert;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BalancedSteelWardensShield.DisplayName, new BalancedSteelWardensShield(1));
            dict.Add(BalancedWardensShieldoftheDefender.DisplayName, new BalancedWardensShieldoftheDefender(1));
            dict.Add(DefendersArmour.DisplayName, new DefendersArmour(1));
            dict.Add(DefendersBoots.DisplayName, new DefendersBoots(1));
            dict.Add(DefendersGloves.DisplayName, new DefendersGloves(1));
            dict.Add(DefendersHeavyKiteShield.DisplayName, new DefendersHeavyKiteShield(1));
            dict.Add(DefendersHelm.DisplayName, new DefendersHelm(1));
            dict.Add(DefendersLeggings.DisplayName, new DefendersLeggings(1));
            dict.Add(DefendersLightKiteShield.DisplayName, new DefendersLightKiteShield(1));
            dict.Add(DefendersShoulderGuards.DisplayName, new DefendersShoulderGuards(1));
            dict.Add(DwarfmakeDefendersArmour.DisplayName, new DwarfmakeDefendersArmour(1));
            dict.Add(DwarfmakeDefendersBoots.DisplayName, new DwarfmakeDefendersBoots(1));
            dict.Add(DwarfmakeDefendersGloves.DisplayName, new DwarfmakeDefendersGloves(1));
            dict.Add(DwarfmakeDefendersLeggings.DisplayName, new DwarfmakeDefendersLeggings(1));
            dict.Add(DwarfmakeDefendersShoulderGuards.DisplayName, new DwarfmakeDefendersShoulderGuards(1));
            dict.Add(DwarfmakeSteelArmour.DisplayName, new DwarfmakeSteelArmour(1));
            dict.Add(DwarfmakeSteelBoots.DisplayName, new DwarfmakeSteelBoots(1));
            dict.Add(DwarfmakeSteelGloves.DisplayName, new DwarfmakeSteelGloves(1));
            dict.Add(DwarfmakeSteelLeggings.DisplayName, new DwarfmakeSteelLeggings(1));
            dict.Add(DwarfmakeSteelShoulderGuards.DisplayName, new DwarfmakeSteelShoulderGuards(1));
            dict.Add(ElvenDefendersArmour.DisplayName, new ElvenDefendersArmour(1));
            dict.Add(ElvenDefendersBoots.DisplayName, new ElvenDefendersBoots(1));
            dict.Add(ElvenDefendersGloves.DisplayName, new ElvenDefendersGloves(1));
            dict.Add(ElvenDefendersLeggings.DisplayName, new ElvenDefendersLeggings(1));
            dict.Add(ElvenDefendersShoulderGuards.DisplayName, new ElvenDefendersShoulderGuards(1));
            dict.Add(ElvenSteelArmour.DisplayName, new ElvenSteelArmour(1));
            dict.Add(ElvenSteelBoots.DisplayName, new ElvenSteelBoots(1));
            dict.Add(ElvenSteelGloves.DisplayName, new ElvenSteelGloves(1));
            dict.Add(ElvenSteelLeggings.DisplayName, new ElvenSteelLeggings(1));
            dict.Add(ElvenSteelShoulderGuards.DisplayName, new ElvenSteelShoulderGuards(1));
            dict.Add(FinelyPolishedScale.DisplayName, new FinelyPolishedScale(1));
            dict.Add(HardenedDefendersHeavyKiteShield.DisplayName, new HardenedDefendersHeavyKiteShield(1));
            dict.Add(HeavySteelArmour.DisplayName, new HeavySteelArmour(1));
            dict.Add(HeavyDwarfmakeSteelArmour.DisplayName, new HeavyDwarfmakeSteelArmour(1));
            dict.Add(HeavyDwarfmakeSteelBoots.DisplayName, new HeavyDwarfmakeSteelBoots(1));
            dict.Add(HeavyDwarfmakeSteelGloves.DisplayName, new HeavyDwarfmakeSteelGloves(1));
            dict.Add(HeavyDwarfmakeSteelLeggings.DisplayName, new HeavyDwarfmakeSteelLeggings(1));
            dict.Add(HeavyDwarfmakeSteelShoulderGuards.DisplayName, new HeavyDwarfmakeSteelShoulderGuards(1));
            dict.Add(HeavyElvenSteelArmour.DisplayName, new HeavyElvenSteelArmour(1));
            dict.Add(HeavyElvenSteelBoots.DisplayName, new HeavyElvenSteelBoots(1));
            dict.Add(HeavyElvenSteelGloves.DisplayName, new HeavyElvenSteelGloves(1));
            dict.Add(HeavyElvenSteelLeggings.DisplayName, new HeavyElvenSteelLeggings(1));
            dict.Add(HeavyElvenSteelShoulderGuards.DisplayName, new HeavyElvenSteelShoulderGuards(1));
            dict.Add(HeavySteelBoots.DisplayName, new HeavySteelBoots(1));
            dict.Add(HeavySteelGloves.DisplayName, new HeavySteelGloves(1));
            dict.Add(HeavySteelHelm.DisplayName, new HeavySteelHelm(1));
            dict.Add(HeavySteelLeggings.DisplayName, new HeavySteelLeggings(1));
            dict.Add(HeavySteelRoundShield.DisplayName, new HeavySteelRoundShield(1));
            dict.Add(HeavySteelShoulderGuards.DisplayName, new HeavySteelShoulderGuards(1));
            dict.Add(ImprovedFinelyPolishedScale.DisplayName, new ImprovedFinelyPolishedScale(1));
            dict.Add(ImprovedSteelPlates.DisplayName, new ImprovedSteelPlates(1));
            dict.Add(ImprovedSteelRivets.DisplayName, new ImprovedSteelRivets(1));
            dict.Add(ImprovedStrongIronChain.DisplayName, new ImprovedStrongIronChain(1));
            dict.Add(LightSteelRoundShield.DisplayName, new LightSteelRoundShield(1));
            dict.Add(MediumExpertCrest.DisplayName, new MediumExpertCrest(1));
            dict.Add(SmallExpertCrest.DisplayName, new SmallExpertCrest(1));
            dict.Add(SolidBalancedWardensShieldOfTheDefender.DisplayName, new SolidBalancedWardensShieldOfTheDefender(1));
            dict.Add(SolidDefendersArmour.DisplayName, new SolidDefendersArmour(1));
            dict.Add(SolidDefendersBoots.DisplayName, new SolidDefendersBoots(1));
            dict.Add(SolidDefendersGloves.DisplayName, new SolidDefendersGloves(1));
            dict.Add(SolidDefendersHelm.DisplayName, new SolidDefendersHelm(1));
            dict.Add(SolidDefendersLeggings.DisplayName, new SolidDefendersLeggings(1));
            dict.Add(SolidDefendersLightKiteShield.DisplayName, new SolidDefendersLightKiteShield(1));
            dict.Add(SolidDefendersShoulderGuards.DisplayName, new SolidDefendersShoulderGuards(1));
            dict.Add(SteelArmour.DisplayName, new SteelArmour(1));
            dict.Add(SteelBoots.DisplayName, new SteelBoots(1));
            dict.Add(SteelChainLink.DisplayName, new SteelChainLink(1));
            dict.Add(SteelCookingSupplies.DisplayName, new SteelCookingSupplies(1));
            dict.Add(SteelFarmingTools.DisplayName, new SteelFarmingTools(1));
            dict.Add(SteelForestersAxe.DisplayName, new SteelForestersAxe(1));
            dict.Add(SteelGloves.DisplayName, new SteelGloves(1));
            dict.Add(SteelHelm.DisplayName, new SteelHelm(1));
            dict.Add(SteelJewellersTools.DisplayName, new SteelJewellersTools(1));
            dict.Add(SteelLeggings.DisplayName, new SteelLeggings(1));
            dict.Add(SteelPlate.DisplayName, new SteelPlate(1));
            dict.Add(SteelProspectorsTools.DisplayName, new SteelProspectorsTools(1));
            dict.Add(SteelRivets.DisplayName, new SteelRivets(1));
            dict.Add(SteelRoundShield.DisplayName, new SteelRoundShield(1));
            dict.Add(SteelScholarsGlass.DisplayName, new SteelScholarsGlass(1));
            dict.Add(SteelShoulderGuards.DisplayName, new SteelShoulderGuards(1));
            dict.Add(SteelSmithingHammer.DisplayName, new SteelSmithingHammer(1));
            dict.Add(SteelTailorsTools.DisplayName, new SteelTailorsTools(1));
            dict.Add(SteelWardensShield.DisplayName, new SteelWardensShield(1));
            dict.Add(SteelWoodworkingTools.DisplayName, new SteelWoodworkingTools(1));
            dict.Add(StrongElvenDefendersArmour.DisplayName, new StrongElvenDefendersArmour(1));
            dict.Add(StrongElvenDefendersBoots.DisplayName, new StrongElvenDefendersBoots(1));
            dict.Add(StrongElvenDefendersGloves.DisplayName, new StrongElvenDefendersGloves(1));
            dict.Add(StrongElvenDefendersLeggings.DisplayName, new StrongElvenDefendersLeggings(1));
            dict.Add(StrongElvenDefendersShoulderGuards.DisplayName, new StrongElvenDefendersShoulderGuards(1));
            dict.Add(StrongDefendersArmour.DisplayName, new StrongDefendersArmour(1));
            dict.Add(StrongDefendersBoots.DisplayName, new StrongDefendersBoots(1));
            dict.Add(StrongDefendersGloves.DisplayName, new StrongDefendersGloves(1));
            dict.Add(StrongDefendersHelm.DisplayName, new StrongDefendersHelm(1));
            dict.Add(StrongDefendersLeggings.DisplayName, new StrongDefendersLeggings(1));
            dict.Add(StrongDefendersShoulderGuards.DisplayName, new StrongDefendersShoulderGuards(1));
            dict.Add(StrongDwarfmakeDefendersArmour.DisplayName, new StrongDwarfmakeDefendersArmour(1));
            dict.Add(StrongDwarfmakeDefendersBoots.DisplayName, new StrongDwarfmakeDefendersBoots(1));
            dict.Add(StrongDwarfmakeDefendersGloves.DisplayName, new StrongDwarfmakeDefendersGloves(1));
            dict.Add(StrongDwarfmakeDefendersLeggings.DisplayName, new StrongDwarfmakeDefendersLeggings(1));
            dict.Add(StrongDwarfmakeDefendersShoulderGuards.DisplayName, new StrongDwarfmakeDefendersShoulderGuards(1));
            dict.Add(StudentsChisel.DisplayName, new StudentsChisel(1));
            dict.Add(StudentsSharpChisel.DisplayName, new StudentsSharpChisel(1));
            dict.Add(WardensShieldOfTheDefender.DisplayName, new WardensShieldOfTheDefender(1));
        }
    }
}