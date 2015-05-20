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
        private string input;

        private Api Api = new Api();

        /// <summary>
        /// doubles resulting of the calculation.
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            string[] legys = { legyList.GetLegy("bifr").name, legyList.GetLegy("bolt").name, legyList.GetLegy("flam").name, legyList.GetLegy("fren").name, legyList.GetLegy("fros").name, legyList.GetLegy("howl").name, legyList.GetLegy("inci").name, legyList.GetLegy("jugg").name, legyList.GetLegy("kamo").name, legyList.GetLegy("krai").name, legyList.GetLegy("kudz").name, legyList.GetLegy("mete").name, legyList.GetLegy("moot").name, legyList.GetLegy("quip").name, legyList.GetLegy("rodg").name, legyList.GetLegy("sunr").name, legyList.GetLegy("drea").name, legyList.GetLegy("mins").name, legyList.GetLegy("pred").name, legyList.GetLegy("twil").name };
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
        private int priceblood;
        private int l_bone = 250;
        private int pricebone;
        private int l_claws = 250;
        private int priceclaws;
        private int l_clover = 77;
        private int l_dust = 250;
        private int pricedust;
        private int l_ecto = 250;
        private int priceecto;
        private int l_fangs = 250;
        private int pricefangs;
        private int l_honor = 500;
        private int l_obsi = 250;
        private int l_runestone = 100;
        private int pricerunestone;
        private int l_scale = 250;
        private int pricescale;
        private int l_skill = 200;
        private int l_token = 500;
        private int l_totem = 250;
        private int pricetotem;
        private int l_venom = 250;
        private int pricevenom;

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
                case "The Bifrost":
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

                case "The Juggernaught":
                    labelCheckBox("jugg");
                    break;

                case "Kamohoali i Kotaki":
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

                case "The Moot":
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

        private int calcPrice(Control tb, int mat, int matprice, Control lab, ref double perc)
        {
            int temp = tryParse(tb);
            perc = toPercent(temp, mat);
            int price = (mat - temp) * matprice;
            lab.Text = FormatAsGold(price);
            return price;
        }

        private void DoCalc()
        {
            double perc_pre = 0;
            if (checkBox_pre.Checked)
            {
                perc_pre = 100;
                prePrice = 0;
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
            double perc_totem = 0;
            int totemPrice = calcPrice(textBox_totem, mats_item_value, pricetotem, labelTotemPrice, ref perc_totem);
            double perc_dust = 0;
            int dustPrice = calcPrice(textBox_dust, mats_item_value, pricedust, labelDustPrice, ref perc_dust);
            double perc_venom = 0;
            int venomPrice = calcPrice(textBox_venom, mats_item_value, pricevenom, labelVenomPrice, ref perc_venom);
            double perc_blood = 0;
            int bloodPrice = calcPrice(textBox_blood, mats_item_value, priceblood, labelBloodPrice, ref perc_blood);
            double perc_magic = sumDivide(perc_totem, perc_dust, perc_venom, perc_blood);
            int magicPrice = totemPrice + venomPrice + dustPrice + bloodPrice;
            if (checkBox_magic.Checked)
            {
                perc_magic = 100;
                magicPrice = 0;
            }
            labelMagicPrice.Text = FormatAsGold(magicPrice);
            double perc_bone = 0;
            int bonePrice = calcPrice(textBox_bone, mats_item_value, pricebone, labelBonePrice, ref perc_bone);
            double perc_scale = 0;
            int scalePrice = calcPrice(textBox_scale, mats_item_value, pricescale, labelScalePrice, ref perc_scale);
            double perc_claws = 0;
            int clawsPrice = calcPrice(textBox_claws, mats_item_value, priceclaws, labelClawsPrice, ref perc_claws);
            double perc_fangs = 0;
            int fangsPrice = calcPrice(textBox_fangs, mats_item_value, pricefangs, labelFangsPrice, ref perc_fangs);
            double perc_might = sumDivide(perc_bone, perc_scale, perc_claws, perc_fangs);
            int mightPrice = bonePrice + scalePrice + clawsPrice + fangsPrice;
            if (checkBox_might.Checked)
            {
                perc_might = 100;
                mightPrice = 0;
            }
            labelMightPrice.Text = FormatAsGold(mightPrice);
            double perc_ecto = 0;
            int ectoprice = calcPrice(textBox_ecto, mats_item_value, priceecto, labelEctoPrice, ref perc_ecto);
            double perc_clover = toPercent(tryParse(textBox_clover), l_clover);
            double perc_fortune = sumDivide(perc_magic, perc_might, perc_ecto, perc_clover);
            int fortunePrice = magicPrice + mightPrice + ectoprice;
            if (checkBox_fortune.Checked)
            {
                perc_fortune = 100;
                fortunePrice = 0;
            }
            labelFortunePrice.Text = FormatAsGold(fortunePrice);
            double perc_dungeon = toPercent(tryParse(textBox_token), l_token);
            if (checkBox_dungeon_gift.Checked)
            {
                perc_dungeon = 100;
            }
            double perc_ritem1 = 0;
            int ritem1Price = calcPrice(textBox_recipe_item, l_ritem, ritem1price, labelRItem1, ref perc_ritem1);
            double perc_ritem2 = 0;
            int ritem2Price = calcPrice(textBox_recipe_item1, l_ritem1, ritem2price, labelRItem2, ref perc_ritem2);
            double perc_ritem3 = 0;
            int ritem3Price = calcPrice(textBox_recipe_item2, l_ritem2, ritem3price, labelRItem3, ref perc_ritem3);
            int uniqueGiftPrice = ritem1Price + ritem2Price + ritem3Price;
            double perc_recipe = sumDivide(perc_dungeon, perc_ritem1, perc_ritem2, perc_ritem3);
            if (checkBox_recipe_gift.Checked)
            {
                perc_recipe = 100;
                uniqueGiftPrice = 0;
            }
            labelUniqueGiftPrice.Text = FormatAsGold(uniqueGiftPrice);
            double perc_mitem1 = 0;
            int mitem1Price = calcPrice(textBox_mats_item, mats_item_value, mitem1price, labelMatsItemPrice, ref perc_mitem1);
            double perc_mitem2 = 0;
            int mitem2Price = calcPrice(textBox_mats_item1, mats_item_value, mitem2price, labelMatsItem1Price, ref perc_mitem2);
            double perc_mitem3 = 0;
            int mitem3Price = calcPrice(textBox_mats_item2, mats_item_value, mitem3price, labelMatsItem2Price, ref perc_mitem3);
            double perc_mitem4 = 0;
            int mitem4Price = calcPrice(textBox_mats_item3, mats_item_value, mitem4price, labelMatsItem3Price, ref perc_mitem4);
            int matsTotal = mitem1Price + mitem2Price + mitem3Price + mitem4Price;
            double perc_mats = sumDivide(perc_mitem1, perc_mitem2, perc_mitem3, perc_mitem4);
            if (checkBox_mats_gift.Checked)
            {
                perc_mats = 100;
                matsTotal = 0;
            }
            labelMatsPriceTot.Text = FormatAsGold(matsTotal);
            double perc_sigil = 0;

            if (checkBox_sigil.Checked)
            {
                perc_sigil = 100;
                sigilPrice = 0;
            }
            double perc_runestones = 0;
            int runestonePrice = calcPrice(textBox_runestones, l_runestone, pricerunestone, labelRunestones, ref perc_runestones);
            double perc_legy = sumDivide(perc_recipe, perc_mats, perc_sigil, perc_runestones);
            if (checkBox_gift.Checked)
            {
                perc_legy = 100;
            }
            int giftLegyPrice = matsTotal + runestonePrice + uniqueGiftPrice;
            labelGiftLegyPrice.Text = FormatAsGold(giftLegyPrice);
            double perc_tot = sumDivide(perc_pre, perc_mastery, perc_fortune, perc_legy);
            label_perc.Text = perc_tot.ToString() + " %";
            labelGoldTotal.Text = FormatAsGold(prePrice + giftLegyPrice + fortunePrice);
        }

        private int prePrice, sigilPrice;

        /// <summary>
        /// Sets the labels specific of the legendary.
        /// </summary>
        /// <param name="id">Gets the identifiator of the legendary.</param>
        private void labelCheckBox(string id)
        {
            legy legy = legyList.GetLegy(id);
            labelLegyPrice.Text = FormatAsGold(Api.GetSellPrice(legy.api));
            checkBox_pre.Text = legy.pre;
            prePrice = Api.GetSellPrice(legy.preapi);
            labelPrePrice.Text = FormatAsGold(prePrice);
            sigilPrice = Api.GetSellPrice(legy.sigilapi);
            labelSigilPrice.Text = FormatAsGold(sigilPrice);
            checkBox_gift.Text = "Gift of" + legy.name;
            checkBox_recipe_gift.Text = recipeBook.GetByID(legy.recipeGift).name;
            setDungeon(recipeBook.GetByID(legy.recipeGift).dungeonGift);
            labelMats(legy.matsGift);
            labelRecipe(legy.recipeGift);
            checkBox_sigil.Text = "Superior Sigil of " + legy.sigil;
        }

        private int mitem1price, mitem2price, mitem3price, mitem4price;

        private void labelMats(string name)
        {
            matGift material = MatStore.GetByName(name);
            checkBox_mats_gift.Text = "Gift of " + material.name;
            label_mats_item.Text = material.item;
            label_mats_item_value.Text = mats_item_value.ToString();
            mitem1price = Api.GetSellPrice(material.itemApi);
            label_mats_item1.Text = material.item1;
            label_mats_item1_value.Text = mats_item_value.ToString();
            mitem2price = Api.GetSellPrice(material.item1Api);
            label_mats_item2.Text = material.item2;
            label_mats_item2_value.Text = mats_item_value.ToString();
            mitem3price = Api.GetSellPrice(material.item2Api);
            label_mats_item3.Text = material.item3;
            label_mats_item3_value.Text = mats_item_value.ToString();
            mitem4price = Api.GetSellPrice(material.item3Api);
        }

        private int l_ritem, l_ritem1, l_ritem2;
        private int ritem1price, ritem2price, ritem3price;

        /// <summary>
        /// Sets the <c>Label.Text</c> to the value taken from the data base.
        /// </summary>
        /// <param name="id">Identifier of the specific label.</param>
        private void labelRecipe(string id)
        {
            recipeGift recipe = recipeBook.GetByID(id);
            l_ritem = recipe.item_value;
            l_ritem1 = recipe.item1_value;
            l_ritem2 = recipe.item2_value;
            label_recipe_item.Text = recipe.item;
            label_recipe_item_value.Text = l_ritem.ToString();
            ritem1price = Api.GetSellPrice(recipe.itemApi);
            label_recipe_item1.Text = recipe.item1;
            label_recipe_item1_value.Text = l_ritem1.ToString();
            ritem2price = Api.GetSellPrice(recipe.item1Api);
            label_recipe_item2.Text = recipe.item2;
            label_recipe_item2_value.Text = l_ritem2.ToString();
            ritem3price = Api.GetSellPrice(recipe.item2Api);
        }

        /// <summary>
        /// Sets the labels specific to the dungeon, based on the <c>abbr parameter</c>.
        /// </summary>
        /// <param name="Abbr">Identifier of the dungeon.</param>
        private void setDungeon(string Abbr)
        {
            checkBox_dungeon_gift.Text = DungeonStore.GetByCode(Abbr).name;
            labelDungeonName.Text = DungeonStore.GetByCode(Abbr).dungeon;
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

            priceblood = Api.GetSellPrice(ApiList.GetByAbbr("vpbl").id);
            pricebone = Api.GetSellPrice(ApiList.GetByAbbr("anbo").id);
            priceclaws = Api.GetSellPrice(ApiList.GetByAbbr("vicl").id);
            pricedust = Api.GetSellPrice(ApiList.GetByAbbr("cryd").id);
            priceecto = Api.GetSellPrice(ApiList.GetByAbbr("ecto").id);
            pricefangs = Api.GetSellPrice(ApiList.GetByAbbr("vifa").id);
            pricerunestone = 10000;
            pricescale = Api.GetSellPrice(ApiList.GetByAbbr("arsc").id);
            pricetotem = Api.GetSellPrice(ApiList.GetByAbbr("elto").id);
            pricevenom = Api.GetSellPrice(ApiList.GetByAbbr("pove").id);
        }

        private string FormatAsGold(int p)
        {
            var gold = Rounding.RoundDown(p / 10000, 0);
            var silver = Rounding.RoundDown((p - (10000 * gold)) / 100, 0);
            var copper = (p - (10000 * gold) - (100 * silver));
            //return gold + _rm.GetString("gold", _cul) + " " + silver + _rm.GetString("silver", _cul) + " " + copper + _rm.GetString("copper", _cul);
            return gold + "g " + silver + "s " + copper + "c";
        }
    }
}