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

        public int itemApi
        {
            get;
            set;
        }

        public int item1Api
        {
            get;
            set;
        }

        public int item2Api
        {
            get;
            set;
        }

        public int item3Api
        {
            get;
            set;
        }
    }

    internal static class MatStore
    {
        private static List<matGift> materials = new List<matGift>
        {
            new matGift{name = "Energy", item = ApiList.GetByAbbr("cryd").name, itemApi = ApiList.GetByAbbr("cryd").id , item1 = ApiList.GetByAbbr("incd").name,  item1Api = ApiList.GetByAbbr("incd").id , item2 = ApiList.GetByAbbr("lumd").name,  item2Api = ApiList.GetByAbbr("lumd").id, item3 = ApiList.GetByAbbr("radd").name, item3Api = ApiList.GetByAbbr("radd").id},
            new matGift{name = "Metal", item = ApiList.GetByAbbr("dsti").name,  itemApi = ApiList.GetByAbbr("dsti").id, item1 = ApiList.GetByAbbr("miti").name,  item1Api = ApiList.GetByAbbr("miti").id, item2 = ApiList.GetByAbbr("orii").name,  item2Api = ApiList.GetByAbbr("orii").id, item3 = ApiList.GetByAbbr("plai").name, item3Api = ApiList.GetByAbbr("plai").id},
            new matGift{name = "Wood", item = ApiList.GetByAbbr("anwp").name,  itemApi = ApiList.GetByAbbr("anwp").id, item1 = ApiList.GetByAbbr("elwp").name,  item1Api = ApiList.GetByAbbr("elwp").id, item2 = ApiList.GetByAbbr("hawp").name,  item2Api = ApiList.GetByAbbr("hawp").id, item3 = ApiList.GetByAbbr("sewp").name, item3Api = ApiList.GetByAbbr("sewp").id}
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