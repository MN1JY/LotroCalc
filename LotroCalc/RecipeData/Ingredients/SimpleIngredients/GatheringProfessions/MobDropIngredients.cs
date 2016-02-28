using System.Collections.Generic;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions
{
    public class MobDropIngredients : SimpleIngredients
    {
        public static string AdamantShard = "Adamant Shard";
        public static string BerylShard = "Beryl Shard";
        public static string CrushedIntestine = "Crushed Intestine";
        public static string DelicateHorn = "Delicate Horn";
        public static string ExceptionalHide = "Exceptional Hide";
        public static string ExtraordinaryHide = "Extraordinary Hide";
        public static string GreatHoaryAurochsHide = "Great Hoary Aurochs Hide";
        public static string LargeHide = "Large Hide";
        public static string LightHide = "Light Hide";
        public static string LongHorn = "Long Horn";
        public static string MagnificentHide = "Magnificent Hide";
	    public static string MediumHide = "Medium Hide";
	    public static string MithrilFlake = "Mithril Flake";
        public static string PristineHide = "Pristine Hide";
        public static string RubyShard = "Ruby Shard";
	    public static string SapphireShard = "Sapphire Shard";
        public static string SmallIntestine = "Small Intestine";
        public static string SpiderSilk = "Spider Silk";
        public static string SpeckledShellFragment = "Speckled Shell Fragment";
        public static string SlenderHorn = "Slender Horn";
        public static string StreakedHorn = "Streaked Horn";
        public static string SturdyHide = "Sturdy Hide";
        public static string SymbolOfCelebrimbor = "Symbol Of Celebrimbor";
        public static string TuftofTorahammasFur = "Tuft of Torahammas' Fur";
        public static string TornIntestine = "Torn Intestine";

	    public MobDropIngredients(string ingredientName, int count, ProfessionTierEnum level)
	    {
		    Name = ingredientName;
		    QuantityRequested = count;
		    Tier = level;
	    }

	    public override object Clone()
	    {
		    return new MobDropIngredients(Name, QuantityRequested, Tier);
	    }


        public override string FormatIngredientType()
	    {
		    return "Mob Drop";
	    }


	    public static void GetMobDropIngredients(ref SortedDictionary<string, Ingredient> dictIng)
	    {
		    //************************************
            ProfessionTierEnum level = ProfessionTierEnum.Apprentice;
		    dictIng.Add(CrushedIntestine, new MobDropIngredients(CrushedIntestine, 1, level));
            dictIng.Add(LightHide, new MobDropIngredients(LightHide, 1, level));
            dictIng.Add(TornIntestine, new MobDropIngredients(TornIntestine, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Journeyman;
            dictIng.Add(DelicateHorn, new MobDropIngredients(DelicateHorn, 1, level));
            dictIng.Add(MediumHide, new MobDropIngredients(MediumHide, 1, level));
            dictIng.Add(SapphireShard, new MobDropIngredients(SapphireShard, 1, level));
            dictIng.Add(SmallIntestine, new MobDropIngredients(SmallIntestine, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Expert;
            dictIng.Add(RubyShard, new MobDropIngredients(RubyShard, 1, level));
            dictIng.Add(StreakedHorn, new MobDropIngredients(StreakedHorn, 1, level));
            dictIng.Add(SturdyHide, new MobDropIngredients(SturdyHide, 1, level));

            //************************************
            level = ProfessionTierEnum.Artisan;
            dictIng.Add(AdamantShard, new MobDropIngredients(AdamantShard, 1, level));
            dictIng.Add(SlenderHorn, new MobDropIngredients(SlenderHorn, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Master;
            dictIng.Add(BerylShard, new MobDropIngredients(BerylShard, 1, level));
            dictIng.Add(ExceptionalHide, new MobDropIngredients(ExceptionalHide, 1, level));
            dictIng.Add(GreatHoaryAurochsHide, new MobDropIngredients(GreatHoaryAurochsHide, 1, level));
            dictIng.Add(LongHorn, new MobDropIngredients(LongHorn, 1, level));
            dictIng.Add(PristineHide, new MobDropIngredients(PristineHide, 1, level));
            dictIng.Add(SpiderSilk, new MobDropIngredients(SpiderSilk, 1, level));
            dictIng.Add(TuftofTorahammasFur, new MobDropIngredients(TuftofTorahammasFur, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Supreme;
		    dictIng.Add(ExtraordinaryHide, new MobDropIngredients(ExtraordinaryHide, 1, level));
		    dictIng.Add(MithrilFlake, new MobDropIngredients(MithrilFlake, 1, level));
            dictIng.Add(MagnificentHide, new MobDropIngredients(MagnificentHide, 1, level));
            dictIng.Add(SpeckledShellFragment, new MobDropIngredients(SpeckledShellFragment, 1, level));
            dictIng.Add(SymbolOfCelebrimbor, new MobDropIngredients(SymbolOfCelebrimbor, 1, level));

            //************************************
            level = ProfessionTierEnum.Westfold;
            dictIng.Add(LargeHide, new MobDropIngredients(LargeHide, 1, level));
        }
    }
}