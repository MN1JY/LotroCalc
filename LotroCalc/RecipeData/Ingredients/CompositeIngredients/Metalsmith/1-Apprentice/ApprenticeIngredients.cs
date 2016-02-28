using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._1_Apprentice
{
    public abstract class ApprenticeIngredients : MetalsmithIngredients
    {
        protected ApprenticeIngredients()
        {
            Tier = ProfessionTierEnum.Apprentice;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BalancedBronzeWardensShield.DisplayName, new BalancedBronzeWardensShield(1));
            dict.Add(BronzeArmour.DisplayName, new BronzeArmour(1));
            dict.Add(BronzeBoots.DisplayName, new BronzeBoots(1));
            dict.Add(BronzeBuckler.DisplayName, new BronzeBuckler(1));
            dict.Add(BronzeChainLinks.DisplayName, new BronzeChainLinks(1));
            dict.Add(BronzeCookingSupplies.DisplayName, new BronzeCookingSupplies(1));
            dict.Add(BronzeFarmingTools.DisplayName, new BronzeFarmingTools(1));
            dict.Add(BronzeForestersAxe.DisplayName, new BronzeForestersAxe(1));
            dict.Add(BronzeGloves.DisplayName, new BronzeGloves(1));
            dict.Add(BronzeHelm.DisplayName, new BronzeHelm(1));
            dict.Add(BronzeJewellersTools.DisplayName, new BronzeJewellersTools(1));
            dict.Add(BronzeLeggings.DisplayName, new BronzeLeggings(1));
            dict.Add(BronzePlate.DisplayName, new BronzePlate(1));
            dict.Add(BronzeProspectorsTools.DisplayName, new BronzeProspectorsTools(1));
            dict.Add(BronzeScholarsGlass.DisplayName, new BronzeScholarsGlass(1));
            dict.Add(BronzeShoulderGuards.DisplayName, new BronzeShoulderGuards(1));
            dict.Add(BronzeSmithingHammer.DisplayName, new BronzeSmithingHammer(1));
            dict.Add(BronzeTailorsTools.DisplayName, new BronzeTailorsTools(1));
            dict.Add(BronzeWardensShield.DisplayName, new BronzeWardensShield(1));
            dict.Add(BronzeWoodworkingTools.DisplayName, new BronzeWoodworkingTools(1));
            dict.Add(DwarfMakeBronzeArmour.DisplayName, new DwarfMakeBronzeArmour(1));
            dict.Add(DwarfMakeBronzeBoots.DisplayName, new DwarfMakeBronzeBoots(1));
            dict.Add(DwarfMakeBronzeGloves.DisplayName, new DwarfMakeBronzeGloves(1));
            dict.Add(DwarfMakeBronzeHelm.DisplayName, new DwarfMakeBronzeHelm(1));
            dict.Add(DwarfMakeBronzeLeggings.DisplayName, new DwarfMakeBronzeLeggings(1));
            dict.Add(DwarfMakeBronzeShoulderGuards.DisplayName, new DwarfMakeBronzeShoulderGuards(1));
            dict.Add(ElvenBronzeArmour.DisplayName, new ElvenBronzeArmour(1));
            dict.Add(ElvenBronzeBoots.DisplayName, new ElvenBronzeBoots(1));
            dict.Add(ElvenBronzeGloves.DisplayName, new ElvenBronzeGloves(1));
            dict.Add(ElvenBronzeLeggings.DisplayName, new ElvenBronzeLeggings(1));
            dict.Add(ElvenBronzeShoulderGuards.DisplayName, new ElvenBronzeShoulderGuards(1));
            dict.Add(HeavyBronzeArmour.DisplayName, new HeavyBronzeArmour(1));
            dict.Add(HeavyBronzeBoots.DisplayName, new HeavyBronzeBoots(1));
            dict.Add(HeavyBronzeGloves.DisplayName, new HeavyBronzeGloves(1));
            dict.Add(HeavyBronzeHelm.DisplayName, new HeavyBronzeHelm(1));
            dict.Add(HeavyBronzeLeggings.DisplayName, new HeavyBronzeLeggings(1));
            dict.Add(HeavyBronzeShoulderGuards.DisplayName, new HeavyBronzeShoulderGuards(1));
            dict.Add(HeavyDwarfMakeBronzeArmour.DisplayName, new HeavyDwarfMakeBronzeArmour(1));
            dict.Add(HeavyDwarfMakeBronzeBoots.DisplayName, new HeavyDwarfMakeBronzeBoots(1));
            dict.Add(HeavyDwarfMakeBronzeGloves.DisplayName, new HeavyDwarfMakeBronzeGloves(1));
            dict.Add(HeavyDwarfMakeBronzeHelm.DisplayName, new HeavyDwarfMakeBronzeHelm(1));
            dict.Add(HeavyDwarfMakeBronzeLeggings.DisplayName, new HeavyDwarfMakeBronzeLeggings(1));
            dict.Add(HeavyDwarfMakeBronzeShoulderGuards.DisplayName, new HeavyDwarfMakeBronzeShoulderGuards(1));
            dict.Add(HeavyElvenBronzeShoulderGuards.DisplayName, new HeavyElvenBronzeShoulderGuards(1));
            dict.Add(HeavyElvenBronzeLeggings.DisplayName, new HeavyElvenBronzeLeggings(1));
            dict.Add(HeavyElvenBronzeGloves.DisplayName, new HeavyElvenBronzeGloves(1));
            dict.Add(HeavyElvenBronzeBoots.DisplayName, new HeavyElvenBronzeBoots(1));
            dict.Add(HeavyElvenBronzeArmour.DisplayName, new HeavyElvenBronzeArmour(1));
            dict.Add(LightBronzeBuckler.DisplayName, new LightBronzeBuckler(1));
        }
    }
}