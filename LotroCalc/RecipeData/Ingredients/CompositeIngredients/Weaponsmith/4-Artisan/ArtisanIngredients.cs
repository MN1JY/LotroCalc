using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._4_Artisan
{
    public abstract class ArtisanIngredients : WeaponsmithIngredients 
    {
        protected ArtisanIngredients()
        {
            Tier = ProfessionTierEnum.Artisan;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(ArtisanBeleriandShieldspikeKit.DisplayName, new ArtisanBeleriandShieldspikeKit(1));
            dict.Add(BlindingStunDusts.DisplayName, new BlindingStunDusts(1));
            dict.Add(CeremonialDagger.DisplayName, new CeremonialDagger(1));
            dict.Add(DwarfcraftAxe.DisplayName, new DwarfcraftAxe(1));
            dict.Add(DwarfcraftBlade.DisplayName, new DwarfcraftBlade(1));
            dict.Add(DwarfcraftDagger.DisplayName, new DwarfcraftDagger(1));
            dict.Add(DwarfcraftGreatsword.DisplayName, new DwarfcraftGreatsword(1));
            dict.Add(DwarfcraftSword.DisplayName, new DwarfcraftSword(1));
            dict.Add(DwarfcraftThrowingAxe.DisplayName, new DwarfcraftThrowingAxe(1));
            dict.Add(FinelyBalancedGuard.DisplayName, new FinelyBalancedGuard(1));
            dict.Add(ForgedDwarfcraftAxe.DisplayName, new ForgedDwarfcraftAxe(1));
            dict.Add(ForgedDwarfcraftDagger.DisplayName, new ForgedDwarfcraftDagger(1));
            dict.Add(ForgedDwarfcraftGreatsword.DisplayName, new ForgedDwarfcraftGreatsword(1));
            dict.Add(ForgedDwarfcraftHalberd.DisplayName, new ForgedDwarfcraftHalberd(1));
            dict.Add(ForgedDwarfcraftHeadsmansAxe.DisplayName, new ForgedDwarfcraftHeadsmansAxe(1));
            dict.Add(ForgedDwarfcraftMace.DisplayName, new ForgedDwarfcraftMace(1));
            dict.Add(ForgedDwarfcraftSword.DisplayName, new ForgedDwarfcraftSword(1));
            dict.Add(ImprovedDwarfcraftBlade.DisplayName, new ImprovedDwarfcraftBlade(1));
            dict.Add(ImprovedFinelyBalancedGuardGuild.DisplayName, new ImprovedFinelyBalancedGuardGuild(1));
            dict.Add(ImprovedLureTrap.DisplayName, new ImprovedLureTrap(1));
            dict.Add(ImprovedStrongSteelHiltGuild.DisplayName, new ImprovedStrongSteelHiltGuild(1));
            dict.Add(ImprovedStrongTrap.DisplayName, new ImprovedStrongTrap(1));
            dict.Add(ImprovedTripletrap.DisplayName, new ImprovedTripletrap(1));
            dict.Add(ImprovedWesternesseBladeGuild.DisplayName, new ImprovedWesternesseBladeGuild(1));
            dict.Add(MediumArtisanEmblemGuild.DisplayName, new MediumArtisanEmblemGuild(1));
            dict.Add(MediumBagofMarbles.DisplayName, new MediumBagofMarbles(1));
            dict.Add(MirroredWesternesseAxeGuild.DisplayName, new MirroredWesternesseAxeGuild(1));
            dict.Add(MirroredWesternesseDaggerGuild.DisplayName, new MirroredWesternesseDaggerGuild(1));
            dict.Add(MirroredWesternesseGreatswordGuild.DisplayName, new MirroredWesternesseGreatswordGuild(1));
            dict.Add(MirroredWesternesseHalberdGuild.DisplayName, new MirroredWesternesseHalberdGuild(1));
            dict.Add(MirroredWesternesseHeadsmansAxeGuild.DisplayName, new MirroredWesternesseHeadsmansAxeGuild(1));
            dict.Add(MirroredWesternesseMaceGuild.DisplayName, new MirroredWesternesseMaceGuild(1));
            dict.Add(MirroredWesternesseSwordGuild.DisplayName, new MirroredWesternesseSwordGuild(1));
            dict.Add(PolishedQuickTrap.DisplayName, new PolishedQuickTrap(1));
            dict.Add(PolishedWesternesseAxe.DisplayName, new PolishedWesternesseAxe(1));
            dict.Add(PolishedWesternesseDagger.DisplayName, new PolishedWesternesseDagger(1));
            dict.Add(PolishedWesternesseGreatsword.DisplayName, new PolishedWesternesseGreatsword(1));
            dict.Add(PolishedWesternesseHalberd.DisplayName, new PolishedWesternesseHalberd(1));
            dict.Add(PolishedWesternesseHeadsmansAxe.DisplayName, new PolishedWesternesseHeadsmansAxe(1));
            dict.Add(PolishedWesternesseMace.DisplayName, new PolishedWesternesseMace(1));
            dict.Add(PolishedWesternesseSword.DisplayName, new PolishedWesternesseSword(1));
            dict.Add(RepairAnvil.DisplayName, new RepairAnvil(1));
            dict.Add(SharpBearTrap.DisplayName, new SharpBearTrap(1));
            dict.Add(SharpCaltrops.DisplayName, new SharpCaltrops(1));
            dict.Add(SharpShieldspikeKit.DisplayName, new SharpShieldspikeKit(1));
            dict.Add(SmallArtisanEmblemGuild.DisplayName, new SmallArtisanEmblemGuild(1));
            dict.Add(StrongSteelHilt.DisplayName, new StrongSteelHilt(1));
            dict.Add(Tripwire.DisplayName, new Tripwire(1));
            dict.Add(WesternesseAxe.DisplayName, new WesternesseAxe(1));
            dict.Add(WesternesseBlade.DisplayName, new WesternesseBlade(1));
            dict.Add(WesternesseDagger.DisplayName, new WesternesseDagger(1));
            dict.Add(WesternesseGreatsword.DisplayName, new WesternesseGreatsword(1));
            dict.Add(WesternesseSword.DisplayName, new WesternesseSword(1));
            dict.Add(WesternesseThrowingAxe.DisplayName, new WesternesseThrowingAxe(1));
        }
    }
}