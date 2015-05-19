using DungeonGift;
using legendary;
using matGift;
using recipeGift;
using System;
using System.Collections.Generic;
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
        /// doubles resulting of the calculation.
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            comboBox_legy.DataSource = legys;
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

        private int l_blood = 250;
        private int l_bone = 250;
        private int l_claws = 250;
        private int l_clover = 77;
        private int l_dust = 250;
        private int l_ecto = 250;
        private int l_fangs = 250;
        private int l_honor = 500;
        private int l_obsi = 250;
        private int l_runestone = 100;
        private int l_scale = 250;
        private int l_skill = 200;
        private int l_token = 500;
        private int l_totem = 250;
        private int l_venom = 250;

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
                    labelCheckBox("bifr");
                    break;

                case "Bolt":
                    labelCheckBox("bolt");
                    break;

                case "The Flame Seeker Prophecies":
                    labelCheckBox("flam");
                    break;

                case "Frenzy":
                    labelCheckBox("fren");
                    break;

                case "Frostfang":
                    labelCheckBox("fros");
                    break;

                case "Howler":
                    labelCheckBox("howl");
                    break;

                case "Incinerator":
                    labelCheckBox("inci");
                    break;

                case "Juggernaught":
                    labelCheckBox("jugg");
                    break;

                case "Kamohoali":
                    labelCheckBox("kamo");
                    break;

                case "Kraitkin":
                    labelCheckBox("krai");
                    break;

                case "Kudzu":
                    labelCheckBox("kudz");
                    break;

                case "Meteorlogicus":
                    labelCheckBox("mete");
                    break;

                case "Moot":
                    labelCheckBox("moot");
                    break;

                case "Quip":
                    labelCheckBox("quip");
                    break;

                case "Rodgort":
                    labelCheckBox("rodg");
                    break;

                case "Sunrise":
                    labelCheckBox("sunr");
                    break;

                case "The Dreamer":
                    labelCheckBox("drea");
                    break;

                case "The Minstrel":
                    labelCheckBox("mins");
                    break;

                case "The Predator":
                    labelCheckBox("pred");
                    break;

                case "Twilight":
                    labelCheckBox("twil");
                    break;
            }
        }

        /// <summary>
        /// Input and output integers of the application.
        /// </summary>
        private int mats_item_value = 250;

        private int tryParse(Control c)
        {
            int temp;
            int.TryParse(c.Text, out temp);
            return temp;
        }

        private void DoCalc()
        {
            double perc_pre = 0;
            if (checkBox_pre.Checked)
            {
                perc_pre = 100;
            }
            double perc_bloodstone = toPercent(tryParse(textBox_skillpoint), l_skill);
            if (checkBox_bloodstone.Checked)
            {
                perc_bloodstone = 100;
            }
            double perc_battle = toPercent(tryParse(textBox_honor), l_honor);
            if (checkBox_battle.Checked)
            {
                perc_battle = 100;
            }
            double perc_explo = 0;
            if (checkBox_explo.Checked)
            {
                perc_explo = 100;
            }
            double perc_obsi = toPercent(tryParse(textBox_obsi), mats_item_value);
            double perc_mastery = sumDivide(perc_bloodstone, perc_battle, perc_explo, perc_obsi);
            if (checkBox_mastery.Checked)
            {
                perc_mastery = 100;
            }
            double perc_totem = toPercent(tryParse(textBox_totem), mats_item_value);
            double perc_dust = toPercent(tryParse(textBox_dust), mats_item_value);
            double perc_venom = toPercent(tryParse(textBox_venom), mats_item_value);
            double perc_blood = toPercent(tryParse(textBox_blood), mats_item_value);
            double perc_magic = sumDivide(perc_totem, perc_dust, perc_venom, perc_blood);
            if (checkBox_magic.Checked)
            {
                perc_magic = 100;
            }
            double perc_bone = toPercent(tryParse(textBox_bone), mats_item_value);
            double perc_scale = toPercent(tryParse(textBox_scale), mats_item_value);
            double perc_claws = toPercent(tryParse(textBox_claws), mats_item_value);
            double perc_fangs = toPercent(tryParse(textBox_fangs), mats_item_value);
            double perc_might = sumDivide(perc_bone, perc_scale, perc_claws, perc_fangs);
            if (checkBox_might.Checked)
            {
                perc_might = 100;
            }
            double perc_ecto = toPercent(tryParse(textBox_ecto), mats_item_value);
            double perc_clover = toPercent(tryParse(textBox_clover), l_clover);
            double perc_fortune = sumDivide(perc_magic, perc_might, perc_ecto, perc_clover);
            if (checkBox_fortune.Checked)
            {
                perc_fortune = 100;
            }
            double perc_dungeon = toPercent(tryParse(textBox_token), l_token);
            if (checkBox_dungeon_gift.Checked)
            {
                perc_dungeon = 100;
            }
            double perc_ritem1 = toPercent(tryParse(textBox_recipe_item), l_ritem);
            double perc_ritem2 = toPercent(tryParse(textBox_recipe_item1), l_ritem1);
            double perc_ritem3 = toPercent(tryParse(textBox_recipe_item2), l_ritem2);
            double perc_recipe = sumDivide(perc_dungeon, perc_ritem1, perc_ritem2, perc_ritem3);
            if (checkBox_recipe_gift.Checked)
            {
                perc_recipe = 100;
            }
            double perc_mitem1 = toPercent(tryParse(textBox_mats_item), mats_item_value);
            double perc_mitem2 = toPercent(tryParse(textBox_mats_item1), mats_item_value);
            double perc_mitem3 = toPercent(tryParse(textBox_mats_item2), mats_item_value);
            double perc_mitem4 = toPercent(tryParse(textBox_mats_item3), mats_item_value);
            double perc_mats = sumDivide(perc_mitem1, perc_mitem2, perc_mitem3, perc_mitem4);
            if (checkBox_mats_gift.Checked)
            {
                perc_mats = 100;
            }
            double perc_sigil = 0;
            if (checkBox_sigil.Checked)
            {
                perc_sigil = 100;
            }
            double perc_runestones = toPercent(tryParse(textBox_runestones), l_runestone);
            double perc_legy = sumDivide(perc_recipe, perc_mats, perc_sigil, perc_runestones);
            if (checkBox_gift.Checked)
            {
                perc_legy = 100;
            }
            double perc_tot = sumDivide(perc_pre, perc_mastery, perc_fortune, perc_legy);
            label_perc.Text = perc_tot.ToString() + " %";
        }

        /// <summary>
        /// Sets the labels specific of the legendary.
        /// </summary>
        /// <param name="id">Gets the identifiator of the legendary.</param>
        private void labelCheckBox(string id)
        {
            checkBox_pre.Text = legyList.GetLegy(id).pre;
            checkBox_gift.Text = "Gift of" + legyList.GetLegy(id).name;
            checkBox_recipe_gift.Text = recipeBook.GetByID(legyList.GetLegy(id).recipeGift).name;
            setDungeon(recipeBook.GetByID(legyList.GetLegy(id).recipeGift).dungeonGift);
            labelMats(legyList.GetLegy(id).matsGift);
            labelRecipe(legyList.GetLegy(id).recipeGift);
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
                return 0;
            }
            else if (i > x)
            {
                return x;
            }
            else
            {
                return i;
            }
        }

        /// <summary>
        /// Sums the percentage of the four parts of the specific gift up and divides by four, to achieve percent.
        /// </summary>
        /// <param name="sum1">First part of the sum.</param>
        /// <param name="sum2">Second part of the sum.</param>
        /// <param name="sum3">Third part of the sum.</param>
        /// <param name="sum4">Fourth part of the sum.</param>
        /// <returns></returns>
        private double sumDivide(double sum1, double sum2, double sum3, double sum4)
        {
            return ((sum1 + sum2 + sum3 + sum4) / 4);
        }

        /// <summary>
        /// Calculates the percentage of the specific item and checks if needed amount is equal to NULL.
        /// </summary>
        /// <param name="i">Input, given by TextBoxes.</param>
        /// <param name="x">Needed amount of items.</param>
        private double toPercent(int i, int x)
        {
            return ((double)(setMax(i, x)) / (double)x) * 100.0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<Control, int> initLabel = new Dictionary<Control, int>()
            {
                {label_blood, l_blood},
                {label_bone, l_bone},
                {label_claws, l_claws},
                {label_clover, l_clover},
                {label_dust, l_dust},
                {label_ecto, l_ecto},
                {label_fangs, l_fangs},
                {label_honor, l_honor},
                {label_obsi, l_obsi},
                {label_runestone_value, l_runestone},
                {label_scale, l_scale},
                {label_skill, l_skill},
                {label_token_value, l_token},
                {label_totem, l_totem},
                {label_venom, l_venom}
            };
            foreach (var item in initLabel)
            {
                item.Key.Text = item.Value.ToString();
            }
        }
    }
}