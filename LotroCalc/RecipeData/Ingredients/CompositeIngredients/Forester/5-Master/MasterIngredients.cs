using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._5_Master
{
    public abstract class MasterIngredients : ForesterCompIngredients 
    {
        protected MasterIngredients()
        {
            Tier = ProfessionTierEnum.Master;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(GossamerThread.DisplayName, new GossamerThread(1));
            dict.Add(PieceOfExceptionalLeather.DisplayName, new PieceOfExceptionalLeather(1));
            dict.Add(PlankOfTreatedBlackAsh.DisplayName, new PlankOfTreatedBlackAsh(1));
            dict.Add(TreatedBlackAshHeartwood.DisplayName, new TreatedBlackAshHeartwood(1));
        }
    }
}