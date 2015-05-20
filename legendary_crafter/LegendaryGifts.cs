using System.Collections.Generic;
using System.Linq;

namespace legendary_crafter
{
    internal class recipeGift
    {
        public string id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string dungeonGift
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

        public int item_value
        {
            get;
            set;
        }

        public int item1_value
        {
            get;
            set;
        }

        public int item2_value
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
    }

    internal static class recipeBook
    {
        private static List<recipeGift> recipes = new List<recipeGift>
            {
                new recipeGift{item = ApiList.GetByAbbr("opor").name, itemApi = ApiList.GetByAbbr("opor").id, item1 = ApiList.GetByAbbr("cryd").name, item1Api = ApiList.GetByAbbr("cryd").id, item2 = ApiList.GetByAbbr("unid").name, item2Api = ApiList.GetByAbbr("unid").id, id = "color", name = "Gift of Color", dungeonGift = DungeonStore.GetByCode("Arah").Abbr, item_value = 100, item1_value = 250, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("cuhl").name, itemApi = ApiList.GetByAbbr("cuhl").id, item1 = ApiList.GetByAbbr("onld").name, item1Api = ApiList.GetByAbbr("onld").id, item2 = ApiList.GetByAbbr("orii").name, item2Api = ApiList.GetByAbbr("orii").id, id = "darkness", name = "Gift of Darkness", dungeonGift = DungeonStore.GetByCode("AC").Abbr, item_value = 250, item1_value = 100, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("arsc").name, itemApi = ApiList.GetByAbbr("arsc").id, item1 = ApiList.GetByAbbr("cuhl").name, item1Api = ApiList.GetByAbbr("cuhl").id, item2 = ApiList.GetByAbbr("orii").name, item2Api = ApiList.GetByAbbr("orii").id, id = "eel", name = "Eel Statue", dungeonGift = DungeonStore.GetByCode("SE").Abbr, item_value = 250, item1_value = 250, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("bgos").name, itemApi = ApiList.GetByAbbr("bgos").id, item1 = ApiList.GetByAbbr("boxf").name, item1Api = ApiList.GetByAbbr("boxf").id, item2 = ApiList.GetByAbbr("orii").name, item2Api = ApiList.GetByAbbr("orii").id, id = "entertainment", name = "Gift of Entertainment", dungeonGift = DungeonStore.GetByCode("CM").Abbr, item_value = 250, item1_value = 5, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("cuhl").name, itemApi = ApiList.GetByAbbr("cuhl").id, item1 = ApiList.GetByAbbr("onld").name, item1Api = ApiList.GetByAbbr("onld").id, item2 = ApiList.GetByAbbr("cryd").name, item2Api = ApiList.GetByAbbr("cryd").id, id = "history", name = "Gift of History", dungeonGift = DungeonStore.GetByCode("AC").Abbr, item_value = 250, item1_value = 100, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("cold").name, itemApi = ApiList.GetByAbbr("cold").id, item1 = ApiList.GetByAbbr("glld").name, item1Api = ApiList.GetByAbbr("glld").id, item2 = ApiList.GetByAbbr("orii").name, item2Api = ApiList.GetByAbbr("orii").id, id = "ice", name = "Gift of Ice", dungeonGift = DungeonStore.GetByCode("HOTW").Abbr, item_value = 100, item1_value = 100, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("chld").name, itemApi = ApiList.GetByAbbr("chld").id, item1 = ApiList.GetByAbbr("cuhl").name, item1Api = ApiList.GetByAbbr("cuhl").id, item2 = ApiList.GetByAbbr("orii").name, item2Api = ApiList.GetByAbbr("orii").id, id = "light", name = "Gift of Light", dungeonGift = DungeonStore.GetByCode("AC").Abbr, item_value = 100, item1_value = 250, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("bgos").name, itemApi = ApiList.GetByAbbr("bgos").id, item1 = ApiList.GetByAbbr("chld").name, item1Api = ApiList.GetByAbbr("chld").id, item2 = ApiList.GetByAbbr("orii").name, item2Api = ApiList.GetByAbbr("orii").id, id = "lightning", name = "Gift of Lightning", dungeonGift = DungeonStore.GetByCode("AC").Abbr, item_value = 250, item1_value = 100, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("deld").name, itemApi = ApiList.GetByAbbr("deld").id, item1 = ApiList.GetByAbbr("ghpe").name, item1Api = ApiList.GetByAbbr("ghpe").id, item2 = ApiList.GetByAbbr("mold").name, item2Api = ApiList.GetByAbbr("mold").id, id = "liquidflame", name = "Vial of Liquid Flame", dungeonGift = DungeonStore.GetByCode("FZ").Abbr, item_value = 100, item1_value = 250, item2_value = 100},
                new recipeGift{item = ApiList.GetByAbbr("bgos").name, itemApi = ApiList.GetByAbbr("bgos").id, item1 = ApiList.GetByAbbr("opor").name, item1Api = ApiList.GetByAbbr("opor").id, item2 = ApiList.GetByAbbr("orii").name, item2Api = ApiList.GetByAbbr("orii").id, id = "music", name = "Gift of Music", dungeonGift = DungeonStore.GetByCode("CM").Abbr, item_value = 250, item1_value = 100, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("anwp").name, itemApi = ApiList.GetByAbbr("anwp").id, item1 = ApiList.GetByAbbr("cuhl").name, item1Api = ApiList.GetByAbbr("cuhl").id, item2 = ApiList.GetByAbbr("ombe").name, item2Api = ApiList.GetByAbbr("ombe").id, id = "nature", name = "Gift of Nature", dungeonGift = DungeonStore.GetByCode("TA").Abbr, item_value = 250, item1_value = 250, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("mold").name, itemApi = ApiList.GetByAbbr("mold").id, item1 = ApiList.GetByAbbr("sidu").name, item1Api = ApiList.GetByAbbr("sidu").id, item2 = ApiList.GetByAbbr("stei").name, item2Api = ApiList.GetByAbbr("stei").id, id = "quicksilver", name = "Vial of Quicksilver", dungeonGift = DungeonStore.GetByCode("SE").Abbr, item_value = 150, item1_value = 250, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("arsc").name, itemApi = ApiList.GetByAbbr("arsc").id, item1 = ApiList.GetByAbbr("orii").name, item1Api = ApiList.GetByAbbr("orii").id, item2 = ApiList.GetByAbbr("vpbl").name, item2Api = ApiList.GetByAbbr("vpbl").id, id = "shark", name = "Shark Statue", dungeonGift = DungeonStore.GetByCode("Arah").Abbr, item_value = 250, item1_value = 250, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("onld").name, itemApi = ApiList.GetByAbbr("onld").id, item1 = ApiList.GetByAbbr("orii").name, item1Api = ApiList.GetByAbbr("orii").id, item2 = ApiList.GetByAbbr("ortr").name, item2Api = ApiList.GetByAbbr("ortr").id, id = "stealth", name = "Gift of Stealth", dungeonGift = DungeonStore.GetByCode("COE").Abbr, item_value = 100, item1_value = 250, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("chor").name, itemApi = ApiList.GetByAbbr("chor").id, item1 = ApiList.GetByAbbr("opor").name, item1Api = ApiList.GetByAbbr("opor").id, item2 = ApiList.GetByAbbr("orii").name, item2Api = ApiList.GetByAbbr("orii").id, id = "unicorn", name = "Unicorn Statue", dungeonGift = DungeonStore.GetByCode("TA").Abbr, item_value = 100, item1_value = 100, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("glld").name, itemApi = ApiList.GetByAbbr("glld").id, item1 = ApiList.GetByAbbr("mold").name, item1Api = ApiList.GetByAbbr("mold").id, item2 = ApiList.GetByAbbr("orii").name, item2Api = ApiList.GetByAbbr("orii").id, id = "water", name = "Gift of Water", dungeonGift = DungeonStore.GetByCode("HOTW").Abbr, item_value = 100, item1_value = 100, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("chld").name, itemApi = ApiList.GetByAbbr("chld").id, item1 = ApiList.GetByAbbr("cuhl").name, item1Api = ApiList.GetByAbbr("cuhl").id, item2 = ApiList.GetByAbbr("orii").name, item2Api = ApiList.GetByAbbr("orii").id, id = "weather", name = "Gift of Weather", dungeonGift = DungeonStore.GetByCode("COE").Abbr, item_value = 100, item1_value = 250, item2_value = 250},
                new recipeGift{item = ApiList.GetByAbbr("cuhl").name, itemApi = ApiList.GetByAbbr("cuhl").id, item1 = ApiList.GetByAbbr("orii").name, item1Api = ApiList.GetByAbbr("orii").id, item2 = ApiList.GetByAbbr("vifa").name, item2Api = ApiList.GetByAbbr("vifa").id, id = "wolfstatue", name = "Wolf Statue", dungeonGift = DungeonStore.GetByCode("TA").Abbr, item_value = 250, item1_value = 250, item2_value = 250}
            };

        /// <summary>
        /// Gets the specific gift to craft the Gift of the Legendary from the data base.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static recipeGift GetByID(string id)
        {
            return recipes.Single(a => a.id == id);
        }
    }
}