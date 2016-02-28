using System.Collections.Generic;

namespace LotroCalc.RecipeData.Professions
{
    public enum ProfessionTierEnum
    {
        Apprentice,
        Journeyman,
        Expert,
        Artisan,
        Master,
        Supreme,
        Westfold,
        Eastemnet,
        Westemnet
    }


    public class ProfessionTier
    {
        public ProfessionTierEnum TierEnum;

        public string TierName;
        public static string Apprentice = "Apprentice";
        public static string Journeyman = "Journeyman";
        public static string Expert = "Expert";
        public static string Artisan = "Artisan";
        public static string Master = "Master";
        public static string Supreme = "Supreme";
        public static string Westfold = "Westfold";
        public static string Eastemnet = "Eastemnet";
        public static string Westemnet = "Westemnet";

        public ProfessionTier(ProfessionTierEnum tier, string name)
        {
            TierEnum = tier;
            TierName = name;
        }


        public static Dictionary<ProfessionTierEnum, ProfessionTier> GetAllTiers()
        {
            var ret = new Dictionary<ProfessionTierEnum, ProfessionTier>();
            ret.Add(ProfessionTierEnum.Apprentice, new ProfessionTier(ProfessionTierEnum.Apprentice, Apprentice));
            ret.Add(ProfessionTierEnum.Journeyman, new ProfessionTier(ProfessionTierEnum.Journeyman, Journeyman));
            ret.Add(ProfessionTierEnum.Expert, new ProfessionTier(ProfessionTierEnum.Expert, Expert));
            ret.Add(ProfessionTierEnum.Artisan, new ProfessionTier(ProfessionTierEnum.Artisan, Artisan));
            ret.Add(ProfessionTierEnum.Master, new ProfessionTier(ProfessionTierEnum.Master, Master));
            ret.Add(ProfessionTierEnum.Supreme, new ProfessionTier(ProfessionTierEnum.Supreme, Supreme));
            ret.Add(ProfessionTierEnum.Westfold, new ProfessionTier(ProfessionTierEnum.Westfold, Westfold));
            ret.Add(ProfessionTierEnum.Eastemnet, new ProfessionTier(ProfessionTierEnum.Eastemnet, Eastemnet));
            ret.Add(ProfessionTierEnum.Westemnet, new ProfessionTier(ProfessionTierEnum.Westemnet, Westemnet));
            return ret;
        }


        public static string FormatTier(ProfessionTierEnum tier)
        {
            Dictionary<ProfessionTierEnum, ProfessionTier> tiers = GetAllTiers();
            return tiers[tier].TierName;
        }

        public static ProfessionTierEnum GetTier(string tier)
        {
            Dictionary<ProfessionTierEnum, ProfessionTier> tiers = GetAllTiers();

            foreach (ProfessionTier t in tiers.Values)
                if (tier == t.TierName)
                    return t.TierEnum;

            return ProfessionTierEnum.Supreme;
        }
    }
}