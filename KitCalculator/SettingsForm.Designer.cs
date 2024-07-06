namespace KitCalculator
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            settingsInfoLabel = new Label();
            settingsHelmetLabel = new Label();
            settingsIronLabel = new Label();
            settingsGoldLabel = new Label();
            settingsDiamondsLabel = new Label();
            helmetIron = new TextBox();
            helmetGold = new TextBox();
            helmetDias = new TextBox();
            chestplateIron = new TextBox();
            chestplateGold = new TextBox();
            chestplateDias = new TextBox();
            leggingsIron = new TextBox();
            leggingsGold = new TextBox();
            leggingsDias = new TextBox();
            bootsIron = new TextBox();
            bootsGold = new TextBox();
            bootsDias = new TextBox();
            shieldsIron = new TextBox();
            shieldsGold = new TextBox();
            shieldsDias = new TextBox();
            settingsChestplateLabel = new Label();
            settingsLeggingsLabel = new Label();
            settingsBootsLabel = new Label();
            settingsShieldLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            twohandaxeDias = new TextBox();
            twohandaxeGold = new TextBox();
            twohandaxeIron = new TextBox();
            maceDias = new TextBox();
            maceGold = new TextBox();
            maceIron = new TextBox();
            onehandaxeDias = new TextBox();
            onehandaxeGold = new TextBox();
            onehandaxeIron = new TextBox();
            daggerDias = new TextBox();
            daggerGold = new TextBox();
            daggerIron = new TextBox();
            onehandswordDias = new TextBox();
            onehandswordGold = new TextBox();
            onehandswordIron = new TextBox();
            javelinDias = new TextBox();
            javelinGold = new TextBox();
            javelinIron = new TextBox();
            shortBowDias = new TextBox();
            shortBowGold = new TextBox();
            shortBowIron = new TextBox();
            longBowDias = new TextBox();
            longBowGold = new TextBox();
            longBowIron = new TextBox();
            settingsDaggerLabel = new Label();
            settingsOnehandaxeLabel = new Label();
            settingsOnehandswordLabel = new Label();
            settingsMaceLabel = new Label();
            settingsTwohandaxeLabel = new Label();
            settingsJavelinLabel = new Label();
            settingsShortBowLabel = new Label();
            settingsLongBowLabel = new Label();
            settingsSaveButton = new Button();
            tutorial2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // settingsInfoLabel
            // 
            settingsInfoLabel.AutoSize = true;
            settingsInfoLabel.BackColor = Color.Transparent;
            settingsInfoLabel.ForeColor = Color.Green;
            settingsInfoLabel.Location = new Point(12, 9);
            settingsInfoLabel.Name = "settingsInfoLabel";
            settingsInfoLabel.Size = new Size(621, 15);
            settingsInfoLabel.TabIndex = 0;
            settingsInfoLabel.Text = "In case the kits' cost changes, here you will be able to adjust it according to the current price, just remember to SAVE!\r\n";
            // 
            // settingsHelmetLabel
            // 
            settingsHelmetLabel.AutoSize = true;
            settingsHelmetLabel.BackColor = Color.Transparent;
            settingsHelmetLabel.Font = new Font("Segoe UI", 11F);
            settingsHelmetLabel.Location = new Point(67, 40);
            settingsHelmetLabel.Name = "settingsHelmetLabel";
            settingsHelmetLabel.Size = new Size(61, 20);
            settingsHelmetLabel.TabIndex = 1;
            settingsHelmetLabel.Text = "Helmet:";
            settingsHelmetLabel.Click += settingsHelmetLabel_Click;
            // 
            // settingsIronLabel
            // 
            settingsIronLabel.AutoSize = true;
            settingsIronLabel.BackColor = Color.Transparent;
            settingsIronLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            settingsIronLabel.Location = new Point(12, 64);
            settingsIronLabel.Name = "settingsIronLabel";
            settingsIronLabel.Size = new Size(34, 17);
            settingsIronLabel.TabIndex = 2;
            settingsIronLabel.Text = "Iron:";
            // 
            // settingsGoldLabel
            // 
            settingsGoldLabel.AutoSize = true;
            settingsGoldLabel.BackColor = Color.Transparent;
            settingsGoldLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            settingsGoldLabel.Location = new Point(9, 90);
            settingsGoldLabel.Name = "settingsGoldLabel";
            settingsGoldLabel.Size = new Size(39, 17);
            settingsGoldLabel.TabIndex = 3;
            settingsGoldLabel.Text = "Gold:";
            // 
            // settingsDiamondsLabel
            // 
            settingsDiamondsLabel.AutoSize = true;
            settingsDiamondsLabel.BackColor = Color.Transparent;
            settingsDiamondsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            settingsDiamondsLabel.Location = new Point(12, 116);
            settingsDiamondsLabel.Name = "settingsDiamondsLabel";
            settingsDiamondsLabel.Size = new Size(36, 17);
            settingsDiamondsLabel.TabIndex = 4;
            settingsDiamondsLabel.Text = "Dias:";
            // 
            // helmetIron
            // 
            helmetIron.BackColor = Color.LightCyan;
            helmetIron.BorderStyle = BorderStyle.FixedSingle;
            helmetIron.Location = new Point(61, 63);
            helmetIron.Name = "helmetIron";
            helmetIron.Size = new Size(72, 23);
            helmetIron.TabIndex = 5;
            helmetIron.Text = "2";
            helmetIron.TextChanged += textBox1_TextChanged;
            // 
            // helmetGold
            // 
            helmetGold.BackColor = Color.LightCyan;
            helmetGold.BorderStyle = BorderStyle.FixedSingle;
            helmetGold.Location = new Point(61, 89);
            helmetGold.Name = "helmetGold";
            helmetGold.Size = new Size(72, 23);
            helmetGold.TabIndex = 6;
            helmetGold.Text = "3";
            // 
            // helmetDias
            // 
            helmetDias.BackColor = Color.LightCyan;
            helmetDias.BorderStyle = BorderStyle.FixedSingle;
            helmetDias.Location = new Point(61, 115);
            helmetDias.Name = "helmetDias";
            helmetDias.Size = new Size(72, 23);
            helmetDias.TabIndex = 7;
            helmetDias.Text = "0";
            // 
            // chestplateIron
            // 
            chestplateIron.BackColor = Color.LightCyan;
            chestplateIron.BorderStyle = BorderStyle.FixedSingle;
            chestplateIron.Location = new Point(139, 63);
            chestplateIron.Name = "chestplateIron";
            chestplateIron.Size = new Size(72, 23);
            chestplateIron.TabIndex = 8;
            chestplateIron.Text = "5";
            // 
            // chestplateGold
            // 
            chestplateGold.BackColor = Color.LightCyan;
            chestplateGold.BorderStyle = BorderStyle.FixedSingle;
            chestplateGold.Location = new Point(139, 89);
            chestplateGold.Name = "chestplateGold";
            chestplateGold.Size = new Size(72, 23);
            chestplateGold.TabIndex = 9;
            chestplateGold.Text = "1";
            // 
            // chestplateDias
            // 
            chestplateDias.BackColor = Color.LightCyan;
            chestplateDias.BorderStyle = BorderStyle.FixedSingle;
            chestplateDias.Location = new Point(139, 115);
            chestplateDias.Name = "chestplateDias";
            chestplateDias.Size = new Size(72, 23);
            chestplateDias.TabIndex = 10;
            chestplateDias.Text = "2";
            // 
            // leggingsIron
            // 
            leggingsIron.BackColor = Color.LightCyan;
            leggingsIron.BorderStyle = BorderStyle.FixedSingle;
            leggingsIron.Location = new Point(217, 63);
            leggingsIron.Name = "leggingsIron";
            leggingsIron.Size = new Size(72, 23);
            leggingsIron.TabIndex = 11;
            leggingsIron.Text = "4";
            // 
            // leggingsGold
            // 
            leggingsGold.BackColor = Color.LightCyan;
            leggingsGold.BorderStyle = BorderStyle.FixedSingle;
            leggingsGold.Location = new Point(217, 89);
            leggingsGold.Name = "leggingsGold";
            leggingsGold.Size = new Size(72, 23);
            leggingsGold.TabIndex = 12;
            leggingsGold.Text = "1";
            // 
            // leggingsDias
            // 
            leggingsDias.BackColor = Color.LightCyan;
            leggingsDias.BorderStyle = BorderStyle.FixedSingle;
            leggingsDias.Location = new Point(217, 115);
            leggingsDias.Name = "leggingsDias";
            leggingsDias.Size = new Size(72, 23);
            leggingsDias.TabIndex = 13;
            leggingsDias.Text = "2";
            // 
            // bootsIron
            // 
            bootsIron.BackColor = Color.LightCyan;
            bootsIron.BorderStyle = BorderStyle.FixedSingle;
            bootsIron.Location = new Point(295, 63);
            bootsIron.Name = "bootsIron";
            bootsIron.Size = new Size(72, 23);
            bootsIron.TabIndex = 14;
            bootsIron.Text = "0";
            // 
            // bootsGold
            // 
            bootsGold.BackColor = Color.LightCyan;
            bootsGold.BorderStyle = BorderStyle.FixedSingle;
            bootsGold.Location = new Point(295, 89);
            bootsGold.Name = "bootsGold";
            bootsGold.Size = new Size(72, 23);
            bootsGold.TabIndex = 15;
            bootsGold.Text = "4";
            // 
            // bootsDias
            // 
            bootsDias.BackColor = Color.LightCyan;
            bootsDias.BorderStyle = BorderStyle.FixedSingle;
            bootsDias.Location = new Point(295, 115);
            bootsDias.Name = "bootsDias";
            bootsDias.Size = new Size(72, 23);
            bootsDias.TabIndex = 16;
            bootsDias.Text = "0";
            // 
            // shieldsIron
            // 
            shieldsIron.BackColor = Color.LightCyan;
            shieldsIron.BorderStyle = BorderStyle.FixedSingle;
            shieldsIron.Location = new Point(373, 63);
            shieldsIron.Name = "shieldsIron";
            shieldsIron.Size = new Size(72, 23);
            shieldsIron.TabIndex = 17;
            shieldsIron.Text = "3";
            // 
            // shieldsGold
            // 
            shieldsGold.BackColor = Color.LightCyan;
            shieldsGold.BorderStyle = BorderStyle.FixedSingle;
            shieldsGold.Location = new Point(373, 89);
            shieldsGold.Name = "shieldsGold";
            shieldsGold.Size = new Size(72, 23);
            shieldsGold.TabIndex = 18;
            shieldsGold.Text = "0";
            // 
            // shieldsDias
            // 
            shieldsDias.BackColor = Color.LightCyan;
            shieldsDias.BorderStyle = BorderStyle.FixedSingle;
            shieldsDias.Location = new Point(373, 115);
            shieldsDias.Name = "shieldsDias";
            shieldsDias.Size = new Size(72, 23);
            shieldsDias.TabIndex = 19;
            shieldsDias.Text = "0";
            // 
            // settingsChestplateLabel
            // 
            settingsChestplateLabel.AutoSize = true;
            settingsChestplateLabel.BackColor = Color.Transparent;
            settingsChestplateLabel.Font = new Font("Segoe UI", 11F);
            settingsChestplateLabel.Location = new Point(134, 40);
            settingsChestplateLabel.Name = "settingsChestplateLabel";
            settingsChestplateLabel.Size = new Size(82, 20);
            settingsChestplateLabel.TabIndex = 20;
            settingsChestplateLabel.Text = "Chestplate:";
            // 
            // settingsLeggingsLabel
            // 
            settingsLeggingsLabel.AutoSize = true;
            settingsLeggingsLabel.BackColor = Color.Transparent;
            settingsLeggingsLabel.Font = new Font("Segoe UI", 11F);
            settingsLeggingsLabel.Location = new Point(217, 40);
            settingsLeggingsLabel.Name = "settingsLeggingsLabel";
            settingsLeggingsLabel.Size = new Size(72, 20);
            settingsLeggingsLabel.TabIndex = 21;
            settingsLeggingsLabel.Text = "Leggings:";
            // 
            // settingsBootsLabel
            // 
            settingsBootsLabel.AutoSize = true;
            settingsBootsLabel.BackColor = Color.Transparent;
            settingsBootsLabel.Font = new Font("Segoe UI", 11F);
            settingsBootsLabel.Location = new Point(306, 40);
            settingsBootsLabel.Name = "settingsBootsLabel";
            settingsBootsLabel.Size = new Size(50, 20);
            settingsBootsLabel.TabIndex = 22;
            settingsBootsLabel.Text = "Boots:";
            // 
            // settingsShieldLabel
            // 
            settingsShieldLabel.AutoSize = true;
            settingsShieldLabel.BackColor = Color.Transparent;
            settingsShieldLabel.Font = new Font("Segoe UI", 11F);
            settingsShieldLabel.Location = new Point(379, 40);
            settingsShieldLabel.Name = "settingsShieldLabel";
            settingsShieldLabel.Size = new Size(59, 20);
            settingsShieldLabel.TabIndex = 23;
            settingsShieldLabel.Text = "Shields:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(10, 227);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 26;
            label1.Text = "Dias:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(7, 201);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 25;
            label2.Text = "Gold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(10, 175);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 24;
            label3.Text = "Iron:";
            // 
            // twohandaxeDias
            // 
            twohandaxeDias.BackColor = Color.LightCyan;
            twohandaxeDias.BorderStyle = BorderStyle.FixedSingle;
            twohandaxeDias.Location = new Point(373, 226);
            twohandaxeDias.Name = "twohandaxeDias";
            twohandaxeDias.Size = new Size(72, 23);
            twohandaxeDias.TabIndex = 41;
            twohandaxeDias.Text = "3";
            // 
            // twohandaxeGold
            // 
            twohandaxeGold.BackColor = Color.LightCyan;
            twohandaxeGold.BorderStyle = BorderStyle.FixedSingle;
            twohandaxeGold.Location = new Point(373, 200);
            twohandaxeGold.Name = "twohandaxeGold";
            twohandaxeGold.Size = new Size(72, 23);
            twohandaxeGold.TabIndex = 40;
            twohandaxeGold.Text = "0";
            // 
            // twohandaxeIron
            // 
            twohandaxeIron.BackColor = Color.LightCyan;
            twohandaxeIron.BorderStyle = BorderStyle.FixedSingle;
            twohandaxeIron.Location = new Point(373, 174);
            twohandaxeIron.Name = "twohandaxeIron";
            twohandaxeIron.Size = new Size(72, 23);
            twohandaxeIron.TabIndex = 39;
            twohandaxeIron.Text = "0";
            // 
            // maceDias
            // 
            maceDias.BackColor = Color.LightCyan;
            maceDias.BorderStyle = BorderStyle.FixedSingle;
            maceDias.Location = new Point(295, 226);
            maceDias.Name = "maceDias";
            maceDias.Size = new Size(72, 23);
            maceDias.TabIndex = 38;
            maceDias.Text = "2";
            // 
            // maceGold
            // 
            maceGold.BackColor = Color.LightCyan;
            maceGold.BorderStyle = BorderStyle.FixedSingle;
            maceGold.Location = new Point(295, 200);
            maceGold.Name = "maceGold";
            maceGold.Size = new Size(72, 23);
            maceGold.TabIndex = 37;
            maceGold.Text = "1";
            // 
            // maceIron
            // 
            maceIron.BackColor = Color.LightCyan;
            maceIron.BorderStyle = BorderStyle.FixedSingle;
            maceIron.Location = new Point(295, 174);
            maceIron.Name = "maceIron";
            maceIron.Size = new Size(72, 23);
            maceIron.TabIndex = 36;
            maceIron.Text = "0";
            // 
            // onehandaxeDias
            // 
            onehandaxeDias.BackColor = Color.LightCyan;
            onehandaxeDias.BorderStyle = BorderStyle.FixedSingle;
            onehandaxeDias.Location = new Point(217, 226);
            onehandaxeDias.Name = "onehandaxeDias";
            onehandaxeDias.Size = new Size(72, 23);
            onehandaxeDias.TabIndex = 35;
            onehandaxeDias.Text = "2";
            // 
            // onehandaxeGold
            // 
            onehandaxeGold.BackColor = Color.LightCyan;
            onehandaxeGold.BorderStyle = BorderStyle.FixedSingle;
            onehandaxeGold.Location = new Point(217, 200);
            onehandaxeGold.Name = "onehandaxeGold";
            onehandaxeGold.Size = new Size(72, 23);
            onehandaxeGold.TabIndex = 34;
            onehandaxeGold.Text = "0";
            // 
            // onehandaxeIron
            // 
            onehandaxeIron.BackColor = Color.LightCyan;
            onehandaxeIron.BorderStyle = BorderStyle.FixedSingle;
            onehandaxeIron.Location = new Point(217, 174);
            onehandaxeIron.Name = "onehandaxeIron";
            onehandaxeIron.Size = new Size(72, 23);
            onehandaxeIron.TabIndex = 33;
            onehandaxeIron.Text = "1";
            // 
            // daggerDias
            // 
            daggerDias.BackColor = Color.LightCyan;
            daggerDias.BorderStyle = BorderStyle.FixedSingle;
            daggerDias.Location = new Point(139, 226);
            daggerDias.Name = "daggerDias";
            daggerDias.Size = new Size(72, 23);
            daggerDias.TabIndex = 32;
            daggerDias.Text = "1";
            // 
            // daggerGold
            // 
            daggerGold.BackColor = Color.LightCyan;
            daggerGold.BorderStyle = BorderStyle.FixedSingle;
            daggerGold.Location = new Point(139, 200);
            daggerGold.Name = "daggerGold";
            daggerGold.Size = new Size(72, 23);
            daggerGold.TabIndex = 31;
            daggerGold.Text = "1";
            // 
            // daggerIron
            // 
            daggerIron.BackColor = Color.LightCyan;
            daggerIron.BorderStyle = BorderStyle.FixedSingle;
            daggerIron.Location = new Point(139, 174);
            daggerIron.Name = "daggerIron";
            daggerIron.Size = new Size(72, 23);
            daggerIron.TabIndex = 30;
            daggerIron.Text = "0";
            // 
            // onehandswordDias
            // 
            onehandswordDias.BackColor = Color.LightCyan;
            onehandswordDias.BorderStyle = BorderStyle.FixedSingle;
            onehandswordDias.Location = new Point(61, 226);
            onehandswordDias.Name = "onehandswordDias";
            onehandswordDias.Size = new Size(72, 23);
            onehandswordDias.TabIndex = 29;
            onehandswordDias.Text = "2";
            // 
            // onehandswordGold
            // 
            onehandswordGold.BackColor = Color.LightCyan;
            onehandswordGold.BorderStyle = BorderStyle.FixedSingle;
            onehandswordGold.Location = new Point(61, 200);
            onehandswordGold.Name = "onehandswordGold";
            onehandswordGold.Size = new Size(72, 23);
            onehandswordGold.TabIndex = 28;
            onehandswordGold.Text = "0";
            // 
            // onehandswordIron
            // 
            onehandswordIron.BackColor = Color.LightCyan;
            onehandswordIron.BorderStyle = BorderStyle.FixedSingle;
            onehandswordIron.Location = new Point(61, 174);
            onehandswordIron.Name = "onehandswordIron";
            onehandswordIron.Size = new Size(72, 23);
            onehandswordIron.TabIndex = 27;
            onehandswordIron.Text = "0";
            // 
            // javelinDias
            // 
            javelinDias.BackColor = Color.LightCyan;
            javelinDias.BorderStyle = BorderStyle.FixedSingle;
            javelinDias.Location = new Point(451, 226);
            javelinDias.Name = "javelinDias";
            javelinDias.Size = new Size(72, 23);
            javelinDias.TabIndex = 44;
            javelinDias.Text = "1";
            // 
            // javelinGold
            // 
            javelinGold.BackColor = Color.LightCyan;
            javelinGold.BorderStyle = BorderStyle.FixedSingle;
            javelinGold.Location = new Point(451, 200);
            javelinGold.Name = "javelinGold";
            javelinGold.Size = new Size(72, 23);
            javelinGold.TabIndex = 43;
            javelinGold.Text = "0";
            // 
            // javelinIron
            // 
            javelinIron.BackColor = Color.LightCyan;
            javelinIron.BorderStyle = BorderStyle.FixedSingle;
            javelinIron.Location = new Point(451, 174);
            javelinIron.Name = "javelinIron";
            javelinIron.Size = new Size(72, 23);
            javelinIron.TabIndex = 42;
            javelinIron.Text = "1";
            // 
            // shortBowDias
            // 
            shortBowDias.BackColor = Color.LightCyan;
            shortBowDias.BorderStyle = BorderStyle.FixedSingle;
            shortBowDias.Location = new Point(529, 226);
            shortBowDias.Name = "shortBowDias";
            shortBowDias.Size = new Size(72, 23);
            shortBowDias.TabIndex = 47;
            shortBowDias.Text = "0";
            // 
            // shortBowGold
            // 
            shortBowGold.BackColor = Color.LightCyan;
            shortBowGold.BorderStyle = BorderStyle.FixedSingle;
            shortBowGold.Location = new Point(529, 200);
            shortBowGold.Name = "shortBowGold";
            shortBowGold.Size = new Size(72, 23);
            shortBowGold.TabIndex = 46;
            shortBowGold.Text = "0";
            // 
            // shortBowIron
            // 
            shortBowIron.BackColor = Color.LightCyan;
            shortBowIron.BorderStyle = BorderStyle.FixedSingle;
            shortBowIron.Location = new Point(529, 174);
            shortBowIron.Name = "shortBowIron";
            shortBowIron.Size = new Size(72, 23);
            shortBowIron.TabIndex = 45;
            shortBowIron.Text = "1";
            // 
            // longBowDias
            // 
            longBowDias.BackColor = Color.LightCyan;
            longBowDias.BorderStyle = BorderStyle.FixedSingle;
            longBowDias.Location = new Point(607, 226);
            longBowDias.Name = "longBowDias";
            longBowDias.Size = new Size(72, 23);
            longBowDias.TabIndex = 50;
            longBowDias.Text = "1";
            // 
            // longBowGold
            // 
            longBowGold.BackColor = Color.LightCyan;
            longBowGold.BorderStyle = BorderStyle.FixedSingle;
            longBowGold.Location = new Point(607, 200);
            longBowGold.Name = "longBowGold";
            longBowGold.Size = new Size(72, 23);
            longBowGold.TabIndex = 49;
            longBowGold.Text = "0";
            // 
            // longBowIron
            // 
            longBowIron.BackColor = Color.LightCyan;
            longBowIron.BorderStyle = BorderStyle.FixedSingle;
            longBowIron.Location = new Point(607, 174);
            longBowIron.Name = "longBowIron";
            longBowIron.Size = new Size(72, 23);
            longBowIron.TabIndex = 48;
            longBowIron.Text = "0";
            // 
            // settingsDaggerLabel
            // 
            settingsDaggerLabel.AutoSize = true;
            settingsDaggerLabel.BackColor = Color.Transparent;
            settingsDaggerLabel.Font = new Font("Segoe UI", 9F);
            settingsDaggerLabel.Location = new Point(158, 156);
            settingsDaggerLabel.Name = "settingsDaggerLabel";
            settingsDaggerLabel.Size = new Size(48, 15);
            settingsDaggerLabel.TabIndex = 51;
            settingsDaggerLabel.Text = "Dagger:";
            // 
            // settingsOnehandaxeLabel
            // 
            settingsOnehandaxeLabel.AutoSize = true;
            settingsOnehandaxeLabel.BackColor = Color.Transparent;
            settingsOnehandaxeLabel.Font = new Font("Segoe UI", 9F);
            settingsOnehandaxeLabel.Location = new Point(215, 156);
            settingsOnehandaxeLabel.Name = "settingsOnehandaxeLabel";
            settingsOnehandaxeLabel.Size = new Size(77, 15);
            settingsOnehandaxeLabel.TabIndex = 52;
            settingsOnehandaxeLabel.Text = "Onehandaxe:";
            // 
            // settingsOnehandswordLabel
            // 
            settingsOnehandswordLabel.AutoSize = true;
            settingsOnehandswordLabel.BackColor = Color.Transparent;
            settingsOnehandswordLabel.Font = new Font("Segoe UI", 9F);
            settingsOnehandswordLabel.Location = new Point(52, 156);
            settingsOnehandswordLabel.Name = "settingsOnehandswordLabel";
            settingsOnehandswordLabel.Size = new Size(91, 15);
            settingsOnehandswordLabel.TabIndex = 53;
            settingsOnehandswordLabel.Text = "Onehandsword:";
            // 
            // settingsMaceLabel
            // 
            settingsMaceLabel.AutoSize = true;
            settingsMaceLabel.BackColor = Color.Transparent;
            settingsMaceLabel.Font = new Font("Segoe UI", 9F);
            settingsMaceLabel.Location = new Point(310, 156);
            settingsMaceLabel.Name = "settingsMaceLabel";
            settingsMaceLabel.Size = new Size(39, 15);
            settingsMaceLabel.TabIndex = 54;
            settingsMaceLabel.Text = "Mace:";
            // 
            // settingsTwohandaxeLabel
            // 
            settingsTwohandaxeLabel.AutoSize = true;
            settingsTwohandaxeLabel.BackColor = Color.Transparent;
            settingsTwohandaxeLabel.Font = new Font("Segoe UI", 9F);
            settingsTwohandaxeLabel.Location = new Point(368, 156);
            settingsTwohandaxeLabel.Name = "settingsTwohandaxeLabel";
            settingsTwohandaxeLabel.Size = new Size(76, 15);
            settingsTwohandaxeLabel.TabIndex = 55;
            settingsTwohandaxeLabel.Text = "Twohandaxe:";
            // 
            // settingsJavelinLabel
            // 
            settingsJavelinLabel.AutoSize = true;
            settingsJavelinLabel.BackColor = Color.Transparent;
            settingsJavelinLabel.Font = new Font("Segoe UI", 9F);
            settingsJavelinLabel.Location = new Point(466, 156);
            settingsJavelinLabel.Name = "settingsJavelinLabel";
            settingsJavelinLabel.Size = new Size(45, 15);
            settingsJavelinLabel.TabIndex = 56;
            settingsJavelinLabel.Text = "Javelin:";
            // 
            // settingsShortBowLabel
            // 
            settingsShortBowLabel.AutoSize = true;
            settingsShortBowLabel.BackColor = Color.Transparent;
            settingsShortBowLabel.Font = new Font("Segoe UI", 9F);
            settingsShortBowLabel.Location = new Point(534, 156);
            settingsShortBowLabel.Name = "settingsShortBowLabel";
            settingsShortBowLabel.Size = new Size(64, 15);
            settingsShortBowLabel.TabIndex = 57;
            settingsShortBowLabel.Text = "Short Bow:";
            // 
            // settingsLongBowLabel
            // 
            settingsLongBowLabel.AutoSize = true;
            settingsLongBowLabel.BackColor = Color.Transparent;
            settingsLongBowLabel.Font = new Font("Segoe UI", 9F);
            settingsLongBowLabel.Location = new Point(613, 156);
            settingsLongBowLabel.Name = "settingsLongBowLabel";
            settingsLongBowLabel.Size = new Size(63, 15);
            settingsLongBowLabel.TabIndex = 58;
            settingsLongBowLabel.Text = "Long Bow:";
            // 
            // settingsSaveButton
            // 
            settingsSaveButton.BackColor = Color.LightBlue;
            settingsSaveButton.FlatStyle = FlatStyle.Popup;
            settingsSaveButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            settingsSaveButton.Location = new Point(534, 103);
            settingsSaveButton.Name = "settingsSaveButton";
            settingsSaveButton.Size = new Size(145, 35);
            settingsSaveButton.TabIndex = 59;
            settingsSaveButton.Text = "Save Prices";
            settingsSaveButton.UseVisualStyleBackColor = false;
            settingsSaveButton.Click += settingsSaveButton_Click;
            // 
            // tutorial2
            // 
            tutorial2.AutoSize = true;
            tutorial2.ForeColor = Color.Green;
            tutorial2.Location = new Point(476, 24);
            tutorial2.Name = "tutorial2";
            tutorial2.Size = new Size(214, 15);
            tutorial2.TabIndex = 60;
            tutorial2.Text = "Now you may exit to begin calculating!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(451, 66);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 61;
            label4.Text = "Use only full numbers.";
            label4.Visible = false;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(692, 265);
            Controls.Add(label4);
            Controls.Add(tutorial2);
            Controls.Add(settingsSaveButton);
            Controls.Add(settingsLongBowLabel);
            Controls.Add(settingsShortBowLabel);
            Controls.Add(settingsJavelinLabel);
            Controls.Add(settingsTwohandaxeLabel);
            Controls.Add(settingsMaceLabel);
            Controls.Add(settingsOnehandswordLabel);
            Controls.Add(settingsOnehandaxeLabel);
            Controls.Add(settingsDaggerLabel);
            Controls.Add(longBowDias);
            Controls.Add(longBowGold);
            Controls.Add(longBowIron);
            Controls.Add(shortBowDias);
            Controls.Add(shortBowGold);
            Controls.Add(shortBowIron);
            Controls.Add(javelinDias);
            Controls.Add(javelinGold);
            Controls.Add(javelinIron);
            Controls.Add(twohandaxeDias);
            Controls.Add(twohandaxeGold);
            Controls.Add(twohandaxeIron);
            Controls.Add(maceDias);
            Controls.Add(maceGold);
            Controls.Add(maceIron);
            Controls.Add(onehandaxeDias);
            Controls.Add(onehandaxeGold);
            Controls.Add(onehandaxeIron);
            Controls.Add(daggerDias);
            Controls.Add(daggerGold);
            Controls.Add(daggerIron);
            Controls.Add(onehandswordDias);
            Controls.Add(onehandswordGold);
            Controls.Add(onehandswordIron);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(settingsShieldLabel);
            Controls.Add(settingsBootsLabel);
            Controls.Add(settingsLeggingsLabel);
            Controls.Add(settingsChestplateLabel);
            Controls.Add(shieldsDias);
            Controls.Add(shieldsGold);
            Controls.Add(shieldsIron);
            Controls.Add(bootsDias);
            Controls.Add(bootsGold);
            Controls.Add(bootsIron);
            Controls.Add(leggingsDias);
            Controls.Add(leggingsGold);
            Controls.Add(leggingsIron);
            Controls.Add(chestplateDias);
            Controls.Add(chestplateGold);
            Controls.Add(chestplateIron);
            Controls.Add(helmetDias);
            Controls.Add(helmetGold);
            Controls.Add(helmetIron);
            Controls.Add(settingsDiamondsLabel);
            Controls.Add(settingsGoldLabel);
            Controls.Add(settingsIronLabel);
            Controls.Add(settingsHelmetLabel);
            Controls.Add(settingsInfoLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SettingsForm";
            Text = "SettingsForm";
            FormClosed += SettingsForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label settingsInfoLabel;
        private Label settingsHelmetLabel;
        private Label settingsIronLabel;
        private Label settingsGoldLabel;
        private Label settingsDiamondsLabel;
        private TextBox helmetIron;
        private TextBox helmetGold;
        private TextBox helmetDias;
        private TextBox chestplateIron;
        private TextBox chestplateGold;
        private TextBox chestplateDias;
        private TextBox leggingsIron;
        private TextBox leggingsGold;
        private TextBox leggingsDias;
        private TextBox bootsIron;
        private TextBox bootsGold;
        private TextBox bootsDias;
        private TextBox shieldsIron;
        private TextBox shieldsGold;
        private TextBox shieldsDias;
        private Label settingsChestplateLabel;
        private Label settingsLeggingsLabel;
        private Label settingsBootsLabel;
        private Label settingsShieldLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox twohandaxeDias;
        private TextBox twohandaxeGold;
        private TextBox twohandaxeIron;
        private TextBox maceDias;
        private TextBox maceGold;
        private TextBox maceIron;
        private TextBox onehandaxeDias;
        private TextBox onehandaxeGold;
        private TextBox onehandaxeIron;
        private TextBox daggerDias;
        private TextBox daggerGold;
        private TextBox daggerIron;
        private TextBox onehandswordDias;
        private TextBox onehandswordGold;
        private TextBox onehandswordIron;
        private TextBox javelinDias;
        private TextBox javelinGold;
        private TextBox javelinIron;
        private TextBox shortBowDias;
        private TextBox shortBowGold;
        private TextBox shortBowIron;
        private TextBox longBowDias;
        private TextBox longBowGold;
        private TextBox longBowIron;
        private Label settingsDaggerLabel;
        private Label settingsOnehandaxeLabel;
        private Label settingsOnehandswordLabel;
        private Label settingsMaceLabel;
        private Label settingsTwohandaxeLabel;
        private Label settingsJavelinLabel;
        private Label settingsShortBowLabel;
        private Label settingsLongBowLabel;
        private Button settingsSaveButton;
        private Label tutorial2;
        private Label label4;
    }
}