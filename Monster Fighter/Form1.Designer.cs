namespace Monster_Fighter
{
    partial class Form1
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
            this.textBoxPlayerHealth = new System.Windows.Forms.TextBox();
            this.textBoxPlayerScore = new System.Windows.Forms.TextBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonDecreaseScore = new System.Windows.Forms.Button();
            this.buttonIncreaseScore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPlayerLives = new System.Windows.Forms.TextBox();
            this.buttonAddLives = new System.Windows.Forms.Button();
            this.buttonRemLives = new System.Windows.Forms.Button();
            this.groupBoxCurrentWeapon = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGenerateRandomWeapon = new System.Windows.Forms.Button();
            this.buttonDropWeapon = new System.Windows.Forms.Button();
            this.textBoxWeaponAttackPower = new System.Windows.Forms.TextBox();
            this.textBoxWeaponName = new System.Windows.Forms.TextBox();
            this.textBoxWeaponType = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonGenerateRandomArmour = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonDropArmour = new System.Windows.Forms.Button();
            this.textBoxArmourDefencePower = new System.Windows.Forms.TextBox();
            this.textBoxArmourType = new System.Windows.Forms.TextBox();
            this.textBoxArmourName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxCurrentWeapon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPlayerHealth
            // 
            this.textBoxPlayerHealth.Location = new System.Drawing.Point(122, 133);
            this.textBoxPlayerHealth.Name = "textBoxPlayerHealth";
            this.textBoxPlayerHealth.Size = new System.Drawing.Size(101, 20);
            this.textBoxPlayerHealth.TabIndex = 1;
            // 
            // textBoxPlayerScore
            // 
            this.textBoxPlayerScore.Location = new System.Drawing.Point(122, 107);
            this.textBoxPlayerScore.Name = "textBoxPlayerScore";
            this.textBoxPlayerScore.Size = new System.Drawing.Size(101, 20);
            this.textBoxPlayerScore.TabIndex = 3;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(122, 81);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(101, 20);
            this.textBoxPlayerName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Health";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(72, 185);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 9;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(153, 185);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonDecreaseScore
            // 
            this.buttonDecreaseScore.Location = new System.Drawing.Point(327, 105);
            this.buttonDecreaseScore.Name = "buttonDecreaseScore";
            this.buttonDecreaseScore.Size = new System.Drawing.Size(92, 22);
            this.buttonDecreaseScore.TabIndex = 12;
            this.buttonDecreaseScore.Text = "Decrease Score";
            this.buttonDecreaseScore.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonDecreaseScore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDecreaseScore.UseVisualStyleBackColor = true;
            this.buttonDecreaseScore.Click += new System.EventHandler(this.buttonDecreaseScore_Click);
            // 
            // buttonIncreaseScore
            // 
            this.buttonIncreaseScore.Location = new System.Drawing.Point(229, 105);
            this.buttonIncreaseScore.Name = "buttonIncreaseScore";
            this.buttonIncreaseScore.Size = new System.Drawing.Size(92, 22);
            this.buttonIncreaseScore.TabIndex = 13;
            this.buttonIncreaseScore.Text = "Increase Score";
            this.buttonIncreaseScore.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonIncreaseScore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonIncreaseScore.UseVisualStyleBackColor = true;
            this.buttonIncreaseScore.Click += new System.EventHandler(this.buttonIncreaseScore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lives";
            // 
            // textBoxPlayerLives
            // 
            this.textBoxPlayerLives.Location = new System.Drawing.Point(122, 159);
            this.textBoxPlayerLives.Name = "textBoxPlayerLives";
            this.textBoxPlayerLives.Size = new System.Drawing.Size(101, 20);
            this.textBoxPlayerLives.TabIndex = 14;
            // 
            // buttonAddLives
            // 
            this.buttonAddLives.Location = new System.Drawing.Point(229, 159);
            this.buttonAddLives.Name = "buttonAddLives";
            this.buttonAddLives.Size = new System.Drawing.Size(92, 21);
            this.buttonAddLives.TabIndex = 16;
            this.buttonAddLives.Text = "Add Lives";
            this.buttonAddLives.UseVisualStyleBackColor = true;
            this.buttonAddLives.Click += new System.EventHandler(this.buttonAddLives_Click);
            // 
            // buttonRemLives
            // 
            this.buttonRemLives.Location = new System.Drawing.Point(327, 159);
            this.buttonRemLives.Name = "buttonRemLives";
            this.buttonRemLives.Size = new System.Drawing.Size(92, 21);
            this.buttonRemLives.TabIndex = 17;
            this.buttonRemLives.Text = "Subtract Lives";
            this.buttonRemLives.UseVisualStyleBackColor = true;
            this.buttonRemLives.Click += new System.EventHandler(this.buttonRemLives_Click);
            // 
            // groupBoxCurrentWeapon
            // 
            this.groupBoxCurrentWeapon.Controls.Add(this.label7);
            this.groupBoxCurrentWeapon.Controls.Add(this.label6);
            this.groupBoxCurrentWeapon.Controls.Add(this.label5);
            this.groupBoxCurrentWeapon.Controls.Add(this.buttonGenerateRandomWeapon);
            this.groupBoxCurrentWeapon.Controls.Add(this.buttonDropWeapon);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponAttackPower);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponName);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponType);
            this.groupBoxCurrentWeapon.Location = new System.Drawing.Point(72, 228);
            this.groupBoxCurrentWeapon.Name = "groupBoxCurrentWeapon";
            this.groupBoxCurrentWeapon.Size = new System.Drawing.Size(291, 146);
            this.groupBoxCurrentWeapon.TabIndex = 18;
            this.groupBoxCurrentWeapon.TabStop = false;
            this.groupBoxCurrentWeapon.Text = "Current Weapon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Attack Power:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonGenerateRandomWeapon
            // 
            this.buttonGenerateRandomWeapon.Location = new System.Drawing.Point(17, 100);
            this.buttonGenerateRandomWeapon.Name = "buttonGenerateRandomWeapon";
            this.buttonGenerateRandomWeapon.Size = new System.Drawing.Size(120, 40);
            this.buttonGenerateRandomWeapon.TabIndex = 4;
            this.buttonGenerateRandomWeapon.Text = "Generate Random Weapon";
            this.buttonGenerateRandomWeapon.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomWeapon.Click += new System.EventHandler(this.buttonGenerateRandomWeapon_Click);
            // 
            // buttonDropWeapon
            // 
            this.buttonDropWeapon.Location = new System.Drawing.Point(154, 100);
            this.buttonDropWeapon.Name = "buttonDropWeapon";
            this.buttonDropWeapon.Size = new System.Drawing.Size(115, 40);
            this.buttonDropWeapon.TabIndex = 3;
            this.buttonDropWeapon.Text = "Drop Weapon";
            this.buttonDropWeapon.UseVisualStyleBackColor = true;
            this.buttonDropWeapon.Click += new System.EventHandler(this.buttonDropWeapon_Click);
            // 
            // textBoxWeaponAttackPower
            // 
            this.textBoxWeaponAttackPower.Location = new System.Drawing.Point(96, 74);
            this.textBoxWeaponAttackPower.Name = "textBoxWeaponAttackPower";
            this.textBoxWeaponAttackPower.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeaponAttackPower.TabIndex = 2;
            // 
            // textBoxWeaponName
            // 
            this.textBoxWeaponName.Location = new System.Drawing.Point(96, 19);
            this.textBoxWeaponName.Name = "textBoxWeaponName";
            this.textBoxWeaponName.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeaponName.TabIndex = 1;
            // 
            // textBoxWeaponType
            // 
            this.textBoxWeaponType.Location = new System.Drawing.Point(96, 48);
            this.textBoxWeaponType.Name = "textBoxWeaponType";
            this.textBoxWeaponType.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeaponType.TabIndex = 0;
            this.textBoxWeaponType.TextChanged += new System.EventHandler(this.textBoxWeaponName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.buttonGenerateRandomArmour);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.buttonDropArmour);
            this.groupBox1.Controls.Add(this.textBoxArmourDefencePower);
            this.groupBox1.Controls.Add(this.textBoxArmourType);
            this.groupBox1.Controls.Add(this.textBoxArmourName);
            this.groupBox1.Location = new System.Drawing.Point(72, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 146);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Armour";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Defence Power:";
            // 
            // buttonGenerateRandomArmour
            // 
            this.buttonGenerateRandomArmour.Location = new System.Drawing.Point(17, 100);
            this.buttonGenerateRandomArmour.Name = "buttonGenerateRandomArmour";
            this.buttonGenerateRandomArmour.Size = new System.Drawing.Size(120, 40);
            this.buttonGenerateRandomArmour.TabIndex = 4;
            this.buttonGenerateRandomArmour.Text = "Generate Random Armour";
            this.buttonGenerateRandomArmour.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomArmour.Click += new System.EventHandler(this.buttonGenerateRandomArmour_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Name:";
            // 
            // buttonDropArmour
            // 
            this.buttonDropArmour.Location = new System.Drawing.Point(154, 100);
            this.buttonDropArmour.Name = "buttonDropArmour";
            this.buttonDropArmour.Size = new System.Drawing.Size(115, 40);
            this.buttonDropArmour.TabIndex = 3;
            this.buttonDropArmour.Text = "Drop Armour";
            this.buttonDropArmour.UseVisualStyleBackColor = true;
            this.buttonDropArmour.Click += new System.EventHandler(this.buttonDropArmour_Click);
            // 
            // textBoxArmourDefencePower
            // 
            this.textBoxArmourDefencePower.Location = new System.Drawing.Point(96, 74);
            this.textBoxArmourDefencePower.Name = "textBoxArmourDefencePower";
            this.textBoxArmourDefencePower.Size = new System.Drawing.Size(100, 20);
            this.textBoxArmourDefencePower.TabIndex = 2;
            // 
            // textBoxArmourType
            // 
            this.textBoxArmourType.Location = new System.Drawing.Point(96, 48);
            this.textBoxArmourType.Name = "textBoxArmourType";
            this.textBoxArmourType.Size = new System.Drawing.Size(100, 20);
            this.textBoxArmourType.TabIndex = 1;
            // 
            // textBoxArmourName
            // 
            this.textBoxArmourName.Location = new System.Drawing.Point(96, 19);
            this.textBoxArmourName.Name = "textBoxArmourName";
            this.textBoxArmourName.Size = new System.Drawing.Size(100, 20);
            this.textBoxArmourName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCurrentWeapon);
            this.Controls.Add(this.buttonRemLives);
            this.Controls.Add(this.buttonAddLives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPlayerLives);
            this.Controls.Add(this.buttonIncreaseScore);
            this.Controls.Add(this.buttonDecreaseScore);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.textBoxPlayerScore);
            this.Controls.Add(this.textBoxPlayerHealth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCurrentWeapon.ResumeLayout(false);
            this.groupBoxCurrentWeapon.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPlayerHealth;
        private System.Windows.Forms.TextBox textBoxPlayerScore;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDecreaseScore;
        private System.Windows.Forms.Button buttonIncreaseScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPlayerLives;
        private System.Windows.Forms.Button buttonAddLives;
        private System.Windows.Forms.Button buttonRemLives;
        private System.Windows.Forms.GroupBox groupBoxCurrentWeapon;
        private System.Windows.Forms.Button buttonGenerateRandomWeapon;
        private System.Windows.Forms.Button buttonDropWeapon;
        private System.Windows.Forms.TextBox textBoxWeaponAttackPower;
        private System.Windows.Forms.TextBox textBoxWeaponName;
        private System.Windows.Forms.TextBox textBoxWeaponType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGenerateRandomArmour;
        private System.Windows.Forms.Button buttonDropArmour;
        private System.Windows.Forms.TextBox textBoxArmourDefencePower;
        private System.Windows.Forms.TextBox textBoxArmourType;
        private System.Windows.Forms.TextBox textBoxArmourName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}

