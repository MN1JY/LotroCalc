using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions
{
    public class ForesterIngredients : SimpleIngredients
    {
        public static string BirchSapwoodBranch = "Birch Sapwood Branch";
        public static string BlackAshHeartwood = "Black Ash Heartwood";
        public static string LogOfAshWood = "Log Of Ash Wood";
        public static string LogOfBlackAshWood = "Log Of Black Ash Wood";
        public static string LogOfIlexWood = "Log Of Ilex Wood";
        public static string LogOfLebethronWood = "Log Of Lebethron Wood";
        public static string LogOfMallornWood = "Log Of Mallorn Wood";
        public static string LogOfOakWood = "Log Of Oak Wood";
        public static string LogOfRowanWood = "Log Of Rowan Wood";
        public static string LogOfYewWood = "Log Of Yew Wood";
        public static string GnarledBirchBranches = "Gnarled Birch Branches";

        public ForesterIngredients(string ingredientName, int count, ProfessionTierEnum level)
        {
            Name = ingredientName;
            QuantityRequested = count;
            Tier = level;
        }


        public override object Clone()
        {
            return new ForesterIngredients(Name, QuantityRequested, Tier);
        }


        public override string FormatIngredientType()
        {
            return "Forester";
        }


        public static void GetForesterIngredients(ref SortedDictionary<string, Ingredient> dictIng)
        {
            ProfessionTierEnum level = ProfessionTierEnum.Apprentice;

            //************************************
            level = ProfessionTierEnum.Apprentice;
            dictIng.Add(LogOfRowanWood, new ForesterIngredients(LogOfRowanWood, 1, level));


            //************************************
            level = ProfessionTierEnum.Journeyman;
            dictIng.Add(LogOfAshWood, new ForesterIngredients(LogOfAshWood, 1, level));

            //************************************
            level = ProfessionTierEnum.Expert;
            dictIng.Add(LogOfYewWood, new ForesterIngredients(LogOfYewWood, 1, level));

            //************************************
            level = ProfessionTierEnum.Artisan;
            dictIng.Add(LogOfLebethronWood, new ForesterIngredients(LogOfLebethronWood, 1, level));

            //************************************
            level = ProfessionTierEnum.Master;
            dictIng.Add(BlackAshHeartwood, new ForesterIngredients(BlackAshHeartwood, 1, level));
            dictIng.Add(LogOfBlackAshWood, new ForesterIngredients(LogOfBlackAshWood, 1, level));

            //************************************
            level = ProfessionTierEnum.Supreme;
            dictIng.Add(LogOfMallornWood, new ForesterIngredients(LogOfMallornWood, 1, level));
            dictIng.Add(LogOfIlexWood, new ForesterIngredients(LogOfIlexWood, 1, level));

            //************************************
            level = ProfessionTierEnum.Westfold;
            dictIng.Add(BirchSapwoodBranch, new ForesterIngredients(BirchSapwoodBranch, 1, level));
            dictIng.Add(GnarledBirchBranches, new ForesterIngredients(GnarledBirchBranches, 1, level));

            //************************************
            level = ProfessionTierEnum.Eastemnet;
            dictIng.Add(LogOfOakWood, new ForesterIngredients(LogOfOakWood, 1, level));
        }
    }
}