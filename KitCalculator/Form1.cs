using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace KitCalculator
{
    public partial class Form1 : Form
    {
        public string HelmetPrice { get; set; }
        public string ChestplatePrice { get; set; }
        public string LeggingsPrice { get; set; }
        public string BootsPrice { get; set; }
        public string ShieldPrice { get; set; }
        public string OnehandswordPrice { get; set; }
        public string DaggerPrice { get; set; }
        public string OnehandaxePrice { get; set; }
        public string MacePrice { get; set; }
        public string TwohandaxePrice { get; set; }
        public string JavelinPrice { get; set; }
        public string ShortBowPrice { get; set; }
        public string LongBowPrice { get; set; }
        private bool tutorialbool = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                int iron = int.Parse(ironTextBox.Text);
                int gold = int.Parse(goldTextBox.Text);
                int dias = int.Parse(diasTextBox.Text);

                int[] prices = ResourceTax();
                int ironToTax = prices[0];
                int goldToTax = prices[1];
                int diasToTax = prices[2];
                while ((iron - ironToTax) >= 0 && (gold - goldToTax) >= 0 && (dias - diasToTax) >= 0)
                {
                    iron -= ironToTax;
                    gold -= goldToTax;
                    dias -= diasToTax;
                    count++;
                }
                resultLabel.Text = $"You can craft {count} kits and you are left with: \n {iron} iron ({ironToTax} iron a kit) \n {gold} gold ({goldToTax} gold a kit) \n {dias} diamonds ({diasToTax} diamonds a kit) \n NOTE: the brackets explain how many ores of the type you need \n per kit.";
                errorLabel.Visible = false;
            }
            catch (FormatException)
            {
                errorLabel.Text = "Use only full numbers! (In settings too)";
                errorLabel.Visible = true;
            }
            catch (ArgumentException)
            {
                errorLabel.Text = "Select an item first!";
                errorLabel.Visible = true;
            }
            catch (Exception)
            {
                errorLabel.Text = "You are not that rich...";
                errorLabel.Visible = true;
            }
        }
        private int[] ResourceTax()
        {
            if (helmetCheckBox.Checked == false && chestplateCheckBox.Checked == false && leggingsCheckBox.Checked == false && bootsCheckBox.Checked == false && shieldCheckBox.Checked == false && onehandswordCheckBox.Checked == false && daggerCheckBox.Checked == false && onehandaxeCheckBox.Checked == false && maceCheckBox.Checked == false && twohandaxeCheckBox.Checked == false && javelinCheckBox.Checked == false && shortBowCheckBox.Checked == false && longBowCheckBox.Checked == false) throw new ArgumentException();
            int ironToTax = 0;
            int goldToTax = 0;
            int diasToTax = 0;
            if (helmetCheckBox.Checked == true)
            {
                ironToTax += int.Parse(HelmetPrice.Split(';')[0]);
                goldToTax += int.Parse(HelmetPrice.Split(';')[1]);
                diasToTax += int.Parse(HelmetPrice.Split(';')[2]);
            }
            if (chestplateCheckBox.Checked == true)
            {
                ironToTax += int.Parse(ChestplatePrice.Split(';')[0]);
                goldToTax += int.Parse(ChestplatePrice.Split(';')[1]);
                diasToTax += int.Parse(ChestplatePrice.Split(';')[2]);
            }
            if (leggingsCheckBox.Checked == true)
            {
                ironToTax += int.Parse(LeggingsPrice.Split(';')[0]);
                goldToTax += int.Parse(LeggingsPrice.Split(';')[1]);
                diasToTax += int.Parse(LeggingsPrice.Split(';')[2]);
            }
            if (bootsCheckBox.Checked == true)
            {
                ironToTax += int.Parse(BootsPrice.Split(';')[0]);
                goldToTax += int.Parse(BootsPrice.Split(';')[1]);
                diasToTax += int.Parse(BootsPrice.Split(';')[2]);
            }
            if (shieldCheckBox.Checked == true)
            {
                ironToTax += int.Parse(ShieldPrice.Split(';')[0]);
                goldToTax += int.Parse(ShieldPrice.Split(';')[1]);
                diasToTax += int.Parse(ShieldPrice.Split(';')[2]);
            }
            if (onehandswordCheckBox.Checked == true)
            {
                ironToTax += int.Parse(OnehandswordPrice.Split(';')[0]);
                goldToTax += int.Parse(OnehandswordPrice.Split(';')[1]);
                diasToTax += int.Parse(OnehandswordPrice.Split(';')[2]);
            }
            if (daggerCheckBox.Checked == true)
            {
                ironToTax += int.Parse(DaggerPrice.Split(';')[0]);
                goldToTax += int.Parse(DaggerPrice.Split(';')[1]);
                diasToTax += int.Parse(DaggerPrice.Split(';')[2]);
            }
            if (onehandaxeCheckBox.Checked == true)
            {
                ironToTax += int.Parse(OnehandaxePrice.Split(';')[0]);
                goldToTax += int.Parse(OnehandaxePrice.Split(';')[1]);
                diasToTax += int.Parse(OnehandaxePrice.Split(';')[2]);
            }
            if (maceCheckBox.Checked == true)
            {
                ironToTax += int.Parse(MacePrice.Split(';')[0]);
                goldToTax += int.Parse(MacePrice.Split(';')[1]);
                diasToTax += int.Parse(MacePrice.Split(';')[2]);
            }
            if (twohandaxeCheckBox.Checked == true)
            {
                ironToTax += int.Parse(TwohandaxePrice.Split(';')[0]);
                goldToTax += int.Parse(TwohandaxePrice.Split(';')[1]);
                diasToTax += int.Parse(TwohandaxePrice.Split(';')[2]);
            }
            if (javelinCheckBox.Checked == true)
            {
                ironToTax += int.Parse(JavelinPrice.Split(';')[0]);
                goldToTax += int.Parse(JavelinPrice.Split(';')[1]);
                diasToTax += int.Parse(JavelinPrice.Split(';')[2]);
            }
            if (shortBowCheckBox.Checked == true)
            {
                ironToTax += int.Parse(ShortBowPrice.Split(';')[0]);
                goldToTax += int.Parse(ShortBowPrice.Split(';')[1]);
                diasToTax += int.Parse(ShortBowPrice.Split(';')[2]);
            }
            if (longBowCheckBox.Checked == true)
            {
                ironToTax += int.Parse(LongBowPrice.Split(';')[0]);
                goldToTax += int.Parse(LongBowPrice.Split(';')[1]);
                diasToTax += int.Parse(LongBowPrice.Split(';')[2]);
            }
            return [ironToTax, goldToTax, diasToTax];
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm(this, tutorialbool);
            form.ShowDialog();
            infoLabel.Visible = true;
            ironTextBox.Enabled = true;
            goldTextBox.Enabled = true;
            diasTextBox.Enabled = true;
            revCalcCountTextBox.Enabled = true;
            calcButton.Enabled = true;
            reverseCalcButton.Enabled = true;
            helmetCheckBox.Enabled = true;
            chestplateCheckBox.Enabled = true;
            leggingsCheckBox.Enabled = true;
            bootsCheckBox.Enabled = true;
            shieldCheckBox.Enabled = true;
            onehandswordCheckBox.Enabled = true;
            daggerCheckBox.Enabled = true;
            onehandaxeCheckBox.Enabled = true;
            maceCheckBox.Enabled = true;
            twohandaxeCheckBox.Enabled = true;
            javelinCheckBox.Enabled = true;
            shortBowCheckBox.Enabled = true;
            longBowCheckBox.Enabled = true;
            tutorial.Visible = false;
            tutorialbool = false;
        }

        private void reverseCalcButton_Click(object sender, EventArgs e)
        {
            try
            {
                int count = int.Parse(revCalcCountTextBox.Text);

                int[] prices = ResourceTax();
                int ironToTax = prices[0];
                int goldToTax = prices[1];
                int diasToTax = prices[2];

                int iron = ironToTax * count;
                int gold = goldToTax * count;
                int dias = diasToTax * count;
                resultLabel.Text = $"You need to get: \n {iron} iron ({ironToTax} a kit) \n {gold} gold ({goldToTax} a kit) \n {dias} diamonds ({diasToTax} a kit) \n NOTE: the brackets explain how many ores of the type you need \n per kit.";
                errorLabel.Visible = false;
            }
            catch (FormatException)
            {
                errorLabel.Text = "Use only full numbers!";
                errorLabel.Visible = true;
            }
            catch (ArgumentException)
            {
                errorLabel.Text = "Select an item first!";
                errorLabel.Visible = true;
            }
            catch (Exception)
            {
                errorLabel.Text = "You are not that rich...";
                errorLabel.Visible = true;
            }
        }

        private void chestplateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}