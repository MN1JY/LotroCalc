using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._4_Artisan
{
    public abstract class ArtisanIngredients : ForesterCompIngredients 
    {
        protected ArtisanIngredients()
        {
            Tier = ProfessionTierEnum.Artisan;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(PieceOfPristineLeather.DisplayName, new PieceOfPristineLeather(1));
            dict.Add(PlankOfTreatedLebethron.DisplayName, new PlankOfTreatedLebethron(1));
        }
    }
}