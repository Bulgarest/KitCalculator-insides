namespace KitCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            version = new Label();
            settingsButton = new Button();
            ironTextBox = new TextBox();
            infoLabel = new Label();
            ironLabel = new Label();
            goldTextBox = new TextBox();
            diasTextBox = new TextBox();
            goldLabel = new Label();
            diamondsLabel = new Label();
            calcButton = new Button();
            helmetCheckBox = new CheckBox();
            chestplateCheckBox = new CheckBox();
            leggingsCheckBox = new CheckBox();
            bootsCheckBox = new CheckBox();
            shieldCheckBox = new CheckBox();
            onehandswordCheckBox = new CheckBox();
            daggerCheckBox = new CheckBox();
            onehandaxeCheckBox = new CheckBox();
            maceCheckBox = new CheckBox();
            twohandaxeCheckBox = new CheckBox();
            javelinCheckBox = new CheckBox();
            shortBowCheckBox = new CheckBox();
            longBowCheckBox = new CheckBox();
            settingLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            revCalcCountTextBox = new TextBox();
            reverseCalcButton = new Button();
            resultLabel = new Label();
            errorLabel = new Label();
            tutorial = new Label();
            SuspendLayout();
            // 
            // version
            // 
            version.AutoSize = true;
            version.BackColor = Color.Transparent;
            version.Location = new Point(-2, 404);
            version.Name = "version";
            version.Size = new Size(375, 15);
            version.TabIndex = 0;
            version.Text = "v1.0.2 by Bulgarest (discord: bulgarest); If there are any errors, DM me.\r\n";
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.LightBlue;
            settingsButton.FlatStyle = FlatStyle.Popup;
            settingsButton.Font = new Font("Segoe UI", 11.25F);
            settingsButton.Location = new Point(400, 12);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(78, 37);
            settingsButton.TabIndex = 1;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // ironTextBox
            // 
            ironTextBox.BackColor = Color.LightCyan;
            ironTextBox.BorderStyle = BorderStyle.FixedSingle;
            ironTextBox.Enabled = false;
            ironTextBox.Location = new Point(59, 151);
            ironTextBox.Name = "ironTextBox";
            ironTextBox.Size = new Size(79, 23);
            ironTextBox.TabIndex = 2;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.BackColor = Color.Transparent;
            infoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoLabel.Location = new Point(12, 12);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(386, 105);
            infoLabel.TabIndex = 3;
            infoLabel.Text = resources.GetString("infoLabel.Text");
            infoLabel.Visible = false;
            // 
            // ironLabel
            // 
            ironLabel.AutoSize = true;
            ironLabel.BackColor = Color.Transparent;
            ironLabel.Font = new Font("Segoe UI", 11.25F);
            ironLabel.Location = new Point(15, 154);
            ironLabel.Name = "ironLabel";
            ironLabel.Size = new Size(38, 20);
            ironLabel.TabIndex = 4;
            ironLabel.Text = "Iron:";
            // 
            // goldTextBox
            // 
            goldTextBox.BackColor = Color.LightCyan;
            goldTextBox.BorderStyle = BorderStyle.FixedSingle;
            goldTextBox.Enabled = false;
            goldTextBox.Location = new Point(59, 180);
            goldTextBox.Name = "goldTextBox";
            goldTextBox.Size = new Size(79, 23);
            goldTextBox.TabIndex = 5;
            // 
            // diasTextBox
            // 
            diasTextBox.BackColor = Color.LightCyan;
            diasTextBox.BorderStyle = BorderStyle.FixedSingle;
            diasTextBox.Enabled = false;
            diasTextBox.Location = new Point(59, 210);
            diasTextBox.Name = "diasTextBox";
            diasTextBox.Size = new Size(79, 23);
            diasTextBox.TabIndex = 6;
            // 
            // goldLabel
            // 
            goldLabel.AutoSize = true;
            goldLabel.BackColor = Color.Transparent;
            goldLabel.Font = new Font("Segoe UI", 11.25F);
            goldLabel.Location = new Point(9, 183);
            goldLabel.Name = "goldLabel";
            goldLabel.Size = new Size(44, 20);
            goldLabel.TabIndex = 7;
            goldLabel.Text = "Gold:";
            // 
            // diamondsLabel
            // 
            diamondsLabel.AutoSize = true;
            diamondsLabel.BackColor = Color.Transparent;
            diamondsLabel.Font = new Font("Segoe UI", 11.25F);
            diamondsLabel.Location = new Point(12, 213);
            diamondsLabel.Name = "diamondsLabel";
            diamondsLabel.Size = new Size(41, 20);
            diamondsLabel.TabIndex = 8;
            diamondsLabel.Text = "Dias:";
            // 
            // calcButton
            // 
            calcButton.BackColor = Color.LightBlue;
            calcButton.Enabled = false;
            calcButton.FlatStyle = FlatStyle.Popup;
            calcButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            calcButton.Location = new Point(59, 241);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(79, 32);
            calcButton.TabIndex = 9;
            calcButton.Text = "Calculate";
            calcButton.UseVisualStyleBackColor = false;
            calcButton.Click += calcButton_Click;
            // 
            // helmetCheckBox
            // 
            helmetCheckBox.AutoSize = true;
            helmetCheckBox.BackColor = Color.Transparent;
            helmetCheckBox.Enabled = false;
            helmetCheckBox.FlatStyle = FlatStyle.Popup;
            helmetCheckBox.Location = new Point(378, 150);
            helmetCheckBox.Name = "helmetCheckBox";
            helmetCheckBox.Size = new Size(63, 19);
            helmetCheckBox.TabIndex = 10;
            helmetCheckBox.Text = "Helmet";
            helmetCheckBox.UseVisualStyleBackColor = false;
            // 
            // chestplateCheckBox
            // 
            chestplateCheckBox.AutoSize = true;
            chestplateCheckBox.BackColor = Color.Transparent;
            chestplateCheckBox.Enabled = false;
            chestplateCheckBox.FlatStyle = FlatStyle.Popup;
            chestplateCheckBox.Location = new Point(378, 170);
            chestplateCheckBox.Name = "chestplateCheckBox";
            chestplateCheckBox.Size = new Size(80, 19);
            chestplateCheckBox.TabIndex = 11;
            chestplateCheckBox.Text = "Chestplate";
            chestplateCheckBox.UseVisualStyleBackColor = false;
            // 
            // leggingsCheckBox
            // 
            leggingsCheckBox.AutoSize = true;
            leggingsCheckBox.BackColor = Color.Transparent;
            leggingsCheckBox.Enabled = false;
            leggingsCheckBox.FlatStyle = FlatStyle.Popup;
            leggingsCheckBox.Location = new Point(378, 190);
            leggingsCheckBox.Name = "leggingsCheckBox";
            leggingsCheckBox.Size = new Size(72, 19);
            leggingsCheckBox.TabIndex = 12;
            leggingsCheckBox.Text = "Leggings";
            leggingsCheckBox.UseVisualStyleBackColor = false;
            // 
            // bootsCheckBox
            // 
            bootsCheckBox.AutoSize = true;
            bootsCheckBox.BackColor = Color.Transparent;
            bootsCheckBox.Enabled = false;
            bootsCheckBox.FlatStyle = FlatStyle.Popup;
            bootsCheckBox.Location = new Point(378, 210);
            bootsCheckBox.Name = "bootsCheckBox";
            bootsCheckBox.Size = new Size(54, 19);
            bootsCheckBox.TabIndex = 13;
            bootsCheckBox.Text = "Boots";
            bootsCheckBox.UseVisualStyleBackColor = false;
            // 
            // shieldCheckBox
            // 
            shieldCheckBox.AutoSize = true;
            shieldCheckBox.BackColor = Color.Transparent;
            shieldCheckBox.Enabled = false;
            shieldCheckBox.FlatStyle = FlatStyle.Popup;
            shieldCheckBox.Location = new Point(378, 230);
            shieldCheckBox.Name = "shieldCheckBox";
            shieldCheckBox.Size = new Size(56, 19);
            shieldCheckBox.TabIndex = 14;
            shieldCheckBox.Text = "Shield";
            shieldCheckBox.UseVisualStyleBackColor = false;
            // 
            // onehandswordCheckBox
            // 
            onehandswordCheckBox.AutoSize = true;
            onehandswordCheckBox.BackColor = Color.Transparent;
            onehandswordCheckBox.Enabled = false;
            onehandswordCheckBox.FlatStyle = FlatStyle.Popup;
            onehandswordCheckBox.Location = new Point(378, 250);
            onehandswordCheckBox.Name = "onehandswordCheckBox";
            onehandswordCheckBox.Size = new Size(105, 19);
            onehandswordCheckBox.TabIndex = 15;
            onehandswordCheckBox.Text = "Onehandsword";
            onehandswordCheckBox.UseVisualStyleBackColor = false;
            // 
            // daggerCheckBox
            // 
            daggerCheckBox.AutoSize = true;
            daggerCheckBox.BackColor = Color.Transparent;
            daggerCheckBox.Enabled = false;
            daggerCheckBox.FlatStyle = FlatStyle.Popup;
            daggerCheckBox.Location = new Point(378, 270);
            daggerCheckBox.Name = "daggerCheckBox";
            daggerCheckBox.Size = new Size(62, 19);
            daggerCheckBox.TabIndex = 16;
            daggerCheckBox.Text = "Dagger";
            daggerCheckBox.UseVisualStyleBackColor = false;
            // 
            // onehandaxeCheckBox
            // 
            onehandaxeCheckBox.AutoSize = true;
            onehandaxeCheckBox.BackColor = Color.Transparent;
            onehandaxeCheckBox.Enabled = false;
            onehandaxeCheckBox.FlatStyle = FlatStyle.Popup;
            onehandaxeCheckBox.Location = new Point(378, 290);
            onehandaxeCheckBox.Name = "onehandaxeCheckBox";
            onehandaxeCheckBox.Size = new Size(91, 19);
            onehandaxeCheckBox.TabIndex = 17;
            onehandaxeCheckBox.Text = "Onehandaxe";
            onehandaxeCheckBox.UseVisualStyleBackColor = false;
            // 
            // maceCheckBox
            // 
            maceCheckBox.AutoSize = true;
            maceCheckBox.BackColor = Color.Transparent;
            maceCheckBox.Enabled = false;
            maceCheckBox.FlatStyle = FlatStyle.Popup;
            maceCheckBox.Location = new Point(378, 310);
            maceCheckBox.Name = "maceCheckBox";
            maceCheckBox.Size = new Size(53, 19);
            maceCheckBox.TabIndex = 18;
            maceCheckBox.Text = "Mace";
            maceCheckBox.UseVisualStyleBackColor = false;
            // 
            // twohandaxeCheckBox
            // 
            twohandaxeCheckBox.AutoSize = true;
            twohandaxeCheckBox.BackColor = Color.Transparent;
            twohandaxeCheckBox.Enabled = false;
            twohandaxeCheckBox.FlatStyle = FlatStyle.Popup;
            twohandaxeCheckBox.Location = new Point(378, 330);
            twohandaxeCheckBox.Name = "twohandaxeCheckBox";
            twohandaxeCheckBox.Size = new Size(90, 19);
            twohandaxeCheckBox.TabIndex = 19;
            twohandaxeCheckBox.Text = "Twohandaxe";
            twohandaxeCheckBox.UseVisualStyleBackColor = false;
            // 
            // javelinCheckBox
            // 
            javelinCheckBox.AutoSize = true;
            javelinCheckBox.BackColor = Color.Transparent;
            javelinCheckBox.Enabled = false;
            javelinCheckBox.FlatStyle = FlatStyle.Popup;
            javelinCheckBox.Location = new Point(378, 350);
            javelinCheckBox.Name = "javelinCheckBox";
            javelinCheckBox.Size = new Size(59, 19);
            javelinCheckBox.TabIndex = 20;
            javelinCheckBox.Text = "Javelin";
            javelinCheckBox.UseVisualStyleBackColor = false;
            // 
            // shortBowCheckBox
            // 
            shortBowCheckBox.AutoSize = true;
            shortBowCheckBox.BackColor = Color.Transparent;
            shortBowCheckBox.Enabled = false;
            shortBowCheckBox.FlatStyle = FlatStyle.Popup;
            shortBowCheckBox.Location = new Point(378, 370);
            shortBowCheckBox.Name = "shortBowCheckBox";
            shortBowCheckBox.Size = new Size(78, 19);
            shortBowCheckBox.TabIndex = 21;
            shortBowCheckBox.Text = "Short Bow";
            shortBowCheckBox.UseVisualStyleBackColor = false;
            // 
            // longBowCheckBox
            // 
            longBowCheckBox.AutoSize = true;
            longBowCheckBox.BackColor = Color.Transparent;
            longBowCheckBox.Enabled = false;
            longBowCheckBox.FlatStyle = FlatStyle.Popup;
            longBowCheckBox.Location = new Point(378, 390);
            longBowCheckBox.Name = "longBowCheckBox";
            longBowCheckBox.Size = new Size(77, 19);
            longBowCheckBox.TabIndex = 22;
            longBowCheckBox.Text = "Long Bow";
            longBowCheckBox.UseVisualStyleBackColor = false;
            // 
            // settingLabel
            // 
            settingLabel.AutoSize = true;
            settingLabel.BackColor = Color.Transparent;
            settingLabel.Location = new Point(378, 132);
            settingLabel.Name = "settingLabel";
            settingLabel.Size = new Size(82, 15);
            settingLabel.TabIndex = 23;
            settingLabel.Text = "Make your kit:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(208, 154);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 24;
            label1.Text = "Reverse calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(159, 180);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 25;
            label2.Text = "Count:";
            // 
            // revCalcCountTextBox
            // 
            revCalcCountTextBox.BackColor = Color.LightCyan;
            revCalcCountTextBox.BorderStyle = BorderStyle.FixedSingle;
            revCalcCountTextBox.Enabled = false;
            revCalcCountTextBox.Location = new Point(208, 177);
            revCalcCountTextBox.Name = "revCalcCountTextBox";
            revCalcCountTextBox.Size = new Size(53, 23);
            revCalcCountTextBox.TabIndex = 26;
            // 
            // reverseCalcButton
            // 
            reverseCalcButton.BackColor = Color.LightBlue;
            reverseCalcButton.Enabled = false;
            reverseCalcButton.FlatStyle = FlatStyle.Popup;
            reverseCalcButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            reverseCalcButton.Location = new Point(208, 206);
            reverseCalcButton.Name = "reverseCalcButton";
            reverseCalcButton.Size = new Size(79, 32);
            reverseCalcButton.TabIndex = 27;
            reverseCalcButton.Text = "Calculate";
            reverseCalcButton.UseVisualStyleBackColor = false;
            reverseCalcButton.Click += reverseCalcButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.BackColor = Color.Transparent;
            resultLabel.Location = new Point(5, 279);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(133, 30);
            resultLabel.TabIndex = 28;
            resultLabel.Text = "Results will appear here.\r\n\r\n";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.FromArgb(220, 0, 0);
            errorLabel.Location = new Point(144, 250);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(125, 15);
            errorLabel.TabIndex = 29;
            errorLabel.Text = "Use only full numbers.";
            errorLabel.Visible = false;
            // 
            // tutorial
            // 
            tutorial.AutoSize = true;
            tutorial.ForeColor = Color.Green;
            tutorial.Location = new Point(63, 12);
            tutorial.Name = "tutorial";
            tutorial.Size = new Size(335, 45);
            tutorial.TabIndex = 30;
            tutorial.Text = "Greetings. This is a small project I made that makes it easier to \r\ncalculate how much your kits cost.\r\nBefore you start, check out the settings page.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(484, 419);
            Controls.Add(tutorial);
            Controls.Add(errorLabel);
            Controls.Add(resultLabel);
            Controls.Add(reverseCalcButton);
            Controls.Add(revCalcCountTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(settingLabel);
            Controls.Add(longBowCheckBox);
            Controls.Add(shortBowCheckBox);
            Controls.Add(javelinCheckBox);
            Controls.Add(twohandaxeCheckBox);
            Controls.Add(maceCheckBox);
            Controls.Add(onehandaxeCheckBox);
            Controls.Add(daggerCheckBox);
            Controls.Add(onehandswordCheckBox);
            Controls.Add(shieldCheckBox);
            Controls.Add(bootsCheckBox);
            Controls.Add(leggingsCheckBox);
            Controls.Add(chestplateCheckBox);
            Controls.Add(helmetCheckBox);
            Controls.Add(calcButton);
            Controls.Add(diamondsLabel);
            Controls.Add(goldLabel);
            Controls.Add(diasTextBox);
            Controls.Add(goldTextBox);
            Controls.Add(ironLabel);
            Controls.Add(infoLabel);
            Controls.Add(ironTextBox);
            Controls.Add(settingsButton);
            Controls.Add(version);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Crusalis Kit Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label version;
        private Button settingsButton;
        private TextBox ironTextBox;
        private Label infoLabel;
        private Label ironLabel;
        private TextBox goldTextBox;
        private TextBox diasTextBox;
        private Label goldLabel;
        private Label diamondsLabel;
        private Button calcButton;
        private CheckBox helmetCheckBox;
        private CheckBox chestplateCheckBox;
        private CheckBox leggingsCheckBox;
        private CheckBox bootsCheckBox;
        private CheckBox shieldCheckBox;
        private CheckBox onehandswordCheckBox;
        private CheckBox daggerCheckBox;
        private CheckBox onehandaxeCheckBox;
        private CheckBox maceCheckBox;
        private CheckBox twohandaxeCheckBox;
        private CheckBox javelinCheckBox;
        private CheckBox shortBowCheckBox;
        private CheckBox longBowCheckBox;
        private Label settingLabel;
        private Label label1;
        private Label label2;
        private TextBox revCalcCountTextBox;
        private Button reverseCalcButton;
        private Label resultLabel;
        private Label errorLabel;
        private Label tutorial;
    }
}
