using System.Collections.Generic;
using System.Linq;

namespace legendary_crafter
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

        public int sigilapi
        {
            get;
            set;
        }

        public int api
        {
            get;
            set;
        }

        public int preapi
        {
            get;
            set;
        }
    }

    internal static class legyList
    {
        private static List<legy> legys = new List<legy>
        {
                new legy{id = "bifr", api = 30698 , preapi = 29180 , name = "The Bifrost", pre = "The Legend", recipeGift = recipeBook.GetByID("color").id, matsGift = MatStore.GetByName("Energy").name, sigil = "Nullification", sigilapi = 24572},
                new legy{id = "bolt", api = 30699 , preapi = 29181 , name = "Bolt", pre = "Zap", recipeGift = recipeBook.GetByID("lightning").id, matsGift = MatStore.GetByName("Metal").name, sigil = "Air", sigilapi = 24554},
                new legy{id = "flam", api = 30696 , preapi = 29177 , name = "The Flame Seeker Prophecies", pre = "The Chosen", recipeGift = recipeBook.GetByID("history").id, matsGift = MatStore.GetByName("Metal").name, sigil = "Battle", sigilapi = 24601},
                new legy{id = "fren", api = 30697 , preapi = 29179 , name = "Frenzy", pre = "Rage", recipeGift = recipeBook.GetByID("water").id, matsGift = MatStore.GetByName("Wood").name, sigil = "Rage", sigilapi = 24561},
                new legy{id = "fros", api = 30684 , preapi = 29166 , name = "Frostfang", pre = "Tooth of Frostfang", recipeGift = recipeBook.GetByID("ice").id, matsGift = MatStore.GetByName("Metal").name, sigil = "Ice", sigilapi = 24555},
                new legy{id = "howl", api = 30702 , preapi = 29184 , name = "Howler", pre = "Howl", recipeGift = recipeBook.GetByID("wolfstatue").id, matsGift = MatStore.GetByName("Energy").name, sigil = "Accuracy", sigilapi = 24618},
                new legy{id = "inci", api = 30687 , preapi = 29167 , name = "Incinerator", pre = "Spark", recipeGift = recipeBook.GetByID("liquidflame").id, matsGift = MatStore.GetByName("Metal").name, sigil = "Fire", sigilapi = 24548},
                new legy{id = "jugg", api = 30690 , preapi = 29170 , name = "The Juggernaught", pre = "The Colossus", recipeGift = recipeBook.GetByID("quicksilver").id, matsGift = MatStore.GetByName("Metal").name, sigil = "Benevolence", sigilapi = 24584},
                new legy{id = "kamo", api = 30691 , preapi = 29171 , name = "Kamohoali i Kotaki", pre = "Carcharias", recipeGift = recipeBook.GetByID("shark").id, matsGift = MatStore.GetByName("Metal").name, sigil = "Agony", sigilapi = 24612},
                new legy{id = "krai", api = 30701 , preapi = 29183 , name = "Kraitkin", pre = "Venom", recipeGift = recipeBook.GetByID("eel").id, matsGift = MatStore.GetByName("Energy").name, sigil = "Venom", sigilapi = 24632},
                new legy{id = "kudz", api = 30685 , preapi = 29172 , name = "Kudzu", pre = "Leaf of Kudzu", recipeGift = recipeBook.GetByID("nature").id, matsGift = MatStore.GetByName("Wood").name, sigil = "Celerity", sigilapi = 24685},
                new legy{id = "mete", api = 30695 , preapi = 29176 , name = "Meteorlogicus", pre = "Storm", recipeGift = recipeBook.GetByID("weather").id, matsGift = MatStore.GetByName("Energy").name, sigil = "Air", sigilapi = 24554},
                new legy{id = "moot", api = 30692 , preapi = 29173 , name = "The Moot", pre = "The Energizer", recipeGift = recipeBook.GetByID("entertainment").id, matsGift = MatStore.GetByName("Metal").name, sigil = "Energy", sigilapi = 24607},
                new legy{id = "quip", api = 30693 , preapi = 29174 , name = "Quip", pre = "Chaos Gun", recipeGift = recipeBook.GetByID("entertainment").id, matsGift = MatStore.GetByName("Wood").name, sigil = "Stamina", sigilapi = 24592},
                new legy{id = "rodg", api = 30700 , preapi = 29182 , name = "Rodgort", pre = "Rodgort's Flame", recipeGift = recipeBook.GetByID("liquidflame").id, matsGift = MatStore.GetByName("Wood").name, sigil = "Fire", sigilapi = 24548},
                new legy{id = "sunr", api = 30703 , preapi = 29169 , name = "Sunrise", pre = "Dawn", recipeGift = recipeBook.GetByID("light").id, matsGift = MatStore.GetByName("Metal").name, sigil = "Strength", sigilapi = 24562},
                new legy{id = "drea", api = 30686 , preapi = 29178 , name = "The Dreamer", pre = "The Lover", recipeGift = recipeBook.GetByID("unicorn").id, matsGift = MatStore.GetByName("Wood").name, sigil = "Purity", sigilapi = 24571},
                new legy{id = "mins", api = 30688 , preapi = 29168 , name = "The Minstrel", pre = "The Bard", recipeGift = recipeBook.GetByID("music").id, matsGift = MatStore.GetByName("Energy").name, sigil = "Energy", sigilapi = 24607},
                new legy{id = "pred", api = 30394 , preapi = 29175 , name = "The Predator", pre = "The Hunter", recipeGift = recipeBook.GetByID("stealth").id, matsGift = MatStore.GetByName("Wood").name, sigil = "Force", sigilapi = 24615},
                new legy{id = "twil", api = 30704 , preapi = 29185 , name = "Twilight", pre = "Dusk", recipeGift = recipeBook.GetByID("darkness").id, matsGift = MatStore.GetByName("Metal").name, sigil = "Blood", sigilapi = 24570}
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
    }
}