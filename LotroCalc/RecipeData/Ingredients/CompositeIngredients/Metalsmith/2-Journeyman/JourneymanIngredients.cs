using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._2_Journeyman
{
    public abstract class JourneymanIngredients : MetalsmithIngredients
    {
        protected JourneymanIngredients()
        {
            Tier = ProfessionTierEnum.Journeyman;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AmateursChisel.DisplayName, new AmateursChisel(1));
            dict.Add(AmateursSharpChisel.DisplayName, new AmateursSharpChisel(1));
            dict.Add(BalancedIronWardensShield.DisplayName, new BalancedIronWardensShield(1));
            dict.Add(CraftedArmour.DisplayName, new CraftedArmour(1));
            dict.Add(CraftedBoots.DisplayName, new CraftedBoots(1));
            dict.Add(CraftedBuckler.DisplayName, new CraftedBuckler(1));
            dict.Add(CraftedDwarfmakeArmour.DisplayName, new CraftedDwarfmakeArmour(1));
            dict.Add(CraftedDwarfmakeBoots.DisplayName, new CraftedDwarfmakeBoots(1));
            dict.Add(CraftedDwarfmakeGloves.DisplayName, new CraftedDwarfmakeGloves(1));
            dict.Add(CraftedDwarfmakeLeggings.DisplayName, new CraftedDwarfmakeLeggings(1));
            dict.Add(CraftedDwarfmakeShoulderGuards.DisplayName, new CraftedDwarfmakeShoulderGuards(1));
            dict.Add(CraftedElvenArmour.DisplayName, new CraftedElvenArmour(1));
            dict.Add(CraftedElvenBoots.DisplayName, new CraftedElvenBoots(1));
            dict.Add(CraftedElvenGloves.DisplayName, new CraftedElvenGloves(1));
            dict.Add(CraftedElvenLeggings.DisplayName, new CraftedElvenLeggings(1));
            dict.Add(CraftedElvenShoulderGuards.DisplayName, new CraftedElvenShoulderGuards(1));
            dict.Add(CraftedGloves.DisplayName, new CraftedGloves(1));
            dict.Add(CraftedHelm.DisplayName, new CraftedHelm(1));
            dict.Add(CraftedLeggings.DisplayName, new CraftedLeggings(1));
            dict.Add(CraftedShoulderGuards.DisplayName, new CraftedShoulderGuards(1));
            dict.Add(CraftedWardensShield.DisplayName, new CraftedWardensShield(1));
            dict.Add(DwarfmakeIronArmour.DisplayName, new DwarfmakeIronArmour(1));
            dict.Add(DwarfmakeIronBoots.DisplayName, new DwarfmakeIronBoots(1));
            dict.Add(DwarfmakeIronGloves.DisplayName, new DwarfmakeIronGloves(1));
            dict.Add(DwarfmakeIronLeggings.DisplayName, new DwarfmakeIronLeggings(1));
            dict.Add(DwarfmakeIronShoulderGuards.DisplayName, new DwarfmakeIronShoulderGuards(1));
            dict.Add(ElvenIronArmour.DisplayName, new ElvenIronArmour(1));
            dict.Add(ElvenIronBoots.DisplayName, new ElvenIronBoots(1));
            dict.Add(ElvenIronGloves.DisplayName, new ElvenIronGloves(1));
            dict.Add(ElvenIronLeggings.DisplayName, new ElvenIronLeggings(1));
            dict.Add(ElvenIronShoulderGuards.DisplayName, new ElvenIronShoulderGuards(1));
            dict.Add(ForgecraftedArmour.DisplayName, new ForgecraftedArmour(1));
            dict.Add(ForgecraftedBoots.DisplayName, new ForgecraftedBoots(1));
            dict.Add(ForgecraftedDwarfmakeArmour.DisplayName, new ForgecraftedDwarfmakeArmour(1));
            dict.Add(ForgecraftedDwarfmakeBoots.DisplayName, new ForgecraftedDwarfmakeBoots(1));
            dict.Add(ForgecraftedDwarfmakeGloves.DisplayName, new ForgecraftedDwarfmakeGloves(1));
            dict.Add(ForgecraftedDwarfmakeLeggings.DisplayName, new ForgecraftedDwarfmakeLeggings(1));
            dict.Add(ForgecraftedDwarfmakeShoulderGuards.DisplayName, new ForgecraftedDwarfmakeShoulderGuards(1));
            dict.Add(ForgecraftedElvenArmour.DisplayName, new ForgecraftedElvenArmour(1));
            dict.Add(ForgecraftedElvenBoots.DisplayName, new ForgecraftedElvenBoots(1));
            dict.Add(ForgecraftedElvenGloves.DisplayName, new ForgecraftedElvenGloves(1));
            dict.Add(ForgecraftedElvenLeggings.DisplayName, new ForgecraftedElvenLeggings(1));
            dict.Add(ForgecraftedElvenShoulderGuards.DisplayName, new ForgecraftedElvenShoulderGuards(1));
            dict.Add(ForgecraftedGloves.DisplayName, new ForgecraftedGloves(1));
            dict.Add(ForgecraftedHelm.DisplayName, new ForgecraftedHelm(1));
            dict.Add(ForgecraftedLeggings.DisplayName, new ForgecraftedLeggings(1));
            dict.Add(ForgecraftedShoulderGuards.DisplayName, new ForgecraftedShoulderGuards(1));
            dict.Add(ForgeCraftedWardensShield.DisplayName, new ForgeCraftedWardensShield(1));
            dict.Add(HeavyDwarfmakeIronArmour.DisplayName, new HeavyDwarfmakeIronArmour(1));
            dict.Add(HeavyDwarfmakeIronBoots.DisplayName, new HeavyDwarfmakeIronBoots(1));
            dict.Add(HeavyDwarfmakeIronGloves.DisplayName, new HeavyDwarfmakeIronGloves(1));
            dict.Add(HeavyDwarfmakeIronLeggings.DisplayName, new HeavyDwarfmakeIronLeggings(1));
            dict.Add(HeavyDwarfmakeIronShoulderGuards.DisplayName, new HeavyDwarfmakeIronShoulderGuards(1));
            dict.Add(HeavyElvenIronArmour.DisplayName, new HeavyElvenIronArmour(1));
            dict.Add(HeavyElvenIronBoots.DisplayName, new HeavyElvenIronBoots(1));
            dict.Add(HeavyElvenIronGloves.DisplayName, new HeavyElvenIronGloves(1));
            dict.Add(HeavyElvenIronLeggings.DisplayName, new HeavyElvenIronLeggings(1));
            dict.Add(HeavyElvenIronShoulderGuards.DisplayName, new HeavyElvenIronShoulderGuards(1));
            dict.Add(HeavyForgeCraftedKiteShield.DisplayName, new HeavyForgeCraftedKiteShield(1));
            dict.Add(HeavyIronArmour.DisplayName, new HeavyIronArmour(1));
            dict.Add(HeavyIronBoots.DisplayName, new HeavyIronBoots(1));
            dict.Add(HeavyIronGloves.DisplayName, new HeavyIronGloves(1));
            dict.Add(HeavyIronHelm.DisplayName, new HeavyIronHelm(1));
            dict.Add(HeavyIronKiteShield.DisplayName, new HeavyIronKiteShield(1));
            dict.Add(HeavyIronLeggings.DisplayName, new HeavyIronLeggings(1));
            dict.Add(HeavyIronShoulderGuards.DisplayName, new HeavyIronShoulderGuards(1));
            dict.Add(IronArmour.DisplayName, new IronArmour(1));
            dict.Add(IronBand.DisplayName, new IronBand(1));
            dict.Add(IronBuckler.DisplayName, new IronBuckler(1));
            dict.Add(IronBoots.DisplayName, new IronBoots(1));
            dict.Add(IronChainLink.DisplayName, new IronChainLink(1));
            dict.Add(IronCookingSupplies.DisplayName, new IronCookingSupplies(1));
            dict.Add(IronFarmingTools.DisplayName, new IronFarmingTools(1));
            dict.Add(IronForestersAxe.DisplayName, new IronForestersAxe(1));
            dict.Add(IronGloves.DisplayName, new IronGloves(1));
            dict.Add(IronHelm.DisplayName, new IronHelm(1));
            dict.Add(IronJewellersTools.DisplayName, new IronJewellersTools(1));
            dict.Add(IronLeggings.DisplayName, new IronLeggings(1));
            dict.Add(IronProspectorsTools.DisplayName, new IronProspectorsTools(1));
            dict.Add(IronScholarsGlass.DisplayName, new IronScholarsGlass(1));
            dict.Add(IronShoulderGuards.DisplayName, new IronShoulderGuards(1));
            dict.Add(IronSmithingHammer.DisplayName, new IronSmithingHammer(1));
            dict.Add(IronTailorsTools.DisplayName, new IronTailorsTools(1));
            dict.Add(IronWardensShield.DisplayName, new IronWardensShield(1));
            dict.Add(IronWoodworkingTools.DisplayName, new IronWoodworkingTools(1));
            dict.Add(LightIronKiteShield.DisplayName, new LightIronKiteShield(1));
            dict.Add(LightForgeCraftedKiteShield.DisplayName, new LightForgeCraftedKiteShield(1));
            dict.Add(SteelBrace.DisplayName, new SteelBrace(1));
        }
    }
}