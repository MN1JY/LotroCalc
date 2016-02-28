using System.Collections.Generic;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions
{
    public class ScholarIngredients : SimpleIngredients
    {
	    public static string AgedScrapOfText = "Aged Scrap Of Text";
        public static string BookOfBallads = "Book Of Ballads";
        public static string BrokenDwarfStatue = "Broken Dwarf-Statue";
        public static string CrackedDwarfCarving = "Cracked Dwarf-Carving";
        public static string CrypticText = "Cryptic Text";
        public static string EarlyThirdAgeRelic = "Early Third Age Relic";
        public static string EtchingOfMoria = "Etching Of Moria";
        public static string FragmentOfDunedainScript = "Fragment Of Dunedain Script";
        public static string FadedSindarinPassages = "Faded Sindarin Passages";
        public static string LongLostSecondAgeTexts = "Long-Lost Second Age Texts";
        public static string PageOfGondorianParchment = "Page Of Gondorian Parchment";
        public static string RelicOfKhazadDum = "Relic Of Khazad-Dum";
        public static string RelicOfLothlorien = "Relic Of Lothlorien";
        public static string RuneCarvedTablets = "Rune-Carved Tablets";
        public static string RuinedSecondAgeTrinket = "Ruined Second Age Trinket";
        public static string ScrapOfRohirricText = "Scrap Of Rohirric Text";
        public static string ScrapOfWeatheredDunlendingText = "Scrap Of Weathered Dunlending Text";
        public static string ScrollsOfInsight = "Scrolls Of Insight";
        public static string TatteredKhuzdulParchment = "Tattered Khuzdul Parchment";
        public static string TornCraftsmansDiary = "Torn Craftsman's Diary";
        public static string TornScholarsJournal = "Torn Scholar's Journal";
        public static string UndecipheredMoonLetters = "Undeciphered Moon-Letters";
        public static string WornTabletFragment = "Worn Tablet Fragment";
        public static string WornElfCarving = "Worn Elf-Carving";

	    public ScholarIngredients(string ingredientName, int count, ProfessionTierEnum level)
	    {
		    Name = ingredientName;
		    QuantityRequested = count;
		    Tier = level;
	    }


	    public override object Clone()
	    {
		    return new ScholarIngredients(Name, QuantityRequested, Tier);
	    }


        public override string FormatIngredientType()
	    {
		    return "Scholar";
	    }


	    public static void GetScholarIngredients(ref SortedDictionary<string, Ingredient> dictIng)
	    {
		    //************************************
            ProfessionTierEnum level = ProfessionTierEnum.Apprentice;

		    dictIng.Add(AgedScrapOfText, new ScholarIngredients(AgedScrapOfText, 1, level));
		    dictIng.Add(EarlyThirdAgeRelic, new ScholarIngredients(EarlyThirdAgeRelic, 1, level));
		    dictIng.Add(WornTabletFragment, new ScholarIngredients(WornTabletFragment, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Journeyman;

		    dictIng.Add(CrypticText, new ScholarIngredients(CrypticText, 1, level));
		    dictIng.Add(RuinedSecondAgeTrinket, new ScholarIngredients(RuinedSecondAgeTrinket, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Expert;
            dictIng.Add(CrackedDwarfCarving, new ScholarIngredients(CrackedDwarfCarving, 1, level));
            dictIng.Add(FadedSindarinPassages, new ScholarIngredients(FadedSindarinPassages, 1, level));
            dictIng.Add(TornCraftsmansDiary, new ScholarIngredients(TornCraftsmansDiary, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Artisan;
            dictIng.Add(FragmentOfDunedainScript, new ScholarIngredients(FragmentOfDunedainScript, 1, level));
            dictIng.Add(RelicOfLothlorien, new ScholarIngredients(RelicOfLothlorien, 1, level));
            dictIng.Add(TornScholarsJournal, new ScholarIngredients(TornScholarsJournal, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Master;
            dictIng.Add(LongLostSecondAgeTexts, new ScholarIngredients(LongLostSecondAgeTexts, 1, level));
            dictIng.Add(UndecipheredMoonLetters, new ScholarIngredients(UndecipheredMoonLetters, 1, level));
            dictIng.Add(WornElfCarving, new ScholarIngredients(WornElfCarving, 1, level));

		    //************************************
		    level = ProfessionTierEnum.Supreme;
            dictIng.Add(BrokenDwarfStatue, new ScholarIngredients(BrokenDwarfStatue, 1, level));
            dictIng.Add(EtchingOfMoria, new ScholarIngredients(EtchingOfMoria, 1, level));
            dictIng.Add(RelicOfKhazadDum, new ScholarIngredients(RelicOfKhazadDum, 1, level));
            dictIng.Add(RuneCarvedTablets, new ScholarIngredients(RuneCarvedTablets, 1, level));
            dictIng.Add(TatteredKhuzdulParchment, new ScholarIngredients(TatteredKhuzdulParchment, 1, level));

            //************************************
            level = ProfessionTierEnum.Westfold;
            dictIng.Add(PageOfGondorianParchment, new ScholarIngredients(PageOfGondorianParchment, 1, level));
            dictIng.Add(ScrapOfWeatheredDunlendingText, new ScholarIngredients(ScrapOfWeatheredDunlendingText, 1, level));
            dictIng.Add(ScrollsOfInsight, new ScholarIngredients(ScrollsOfInsight, 1, level));

            //************************************
            level = ProfessionTierEnum.Eastemnet;
            dictIng.Add(ScrapOfRohirricText, new ScholarIngredients(ScrapOfRohirricText, 1, level));
        }
    }
}