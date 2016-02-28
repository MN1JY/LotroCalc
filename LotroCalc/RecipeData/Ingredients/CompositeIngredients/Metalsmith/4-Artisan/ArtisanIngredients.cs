using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._4_Artisan
{
    public abstract class ArtisanIngredients : MetalsmithIngredients
    {
        protected ArtisanIngredients()
        {
            Tier = ProfessionTierEnum.Artisan;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BalancedDwarfironWardensShield.DisplayName, new BalancedDwarfironWardensShield(1));
            dict.Add(BalancedWesternesseWardensShield.DisplayName, new BalancedWesternesseWardensShield(1));
            dict.Add(Candlestand.DisplayName, new Candlestand(1));
            dict.Add(CrestOfVigilance.DisplayName, new CrestOfVigilance(1));
            dict.Add(DwarfchainLink.DisplayName, new DwarfchainLink(1));
            dict.Add(DwarfIronArmour.DisplayName, new DwarfIronArmour(1));
            dict.Add(DwarfIronBoots.DisplayName, new DwarfIronBoots(1));
            dict.Add(DwarfIronGloves.DisplayName, new DwarfIronGloves(1));
            dict.Add(DwarfIronHelm.DisplayName, new DwarfIronHelm(1));
            dict.Add(DwarfIronLeggings.DisplayName, new DwarfIronLeggings(1));
            dict.Add(DwarfironShield.DisplayName, new DwarfironShield(1));
            dict.Add(DwarfIronShoulderGuards.DisplayName, new DwarfIronShoulderGuards(1));
            dict.Add(DwarfironWardensShield.DisplayName, new DwarfironWardensShield(1));
            dict.Add(DwarfSteelCookingSupplies.DisplayName, new DwarfSteelCookingSupplies(1));
            dict.Add(DwarfSteelFarmingTools.DisplayName, new DwarfSteelFarmingTools(1));
            dict.Add(DwarfSteelForestersAxe.DisplayName, new DwarfSteelForestersAxe(1));
            dict.Add(DwarfSteelJewellersTools.DisplayName, new DwarfSteelJewellersTools(1));
            dict.Add(DwarfSteelProspectorsTools.DisplayName, new DwarfSteelProspectorsTools(1));
            dict.Add(DwarfSteelScholarsGlass.DisplayName, new DwarfSteelScholarsGlass(1));
            dict.Add(DwarfSteelSmithingHammer.DisplayName, new DwarfSteelSmithingHammer(1));
            dict.Add(DwarfSteelTailorsTools.DisplayName, new DwarfSteelTailorsTools(1));
            dict.Add(DwarfSteelWoodworkingTools.DisplayName, new DwarfSteelWoodworkingTools(1));
            dict.Add(HardenedHeavyWesternesseShield.DisplayName, new HardenedHeavyWesternesseShield(1));
            dict.Add(HeavyDwarfIronArmour.DisplayName, new HeavyDwarfIronArmour(1));
            dict.Add(HeavyDwarfIronBoots.DisplayName, new HeavyDwarfIronBoots(1));
            dict.Add(HeavyDwarfIronGloves.DisplayName, new HeavyDwarfIronGloves(1));
            dict.Add(HeavyDwarfIronHelm.DisplayName, new HeavyDwarfIronHelm(1));
            dict.Add(HeavyDwarfIronLeggings.DisplayName, new HeavyDwarfIronLeggings(1));
            dict.Add(HeavyDwarfironShield.DisplayName, new HeavyDwarfironShield(1));
            dict.Add(HeavyDwarfIronShoulderGuards.DisplayName, new HeavyDwarfIronShoulderGuards(1));
            dict.Add(HeavyDwarfsteelPlate.DisplayName, new HeavyDwarfsteelPlate(1));
            dict.Add(HeavyWesternesseShield.DisplayName, new HeavyWesternesseShield(1));
            dict.Add(ImprovedDwarfchain.DisplayName, new ImprovedDwarfchain(1));
            dict.Add(ImprovedHeavyDwarfsteelPlates.DisplayName, new ImprovedHeavyDwarfsteelPlates(1));
            dict.Add(ImprovedWesternesseMesh.DisplayName, new ImprovedWesternesseMesh(1));
            dict.Add(ImprovedWesternesseScale.DisplayName, new ImprovedWesternesseScale(1));
            dict.Add(IronCandlestand.DisplayName, new IronCandlestand(1));
            dict.Add(LightDwarfironShield.DisplayName, new LightDwarfironShield(1));
            dict.Add(LightWesternessShield.DisplayName, new LightWesternessShield(1));
            dict.Add(MediumArtisanCrest.DisplayName, new MediumArtisanCrest(1));
            dict.Add(RepairAnvil2.DisplayName, new RepairAnvil2(1));
            dict.Add(ScholarsChisel.DisplayName, new ScholarsChisel(1));
            dict.Add(ScholarsSharpChisel.DisplayName, new ScholarsSharpChisel(1));
            dict.Add(SmallArtisanCrest.DisplayName, new SmallArtisanCrest(1));
            dict.Add(SolidWesternesseArmour.DisplayName, new SolidWesternesseArmour(1));
            dict.Add(SolidWesternesseBoots.DisplayName, new SolidWesternesseBoots(1));
            dict.Add(SolidWesternesseGloves.DisplayName, new SolidWesternesseGloves(1));
            dict.Add(SolidWesternesseHelm.DisplayName, new SolidWesternesseHelm(1));
            dict.Add(SolidWesternesseLeggings.DisplayName, new SolidWesternesseLeggings(1));
            dict.Add(SolidWesternesseShoulderGuards.DisplayName, new SolidWesternesseShoulderGuards(1));
            dict.Add(StrongWesternesseArmour.DisplayName, new StrongWesternesseArmour(1));
            dict.Add(StrongWesternesseBoots.DisplayName, new StrongWesternesseBoots(1));
            dict.Add(StrongWesternesseGloves.DisplayName, new StrongWesternesseGloves(1));
            dict.Add(StrongWesternesseHelm.DisplayName, new StrongWesternesseHelm(1));
            dict.Add(StrongWesternesseLeggings.DisplayName, new StrongWesternesseLeggings(1));
            dict.Add(StrongWesternesseShoulderGuards.DisplayName, new StrongWesternesseShoulderGuards(1));
            dict.Add(SuperbBalancedWesternesseWardensShield.DisplayName, new SuperbBalancedWesternesseWardensShield(1));
            dict.Add(SuperbLightWesternesseShield.DisplayName, new SuperbLightWesternesseShield(1));
            dict.Add(WesternesseArmour.DisplayName, new WesternesseArmour(1));
            dict.Add(WesternesseBoots.DisplayName, new WesternesseBoots(1));
            dict.Add(WesternesseGloves.DisplayName, new WesternesseGloves(1));
            dict.Add(WesternesseHelm.DisplayName, new WesternesseHelm(1));
            dict.Add(WesternesseLeggings.DisplayName, new WesternesseLeggings(1));
            dict.Add(WesternesseMesh.DisplayName, new WesternesseMesh(1));
            dict.Add(WesternesseScale.DisplayName, new WesternesseScale(1));
            dict.Add(WesternesseShield.DisplayName, new WesternesseShield(1));
            dict.Add(WesternesseShoulderGuards.DisplayName, new WesternesseShoulderGuards(1));
            dict.Add(WesternesseWardensShield.DisplayName, new WesternesseWardensShield(1));
        }
    }
}