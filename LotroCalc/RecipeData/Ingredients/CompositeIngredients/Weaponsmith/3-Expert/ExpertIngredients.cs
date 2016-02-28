using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._3_Expert
{
    public abstract class ExpertIngredients : WeaponsmithIngredients 
    {
        protected ExpertIngredients()
        {
            Tier = ProfessionTierEnum.Expert;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(StrongTrap.DisplayName, new StrongTrap(1));
            dict.Add(BrightSteelAxe.DisplayName, new BrightSteelAxe(1));
            dict.Add(BrightSteelBlade.DisplayName, new BrightSteelBlade(1));
            dict.Add(BrightSteelDagger.DisplayName, new BrightSteelDagger(1));
            dict.Add(BrightSteelGreatsword.DisplayName, new BrightSteelGreatsword(1));
            dict.Add(BrightSteelSword.DisplayName, new BrightSteelSword(1));
            dict.Add(BrightSteelThrowingAxe.DisplayName, new BrightSteelThrowingAxe(1));
            dict.Add(EtchedSteelEmblem.DisplayName, new EtchedSteelEmblem(1));
            dict.Add(ExpertAncientDwarfShieldspikeKits.DisplayName, new ExpertAncientDwarfShieldspikeKits(1));
            dict.Add(GondorianAxe.DisplayName, new GondorianAxe(1));
            dict.Add(GondorianDagger.DisplayName, new GondorianDagger(1));
            dict.Add(GondorianGreatsword.DisplayName, new GondorianGreatsword(1));
            dict.Add(GondorianSword.DisplayName, new GondorianSword(1));
            dict.Add(GondorianThrowingAxe.DisplayName, new GondorianThrowingAxe(1));
            dict.Add(HeavyBrightSteelAxe.DisplayName, new HeavyBrightSteelAxe(1));
            dict.Add(HeavyBrightSteelDagger.DisplayName, new HeavyBrightSteelDagger(1));
            dict.Add(HeavyBrightSteelGreatsword.DisplayName, new HeavyBrightSteelGreatsword(1));
            dict.Add(HeavyBrightSteelHalberd.DisplayName, new HeavyBrightSteelHalberd(1));
            dict.Add(HeavyBrightSteelHeadsmansAxe.DisplayName, new HeavyBrightSteelHeadsmansAxe(1));
            dict.Add(HeavyBrightSteelMace.DisplayName, new HeavyBrightSteelMace(1));
            dict.Add(HeavyBrightSteelSword.DisplayName, new HeavyBrightSteelSword(1));
            dict.Add(ImprovedBearTraps.DisplayName, new ImprovedBearTraps(1));
            dict.Add(ImprovedBrightSteelBladeGuild.DisplayName, new ImprovedBrightSteelBladeGuild(1));
            dict.Add(ImprovedCaltrops.DisplayName, new ImprovedCaltrops(1));
            dict.Add(ImprovedEtchedSteelEmblemGuild.DisplayName, new ImprovedEtchedSteelEmblemGuild(1));
            dict.Add(ImprovedQuickTraps.DisplayName, new ImprovedQuickTraps(1));
            dict.Add(ImprovedShieldspikeKits.DisplayName, new ImprovedShieldspikeKits(1));
            dict.Add(ImprovedSteelHiltGuild.DisplayName, new ImprovedSteelHiltGuild(1));
            dict.Add(ImprovedSteelPommelGuild.DisplayName, new ImprovedSteelPommelGuild(1));
            dict.Add(ImprovedStunDusts.DisplayName, new ImprovedStunDusts(1));
            dict.Add(LureTrap.DisplayName, new LureTrap(1));
            dict.Add(MediumExpertEmblem.DisplayName, new MediumExpertEmblem(1));
            dict.Add(MirroredGondorianAxeGuild.DisplayName, new MirroredGondorianAxeGuild(1));
            dict.Add(MirroredGondorianDaggerGuild.DisplayName, new MirroredGondorianDaggerGuild(1));
            dict.Add(MirroredGondorianGreatswordGuild.DisplayName, new MirroredGondorianGreatswordGuild(1));
            dict.Add(MirroredGondorianHalberdGuild.DisplayName, new MirroredGondorianHalberdGuild(1));
            dict.Add(MirroredGondorianHeadsmansAxeGuild.DisplayName, new MirroredGondorianHeadsmansAxeGuild(1));
            dict.Add(MirroredGondorianMaceGuild.DisplayName, new MirroredGondorianMaceGuild(1));
            dict.Add(MirroredGondorianSwordGuild.DisplayName, new MirroredGondorianSwordGuild(1));
            dict.Add(PolishedGondorianAxe.DisplayName, new PolishedGondorianAxe(1));
            dict.Add(PolishedGondorianDagger.DisplayName, new PolishedGondorianDagger(1));
            dict.Add(PolishedGondorianGreatsword.DisplayName, new PolishedGondorianGreatsword(1));
            dict.Add(PolishedGondorianHalberd.DisplayName, new PolishedGondorianHalberd(1));
            dict.Add(PolishedGondorianHeadsmansAxe.DisplayName, new PolishedGondorianHeadsmansAxe(1));
            dict.Add(PolishedGondorianMace.DisplayName, new PolishedGondorianMace(1));
            dict.Add(PolishedGondorianSword.DisplayName, new PolishedGondorianSword(1));
            dict.Add(SmallBagofMarbles.DisplayName, new SmallBagofMarbles(1));
            dict.Add(SmallExpertEmblem.DisplayName, new SmallExpertEmblem(1));
            dict.Add(SteelHilt.DisplayName, new SteelHilt(1));
            dict.Add(SteelPommel.DisplayName, new SteelPommel(1));
            dict.Add(Tripletraps.DisplayName, new Tripletraps(1));
        }
    }
}