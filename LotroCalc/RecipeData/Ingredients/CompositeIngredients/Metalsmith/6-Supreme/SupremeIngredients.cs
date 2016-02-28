using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._6_Supreme
{
    public abstract class SupremeIngredients : MetalsmithIngredients
    {
        protected SupremeIngredients()
        {
            Tier = ProfessionTierEnum.Supreme;
            SuperiorForgeRequired = true;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BlackenedBronzeBand.DisplayName, new BlackenedBronzeBand(1));
            dict.Add(BlackenedBronzeChainLink.DisplayName, new BlackenedBronzeChainLink(1));
            dict.Add(BlackenedBronzePlate.DisplayName, new BlackenedBronzePlate(1));
            dict.Add(BlackenedIronMesh.DisplayName, new BlackenedIronMesh(1));
            dict.Add(BlackenedIronPlate.DisplayName, new BlackenedIronPlate(1));
            dict.Add(BlackenedSteelBrace.DisplayName, new BlackenedSteelBrace(1));
            dict.Add(BootsoftheGaladhrim.DisplayName, new BootsoftheGaladhrim(1));
            dict.Add(CraftedCaptainsEmblemOfTheThirdAge.DisplayName, new CraftedCaptainsEmblemOfTheThirdAge(1));
            dict.Add(CraftedCaptainsEmblemoftheThirdAgeLevel65.DisplayName, new CraftedCaptainsEmblemoftheThirdAgeLevel65(1));
            dict.Add(CraftedGuardiansBeltOfTheThirdAge60.DisplayName, new CraftedGuardiansBeltOfTheThirdAge60(1));
            dict.Add(CraftedGuardiansBeltOfTheThirdAge65.DisplayName, new CraftedGuardiansBeltOfTheThirdAge65(1));
            dict.Add(Dragonhelm.DisplayName, new Dragonhelm(1));
            dict.Add(ExquisiteLothlorienHeavyShield.DisplayName, new ExquisiteLothlorienHeavyShield(1));
            dict.Add(ExquisiteLothlorienLightShield.DisplayName, new ExquisiteLothlorienLightShield(1));
            dict.Add(ExquisiteWardensShieldofLothlorien.DisplayName, new ExquisiteWardensShieldofLothlorien(1));
            dict.Add(GauntletsoftheGaladhrim.DisplayName, new GauntletsoftheGaladhrim(1));
            dict.Add(GloriousBootsOfTheGaladhrim.DisplayName, new GloriousBootsOfTheGaladhrim(1));
            dict.Add(GloriousGauntletsOfTheGaladhrim.DisplayName, new GloriousGauntletsOfTheGaladhrim(1));
            dict.Add(GloriousHauberkOfTheGaladhrim.DisplayName, new GloriousHauberkOfTheGaladhrim(1));
            dict.Add(GloriousHelmetOfTheGaladhrim.DisplayName, new GloriousHelmetOfTheGaladhrim(1));
            dict.Add(GloriousLeggingsOfTheGaladhrim.DisplayName, new GloriousLeggingsOfTheGaladhrim(1));
            dict.Add(GloriousPauldronsOfTheGaladhrim.DisplayName, new GloriousPauldronsOfTheGaladhrim(1));
            dict.Add(HauberkoftheGaladhrim.DisplayName, new HauberkoftheGaladhrim(1));
            dict.Add(HelmetoftheGaladhrim.DisplayName, new HelmetoftheGaladhrim(1));
            dict.Add(HeavyShieldoftheGoldenHost.DisplayName, new HeavyShieldoftheGoldenHost(1));
            dict.Add(HeroicNoblesArmour.DisplayName, new HeroicNoblesArmour(1));
            dict.Add(HeroicNoblesBoots.DisplayName, new HeroicNoblesBoots(1));
            dict.Add(HeroicNoblesGloves.DisplayName, new HeroicNoblesGloves(1));
            dict.Add(HeroicNoblesHeavyShield.DisplayName, new HeroicNoblesHeavyShield(1));
            dict.Add(HeroicNoblesHelm.DisplayName, new HeroicNoblesHelm(1));
            dict.Add(HeroicNoblesLeggings.DisplayName, new HeroicNoblesLeggings(1));
            dict.Add(HeroicNoblesLightShield.DisplayName, new HeroicNoblesLightShield(1));
            dict.Add(HeroicNoblesShoulderGuards.DisplayName, new HeroicNoblesShoulderGuards(1));
            dict.Add(ImprovedBlackenedBronzeBand.DisplayName, new ImprovedBlackenedBronzeBand(1));
            dict.Add(ImprovedBlackenedBronzeChain.DisplayName, new ImprovedBlackenedBronzeChain(1));
            dict.Add(ImprovedBlackenedBronzePlates.DisplayName, new ImprovedBlackenedBronzePlates(1));
            dict.Add(ImprovedBlackenedIronMesh.DisplayName, new ImprovedBlackenedIronMesh(1));
            dict.Add(ImprovedBlackenedIronPlates.DisplayName, new ImprovedBlackenedIronPlates(1));
            dict.Add(ImprovedBlackenedSteelBrace.DisplayName, new ImprovedBlackenedSteelBrace(1));
            dict.Add(LargeSupremeCrestGuild.DisplayName, new LargeSupremeCrestGuild(1));
            dict.Add(LeggingsoftheGaladhrim.DisplayName, new LeggingsoftheGaladhrim(1));
            dict.Add(LightShieldoftheGoldenHost.DisplayName, new LightShieldoftheGoldenHost(1));
            dict.Add(MalledhrimBootsofRejuvenation.DisplayName, new MalledhrimBootsofRejuvenation(1));
            dict.Add(MalledhrimBootsoftheAwakened.DisplayName, new MalledhrimBootsoftheAwakened(1));
            dict.Add(MalledhrimBootsoftheTwilight.DisplayName, new MalledhrimBootsoftheTwilight(1));
            dict.Add(MalledhrimGauntletsoftheAwakened.DisplayName, new MalledhrimGauntletsoftheAwakened(1));
            dict.Add(MalledhrimGauntletsofRejuvenation.DisplayName, new MalledhrimGauntletsofRejuvenation(1));
            dict.Add(MalledhrimGauntletsoftheTwilight.DisplayName, new MalledhrimGauntletsoftheTwilight(1));
            dict.Add(MalledhrimHauberkofRejuvenation.DisplayName, new MalledhrimHauberkofRejuvenation(1));
            dict.Add(MalledhrimHauberkoftheAwakened.DisplayName, new MalledhrimHauberkoftheAwakened(1));
            dict.Add(MalledhrimHauberkoftheTwilight.DisplayName, new MalledhrimHauberkoftheTwilight(1));
            dict.Add(MalledhrimHelmetofRejuvenation.DisplayName, new MalledhrimHelmetofRejuvenation(1));
            dict.Add(MalledhrimHelmetoftheAwakened.DisplayName, new MalledhrimHelmetoftheAwakened(1));
            dict.Add(MalledhrimHelmetoftheTwilight.DisplayName, new MalledhrimHelmetoftheTwilight(1));
            dict.Add(MalledhrimLeggingsofRejuvenation.DisplayName, new MalledhrimLeggingsofRejuvenation(1));
            dict.Add(MalledhrimLeggingsoftheAwakened.DisplayName, new MalledhrimLeggingsoftheAwakened(1));
            dict.Add(MalledhrimLeggingsoftheTwilight.DisplayName, new MalledhrimLeggingsoftheTwilight(1));
            dict.Add(MalledhrimPauldronsofRejuvenation.DisplayName, new MalledhrimPauldronsofRejuvenation(1));
            dict.Add(MalledhrimPauldronsoftheAwakened.DisplayName, new MalledhrimPauldronsoftheAwakened(1));
            dict.Add(MalledhrimPauldronsoftheTwilight.DisplayName, new MalledhrimPauldronsoftheTwilight(1));
            dict.Add(MediumSupremeCrest.DisplayName, new MediumSupremeCrest(1));
            dict.Add(NoblesArmour.DisplayName, new NoblesArmour(1));
            dict.Add(NoblesBoots.DisplayName, new NoblesBoots(1));
            dict.Add(NoblesGloves.DisplayName, new NoblesGloves(1));
            dict.Add(NoblesHeavyShield.DisplayName, new NoblesHeavyShield(1));
            dict.Add(NoblesHelm.DisplayName, new NoblesHelm(1));
            dict.Add(NoblesLeggings.DisplayName, new NoblesLeggings(1));
            dict.Add(NoblesLightShield.DisplayName, new NoblesLightShield(1));
            dict.Add(NoblesShoulderGuards.DisplayName, new NoblesShoulderGuards(1));
            dict.Add(OfficersArmour.DisplayName, new OfficersArmour(1));
            dict.Add(OfficersBoots.DisplayName, new OfficersBoots(1));
            dict.Add(OfficersGloves.DisplayName, new OfficersGloves(1));
            dict.Add(OfficersHeavyShield.DisplayName, new OfficersHeavyShield(1));
            dict.Add(OfficersHelm.DisplayName, new OfficersHelm(1));
            dict.Add(OfficersLeggings.DisplayName, new OfficersLeggings(1));
            dict.Add(OfficersLightShield.DisplayName, new OfficersLightShield(1));
            dict.Add(OfficersShoulderGuards.DisplayName, new OfficersShoulderGuards(1));
            dict.Add(PauldronsoftheGaladhrim.DisplayName, new PauldronsoftheGaladhrim(1));
            dict.Add(ReforgedCaptainsEmblemOfTheSecondAge.DisplayName, new ReforgedCaptainsEmblemOfTheSecondAge(1));
            dict.Add(ReforgedCaptainsEmblemoftheSecondAgeLevel65.DisplayName, new ReforgedCaptainsEmblemoftheSecondAgeLevel65(1));
            dict.Add(ReforgedGuardiansBeltOfTheSecondAge60.DisplayName, new ReforgedGuardiansBeltOfTheSecondAge60(1));
            dict.Add(ReforgedGuardiansBeltOfTheSecondAge65.DisplayName, new ReforgedGuardiansBeltOfTheSecondAge65(1));
            dict.Add(RoyalCrown.DisplayName, new RoyalCrown(1));
            dict.Add(SavantsChisel.DisplayName, new SavantsChisel(1));
            dict.Add(SavantsHonedChisel.DisplayName, new SavantsHonedChisel(1));
            dict.Add(SavantsSharpChisel.DisplayName, new SavantsSharpChisel(1));
            dict.Add(SellswordsArmour.DisplayName, new SellswordsArmour(1));
            dict.Add(SellswordsBoots.DisplayName, new SellswordsBoots(1));
            dict.Add(SellswordsGloves.DisplayName, new SellswordsGloves(1));
            dict.Add(SellswordsHeavyShield.DisplayName, new SellswordsHeavyShield(1));
            dict.Add(SellswordsHelm.DisplayName, new SellswordsHelm(1));
            dict.Add(SellswordsLeggings.DisplayName, new SellswordsLeggings(1));
            dict.Add(SellswordsLightShield.DisplayName, new SellswordsLightShield(1));
            dict.Add(SellswordsShoulderGuards.DisplayName, new SellswordsShoulderGuards(1));
            dict.Add(SentinelsArmour.DisplayName, new SentinelsArmour(1));
            dict.Add(SentinelsBoots.DisplayName, new SentinelsBoots(1));
            dict.Add(SentinelsGloves.DisplayName, new SentinelsGloves(1));
            dict.Add(SentinelsHelm.DisplayName, new SentinelsHelm(1));
            dict.Add(SentinelsHeavyShield.DisplayName, new SentinelsHeavyShield(1));
            dict.Add(SentinelsLeggings.DisplayName, new SentinelsLeggings(1));
            dict.Add(SentinelsLightShield.DisplayName, new SentinelsLightShield(1));
            dict.Add(SentinelsShoulderGuards.DisplayName, new SentinelsShoulderGuards(1));
            dict.Add(SilverBasin.DisplayName, new SilverBasin(1));
            dict.Add(SmallSupremeCrest.DisplayName, new SmallSupremeCrest(1));
            dict.Add(SuperbLothlorienHeavyShield.DisplayName, new SuperbLothlorienHeavyShield(1));
            dict.Add(SuperbLothlorienLightShield.DisplayName, new SuperbLothlorienLightShield(1));
            dict.Add(SuperbWardensShieldOfLothlorien.DisplayName, new SuperbWardensShieldOfLothlorien(1));
            dict.Add(ToolsOfTheArmourer.DisplayName, new ToolsOfTheArmourer(1));
            dict.Add(ToolsOfTheArmsman.DisplayName, new ToolsOfTheArmsman(1));
            dict.Add(ToolsoftheExplorer.DisplayName, new ToolsoftheExplorer(1));
            dict.Add(ToolsOfTheHistorian.DisplayName, new ToolsOfTheHistorian(1));
            dict.Add(ToolsOfTheTinker.DisplayName, new ToolsOfTheTinker(1));
            dict.Add(ToolsOfTheWoodsman.DisplayName, new ToolsOfTheWoodsman(1));
            dict.Add(ToolsOfTheYeoman.DisplayName, new ToolsOfTheYeoman(1));
            dict.Add(WardensShieldoftheGoldenHost.DisplayName, new WardensShieldoftheGoldenHost(1));
            dict.Add(WardensShieldOfTheHeroicNoble.DisplayName, new WardensShieldOfTheHeroicNoble(1));
            dict.Add(WardensShieldoftheNoble.DisplayName, new WardensShieldoftheNoble(1));
            dict.Add(WardensShieldOfTheOfficer.DisplayName, new WardensShieldOfTheOfficer(1));
            dict.Add(WardensShieldOfTheSellsword.DisplayName, new WardensShieldOfTheSellsword(1));
            dict.Add(WardensShieldOfTheSentinel.DisplayName, new WardensShieldOfTheSentinel(1));
        }
    }
}