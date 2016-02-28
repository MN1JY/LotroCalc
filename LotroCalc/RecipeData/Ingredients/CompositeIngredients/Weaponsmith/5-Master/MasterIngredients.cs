using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._5_Master
{
    public abstract class MasterIngredients : WeaponsmithIngredients 
    {
        protected MasterIngredients()
        {
            Tier = ProfessionTierEnum.Master;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(AncientSteelAxe.DisplayName, new AncientSteelAxe(1));
            dict.Add(AncientSteelBlade.DisplayName, new AncientSteelBlade(1));
            dict.Add(AncientSteelDagger.DisplayName, new AncientSteelDagger(1));
            dict.Add(AncientSteelGreatsword.DisplayName, new AncientSteelGreatsword(1));
            dict.Add(AncientSteelSword.DisplayName, new AncientSteelSword(1));
            dict.Add(AncientSteelThrowingAxe.DisplayName, new AncientSteelThrowingAxe(1));
            dict.Add(CunningLureTrap.DisplayName, new CunningLureTrap(1));
            dict.Add(DeadlyBearTrap.DisplayName, new DeadlyBearTrap(1));
            dict.Add(DeadlyCaltrop.DisplayName, new DeadlyCaltrop(1));
            dict.Add(DeadlyShieldspikeKit.DisplayName, new DeadlyShieldspikeKit(1));
            dict.Add(ElvenBlade.DisplayName, new ElvenBlade(1));
            dict.Add(ElvensteelAxe.DisplayName, new ElvensteelAxe(1));
            dict.Add(ElvensteelDagger.DisplayName, new ElvensteelDagger(1));
            dict.Add(ElvensteelGreatsword.DisplayName, new ElvensteelGreatsword(1));
            dict.Add(ElvensteelSword.DisplayName, new ElvensteelSword(1));
            dict.Add(ElvensteelThrowingAxe.DisplayName, new ElvensteelThrowingAxe(1));
            dict.Add(ForgedElvensteelAxe.DisplayName, new ForgedElvensteelAxe(1));
            dict.Add(ForgedElvensteelDagger.DisplayName, new ForgedElvensteelDagger(1));
            dict.Add(ForgedElvensteelGreatsword.DisplayName, new ForgedElvensteelGreatsword(1));
            dict.Add(ForgedElvensteelHalberd.DisplayName, new ForgedElvensteelHalberd(1));
            dict.Add(ForgedElvensteelHeadsmansAxe.DisplayName, new ForgedElvensteelHeadsmansAxe(1));
            dict.Add(ForgedElvensteelMace.DisplayName, new ForgedElvensteelMace(1));
            dict.Add(ImprovedAncientSteelBladeGuild.DisplayName, new ImprovedAncientSteelBladeGuild(1));
            dict.Add(ImprovedElvenBladeGuild.DisplayName, new ImprovedElvenBladeGuild(1));
            dict.Add(ImprovedIntricatelyEngravedPommelGuild.DisplayName, new ImprovedIntricatelyEngravedPommelGuild(1));
            dict.Add(ImprovedLeafpatternHiltGuild.DisplayName, new ImprovedLeafpatternHiltGuild(1));
            dict.Add(ImprovedTripwire.DisplayName, new ImprovedTripwire(1));
            dict.Add(InescapableStrongTrap.DisplayName, new InescapableStrongTrap(1));
            dict.Add(IntricatelyEngravedPommel.DisplayName, new IntricatelyEngravedPommel(1));
            dict.Add(LargeBagofMarbles.DisplayName, new LargeBagofMarbles(1));
            dict.Add(LargeMasterEmblemGuild.DisplayName, new LargeMasterEmblemGuild(1));
            dict.Add(LeafpatternHilt.DisplayName, new LeafpatternHilt(1));
            dict.Add(MasterWesternesseShieldspikeKit.DisplayName, new MasterWesternesseShieldspikeKit(1));
            dict.Add(MediumMasterEmblemGuild.DisplayName, new MediumMasterEmblemGuild(1));
            dict.Add(Mestarivimma.DisplayName, new Mestarivimma(1));
            dict.Add(MirroredAncientSteelAxeGuild.DisplayName, new MirroredAncientSteelAxeGuild(1));
            dict.Add(MirroredAncientSteelDaggerGuild.DisplayName, new MirroredAncientSteelDaggerGuild(1));
            dict.Add(MirroredAncientSteelGreatswordGuild.DisplayName, new MirroredAncientSteelGreatswordGuild(1));
            dict.Add(MirroredAncientSteelHalberdGuild.DisplayName, new MirroredAncientSteelHalberdGuild(1));
            dict.Add(MirroredAncientSteelHeadsmansAxeGuild.DisplayName, new MirroredAncientSteelHeadsmansAxeGuild(1));
            dict.Add(MirroredAncientSteelMaceGuild.DisplayName, new MirroredAncientSteelMaceGuild(1));
            dict.Add(MirroredAncientSteelSwordGuild.DisplayName, new MirroredAncientSteelSwordGuild(1));
            dict.Add(OverpoweringStunDust.DisplayName, new OverpoweringStunDust(1));
            dict.Add(PolishedAncientSteelAxe.DisplayName, new PolishedAncientSteelAxe(1));
            dict.Add(PolishedAncientSteelDagger.DisplayName, new PolishedAncientSteelDagger(1));
            dict.Add(PolishedAncientSteelGreatsword.DisplayName, new PolishedAncientSteelGreatsword(1));
            dict.Add(PolishedAncientSteelHalberd.DisplayName, new PolishedAncientSteelHalberd(1));
            dict.Add(PolishedAncientSteelHeadsmansAxe.DisplayName, new PolishedAncientSteelHeadsmansAxe(1));
            dict.Add(PolishedAncientSteelMace.DisplayName, new PolishedAncientSteelMace(1));
            dict.Add(PolishedAncientSteelSword.DisplayName, new PolishedAncientSteelSword(1));
            dict.Add(QualityQuickTrap.DisplayName, new QualityQuickTrap(1));
            dict.Add(SmallMasterEmblemGuild.DisplayName, new SmallMasterEmblemGuild(1));
            dict.Add(SuperiorTripletrap.DisplayName, new SuperiorTripletrap(1));
            dict.Add(WardensSceptre.DisplayName, new WardensSceptre(1));
        }
    }
}