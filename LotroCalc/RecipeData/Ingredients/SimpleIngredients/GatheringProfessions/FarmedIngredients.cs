using System.Collections.Generic;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions
{
    public class FarmedIngredients : SimpleIngredients
    {
        public static string AmaranthPetal = "Amaranth Petal";

        public static string BagOfCoffeeBeans = "Bag of Coffee Beans";
        public static string BagOfEastemnetCoffeeBeans = "Bag Of Eastemnet Coffee Beans";
        public static string BagOfWestemnetCoffeeBeans = "Bag Of Westemnet Coffee Beans";
        public static string BlackBarley = "Black Barley";
        public static string BlackberryHoney = "Blackberry Honey";
        public static string BloodwortRoot = "Bloodwort Root";
        public static string BluebottlePetal = "Bluebottle Petal";
        public static string BunchOfBeans = "Bunch Of Beans";
        public static string BunchOfBillberries = "Bunch Of Billberries";
        public static string BunchOfBlackberries = "Bunch Of Blackberries";
        public static string BunchOfBlueberries = "Bunch Of Blueberries";
        public static string BunchOfCherries = "Bunch Of Cherries";
        public static string BunchOfGoldingHops = "Bunch Of Golding Hops";
        public static string BunchOfGreenHillHops = "Bunch Of Green Hill Hops";
        public static string BunchOfLeeks = "Bunch Of Leeks";
        public static string BunchOfKingsteadMushrooms = "Bunch Of Kingstead Mushrooms";
        public static string BunchOfNorthDownsHops = "Bunch Of North Downs Hops";
        public static string BunchOfOats = "Bunch Of Oats";
        public static string BunchOfPears = "Bunch Of Pears";
        public static string BunchOfPrideOfChetwoodHops = "Bunch Of Pride Of Chetwood Hops";
        public static string BunchOfRasberries = "Bunch Of Rasberries";
        public static string BunchOfRyeBerries = "Bunch Of Rye Berries";
        public static string BunchOfStrawberries = "Bunch Of Strawberries";
        public static string BunchOfTurnips = "Bunch Of Turnips";
        public static string BunchOfUmbelHops = "Bunch Of Umbel Hops";
        public static string BundleOfBlackBarley = "Bundle Of Black Barley";
        public static string BundleOfMintLeaves = "Bundle Of Mint Leaves";
        public static string BundleOfSpringBarley = "Bundle Of Spring Barley";
        public static string BundleOfStraw = "Bundle Of Straw";
        public static string BundleOfTeaLeaves = "Bundle Of Tea Leaves";
        public static string BundleOfWinterBarley = "Bundle Of Winter Barley";

        public static string Cabbage = "Cabbage";
        public static string ClumpOfPeat = "Clump Of Peat";

        public static string FreshCarrot = "Fresh Carrot";
        public static string FineTeaLeaves = "Fine Tea Leaves";

        public static string GoldenShireTater = "Golden Shire Tater";
        public static string GreenOnion = "Green Onion";
        public static string GreenPeas = "Green Peas";

        public static string HeadOfCauliflower = "Head Of Cauliflower";
        public static string HornblowerPipeWeed = "Hornblower Pipe Weed";

        public static string Iris = "Iris";
        public static string IrisRoot = "Iris Root";

        public static string JuicyBlackberry = "Juicy Blackberry";
        public static string JuicyElderberry = "Juicy Elderberry";
        public static string JuicyStrawberry = "Juicy Strawberry";

        public static string LargeBagOfEastemnetCoffeeBeans = "Large Bag Of Eastemnet Coffee Beans";
        public static string LargeBunchOfCherries = "Large Bunch Of Cherries";
        public static string LargeBunchOfRyeBerries = "Large Bunch Of Rye Berries";
        public static string LargeBunchOfTurnips = "Large Bunch Of Turnips";
        public static string LilyOfTheValleyLeaf = "Lily Of The Valley Leaf";

        public static string Mushroom = "Mushroom";

        public static string OnionSkin = "Onion Skin";

        public static string PerfectTeaLeaves = "Perfect Tea Leaves";
        public static string PinchOfWestfoldHerbs = "Pinch Of Westfold Herbs";
        public static string Potato = "Potato";

        public static string RiddermarkCoffeeBeans = "Riddermark Coffee Beans";
        public static string RoyalTaters = "Royal Tater";
        public static string RushlightPipeWeed = "Rushlight Pipe-Weed";

        public static string Saffron = "Saffron";
        public static string SaffronThread = "Saffron Thread";
        public static string ShireApple = "Shire Apple";
        public static string SouthlinchPipeWeed = "Southlinch Pipe-Weed";

        public static string Tater = "Tater";
        public static string TeaLeaves = "Tea Leaves";

        public static string YarrowRoot = "Yarrow Root";
        public static string YellowOnion = "Yellow Onion";
        public static string YoungTeaLeaves = "Young Tea Leaves";
        //Public _Tier As ProfessionTierEnum

        public FarmedIngredients(string ingredientName, int count, ProfessionTierEnum level)
        {
            Name = ingredientName;
            QuantityRequested = count;
            Tier = level;
        }


        public override object Clone()
        {
            return new FarmedIngredients(Name, QuantityRequested, Tier);
        }


        public override string FormatIngredientType()
        {
            return "Farmer";
        }


        public static void GetFarmedIngredients(ref SortedDictionary<string, Ingredient> dictIng)
        {
            //************************************
            ProfessionTierEnum level = ProfessionTierEnum.Apprentice;
            dictIng.Add(BagOfCoffeeBeans, new FarmedIngredients(BagOfCoffeeBeans, 1, level));
            dictIng.Add(Potato, new FarmedIngredients(Potato, 1, level));
            dictIng.Add(BundleOfSpringBarley, new FarmedIngredients(BundleOfSpringBarley, 1, level));
            dictIng.Add(BunchOfNorthDownsHops, new FarmedIngredients(BunchOfNorthDownsHops, 1, level));
            dictIng.Add(FreshCarrot, new FarmedIngredients(FreshCarrot, 1, level));
            dictIng.Add(LilyOfTheValleyLeaf, new FarmedIngredients(LilyOfTheValleyLeaf, 1, level));
            dictIng.Add(Mushroom, new FarmedIngredients(Mushroom, 1, level));
            dictIng.Add(RushlightPipeWeed, new FarmedIngredients(RushlightPipeWeed, 1, level));
            dictIng.Add(SouthlinchPipeWeed, new FarmedIngredients(SouthlinchPipeWeed, 1, level));
            dictIng.Add(YarrowRoot, new FarmedIngredients(YarrowRoot, 1, level));
            dictIng.Add(YellowOnion, new FarmedIngredients(YellowOnion, 1, level));

            //************************************
            level = ProfessionTierEnum.Journeyman;
            dictIng.Add(BunchOfBlueberries, new FarmedIngredients(BunchOfBlueberries, 1, level));
            dictIng.Add(BunchOfGoldingHops, new FarmedIngredients(BunchOfGoldingHops, 1, level));
            dictIng.Add(BunchOfOats, new FarmedIngredients(BunchOfOats, 1, level));
            dictIng.Add(BundleOfStraw, new FarmedIngredients(BundleOfStraw, 1, level));
            dictIng.Add(Cabbage, new FarmedIngredients(Cabbage, 1, level));
            dictIng.Add(HornblowerPipeWeed, new FarmedIngredients(HornblowerPipeWeed, 1, level));
            dictIng.Add(Iris, new FarmedIngredients(Iris, 1, level));
            dictIng.Add(IrisRoot, new FarmedIngredients(IrisRoot, 1, level));
            dictIng.Add(Tater, new FarmedIngredients(Tater, 1, level));

            //************************************
            level = ProfessionTierEnum.Expert;
            dictIng.Add(BunchOfPrideOfChetwoodHops, new FarmedIngredients(BunchOfPrideOfChetwoodHops, 1, level));
            dictIng.Add(GreenOnion, new FarmedIngredients(GreenOnion, 1, level));
            dictIng.Add(HeadOfCauliflower, new FarmedIngredients(HeadOfCauliflower, 1, level));
            dictIng.Add(OnionSkin, new FarmedIngredients(OnionSkin, 1, level));

            //************************************
            level = ProfessionTierEnum.Artisan;
            dictIng.Add(AmaranthPetal, new FarmedIngredients(AmaranthPetal, 1, level));
            dictIng.Add(BluebottlePetal, new FarmedIngredients(BluebottlePetal, 1, level));
            dictIng.Add(BunchOfRasberries, new FarmedIngredients(BunchOfRasberries, 1, level));
            dictIng.Add(BunchOfStrawberries, new FarmedIngredients(BunchOfStrawberries, 1, level));
            dictIng.Add(BundleOfWinterBarley, new FarmedIngredients(BundleOfWinterBarley, 1, level));
            dictIng.Add(BunchOfGreenHillHops, new FarmedIngredients(BunchOfGreenHillHops, 1, level));
            dictIng.Add(BunchOfUmbelHops, new FarmedIngredients(BunchOfUmbelHops, 1, level));
            dictIng.Add(JuicyStrawberry, new FarmedIngredients(JuicyStrawberry, 1, level));
            dictIng.Add(Saffron, new FarmedIngredients(Saffron, 1, level));
            dictIng.Add(SaffronThread, new FarmedIngredients(SaffronThread, 1, level));
            dictIng.Add(ShireApple, new FarmedIngredients(ShireApple, 1, level));
            dictIng.Add(YoungTeaLeaves, new FarmedIngredients(YoungTeaLeaves, 1, level));

            //************************************
            level = ProfessionTierEnum.Master;
            dictIng.Add(BloodwortRoot, new FarmedIngredients(BloodwortRoot, 1, level));
            dictIng.Add(BlackberryHoney, new FarmedIngredients(BlackberryHoney, 1, level));
            dictIng.Add(BunchOfBlackberries, new FarmedIngredients(BunchOfBlackberries, 1, level));
            dictIng.Add(FineTeaLeaves, new FarmedIngredients(FineTeaLeaves, 1, level));
            dictIng.Add(GoldenShireTater, new FarmedIngredients(GoldenShireTater, 1, level));
            dictIng.Add(JuicyBlackberry, new FarmedIngredients(JuicyBlackberry, 1, level));
            dictIng.Add(JuicyElderberry, new FarmedIngredients(JuicyElderberry, 1, level));

            //************************************
            level = ProfessionTierEnum.Supreme;
            dictIng.Add(BundleOfMintLeaves, new FarmedIngredients(BundleOfMintLeaves, 1, level));
            dictIng.Add(BundleOfTeaLeaves, new FarmedIngredients(BundleOfTeaLeaves, 1, level));
            dictIng.Add(GreenPeas, new FarmedIngredients(GreenPeas, 1, level));
            dictIng.Add(PerfectTeaLeaves, new FarmedIngredients(PerfectTeaLeaves, 1, level));
            dictIng.Add(RoyalTaters, new FarmedIngredients(RoyalTaters, 1, level));
            dictIng.Add(TeaLeaves, new FarmedIngredients(TeaLeaves, 1, level));

            //************************************
            level = ProfessionTierEnum.Westfold;
            dictIng.Add(BlackBarley, new FarmedIngredients(BlackBarley, 1, level));
            dictIng.Add(BunchOfBillberries, new FarmedIngredients(BunchOfBillberries, 1, level));
            dictIng.Add(BunchOfLeeks, new FarmedIngredients(BunchOfLeeks, 1, level));
            dictIng.Add(BundleOfBlackBarley, new FarmedIngredients(BundleOfBlackBarley, 1, level));
            dictIng.Add(ClumpOfPeat, new FarmedIngredients(ClumpOfPeat, 1, level));
            dictIng.Add(PinchOfWestfoldHerbs, new FarmedIngredients(PinchOfWestfoldHerbs, 1, level));

            //************************************
            level = ProfessionTierEnum.Eastemnet;
            dictIng.Add(BagOfEastemnetCoffeeBeans, new FarmedIngredients(BagOfEastemnetCoffeeBeans, 1, level));
            dictIng.Add(BunchOfRyeBerries, new FarmedIngredients(BunchOfRyeBerries, 1, level));
            dictIng.Add(BunchOfCherries, new FarmedIngredients(BunchOfCherries, 1, level));
            dictIng.Add(BunchOfTurnips, new FarmedIngredients(BunchOfTurnips, 1, level));
            dictIng.Add(LargeBunchOfCherries, new FarmedIngredients(LargeBunchOfCherries, 1, level));
            dictIng.Add(LargeBagOfEastemnetCoffeeBeans, new FarmedIngredients(LargeBagOfEastemnetCoffeeBeans, 1, level));
            dictIng.Add(LargeBunchOfRyeBerries, new FarmedIngredients(LargeBunchOfRyeBerries, 1, level));
            dictIng.Add(LargeBunchOfTurnips, new FarmedIngredients(LargeBunchOfTurnips, 1, level));
            dictIng.Add(RiddermarkCoffeeBeans, new FarmedIngredients(RiddermarkCoffeeBeans, 1, level));

            //************************************
            level = ProfessionTierEnum.Westemnet;
            dictIng.Add(BagOfWestemnetCoffeeBeans, new FarmedIngredients(BagOfWestemnetCoffeeBeans, 1, level));
            dictIng.Add(BunchOfBeans, new FarmedIngredients(BunchOfBeans, 1, level));
            dictIng.Add(BunchOfPears, new FarmedIngredients(BunchOfPears, 1, level));
            dictIng.Add(BunchOfKingsteadMushrooms, new FarmedIngredients(BunchOfKingsteadMushrooms, 1, level));

        }
    }
}