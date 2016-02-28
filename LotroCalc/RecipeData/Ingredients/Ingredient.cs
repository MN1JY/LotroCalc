using System;
using System.Collections.Generic;

namespace LotroCalc.RecipeData.Ingredients
{
    public abstract class Ingredient : ICloneable
    {
        public bool IsUserRecipe;
        public string Name;
        public int QuantityRequested;

        // these are inherited by the child classes to define their ingredients
        public static SortedDictionary<string, Ingredient> DictCraftedIngredients;
        public static SortedDictionary<string, Ingredient> DictSimpleIngredients;

        public abstract object Clone();
        public abstract string FormatIngredientType();

        protected Ingredient()
        {
            IsUserRecipe = false;

            if (null == DictSimpleIngredients)
            {
                DictSimpleIngredients = new SortedDictionary<string, Ingredient>();
                SimpleIngredients.SimpleIngredients.GetSimpleIngredients(ref DictSimpleIngredients);
            }

            if (null == DictCraftedIngredients)
            {
                DictCraftedIngredients = new SortedDictionary<string, Ingredient>();
                CompositeIngredients.CompositeIngredients.GetCompositeIngredients(ref DictCraftedIngredients);
            }
        }

        // this is called by global.asax to get the user recipes
        public static SortedDictionary<string, Ingredient> GetUserRecipes()
        {
            var dict = new SortedDictionary<string, Ingredient>();
            CompositeIngredients.CompositeIngredients.GetCompositeRecipes(ref dict);
            return dict;
        }

        // this is called by global.asax to display ingredients
        public static SortedDictionary<string, Ingredient> GetIngredients()
        {
            var dict = new SortedDictionary<string, Ingredient>();
            SimpleIngredients.SimpleIngredients.GetSimpleIngredients(ref dict);
            CompositeIngredients.CompositeIngredients.GetCompositeIngredients(ref dict);
            return dict;
        }
    }
}