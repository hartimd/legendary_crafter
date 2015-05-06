using matGift;
using recipeGift;
using System.Collections.Generic;
using System.Linq;

namespace legendary
{
    /// <summary>
    /// Defines the parameter of the constructors for the legendaries.
    /// </summary>
    internal class legy
    {
        /// <summary>
        /// Sets an unique and whitespace-free identificator for each legendary.
        /// </summary>
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// Sets the name of the legendary.
        /// </summary>
        public string name
        {
            get;
            set;
        }

        /// <summary>
        /// Sets the Precursor weapon of the legendary.
        /// </summary>
        public string pre
        {
            get;
            set;
        }

        /// <summary>
        /// Sets an indentifier of the specific gift needed to craft the unique Gift of the Legendary.
        /// </summary>
        public string recipeGift
        {
            get;
            set;
        }

        /// <summary>
        /// Sets an indentifier of the specific Gift of Material needed to craft the unique Gift of the Legendary.
        /// </summary>
        public string matsGift
        {
            get;
            set;
        }

        /// <summary>
        /// Sets the Sigil, needed to craft the legendary.
        /// </summary>
        public string sigil
        {
            get;
            set;
        }
    }

    internal static class legyList
    {
        private static List<legy> legys = new List<legy>
        {
                new legy{id = "bifr", name = "The Bifröst", pre = "The Legend", recipeGift = recipeBook.GetByID("color").name, matsGift = MatStore.GetByName("Energy").name, sigil = "Nullification"},
                new legy{id = "bolt", name = "Bolt", pre = "Zap", recipeGift = recipeBook.GetByID("lightning").name, matsGift = MatStore.GetByName("Metal").name, sigil = "Air"},
                new legy{id = "flam", name = "The Flame Seeker Prophecies", pre = "The Chosen", recipeGift = recipeBook.GetByID("history").name, matsGift = MatStore.GetByName("Metal").name, sigil = "Battle"},
                new legy{id = "fren", name = "Frenzy", pre = "Rage", recipeGift = recipeBook.GetByID("water").name, matsGift = MatStore.GetByName("Wood").name, sigil = "Rage"},
                new legy{id = "fros", name = "Frostfang", pre = "Tooth of Frostfang", recipeGift = recipeBook.GetByID("ice").name, matsGift = MatStore.GetByName("Metal").name, sigil = "Ice"},
                new legy{id = "howl", name = "Howler", pre = "Howl", recipeGift = recipeBook.GetByID("wolfstatue").name, matsGift = MatStore.GetByName("Energy").name, sigil = "Accuracy"},
                new legy{id = "inci", name = "Incinerator", pre = "Spark", recipeGift = recipeBook.GetByID("liquidflame").name, matsGift = MatStore.GetByName("Metal").name, sigil = "Fire"},
                new legy{id = "jugg", name = "Juggernaught", pre = "The Colossus", recipeGift = recipeBook.GetByID("quicksilver").name, matsGift = MatStore.GetByName("Metal").name, sigil = "Sanctuary"},
                new legy{id = "kamo", name = "Kamohoali", pre = "Carcharias", recipeGift = recipeBook.GetByID("shark").name, matsGift = MatStore.GetByName("Metal").name, sigil = "Agony"},
                new legy{id = "krai", name = "Kraitkin", pre = "Venom", recipeGift = recipeBook.GetByID("eel").name, matsGift = MatStore.GetByName("Energy").name, sigil = "Venom"},
                new legy{id = "kudz", name = "Kudzu", pre = "Leaf of Kudzu", recipeGift = recipeBook.GetByID("nature").name, matsGift = MatStore.GetByName("Wood").name, sigil = "Conjuration"},
                new legy{id = "mete", name = "Meteorlogicus", pre = "Storm", recipeGift = recipeBook.GetByID("weather").name, matsGift = MatStore.GetByName("Energy").name, sigil = "Air"},
                new legy{id = "moot", name = "Moot", pre = "The Energizer", recipeGift = recipeBook.GetByID("entertainment").name, matsGift = MatStore.GetByName("Metal").name, sigil = "Energy"},
                new legy{id = "quip", name = "Quip", pre = "Chaos Gun", recipeGift = recipeBook.GetByID("entertainment").name, matsGift = MatStore.GetByName("Wood").name, sigil = "Stamina"},
                new legy{id = "rodg", name = "Rodgort", pre = "Rodgort's Flame", recipeGift = recipeBook.GetByID("liquidflame").name, matsGift = MatStore.GetByName("Wood").name, sigil = "Fire"},
                new legy{id = "sunr", name = "Sunrise", pre = "Dawn", recipeGift = recipeBook.GetByID("light").name, matsGift = MatStore.GetByName("Metal").name, sigil = "Strength"},
                new legy{id = "drea", name = "The Dreamer", pre = "The Lover", recipeGift = recipeBook.GetByID("unicorn").name, matsGift = MatStore.GetByName("Wood").name, sigil = "Purity"},
                new legy{id = "mins", name = "The Minstrel", pre = "The Bard", recipeGift = recipeBook.GetByID("music").name, matsGift = MatStore.GetByName("Energy").name, sigil = "Energy"},
                new legy{id = "pred", name = "The Predator", pre = "The Hunter", recipeGift = recipeBook.GetByID("stealth").name, matsGift = MatStore.GetByName("Wood").name, sigil = "Force"},
                new legy{id = "twil", name = "Twilight", pre = "Dusk", recipeGift = recipeBook.GetByID("darkness").name, matsGift = MatStore.GetByName("Metal").name, sigil = "Blood"}
        };

        /// <summary>
        /// Gets the legendary from the data base.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static legy GetLegy(string id)
        {
            return legys.Single(a => a.id == id);
        }

        public static legy GetLegyName(string name)
        {
            return legys.Single(a => a.name == name);
        }
    }
}