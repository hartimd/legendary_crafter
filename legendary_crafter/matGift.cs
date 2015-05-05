using System.Collections.Generic;
using System.Linq;

namespace legendary_crafter
{
    /// <summary>
    /// Defines the parameter of the constructors for the Gifts of Materials.
    /// </summary>
    internal class matGift
    {
        /// <summary>
        /// Sets the name of the Gift of Material.
        /// </summary>
        public string name
        {
            get;
            set;
        }

        /// <summary>
        /// First ingredient of the Gift of Material.
        /// </summary>
        public string item
        {
            get;
            set;
        }

        /// <summary>
        /// Second ingredient of the Gift of Material.
        /// </summary>
        public string item1
        {
            get;
            set;
        }

        /// <summary>
        /// Third ingredient of the Gift of Material.
        /// </summary>
        public string item2
        {
            get;
            set;
        }

        /// <summary>
        /// Fourth ingredient of the Gift of Material.
        /// </summary>
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