using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legendary_crafter
{
    internal class getApi
    {
        public string abbr
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }
    }

    internal static class ApiList
    {
        private static List<getApi> apis = new List<getApi>
            {
                new getApi{abbr = "anbo", id = 24358, name = "Ancient Bone"},
                new getApi{abbr = "anwp", id = 19712, name = "Ancient Wood Plank"},
                new getApi{abbr = "arsc", id = 24289, name = "Armored Scale"},
                new getApi{abbr = "bgos", id = 24283, name = "Bolt of Gossamer"},//
                new getApi{abbr = "boxf", id = 24283, name = "Evon Gnashblade's Box o' Fun"},//
                new getApi{abbr = "chld", id = 24283, name = "Charged Lodestone"},//
                new getApi{abbr = "chor", id = 24283, name = "Chrysocola Orb"},//
                new getApi{abbr = "cold", id = 24283, name = "Corrupted Lodestone"},//
                new getApi{abbr = "cryd", id = 24277, name = "Pile of Crystalline Dust"},
                new getApi{abbr = "cuhl", id = 24283, name = "Cured Hardened Leather Square"},//
                new getApi{abbr = "deld", id = 24283, name = "Destroyer Lodestone"},//
                new getApi{abbr = "dsti", id = 19681, name = "Dark Steel Ingot"},
                new getApi{abbr = "ecto", id = 19721, name = "Glob of Ectoplasm"},
                new getApi{abbr = "elto", id = 24300, name = "Elaborate Totem"},
                new getApi{abbr = "elwp", id = 19709, name = "Elder Wood Plank"},
                new getApi{abbr = "ghpe", id = 24283, name = "Ghost Pepper"},//
                new getApi{abbr = "glld", id = 24283, name = "Glacial Lodestone"},//
                new getApi{abbr = "hawp", id = 19711, name = "Hard Wood Plank"},
                new getApi{abbr = "incd", id = 24276, name = "Pile of Incandescent Dust"},
                new getApi{abbr = "lumd", id = 24275, name = "Pile of Luminous Dust"},
                new getApi{abbr = "miti", id = 19684, name = "Mithril Ingot"},
                new getApi{abbr = "mold", id = 24283, name = "Molten Lodestone"},//
                new getApi{abbr = "ombe", id = 24283, name = "Omnomberry"},//
                new getApi{abbr = "onld", id = 24283, name = "Onyx Lodestone"},//
                new getApi{abbr = "opor", id = 24283, name = "Opal Orb"},//
                new getApi{abbr = "orii", id = 19685, name = "Orichalcum Ingot"},
                new getApi{abbr = "ortr", id = 24283, name = "Orrian Truffle"},//
                new getApi{abbr = "plai", id = 19686, name = "Platinum Ingot"},
                new getApi{abbr = "pove", id = 24283, name = "Powerful Venom Sac"},
                new getApi{abbr = "radd", id = 24274, name = "Pile of Radiant Dust"},
                new getApi{abbr = "sewp", id = 19714, name = "Seasoned Wood Plank"},
                new getApi{abbr = "sidu", id = 24283, name = "Silver Doubloon"},//
                new getApi{abbr = "stei", id = 24283, name = "Steel Ingot"},//
                new getApi{abbr = "unid", id = 24283, name = "Unidentified Dye"},//
                new getApi{abbr = "vicl", id = 24351, name = "Vicious Claw"},
                new getApi{abbr = "vifa", id = 24357, name = "Vicious Fang"},
                new getApi{abbr = "vpbl", id = 24295, name = "Vial of Powerful Blood"},
            };

        /// <summary>
        /// Gets the specific gift to craft the Gift of the Legendary from the data base.
        /// </summary>
        /// <param name="Abbr">The identifier.</param>
        /// <returns></returns>
        public static getApi GetByAbbr(string Abbr)
        {
            return apis.Single(a => a.abbr == Abbr);
        }
    }
}