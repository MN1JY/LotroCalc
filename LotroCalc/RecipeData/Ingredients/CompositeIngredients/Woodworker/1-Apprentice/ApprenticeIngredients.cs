using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker._1_Apprentice
{
    public abstract class ApprenticeIngredients : WoodworkerIngredients 
    {
        protected ApprenticeIngredients()
        {
            Tier = ProfessionTierEnum.Apprentice;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(HeavyRowanBow.DisplayName, new HeavyRowanBow(1));
            dict.Add(HeavyRowanClub.DisplayName, new HeavyRowanClub(1));
            dict.Add(HeavyRowanCrossbow.DisplayName, new HeavyRowanCrossbow(1));
            dict.Add(HeavyRowanGreatClub.DisplayName, new HeavyRowanGreatClub(1));
            dict.Add(HeavyRowanHammer.DisplayName, new HeavyRowanHammer(1));
            dict.Add(HeavyRowanJavelin.DisplayName, new HeavyRowanJavelin(1));
            dict.Add(HeavyRowanSpear.DisplayName, new HeavyRowanSpear(1));
            dict.Add(HeavyRowanStaff.DisplayName, new HeavyRowanStaff(1));
            dict.Add(LongDwarfMakeTable.DisplayName, new LongDwarfMakeTable(1));
            dict.Add(RowanBow.DisplayName, new RowanBow(1));
            dict.Add(RowanBowstaff.DisplayName, new RowanBowstaff(1));
            dict.Add(RowanBrace.DisplayName, new RowanBrace(1));
            dict.Add(RowanClub.DisplayName, new RowanClub(1));
            dict.Add(RowanCrossbow.DisplayName, new RowanCrossbow(1));
            dict.Add(RowanGreatClub.DisplayName, new RowanGreatClub(1));
            dict.Add(RowanHaft.DisplayName, new RowanHaft(1));
            dict.Add(RowanHammer.DisplayName, new RowanHammer(1));
            dict.Add(RowanJavelin.DisplayName, new RowanJavelin(1));
            dict.Add(RowanSpear.DisplayName, new RowanSpear(1));
            dict.Add(RowanStaff.DisplayName, new RowanStaff(1));

        }
    }
}