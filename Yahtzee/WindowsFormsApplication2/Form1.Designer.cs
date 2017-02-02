namespace WindowsFormsApplication2
{
    partial class gameYahtzee
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
            this.labelOnes = new System.Windows.Forms.Label();
            this.bttnOnes = new System.Windows.Forms.Button();
            this.labelTwos = new System.Windows.Forms.Label();
            this.bttnTwos = new System.Windows.Forms.Button();
            this.bttnFours = new System.Windows.Forms.Button();
            this.labelFours = new System.Windows.Forms.Label();
            this.bttnThrees = new System.Windows.Forms.Button();
            this.labelThrees = new System.Windows.Forms.Label();
            this.bttnSixes = new System.Windows.Forms.Button();
            this.labelSixes = new System.Windows.Forms.Label();
            this.bttnFives = new System.Windows.Forms.Button();
            this.labelFives = new System.Windows.Forms.Label();
            this.labelThreeOfAKind = new System.Windows.Forms.Label();
            this.bttnThreeOfAKind = new System.Windows.Forms.Button();
            this.bttnFourOfAKind = new System.Windows.Forms.Button();
            this.labelFourOfAKind = new System.Windows.Forms.Label();
            this.bttnFullHouse = new System.Windows.Forms.Button();
            this.labelFullHouse = new System.Windows.Forms.Label();
            this.bttnSmallStraight = new System.Windows.Forms.Button();
            this.labelSmallStraight = new System.Windows.Forms.Label();
            this.bttnLargeStraight = new System.Windows.Forms.Button();
            this.labelLargeStraight = new System.Windows.Forms.Label();
            this.bttnYahtzee = new System.Windows.Forms.Button();
            this.labelYahtzee = new System.Windows.Forms.Label();
            this.bttnYahtzeeBonus = new System.Windows.Forms.Button();
            this.labelYahtzeeBonus = new System.Windows.Forms.Label();
            this.bttnChance = new System.Windows.Forms.Button();
            this.labelChance = new System.Windows.Forms.Label();
            this.labelDie1 = new System.Windows.Forms.Label();
            this.chkBoxDie1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBoxDie2 = new System.Windows.Forms.CheckBox();
            this.labelDie2 = new System.Windows.Forms.Label();
            this.chkBoxDie3 = new System.Windows.Forms.CheckBox();
            this.labelDie3 = new System.Windows.Forms.Label();
            this.chkBoxDie4 = new System.Windows.Forms.CheckBox();
            this.labelDie4 = new System.Windows.Forms.Label();
            this.chkBoxDie5 = new System.Windows.Forms.CheckBox();
            this.labelDie5 = new System.Windows.Forms.Label();
            this.bttnRoll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalScore = new System.Windows.Forms.Label();
            this.bttnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOnes
            // 
            this.labelOnes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOnes.Location = new System.Drawing.Point(12, 9);
            this.labelOnes.Name = "labelOnes";
            this.labelOnes.Size = new System.Drawing.Size(42, 22);
            this.labelOnes.TabIndex = 0;
            this.labelOnes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnOnes
            // 
            this.bttnOnes.Enabled = false;
            this.bttnOnes.Location = new System.Drawing.Point(12, 34);
            this.bttnOnes.Name = "bttnOnes";
            this.bttnOnes.Size = new System.Drawing.Size(44, 22);
            this.bttnOnes.TabIndex = 1;
            this.bttnOnes.Text = "Ones";
            this.bttnOnes.UseVisualStyleBackColor = true;
            this.bttnOnes.Click += new System.EventHandler(this.bttnOnes_Click);
            // 
            // labelTwos
            // 
            this.labelTwos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTwos.Location = new System.Drawing.Point(60, 9);
            this.labelTwos.Name = "labelTwos";
            this.labelTwos.Size = new System.Drawing.Size(42, 22);
            this.labelTwos.TabIndex = 2;
            this.labelTwos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnTwos
            // 
            this.bttnTwos.Enabled = false;
            this.bttnTwos.Location = new System.Drawing.Point(60, 34);
            this.bttnTwos.Name = "bttnTwos";
            this.bttnTwos.Size = new System.Drawing.Size(42, 22);
            this.bttnTwos.TabIndex = 3;
            this.bttnTwos.Text = "Twos";
            this.bttnTwos.UseVisualStyleBackColor = true;
            // 
            // bttnFours
            // 
            this.bttnFours.Enabled = false;
            this.bttnFours.Location = new System.Drawing.Point(163, 34);
            this.bttnFours.Name = "bttnFours";
            this.bttnFours.Size = new System.Drawing.Size(42, 22);
            this.bttnFours.TabIndex = 7;
            this.bttnFours.Text = "Fours";
            this.bttnFours.UseVisualStyleBackColor = true;
            // 
            // labelFours
            // 
            this.labelFours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFours.Location = new System.Drawing.Point(163, 9);
            this.labelFours.Name = "labelFours";
            this.labelFours.Size = new System.Drawing.Size(42, 22);
            this.labelFours.TabIndex = 6;
            this.labelFours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnThrees
            // 
            this.bttnThrees.Enabled = false;
            this.bttnThrees.Location = new System.Drawing.Point(108, 34);
            this.bttnThrees.Name = "bttnThrees";
            this.bttnThrees.Size = new System.Drawing.Size(49, 22);
            this.bttnThrees.TabIndex = 5;
            this.bttnThrees.Text = "Threes";
            this.bttnThrees.UseVisualStyleBackColor = true;
            // 
            // labelThrees
            // 
            this.labelThrees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelThrees.Location = new System.Drawing.Point(108, 9);
            this.labelThrees.Name = "labelThrees";
            this.labelThrees.Size = new System.Drawing.Size(49, 22);
            this.labelThrees.TabIndex = 4;
            this.labelThrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnSixes
            // 
            this.bttnSixes.Enabled = false;
            this.bttnSixes.Location = new System.Drawing.Point(260, 35);
            this.bttnSixes.Name = "bttnSixes";
            this.bttnSixes.Size = new System.Drawing.Size(42, 22);
            this.bttnSixes.TabIndex = 11;
            this.bttnSixes.Text = "Sixes";
            this.bttnSixes.UseVisualStyleBackColor = true;
            // 
            // labelSixes
            // 
            this.labelSixes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSixes.Location = new System.Drawing.Point(260, 9);
            this.labelSixes.Name = "labelSixes";
            this.labelSixes.Size = new System.Drawing.Size(42, 22);
            this.labelSixes.TabIndex = 10;
            this.labelSixes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnFives
            // 
            this.bttnFives.Enabled = false;
            this.bttnFives.Location = new System.Drawing.Point(210, 34);
            this.bttnFives.Name = "bttnFives";
            this.bttnFives.Size = new System.Drawing.Size(42, 22);
            this.bttnFives.TabIndex = 9;
            this.bttnFives.Text = "Fives";
            this.bttnFives.UseVisualStyleBackColor = true;
            // 
            // labelFives
            // 
            this.labelFives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFives.Location = new System.Drawing.Point(211, 9);
            this.labelFives.Name = "labelFives";
            this.labelFives.Size = new System.Drawing.Size(42, 22);
            this.labelFives.TabIndex = 8;
            this.labelFives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThreeOfAKind
            // 
            this.labelThreeOfAKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelThreeOfAKind.Location = new System.Drawing.Point(12, 97);
            this.labelThreeOfAKind.Name = "labelThreeOfAKind";
            this.labelThreeOfAKind.Size = new System.Drawing.Size(49, 22);
            this.labelThreeOfAKind.TabIndex = 12;
            this.labelThreeOfAKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnThreeOfAKind
            // 
            this.bttnThreeOfAKind.Enabled = false;
            this.bttnThreeOfAKind.Location = new System.Drawing.Point(12, 122);
            this.bttnThreeOfAKind.Name = "bttnThreeOfAKind";
            this.bttnThreeOfAKind.Size = new System.Drawing.Size(49, 47);
            this.bttnThreeOfAKind.TabIndex = 13;
            this.bttnThreeOfAKind.Text = "Three of a Kind";
            this.bttnThreeOfAKind.UseVisualStyleBackColor = true;
            this.bttnThreeOfAKind.Click += new System.EventHandler(this.bttnThreeOfAKind_Click);
            // 
            // bttnFourOfAKind
            // 
            this.bttnFourOfAKind.Enabled = false;
            this.bttnFourOfAKind.Location = new System.Drawing.Point(67, 122);
            this.bttnFourOfAKind.Name = "bttnFourOfAKind";
            this.bttnFourOfAKind.Size = new System.Drawing.Size(49, 47);
            this.bttnFourOfAKind.TabIndex = 15;
            this.bttnFourOfAKind.Text = "Four of a Kind";
            this.bttnFourOfAKind.UseVisualStyleBackColor = true;
            this.bttnFourOfAKind.Click += new System.EventHandler(this.bttnFourOfAKind_Click);
            // 
            // labelFourOfAKind
            // 
            this.labelFourOfAKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFourOfAKind.Location = new System.Drawing.Point(67, 97);
            this.labelFourOfAKind.Name = "labelFourOfAKind";
            this.labelFourOfAKind.Size = new System.Drawing.Size(49, 22);
            this.labelFourOfAKind.TabIndex = 14;
            this.labelFourOfAKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnFullHouse
            // 
            this.bttnFullHouse.Enabled = false;
            this.bttnFullHouse.Location = new System.Drawing.Point(122, 122);
            this.bttnFullHouse.Name = "bttnFullHouse";
            this.bttnFullHouse.Size = new System.Drawing.Size(49, 47);
            this.bttnFullHouse.TabIndex = 17;
            this.bttnFullHouse.Text = "Full House";
            this.bttnFullHouse.UseVisualStyleBackColor = true;
            this.bttnFullHouse.Click += new System.EventHandler(this.bttnFullHouse_Click);
            // 
            // labelFullHouse
            // 
            this.labelFullHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFullHouse.Location = new System.Drawing.Point(122, 97);
            this.labelFullHouse.Name = "labelFullHouse";
            this.labelFullHouse.Size = new System.Drawing.Size(49, 22);
            this.labelFullHouse.TabIndex = 16;
            this.labelFullHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnSmallStraight
            // 
            this.bttnSmallStraight.Enabled = false;
            this.bttnSmallStraight.Location = new System.Drawing.Point(177, 122);
            this.bttnSmallStraight.Name = "bttnSmallStraight";
            this.bttnSmallStraight.Size = new System.Drawing.Size(58, 47);
            this.bttnSmallStraight.TabIndex = 19;
            this.bttnSmallStraight.Text = "Small Straight";
            this.bttnSmallStraight.UseVisualStyleBackColor = true;
            this.bttnSmallStraight.Click += new System.EventHandler(this.bttnSmallStraight_Click);
            // 
            // labelSmallStraight
            // 
            this.labelSmallStraight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSmallStraight.Location = new System.Drawing.Point(177, 97);
            this.labelSmallStraight.Name = "labelSmallStraight";
            this.labelSmallStraight.Size = new System.Drawing.Size(58, 22);
            this.labelSmallStraight.TabIndex = 18;
            this.labelSmallStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnLargeStraight
            // 
            this.bttnLargeStraight.Enabled = false;
            this.bttnLargeStraight.Location = new System.Drawing.Point(241, 122);
            this.bttnLargeStraight.Name = "bttnLargeStraight";
            this.bttnLargeStraight.Size = new System.Drawing.Size(58, 47);
            this.bttnLargeStraight.TabIndex = 21;
            this.bttnLargeStraight.Text = "Large Straight";
            this.bttnLargeStraight.UseVisualStyleBackColor = true;
            this.bttnLargeStraight.Click += new System.EventHandler(this.bttnLargeStraight_Click);
            // 
            // labelLargeStraight
            // 
            this.labelLargeStraight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLargeStraight.Location = new System.Drawing.Point(241, 97);
            this.labelLargeStraight.Name = "labelLargeStraight";
            this.labelLargeStraight.Size = new System.Drawing.Size(58, 22);
            this.labelLargeStraight.TabIndex = 20;
            this.labelLargeStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnYahtzee
            // 
            this.bttnYahtzee.Enabled = false;
            this.bttnYahtzee.Location = new System.Drawing.Point(304, 122);
            this.bttnYahtzee.Name = "bttnYahtzee";
            this.bttnYahtzee.Size = new System.Drawing.Size(58, 47);
            this.bttnYahtzee.TabIndex = 25;
            this.bttnYahtzee.Text = "Yahtzee";
            this.bttnYahtzee.UseVisualStyleBackColor = true;
            this.bttnYahtzee.Click += new System.EventHandler(this.bttnYahtzee_Click);
            // 
            // labelYahtzee
            // 
            this.labelYahtzee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelYahtzee.Location = new System.Drawing.Point(304, 97);
            this.labelYahtzee.Name = "labelYahtzee";
            this.labelYahtzee.Size = new System.Drawing.Size(58, 22);
            this.labelYahtzee.TabIndex = 24;
            this.labelYahtzee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnYahtzeeBonus
            // 
            this.bttnYahtzeeBonus.Enabled = false;
            this.bttnYahtzeeBonus.Location = new System.Drawing.Point(368, 122);
            this.bttnYahtzeeBonus.Name = "bttnYahtzeeBonus";
            this.bttnYahtzeeBonus.Size = new System.Drawing.Size(58, 47);
            this.bttnYahtzeeBonus.TabIndex = 27;
            this.bttnYahtzeeBonus.Text = "Yahtzee Bonus";
            this.bttnYahtzeeBonus.UseVisualStyleBackColor = true;
            this.bttnYahtzeeBonus.Click += new System.EventHandler(this.bttnYahtzeeBonus_Click);
            // 
            // labelYahtzeeBonus
            // 
            this.labelYahtzeeBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelYahtzeeBonus.Location = new System.Drawing.Point(368, 97);
            this.labelYahtzeeBonus.Name = "labelYahtzeeBonus";
            this.labelYahtzeeBonus.Size = new System.Drawing.Size(58, 22);
            this.labelYahtzeeBonus.TabIndex = 26;
            this.labelYahtzeeBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnChance
            // 
            this.bttnChance.Enabled = false;
            this.bttnChance.Location = new System.Drawing.Point(432, 122);
            this.bttnChance.Name = "bttnChance";
            this.bttnChance.Size = new System.Drawing.Size(58, 47);
            this.bttnChance.TabIndex = 29;
            this.bttnChance.Text = "Chance";
            this.bttnChance.UseVisualStyleBackColor = true;
            this.bttnChance.Click += new System.EventHandler(this.bttnChance_Click);
            // 
            // labelChance
            // 
            this.labelChance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelChance.Location = new System.Drawing.Point(432, 97);
            this.labelChance.Name = "labelChance";
            this.labelChance.Size = new System.Drawing.Size(58, 22);
            this.labelChance.TabIndex = 28;
            this.labelChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDie1
            // 
            this.labelDie1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDie1.Location = new System.Drawing.Point(243, 272);
            this.labelDie1.Name = "labelDie1";
            this.labelDie1.Size = new System.Drawing.Size(20, 20);
            this.labelDie1.TabIndex = 30;
            this.labelDie1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkBoxDie1
            // 
            this.chkBoxDie1.AutoSize = true;
            this.chkBoxDie1.Location = new System.Drawing.Point(243, 295);
            this.chkBoxDie1.Name = "chkBoxDie1";
            this.chkBoxDie1.Size = new System.Drawing.Size(15, 14);
            this.chkBoxDie1.TabIndex = 31;
            this.chkBoxDie1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Select Dice to Keep:";
            // 
            // chkBoxDie2
            // 
            this.chkBoxDie2.AutoSize = true;
            this.chkBoxDie2.Location = new System.Drawing.Point(269, 295);
            this.chkBoxDie2.Name = "chkBoxDie2";
            this.chkBoxDie2.Size = new System.Drawing.Size(15, 14);
            this.chkBoxDie2.TabIndex = 34;
            this.chkBoxDie2.UseVisualStyleBackColor = true;
            // 
            // labelDie2
            // 
            this.labelDie2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDie2.Location = new System.Drawing.Point(269, 272);
            this.labelDie2.Name = "labelDie2";
            this.labelDie2.Size = new System.Drawing.Size(20, 20);
            this.labelDie2.TabIndex = 33;
            this.labelDie2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkBoxDie3
            // 
            this.chkBoxDie3.AutoSize = true;
            this.chkBoxDie3.Location = new System.Drawing.Point(295, 295);
            this.chkBoxDie3.Name = "chkBoxDie3";
            this.chkBoxDie3.Size = new System.Drawing.Size(15, 14);
            this.chkBoxDie3.TabIndex = 36;
            this.chkBoxDie3.UseVisualStyleBackColor = true;
            // 
            // labelDie3
            // 
            this.labelDie3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDie3.Location = new System.Drawing.Point(295, 272);
            this.labelDie3.Name = "labelDie3";
            this.labelDie3.Size = new System.Drawing.Size(20, 20);
            this.labelDie3.TabIndex = 35;
            this.labelDie3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkBoxDie4
            // 
            this.chkBoxDie4.AutoSize = true;
            this.chkBoxDie4.Location = new System.Drawing.Point(321, 295);
            this.chkBoxDie4.Name = "chkBoxDie4";
            this.chkBoxDie4.Size = new System.Drawing.Size(15, 14);
            this.chkBoxDie4.TabIndex = 38;
            this.chkBoxDie4.UseVisualStyleBackColor = true;
            // 
            // labelDie4
            // 
            this.labelDie4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDie4.Location = new System.Drawing.Point(321, 272);
            this.labelDie4.Name = "labelDie4";
            this.labelDie4.Size = new System.Drawing.Size(20, 20);
            this.labelDie4.TabIndex = 37;
            this.labelDie4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkBoxDie5
            // 
            this.chkBoxDie5.AutoSize = true;
            this.chkBoxDie5.Location = new System.Drawing.Point(347, 295);
            this.chkBoxDie5.Name = "chkBoxDie5";
            this.chkBoxDie5.Size = new System.Drawing.Size(15, 14);
            this.chkBoxDie5.TabIndex = 40;
            this.chkBoxDie5.UseVisualStyleBackColor = true;
            // 
            // labelDie5
            // 
            this.labelDie5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDie5.Location = new System.Drawing.Point(347, 272);
            this.labelDie5.Name = "labelDie5";
            this.labelDie5.Size = new System.Drawing.Size(20, 20);
            this.labelDie5.TabIndex = 39;
            this.labelDie5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnRoll
            // 
            this.bttnRoll.Enabled = false;
            this.bttnRoll.Location = new System.Drawing.Point(243, 336);
            this.bttnRoll.Name = "bttnRoll";
            this.bttnRoll.Size = new System.Drawing.Size(75, 23);
            this.bttnRoll.TabIndex = 41;
            this.bttnRoll.Text = "Roll";
            this.bttnRoll.UseVisualStyleBackColor = true;
            this.bttnRoll.Click += new System.EventHandler(this.bttnRoll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Total:";
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalScore.Location = new System.Drawing.Point(239, 193);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(58, 22);
            this.labelTotalScore.TabIndex = 43;
            this.labelTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnNewGame
            // 
            this.bttnNewGame.Location = new System.Drawing.Point(12, 398);
            this.bttnNewGame.Name = "bttnNewGame";
            this.bttnNewGame.Size = new System.Drawing.Size(104, 23);
            this.bttnNewGame.TabIndex = 44;
            this.bttnNewGame.Text = "Start New Game";
            this.bttnNewGame.UseVisualStyleBackColor = true;
            this.bttnNewGame.Click += new System.EventHandler(this.bttnNewGame_Click);
            // 
            // gameYahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 433);
            this.Controls.Add(this.bttnNewGame);
            this.Controls.Add(this.labelTotalScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnRoll);
            this.Controls.Add(this.chkBoxDie5);
            this.Controls.Add(this.labelDie5);
            this.Controls.Add(this.chkBoxDie4);
            this.Controls.Add(this.labelDie4);
            this.Controls.Add(this.chkBoxDie3);
            this.Controls.Add(this.labelDie3);
            this.Controls.Add(this.chkBoxDie2);
            this.Controls.Add(this.labelDie2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkBoxDie1);
            this.Controls.Add(this.labelDie1);
            this.Controls.Add(this.bttnChance);
            this.Controls.Add(this.labelChance);
            this.Controls.Add(this.bttnYahtzeeBonus);
            this.Controls.Add(this.labelYahtzeeBonus);
            this.Controls.Add(this.bttnYahtzee);
            this.Controls.Add(this.labelYahtzee);
            this.Controls.Add(this.bttnLargeStraight);
            this.Controls.Add(this.labelLargeStraight);
            this.Controls.Add(this.bttnSmallStraight);
            this.Controls.Add(this.labelSmallStraight);
            this.Controls.Add(this.bttnFullHouse);
            this.Controls.Add(this.labelFullHouse);
            this.Controls.Add(this.bttnFourOfAKind);
            this.Controls.Add(this.labelFourOfAKind);
            this.Controls.Add(this.bttnThreeOfAKind);
            this.Controls.Add(this.labelThreeOfAKind);
            this.Controls.Add(this.bttnSixes);
            this.Controls.Add(this.labelSixes);
            this.Controls.Add(this.bttnFives);
            this.Controls.Add(this.labelFives);
            this.Controls.Add(this.bttnFours);
            this.Controls.Add(this.labelFours);
            this.Controls.Add(this.bttnThrees);
            this.Controls.Add(this.labelThrees);
            this.Controls.Add(this.bttnTwos);
            this.Controls.Add(this.labelTwos);
            this.Controls.Add(this.bttnOnes);
            this.Controls.Add(this.labelOnes);
            this.Name = "gameYahtzee";
            this.Text = "Yahtzee! - A game programmed by Joshua Sexton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOnes;
        private System.Windows.Forms.Button bttnOnes;
        private System.Windows.Forms.Label labelTwos;
        private System.Windows.Forms.Button bttnTwos;
        private System.Windows.Forms.Button bttnFours;
        private System.Windows.Forms.Label labelFours;
        private System.Windows.Forms.Button bttnThrees;
        private System.Windows.Forms.Label labelThrees;
        private System.Windows.Forms.Button bttnSixes;
        private System.Windows.Forms.Label labelSixes;
        private System.Windows.Forms.Button bttnFives;
        private System.Windows.Forms.Label labelFives;
        private System.Windows.Forms.Label labelThreeOfAKind;
        private System.Windows.Forms.Button bttnThreeOfAKind;
        private System.Windows.Forms.Button bttnFourOfAKind;
        private System.Windows.Forms.Label labelFourOfAKind;
        private System.Windows.Forms.Button bttnFullHouse;
        private System.Windows.Forms.Label labelFullHouse;
        private System.Windows.Forms.Button bttnSmallStraight;
        private System.Windows.Forms.Label labelSmallStraight;
        private System.Windows.Forms.Button bttnLargeStraight;
        private System.Windows.Forms.Label labelLargeStraight;
        private System.Windows.Forms.Button bttnYahtzee;
        private System.Windows.Forms.Label labelYahtzee;
        private System.Windows.Forms.Button bttnYahtzeeBonus;
        private System.Windows.Forms.Label labelYahtzeeBonus;
        private System.Windows.Forms.Button bttnChance;
        private System.Windows.Forms.Label labelChance;
        private System.Windows.Forms.Label labelDie1;
        private System.Windows.Forms.CheckBox chkBoxDie1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBoxDie2;
        private System.Windows.Forms.Label labelDie2;
        private System.Windows.Forms.CheckBox chkBoxDie3;
        private System.Windows.Forms.Label labelDie3;
        private System.Windows.Forms.CheckBox chkBoxDie4;
        private System.Windows.Forms.Label labelDie4;
        private System.Windows.Forms.CheckBox chkBoxDie5;
        private System.Windows.Forms.Label labelDie5;
        private System.Windows.Forms.Button bttnRoll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalScore;
        private System.Windows.Forms.Button bttnNewGame;
    }
}

