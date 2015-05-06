using DungeonGift;
using legendary;
using matGift;
using recipeGift;
using System;
using System.Windows.Forms;

namespace legendary_crafter
{
    /// <summary>
    /// The core of the application.
    /// </summary>
    partial class Form1 : Form
    {
        public string input;

        public string[] legys = { legyList.GetLegy("bifr").name, legyList.GetLegy("bolt").name, legyList.GetLegy("flam").name, legyList.GetLegy("fren").name, legyList.GetLegy("fros").name, legyList.GetLegy("howl").name, legyList.GetLegy("inci").name, legyList.GetLegy("jugg").name, legyList.GetLegy("kamo").name, legyList.GetLegy("krai").name, legyList.GetLegy("kudz").name, legyList.GetLegy("mete").name, legyList.GetLegy("moot").name, legyList.GetLegy("quip").name, legyList.GetLegy("rodg").name, legyList.GetLegy("sunr").name, legyList.GetLegy("drea").name, legyList.GetLegy("mins").name, legyList.GetLegy("pred").name, legyList.GetLegy("twil").name };

        /// <summary>
        /// decimals resulting of the calculation.
        /// </summary>
        public decimal perc_pre, perc_mastery, perc_fortune, perc_legy, perc_tot, perc_magic, perc_totem, perc_dust, perc_venom, perc_blood, perc_might, perc_bone, perc_scale, perc_claws, perc_fangs, perc_recipe, perc_dungeon, perc_ritem1, perc_ritem2, perc_ritem3, perc_mats, perc_mitem1, perc_mitem2, perc_mitem3, perc_mitem4, perc_sigil, perc_runestones, perc_ecto, perc_clover, perc_bloodstone, perc_battle, perc_explo, perc_obsi;

        public string Mats, Abbr;

        public Form1()
        {
            InitializeComponent();
            comboBox_legy.DataSource = legys;
            label_blood.Text = l_blood.ToString();
            label_bone.Text = l_bone.ToString();
            label_claws.Text = l_claws.ToString();
            label_clover.Text = l_clover.ToString();
            label_dust.Text = l_dust.ToString();
            label_ecto.Text = l_ecto.ToString();
            label_fangs.Text = l_fangs.ToString();
            label_honor.Text = l_honor.ToString();
            label_obsi.Text = l_obsi.ToString();
            label_runestone_value.Text = l_runestone.ToString();
            label_scale.Text = l_scale.ToString();
            label_skill.Text = l_skill.ToString();
            label_token_value.Text = l_token.ToString();
            label_totem.Text = l_totem.ToString();
            label_venom.Text = l_venom.ToString();
        }

        /// <summary>
        /// Calls the <see cref="DoCalc"/> function.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button_calc_Click(object sender, EventArgs e)
        {
            DoCalc();
        }

        /// <summary>
        /// Loads a .txt file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button_load_Click(object sender, EventArgs e)
        {
            DialogResult Result = openFileDialog1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                string[] contents = new string[23];
                TextBox[] boxes = { textBox_token, textBox_recipe_item, textBox_recipe_item1, textBox_recipe_item2, textBox_mats_item, textBox_mats_item1, textBox_mats_item2, textBox_mats_item3, textBox_runestones, textBox_skillpoint, textBox_honor, textBox_obsi, textBox_totem, textBox_dust, textBox_venom, textBox_blood, textBox_bone, textBox_scale, textBox_claws, textBox_fangs, textBox_ecto, textBox_clover };
                contents = System.IO.File.ReadAllLines(name);
                input = contents[0];
                for (int i = 1; i < 23; i++)
                {
                    boxes[i - 1].Text = contents[i];
                }
                comboBox_legy.SelectedItem = input;
            }
        }

        /// <summary>
        /// Saves a .txt file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult Result = saveFileDialog1.ShowDialog();
            if ((Result == DialogResult.OK) && (saveFileDialog1.FileName.Length > 0))
            {
                string[] contents = new string[23];
                TextBox[] boxes = { textBox_token, textBox_recipe_item, textBox_recipe_item1, textBox_recipe_item2, textBox_mats_item, textBox_mats_item1, textBox_mats_item2, textBox_mats_item3, textBox_runestones, textBox_skillpoint, textBox_honor, textBox_obsi, textBox_totem, textBox_dust, textBox_venom, textBox_blood, textBox_bone, textBox_scale, textBox_claws, textBox_fangs, textBox_ecto, textBox_clover };
                contents[0] = input;
                for (int i = 1; i < 23; i++)
                {
                    contents[i] = boxes[i - 1].Text;
                }
                string name = saveFileDialog1.FileName;
                System.IO.File.WriteAllLines(name, contents);
            }
        }

        public int l_blood = 250;
        public int l_bone = 250;
        public int l_claws = 250;
        public int l_clover = 77;
        public int l_dust = 250;
        public int l_ecto = 250;
        public int l_fangs = 250;
        public int l_honor = 500;
        public int l_obsi = 250;
        public int l_runestone = 100;
        public int l_scale = 250;
        public int l_skill = 200;
        public int l_token = 500;
        public int l_totem = 250;
        public int l_venom = 250;

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBox_legy control.
        /// </summary>
        /// <remarks>
        /// Returns the values of the chosen legendary to the form.
        /// </remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void comboBox_legy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] abbr = { "AC", "Arah", "CM", "COE", "FZ", "HOTW", "SE", "TA" };
            string[] mats = { "Energy", "Metal", "Wood" };
            string[] recipeIDs = { "eel", "color", "darkness", "entertainment", "history", "ice", "light", "lightning", "music", "nature", "stealth", "water", "weather", "shark", "unicorn", "liquidflame", "quicksilver", "wolfstatue" };

            button_calc.Enabled = true;
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && c.Enabled == false)
                {
                    c.Enabled = true;
                }
            }
            ComboBox senderCombo = (ComboBox)sender;
            input = senderCombo.SelectedItem.ToString();
            switch (input)
            {
                case "The Bifröst":
                    labelCheckBox("bifr", "Arah");
                    break;

                case "Bolt":
                    labelCheckBox("bolt", "AC");
                    break;

                case "The Flame Seeker Prophecies":
                    labelCheckBox("flam", "AC");
                    break;

                case "Frenzy":
                    labelCheckBox("fren", "HOTW");
                    break;

                case "Frostfang":
                    labelCheckBox("fros", "HOTW");
                    break;

                case "Howler":
                    labelCheckBox("howl", "TA");
                    break;

                case "Incinerator":
                    labelCheckBox("inci", "FZ");
                    break;

                case "Juggernaught":
                    labelCheckBox("jugg", "SE");
                    break;

                case "Kamohoali":
                    labelCheckBox("kamo", "Arah");
                    break;

                case "Kraitkin":
                    labelCheckBox("krai", "SE");
                    break;

                case "Kudzu":
                    labelCheckBox("kudz", "TA");
                    break;

                case "Meteorlogicus":
                    labelCheckBox("mete", "COE");
                    break;

                case "Moot":
                    labelCheckBox("moot", "CM");
                    break;

                case "Quip":
                    labelCheckBox("quip", "CM");
                    break;

                case "Rodgort":
                    labelCheckBox("rodg", "FZ");
                    break;

                case "Sunrise":
                    labelCheckBox("sunr", "AC");
                    break;

                case "The Dreamer":
                    labelCheckBox("drea", "TA");
                    break;

                case "The Minstrel":
                    labelCheckBox("mins", "CM");
                    break;

                case "The Predator":
                    labelCheckBox("pred", "COE");
                    break;

                case "Twilight":
                    labelCheckBox("twil", "AC");
                    break;
            }
            foreach (string item in recipeIDs)
            {
                if (recipeBook.GetByID(item).name == legyList.GetLegyName(input).recipeGift)
                {
                    labelRecipe(item);
                }
            }
            foreach (string item in abbr)
            {
                if (Abbr == item)
                {
                    setDungeon(item);
                }
            }

            foreach (string item in mats)
            {
                if (Mats == item)
                {
                    labelMats(item);
                }
            }
        }

        /// <summary>
        /// Input and output integers of the application.
        /// </summary>
        public int mats_item_value = 250;

        private void DoCalc()
        {
            int i_blood;
            int i_bone;
            int i_claws, i_clover, i_dust, i_ecto, i_fangs, i_honor, i_obsi, i_runestone, i_scale, i_skill, i_token, i_totem, i_venom;
            int i_ritem, i_ritem1, i_ritem2, i_mitem, i_mitem1, i_mitem2, i_mitem3;
            Int32.TryParse(textBox_blood.Text, out i_blood);
            Int32.TryParse(textBox_bone.Text, out i_bone);
            Int32.TryParse(textBox_claws.Text, out i_claws);
            Int32.TryParse(textBox_clover.Text, out i_clover);
            Int32.TryParse(textBox_dust.Text, out i_dust);
            Int32.TryParse(textBox_ecto.Text, out i_ecto);
            Int32.TryParse(textBox_fangs.Text, out i_fangs);
            Int32.TryParse(textBox_honor.Text, out i_honor);
            Int32.TryParse(textBox_obsi.Text, out i_obsi);
            Int32.TryParse(textBox_runestones.Text, out i_runestone);
            Int32.TryParse(textBox_scale.Text, out i_scale);
            Int32.TryParse(textBox_skillpoint.Text, out i_skill);
            Int32.TryParse(textBox_token.Text, out i_token);
            Int32.TryParse(textBox_totem.Text, out i_totem);
            Int32.TryParse(textBox_venom.Text, out i_venom);

            Int32.TryParse(textBox_recipe_item.Text, out i_ritem);
            Int32.TryParse(textBox_recipe_item1.Text, out i_ritem1);
            Int32.TryParse(textBox_recipe_item2.Text, out i_ritem2);
            Int32.TryParse(textBox_mats_item.Text, out i_mitem);
            Int32.TryParse(textBox_mats_item1.Text, out i_mitem1);
            Int32.TryParse(textBox_mats_item2.Text, out i_mitem2);
            Int32.TryParse(textBox_mats_item3.Text, out i_mitem3);

            setMax(i_mitem, mats_item_value);
            setMax(i_mitem1, mats_item_value);
            setMax(i_mitem2, mats_item_value);
            setMax(i_mitem3, mats_item_value);
            setMax(i_ritem, l_ritem);
            setMax(i_ritem1, l_ritem1);
            setMax(i_ritem2, l_ritem2);
            if (checkBox_pre.Checked == true)
            {
                perc_pre = 100;
            }
            if (checkBox_mastery.Checked == true)
            {
                perc_mastery = 100.0m;
            }
            else
            {
                if (checkBox_bloodstone.Checked == true)
                {
                    perc_bloodstone = 100.0m;
                }
                else
                {
                    toPercent(perc_bloodstone, i_skill, l_skill);
                }
                if (checkBox_battle.Checked == true)
                {
                    perc_battle = 100.0m;
                }
                else
                {
                    toPercent(perc_battle, i_honor, l_honor);
                }
                if (checkBox_explo.Checked == true)
                {
                    perc_explo = 100.0m;
                }
                else
                {
                    perc_explo = 0.0m;
                }
                toPercent(perc_obsi, i_obsi, mats_item_value);
                sumDivide(perc_mastery, perc_bloodstone, perc_battle, perc_explo, perc_obsi);
            }
            if (checkBox_fortune.Checked == true)
            {
                perc_fortune = 100.0m;
            }
            else
            {
                if (checkBox_magic.Checked == true)
                {
                    perc_magic = 100.0m;
                }
                else
                {
                    toPercent(perc_totem, i_totem, mats_item_value);
                    toPercent(perc_dust, i_dust, mats_item_value);
                    toPercent(perc_venom, i_venom, mats_item_value);
                    toPercent(perc_blood, i_blood, mats_item_value);
                    sumDivide(perc_magic, perc_totem, perc_dust, perc_venom, perc_blood);
                }
                if (checkBox_might.Checked == true)
                {
                    perc_might = 100.0m;
                }
                else
                {
                    toPercent(perc_bone, i_bone, mats_item_value);
                    toPercent(perc_scale, i_scale, mats_item_value);
                    toPercent(perc_claws, i_claws, mats_item_value);
                    toPercent(perc_fangs, i_fangs, mats_item_value);
                    sumDivide(perc_might, perc_bone, perc_scale, perc_claws, perc_fangs);
                }
                toPercent(perc_ecto, i_ecto, mats_item_value);
                toPercent(perc_clover, i_clover, l_clover);
                sumDivide(perc_fortune, perc_magic, perc_might, perc_ecto, perc_clover);
            }
            if (checkBox_gift.Checked == true)
            {
                perc_legy = 100.0m;
            }
            else
            {
                if (checkBox_recipe_gift.Checked == true)
                {
                    perc_recipe = 100.0m;
                }
                else
                {
                    if (checkBox_dungeon_gift.Checked == true)
                    {
                        perc_dungeon = 100.0m;
                    }
                    else
                    {
                        toPercent(perc_dungeon, i_token, l_token);
                    }
                    toPercent(perc_ritem1, i_ritem, l_ritem);
                    toPercent(perc_ritem2, i_ritem1, l_ritem1);
                    toPercent(perc_ritem3, i_ritem2, l_ritem2);
                    sumDivide(perc_recipe, perc_dungeon, perc_ritem1, perc_ritem2, perc_ritem3);
                }
                if (checkBox_mats_gift.Checked == true)
                {
                    perc_mats = 100.0m;
                }
                else
                {
                    toPercent(perc_mitem1, i_mitem, mats_item_value);
                    toPercent(perc_mitem2, i_mitem1, mats_item_value);
                    toPercent(perc_mitem3, i_mitem2, mats_item_value);
                    toPercent(perc_mitem4, i_mitem3, mats_item_value);
                    sumDivide(perc_mats, perc_mitem1, perc_mitem2, perc_mitem3, perc_mitem4);
                }
                if (checkBox_sigil.Checked == true)
                {
                    perc_sigil = 100.0m;
                }
                else
                {
                    perc_sigil = 0.0m;
                }
                toPercent(perc_runestones, i_runestone, l_runestone);
                sumDivide(perc_legy, perc_recipe, perc_mats, perc_sigil, perc_runestones);
            }
            sumDivide(perc_tot, perc_pre, perc_mastery, perc_fortune, perc_legy);
            label_perc.Text = perc_tot.ToString() + " %";
        }

        /// <summary>
        /// Sets the labels specific of the legendary.
        /// </summary>
        /// <param name="id">Gets the identifiator of the legendary.</param>
        /// <param name="dungeon">Gets the identificator of the dungeon specific to the legendary.</param>
        private void labelCheckBox(string id, string dungeon)
        {
            checkBox_pre.Text = legyList.GetLegy(id).pre;
            checkBox_gift.Text = "Gift of" + legyList.GetLegy(id).name;
            checkBox_recipe_gift.Text = legyList.GetLegy(id).recipeGift;
            Abbr = DungeonStore.GetByCode(dungeon).Abbr;
            Mats = legyList.GetLegy(id).matsGift;
            checkBox_sigil.Text = "Superior Sigil of " + legyList.GetLegy(id).sigil;
        }

        /// <summary>
        /// Sets the <c>Label.Text</c> to the value taken from the data base.
        /// </summary>
        /// <param name="name">Value of the specific label.</param>
        private void labelMats(string name)
        {
            checkBox_mats_gift.Text = "Gift of " + MatStore.GetByName(name).name;
            label_mats_item.Text = MatStore.GetByName(name).item;
            label_mats_item_value.Text = mats_item_value.ToString();
            label_mats_item1.Text = MatStore.GetByName(name).item1;
            label_mats_item1_value.Text = mats_item_value.ToString();
            label_mats_item2.Text = MatStore.GetByName(name).item2;
            label_mats_item2_value.Text = mats_item_value.ToString();
            label_mats_item3.Text = MatStore.GetByName(name).item3;
            label_mats_item3_value.Text = mats_item_value.ToString();
        }

        public int l_ritem;
        public int l_ritem1;
        public int l_ritem2;

        /// <summary>
        /// Sets the <c>Label.Text</c> to the value taken from the data base.
        /// </summary>
        /// <param name="id">Identifier of the specific label.</param>
        private void labelRecipe(string id)
        {
            l_ritem = recipeBook.GetByID(id).item_value;
            l_ritem1 = recipeBook.GetByID(id).item1_value;
            l_ritem2 = recipeBook.GetByID(id).item2_value;
            label_recipe_item.Text = recipeBook.GetByID(id).item;
            label_recipe_item_value.Text = l_ritem.ToString();
            label_recipe_item1.Text = recipeBook.GetByID(id).item1;
            label_recipe_item1_value.Text = l_ritem1.ToString();
            label_recipe_item2.Text = recipeBook.GetByID(id).item2;
            label_recipe_item2_value.Text = l_ritem2.ToString();
        }

        /// <summary>
        /// Sets the labels specific to the dungeon, based on the <c>abbr parameter</c>.
        /// </summary>
        /// <param name="Abbr">Identifier of the dungeon.</param>
        private void setDungeon(string Abbr)
        {
            checkBox_dungeon_gift.Text = DungeonStore.GetByCode(Abbr).name;
            label_dungeonname.Text = DungeonStore.GetByCode(Abbr).dungeon;
            label_token.Text = DungeonStore.GetByCode(Abbr).token;
        }

        /// <summary>
        /// Checks if the given input is larger then the needed amount and if so, sets the input equal to the needed amount. Also checks if input is less than 0 and if so set it equal to 0.
        /// </summary>
        /// <param name="i">Input.</param>
        /// <param name="x">Needed amount.</param>
        private int setMax(int i, int x)
        {
            if (i < 0)
            {
                return i = 0;
            }
            else if (i >= x)
            {
                return i = x;
            }
            else
            {
                return i;
            }
        }

        /// <summary>
        /// Sums the percentage of the four parts of the specific gift up and divides by four, to achieve percent.
        /// </summary>
        /// <param name="perc">Result.</param>
        /// <param name="sum1">First part of the sum.</param>
        /// <param name="sum2">Second part of the sum.</param>
        /// <param name="sum3">Third part of the sum.</param>
        /// <param name="sum4">Fourth part of the sum.</param>
        /// <returns></returns>
        private decimal sumDivide(decimal perc, decimal sum1, decimal sum2, decimal sum3, decimal sum4)
        {
            return perc = (sum1 + sum2 + sum3 + sum4) / 4;
        }

        /// <summary>
        /// Calculates the percentage of the specific item and checks if needed amount is equal to NULL.
        /// </summary>
        /// <param name="p">Result of the calculation.</param>
        /// <param name="i">Input, given by TextBoxes.</param>
        /// <param name="x">Needed amount of items.</param>
        private decimal toPercent(decimal p, int i, int x)
        {
            setMax(i, x);
            p = (i / x) * 100.0m;
            return p;
        }
    }
}