using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitCalculator
{
    public partial class SettingsForm : Form
    {

        Form1 EditBoard = new Form1();
        public SettingsForm(Form1 form, bool tutorial)
        {
            InitializeComponent();
            EditBoard = form;
            if (!tutorial)
            {
                tutorial2.Visible = false;
                settingsInfoLabel.ForeColor = Color.Black;
            }
            else
            {
                SavePrices();
            }
            LoadPrices();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingsHelmetLabel_Click(object sender, EventArgs e)
        {

        }

        private void settingsSaveButton_Click(object sender, EventArgs e)
        {
            SavePrices();
        }
        public void SavePrices()
        {
            EditBoard.HelmetPrice = $"{helmetIron.Text};{helmetGold.Text};{helmetDias.Text}";
            EditBoard.ChestplatePrice = $"{chestplateIron.Text};{chestplateGold.Text};{chestplateDias.Text}";
            EditBoard.LeggingsPrice = $"{leggingsIron.Text};{leggingsGold.Text};{leggingsDias.Text}";
            EditBoard.BootsPrice = $"{bootsIron.Text};{bootsGold.Text};{bootsDias.Text}";
            EditBoard.ShieldPrice = $"{shieldsIron.Text};{shieldsGold.Text};{shieldsDias.Text}";
            EditBoard.OnehandswordPrice = $"{onehandswordIron.Text};{onehandswordGold.Text};{onehandswordDias.Text}";
            EditBoard.DaggerPrice = $"{daggerIron.Text};{daggerGold.Text};{daggerDias.Text}";
            EditBoard.OnehandaxePrice = $"{onehandaxeIron.Text};{onehandaxeGold.Text};{onehandaxeDias.Text}";
            EditBoard.MacePrice = $"{maceIron.Text};{maceGold.Text};{maceDias.Text}";
            EditBoard.TwohandaxePrice = $"{twohandaxeIron.Text};{twohandaxeGold.Text};{twohandaxeDias.Text}";
            EditBoard.JavelinPrice = $"{javelinIron.Text};{javelinGold.Text};{javelinDias.Text}";
            EditBoard.ShortBowPrice = $"{shortBowIron.Text};{shortBowGold.Text};{shortBowDias.Text}";
            EditBoard.LongBowPrice = $"{longBowIron.Text};{longBowGold.Text};{longBowDias.Text}";
        }
        public void LoadPrices()
        {
            helmetIron.Text = EditBoard.HelmetPrice.Split(';')[0];
            helmetGold.Text = EditBoard.HelmetPrice.Split(';')[1];
            helmetDias.Text = EditBoard.HelmetPrice.Split(';')[2];

            chestplateIron.Text = EditBoard.ChestplatePrice.Split(';')[0];
            chestplateGold.Text = EditBoard.ChestplatePrice.Split(';')[1];
            chestplateDias.Text = EditBoard.ChestplatePrice.Split(';')[2];

            leggingsIron.Text = EditBoard.LeggingsPrice.Split(';')[0];
            leggingsGold.Text = EditBoard.LeggingsPrice.Split(';')[1];
            leggingsDias.Text = EditBoard.LeggingsPrice.Split(';')[2];

            bootsIron.Text = EditBoard.BootsPrice.Split(';')[0];
            bootsGold.Text = EditBoard.BootsPrice.Split(';')[1];
            bootsDias.Text = EditBoard.BootsPrice.Split(';')[2];

            shieldsIron.Text = EditBoard.ShieldPrice.Split(';')[0];
            shieldsGold.Text = EditBoard.ShieldPrice.Split(';')[1];
            shieldsDias.Text = EditBoard.ShieldPrice.Split(';')[2];

            onehandswordIron.Text = EditBoard.OnehandswordPrice.Split(';')[0];
            onehandswordGold.Text = EditBoard.OnehandswordPrice.Split(';')[1];
            onehandswordDias.Text = EditBoard.OnehandswordPrice.Split(';')[2];

            daggerIron.Text = EditBoard.DaggerPrice.Split(';')[0];
            daggerGold.Text = EditBoard.DaggerPrice.Split(';')[1];
            daggerDias.Text = EditBoard.DaggerPrice.Split(';')[2];

            onehandaxeIron.Text = EditBoard.OnehandaxePrice.Split(';')[0];
            onehandaxeGold.Text = EditBoard.OnehandaxePrice.Split(';')[1];
            onehandaxeDias.Text = EditBoard.OnehandaxePrice.Split(';')[2];
            
            maceIron.Text = EditBoard.MacePrice.Split(';')[0];
            maceGold.Text = EditBoard.MacePrice.Split(';')[1];
            maceDias.Text = EditBoard.MacePrice.Split(';')[2];

            twohandaxeIron.Text = EditBoard.TwohandaxePrice.Split(';')[0];
            twohandaxeGold.Text = EditBoard.TwohandaxePrice.Split(';')[1];
            twohandaxeDias.Text = EditBoard.TwohandaxePrice.Split(';')[2];

            javelinIron.Text = EditBoard.JavelinPrice.Split(';')[0];
            javelinGold.Text = EditBoard.JavelinPrice.Split(';')[1];
            javelinDias.Text = EditBoard.JavelinPrice.Split(';')[2];

            shortBowIron.Text = EditBoard.ShortBowPrice.Split(';')[0];
            shortBowGold.Text = EditBoard.ShortBowPrice.Split(';')[1];
            shortBowDias.Text = EditBoard.ShortBowPrice.Split(';')[2];

            longBowIron.Text = EditBoard.LongBowPrice.Split(';')[0];
            longBowGold.Text = EditBoard.LongBowPrice.Split(';')[1];
            longBowDias.Text = EditBoard.LongBowPrice.Split(';')[2];
        }
        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
