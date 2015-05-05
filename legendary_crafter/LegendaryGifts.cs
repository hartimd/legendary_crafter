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
    }

    internal static class recipeBook
    {
        private static List<recipeGift> recipes = new List<recipeGift>
            {
                new recipeGift{id = "color", name = "Gift of Color", dungeonGift = DungeonStore.GetByCode("Arah").ToString(), item = "Opal Orb", item_value = 100, item1 =  "Pile of Crystalline Dust", item1_value = 250, item2 = "Unidentified Dye", item2_value = 250},
                new recipeGift{id = "darkness", name = "Gift of Darkness", dungeonGift = DungeonStore.GetByCode("AC").ToString(), item = "Cured Hardened Leather Square", item_value = 250, item1 = "Onyx Lodestone", item1_value = 100, item2 = "Orichalcum Ingot", item2_value = 250},
                new recipeGift{id = "eel", name = "Eel Statue", dungeonGift = DungeonStore.GetByCode("SE").ToString(), item = "Armored Scale", item_value = 250, item1 = "Cured Hardened Leather Square", item1_value = 250, item2 = "Orichalcum Ingot", item2_value = 250},
                new recipeGift{id = "entertainment", name = "Gift of Entertainment", dungeonGift = DungeonStore.GetByCode("CM").ToString(), item = "Bolt of Gossamer", item_value = 250, item1 = "Evon Gnashblade's Box o' Fun", item1_value = 5, item2 = "Orichalcum Ingot", item2_value = 250},
                new recipeGift{id = "history", name = "Gift of History", dungeonGift = DungeonStore.GetByCode("AC").ToString(), item = "Cured Hardened Leather Square", item_value = 250, item1 = "Onyx Lodestone", item1_value = 100, item2 = "Pile of Crystalline Dust", item2_value = 250},
                new recipeGift{id = "ice", name = "Gift of Ice", dungeonGift = DungeonStore.GetByCode("HOTW").ToString(), item = "Corrupted Lodestone", item_value = 100, item1 = "Glacial Lodestone", item1_value = 100, item2 = "Orichalcum Ingot", item2_value = 250},
                new recipeGift{id = "light", name = "Gift of Light", dungeonGift = DungeonStore.GetByCode("AC").ToString(), item = "Charged Lodestone", item_value = 100, item1 = "Cured Hardened Leather Square", item1_value = 250, item2 = "Orichalcum Ingot", item2_value = 250},
                new recipeGift{id = "lightning", name = "Gift of Lightning", dungeonGift = DungeonStore.GetByCode("AC").ToString(), item = "Bolt of Gossamer", item_value = 250, item1 = "Charged Lodestone", item1_value = 100, item2 = "Orichalcum Ingot", item2_value = 250},
                new recipeGift{id = "liquidflame", name = "Vial of Liquid Flame", dungeonGift = DungeonStore.GetByCode("FZ").ToString(), item = "Destroyer Lodestone", item_value = 100, item1 = "Ghost Pepper", item1_value = 250, item2 = "Molten Lodestone", item2_value = 100},
                new recipeGift{id = "music", name = "Gift of Music", dungeonGift = DungeonStore.GetByCode("CM").ToString(), item = "Bolt of Gossamer", item_value = 250, item1 = "Opal Orb", item1_value = 100, item2 = "Orichalcum Ingot", item2_value = 250},
                new recipeGift{id = "nature", name = "Gift of Nature", dungeonGift = DungeonStore.GetByCode("TA").ToString(), item = "Ancient Wood Plank", item_value = 250, item1 = "Cured Hardened Leather Square", item1_value = 250, item2 = "Omnomberry", item2_value = 250},
                new recipeGift{id = "quicksilver", name = "Vial of Quicksilver", dungeonGift = DungeonStore.GetByCode("SE").ToString(), item = "Molten Lodestone", item_value = 150, item1 = "Silver Doubloon", item1_value = 250, item2 = "Steel Ingot", item2_value = 250},
                new recipeGift{id = "shark", name = "Shark Statue", dungeonGift = DungeonStore.GetByCode("Arah").ToString(), item = "Armored Scale", item_value = 250, item1 = "Orichalcum Ingot", item1_value = 250, item2 = "Vial of Powerful Blood", item2_value = 250},
                new recipeGift{id = "stealth", name = "Gift of Stealth", dungeonGift = DungeonStore.GetByCode("COE").ToString(), item = "Onyx Lodestone", item_value = 100, item1 = "Orichalcum Ingot", item1_value = 250, item2 = "Orrian Truffle", item2_value = 250},
                new recipeGift{id = "unicorn", name = "Unicorn Statue", dungeonGift = DungeonStore.GetByCode("TA").ToString(), item = "Chrysocola Orb", item_value = 100, item1 = "Opal Orb", item1_value = 100, item2 = "Orichalcum Ingot", item2_value = 250},
                new recipeGift{id = "water", name = "Gift of Water", dungeonGift = DungeonStore.GetByCode("HOTW").ToString(), item = "Glacial Lodestone", item_value = 100, item1 = "Molten Lodestone", item1_value = 100, item2 = "Orichalcum Ingot", item2_value = 250},
                new recipeGift{id = "weather", name = "Gift of Weather", dungeonGift = DungeonStore.GetByCode("COE").ToString(), item = "Charged Lodestone", item_value = 100, item1 = "Hardened Leather Section", item1_value = 250, item2 = "Orichalcum Ingot", item2_value = 250},
                new recipeGift{id = "wolfstatue", name = "Wolf Statue", dungeonGift = DungeonStore.GetByCode("TA").ToString(), item = "Cured Hardened Leather Square", item_value = 250, item1 = "Orichalcum Ingot", item1_value = 250, item2 = "Vicious Fang", item2_value = 250}
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