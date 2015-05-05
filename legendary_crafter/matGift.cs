using System.Collections.Generic;
using System.Linq;

namespace legendary_crafter
{
    public class matGift
    {
        public string name
        {
            get;
            set;
        }

        public string item
        {
            get;
            set;
        }

        public string item1
        {
            get;
            set;
        }

        public string item2
        {
            get;
            set;
        }

        public string item3
        {
            get;
            set;
        }
    }

    internal static class MatStore
    {
        private static List<matGift> materials = new List<matGift>
        {
            new matGift{name = "Energy", item = "Pile of Crystalline Dust", item1 = "Pile of Incandescent Dust", item2 = "Pile of Luminous Dust", item3 = "Pile of Radiant Dust"},
            new matGift{name = "Metal", item = "Darksteel Ingot", item1 = "Mithril Ingot", item2 = "Orichalcum Ingot", item3 = "Platinum Ingot"},
            new matGift{name = "Wood", item = "Ancient Wood Plank", item1 = "Elder Wood Plank", item2 = "Hard Wood Plank", item3 = "Seasoned Wood Plank"}
        };

        /// <summary>
        /// Gets the Gift of Material from the data base.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static matGift GetByName(string id)
        {
            return materials.Single(a => a.name == id);
        }
    }
}