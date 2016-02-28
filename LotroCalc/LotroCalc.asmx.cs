#define DECRYPT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using LotroCalc.RecipeData.Ingredients;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Professions;


namespace LotroCalc
{
    /// <summary>
    /// Summary description for LotroCalc
    /// </summary>
    [WebService(Namespace = "http://craftingcalc.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LotroCalc : WebService
    {
        private const string Seed = "tLd!B%;TC6mx#YuV";

        [WebMethod]
        public string[] GetRecipeNames(String profession, ProfessionTierEnum tier)
        {
#if DECRYPT
            var decProfession = EncryptedString.DecryptString(profession, Seed);
#else
            var decProfession = profession;
#endif
            var recipes = (SortedDictionary<string, Ingredient>)Application["Recipes"];
            var lstRet = new List<String>();

            foreach (Ingredient rec in recipes.Values)
            {
                var comp = (CompositeIngredients)rec; // down-cast for tier
                if (
                    ((rec is CookIngredients) && ("Cook" == decProfession)) ||
                    ((rec is JewelerIngredients) && ("Jeweler" == decProfession)) ||
                    ((rec is MetalsmithIngredients) && ("Metalsmith" == decProfession)) ||
                    ((rec is ScholarCompIngredients) && ("Scholar" == decProfession)) ||
                    ((rec is TailorIngredients) && ("Tailor" == decProfession)) ||
                    ((rec is WeaponsmithIngredients) && ("Weaponsmith" == decProfession)) ||
                    ((rec is WoodworkerIngredients) && ("Woodworker" == decProfession))
                    )
                {
                    if ((int)tier == (int)comp.Tier)
#if DECRYPT
                        lstRet.Add(EncryptedString.EncryptString(comp.Name, Seed));
#else
                        lstRet.Add(comp.Name);
#endif
                }
            }
            //System.Threading.Thread.Sleep(5000);
            return lstRet.ToArray();
        }

        public class WebIngredient
        {
            public string IngredientName;
            public string IngredientType;
            public int Quantity;
            public bool IsCrafted = false;
            public string Tier;
            public int Xp;
            public long SupplierCost;
        }

        [WebMethod]
        public WebIngredient[] GetRecipeIngredients(string recipeName, int quantity)
        {
            //var encRecipeName = EncryptedString.EncryptString(recipeName, Seed);

#if DECRYPT
            var decRecipeName = EncryptedString.DecryptString(recipeName, Seed);
#else
            var decRecipeName = recipeName;
#endif
            var dictRet = new SortedDictionary<string, WebIngredient>();

            var recs = (SortedDictionary<string, Ingredient>)Application["Recipes"];
            if (recs.ContainsKey(decRecipeName))
            {
                var recip = recs[decRecipeName];
                if (recip is CompositeIngredients)
                {
                    var comping = (CompositeIngredients) recip;
                    foreach (Ingredient subIng in comping.GetRecipeIngredients().Values)
                    {
                        if (!dictRet.ContainsKey(subIng.Name))
                            dictRet.Add(subIng.Name, GetWebIngredient(subIng, subIng.QuantityRequested));
                        else
                            dictRet[subIng.Name].Quantity += subIng.QuantityRequested;
                    }   
                    
                }
            }
            return dictRet.Values.ToArray();
        }

        [WebMethod]
        public WebIngredient[] GetComponentIngredients(string ingredientName, int quantity)
        {
           // var encRecipeName = EncryptedString.EncryptString(ingredientName, Seed);

#if DECRYPT
            var decIngredientName = EncryptedString.DecryptString(ingredientName, Seed);
#else
            var decIngredientName = ingredientName;
#endif
            var dictRet = new SortedDictionary<string, WebIngredient>();

            var ings = (SortedDictionary<string, Ingredient>)Application["Ingredients"];
            if (ings.ContainsKey(decIngredientName))
            {
                var recip = ings[decIngredientName];
                if (recip is CompositeIngredients)
                {
                    var comping = (CompositeIngredients)recip;
                    foreach (Ingredient subIng in comping.GetRecipeIngredients().Values)
                    {
                        if (!dictRet.ContainsKey(subIng.Name))
                            dictRet.Add(subIng.Name, GetWebIngredient(subIng, subIng.QuantityRequested));
                        else
                            dictRet[subIng.Name].Quantity += subIng.QuantityRequested;
                    }
                }
            }
            return dictRet.Values.ToArray();
        }


        [WebMethod]
        public WebIngredient[] GetRecursiveIngredients(string recipeName, int quantity)
        {
            //var encRecipeName = EncryptedString.EncryptString(recipeName, Seed);

#if DECRYPT
            var decRecipeName = EncryptedString.DecryptString(recipeName, Seed);
#else
            var decRecipeName = recipeName;
#endif

            var recs = (SortedDictionary<string, Ingredient>)Application["Recipes"];

            if (!(recs.ContainsKey(decRecipeName)))
                return null;

            var recTop = (CompositeIngredients)recs[decRecipeName];
            SortedDictionary<string, Ingredient> dictIngsTop = recTop.GetRecipeIngredients();

            var ings = (SortedDictionary<string, Ingredient>)Application["Ingredients"];
            var retIngs = new SortedDictionary<string, Ingredient>();
            var retWebIngs = new SortedDictionary<string, WebIngredient>();

            foreach (var ing in dictIngsTop.Values)
            {
                var ingTopName = ing.Name;
                if (ings.ContainsKey(ingTopName))
                {
                    var ingTop = ings[ingTopName];
                    if (ingTop is CompositeIngredients)
                    {
                        var rec = (CompositeIngredients)ingTop;
                        if (!retIngs.ContainsKey(ingTopName))
                        {
                            var ingAdd = (Ingredient)rec.Clone();
                            ingAdd.QuantityRequested = (rec.QuantityRequested * ing.QuantityRequested);
                            retIngs.Add(ingTopName, ingAdd);
                        }
                        else
                            retIngs[ingTopName].QuantityRequested += (rec.QuantityRequested * ing.QuantityRequested);

                        SortedDictionary<string, Ingredient> subIngs = rec.GetRecipeIngredients();

                        foreach (var subing in subIngs.Values)
                            GetRecursiveIngredient(ref retIngs, subing.Name, (retIngs[ingTopName].QuantityRequested * subing.QuantityRequested));
                    }
                    else if (ingTop is SupplierIngredients)
                    {
                        var rec = (SupplierIngredients)ingTop;
                        if (!retIngs.ContainsKey(ingTopName))
                        {
                            var ingAdd = (Ingredient)rec.Clone();
                            ingAdd.QuantityRequested = (rec.QuantityRequested * ing.QuantityRequested);
                            retIngs.Add(ingTopName, ingAdd);
                        }
                        else
                            retIngs[ingTopName].QuantityRequested += (rec.QuantityRequested * ing.QuantityRequested);
                    }
                    else
                    {
                        var rec = (SimpleIngredients)ingTop;
                        if (!retIngs.ContainsKey(ingTopName))
                        {
                            var ingAdd = (Ingredient)rec.Clone();
                            ingAdd.QuantityRequested = (rec.QuantityRequested * ing.QuantityRequested);
                            retIngs.Add(ingTopName, ingAdd);
                        }
                        else
                            retIngs[ingTopName].QuantityRequested += (rec.QuantityRequested * ing.QuantityRequested);
                    }
                }
            }

            foreach (var retkey in retIngs.Keys )
            {
                var val = retIngs[retkey];
                retWebIngs.Add(retkey, GetWebIngredient(val, val.QuantityRequested));
            }
            return retWebIngs.Values.ToArray();
        }

        private void GetRecursiveIngredient(ref SortedDictionary<string, Ingredient> retIngs, string ingredientName, int quantity)
        {
            var ings = (SortedDictionary<string, Ingredient>) Application["Ingredients"];

            if (ings.ContainsKey(ingredientName))
            {
                if (ings[ingredientName] is CompositeIngredients)
                {
                    var rec = (CompositeIngredients)ings[ingredientName];
                    if (!retIngs.ContainsKey(ingredientName))
                    {
                        var ingAdd = (Ingredient)rec.Clone();
                        ingAdd.QuantityRequested = (rec.QuantityRequested * quantity);
                        retIngs.Add(ingredientName, ingAdd);
                    }
                    else
                        retIngs[ingredientName].QuantityRequested += (rec.QuantityRequested * quantity);

                    SortedDictionary<string, Ingredient> subIngs = rec.GetRecipeIngredients();

                    foreach (var subing in subIngs.Values)
                        GetRecursiveIngredient(ref retIngs, subing.Name, (subing.QuantityRequested * quantity));
                }
                else if (ings[ingredientName] is SupplierIngredients)
                {
                    var rec = (SupplierIngredients)ings[ingredientName];
                    if (!retIngs.ContainsKey(ingredientName))
                    {
                        var ingAdd = (Ingredient) rec.Clone();
                        ingAdd.QuantityRequested = (rec.QuantityRequested * quantity);
                        retIngs.Add(ingredientName, ingAdd);
                    }
                    else
                        retIngs[ingredientName].QuantityRequested += (rec.QuantityRequested * quantity);
                }
                else
                {
                    var rec = (SimpleIngredients)ings[ingredientName];
                    if (!retIngs.ContainsKey(ingredientName))
                    {
                        var ingAdd = (Ingredient)rec.Clone();
                        ingAdd.QuantityRequested = (rec.QuantityRequested * quantity);
                        retIngs.Add(ingredientName, ingAdd);
                    }
                    else
                        retIngs[ingredientName].QuantityRequested += (rec.QuantityRequested * quantity);
                }
            }
        }


        private WebIngredient GetWebIngredient(Ingredient ing, int quantity)
        {
            var wi = new WebIngredient
            {
#if DECRYPT
                IngredientName = EncryptedString.EncryptString(ing.Name, Seed),
#else
                IngredientName = ing.Name,
#endif
                //IngredientName = ing.Name,
                Quantity = quantity,
#if DECRYPT
                IngredientType = EncryptedString.EncryptString(ing.FormatIngredientType(), Seed)
#else
                IngredientType = ing.FormatIngredientType()
#endif
                //IngredientType = ing.FormatIngredientType()
            };

            if (ing is CompositeIngredients)
            {
                var ci = (CompositeIngredients)ing;
                wi.IsCrafted = true;
#if DECRYPT
                wi.Tier = EncryptedString.EncryptString(ci.Tier.ToString(), Seed);
#else
                wi.Tier = ci.Tier.ToString();
#endif
                wi.Xp = ci.CraftingExperience;
            }
            else // SimpleIngredient
            {
                var simpIng = (SimpleIngredients)ing;
                if (simpIng is SupplierIngredients)
                {
                    var supIng = (SupplierIngredients)ing;
                    wi.SupplierCost = supIng.EstimatedCost * quantity;
                }
            }
            return wi;
        }
    }
}
