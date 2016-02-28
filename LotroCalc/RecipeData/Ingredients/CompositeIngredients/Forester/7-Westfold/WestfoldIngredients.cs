using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._7_Westfold.Ingredients;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._7_Westfold
{
    public abstract class WestfoldIngredients : ForesterCompIngredients 
    {
        protected WestfoldIngredients()
        {
            Tier = ProfessionTierEnum.Westfold;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(DropOfBirchTar.DisplayName, new DropOfBirchTar(1));
            dict.Add(PieceOfBrushedLeather.DisplayName, new PieceOfBrushedLeather(1));
            dict.Add(PieceOfGlazedLeather.DisplayName, new PieceOfGlazedLeather(1));
            dict.Add(ReinforcedBirchBoard.DisplayName, new ReinforcedBirchBoard(1));
            dict.Add(SolidBirchBoard.DisplayName, new SolidBirchBoard(1));
            dict.Add(ThinBirchBoard.DisplayName, new ThinBirchBoard(1));
        }
    }
}