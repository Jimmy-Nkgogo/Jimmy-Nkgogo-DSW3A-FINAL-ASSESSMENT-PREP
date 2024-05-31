namespace Lab1_Question_3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonThin = new System.Windows.Forms.RadioButton();
            this.radioButtonThick = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxPepperoni = new System.Windows.Forms.CheckBox();
            this.checkBoxJalapeno = new System.Windows.Forms.CheckBox();
            this.checkBoxSpinach = new System.Windows.Forms.CheckBox();
            this.checkBoxShreddedChicken = new System.Windows.Forms.CheckBox();
            this.checkBoxPineapple = new System.Windows.Forms.CheckBox();
            this.checkBoxExtraCheese = new System.Windows.Forms.CheckBox();
            this.checkBoxGroundedBeef = new System.Windows.Forms.CheckBox();
            this.checkBoxDriedShrimp = new System.Windows.Forms.CheckBox();
            this.checkBoxMushroom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab1_Question_3.Properties.Resources.classic_cheese_pizza_recipe_2_64429a0cb408b;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Hut";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLarge);
            this.groupBox1.Controls.Add(this.radioButtonMedium);
            this.groupBox1.Controls.Add(this.radioButtonSmall);
            this.groupBox1.Location = new System.Drawing.Point(13, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(39, 46);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(97, 20);
            this.radioButtonSmall.TabIndex = 0;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Small (R20)";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            this.radioButtonSmall.CheckedChanged += new System.EventHandler(this.radioButtonSmall_CheckedChanged);
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(375, 46);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(111, 20);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium (R35)";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            this.radioButtonMedium.CheckedChanged += new System.EventHandler(this.radioButtonMedium_CheckedChanged);
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(723, 46);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(98, 20);
            this.radioButtonLarge.TabIndex = 2;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Large (R55)";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            this.radioButtonLarge.CheckedChanged += new System.EventHandler(this.radioButtonLarge_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonThin);
            this.groupBox2.Controls.Add(this.radioButtonThick);
            this.groupBox2.Location = new System.Drawing.Point(13, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonThin
            // 
            this.radioButtonThin.AutoSize = true;
            this.radioButtonThin.Location = new System.Drawing.Point(558, 46);
            this.radioButtonThin.Name = "radioButtonThin";
            this.radioButtonThin.Size = new System.Drawing.Size(82, 20);
            this.radioButtonThin.TabIndex = 2;
            this.radioButtonThin.TabStop = true;
            this.radioButtonThin.Text = "Thin (R1)";
            this.radioButtonThin.UseVisualStyleBackColor = true;
            this.radioButtonThin.CheckedChanged += new System.EventHandler(this.radioButtonThin_CheckedChanged);
            // 
            // radioButtonThick
            // 
            this.radioButtonThick.AutoSize = true;
            this.radioButtonThick.Location = new System.Drawing.Point(206, 46);
            this.radioButtonThick.Name = "radioButtonThick";
            this.radioButtonThick.Size = new System.Drawing.Size(89, 20);
            this.radioButtonThick.TabIndex = 0;
            this.radioButtonThick.TabStop = true;
            this.radioButtonThick.Text = "Thick (R2)";
            this.radioButtonThick.UseVisualStyleBackColor = true;
            this.radioButtonThick.CheckedChanged += new System.EventHandler(this.radioButtonThick_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxGroundedBeef);
            this.groupBox3.Controls.Add(this.checkBoxDriedShrimp);
            this.groupBox3.Controls.Add(this.checkBoxMushroom);
            this.groupBox3.Controls.Add(this.checkBoxShreddedChicken);
            this.groupBox3.Controls.Add(this.checkBoxPineapple);
            this.groupBox3.Controls.Add(this.checkBoxExtraCheese);
            this.groupBox3.Controls.Add(this.checkBoxSpinach);
            this.groupBox3.Controls.Add(this.checkBoxJalapeno);
            this.groupBox3.Controls.Add(this.checkBoxPepperoni);
            this.groupBox3.Location = new System.Drawing.Point(12, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(847, 193);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Topping (each @ R7)";
            // 
            // checkBoxPepperoni
            // 
            this.checkBoxPepperoni.AutoSize = true;
            this.checkBoxPepperoni.Location = new System.Drawing.Point(40, 31);
            this.checkBoxPepperoni.Name = "checkBoxPepperoni";
            this.checkBoxPepperoni.Size = new System.Drawing.Size(92, 20);
            this.checkBoxPepperoni.TabIndex = 0;
            this.checkBoxPepperoni.Text = "Pepperoni";
            this.checkBoxPepperoni.UseVisualStyleBackColor = true;
            this.checkBoxPepperoni.CheckedChanged += new System.EventHandler(this.checkBoxPepperoni_CheckedChanged);
            // 
            // checkBoxJalapeno
            // 
            this.checkBoxJalapeno.AutoSize = true;
            this.checkBoxJalapeno.Location = new System.Drawing.Point(341, 31);
            this.checkBoxJalapeno.Name = "checkBoxJalapeno";
            this.checkBoxJalapeno.Size = new System.Drawing.Size(86, 20);
            this.checkBoxJalapeno.TabIndex = 1;
            this.checkBoxJalapeno.Text = "Jalapeno";
            this.checkBoxJalapeno.UseVisualStyleBackColor = true;
            this.checkBoxJalapeno.CheckedChanged += new System.EventHandler(this.checkBoxJalapeno_CheckedChanged);
            // 
            // checkBoxSpinach
            // 
            this.checkBoxSpinach.AutoSize = true;
            this.checkBoxSpinach.Location = new System.Drawing.Point(682, 31);
            this.checkBoxSpinach.Name = "checkBoxSpinach";
            this.checkBoxSpinach.Size = new System.Drawing.Size(78, 20);
            this.checkBoxSpinach.TabIndex = 2;
            this.checkBoxSpinach.Text = "Spinach";
            this.checkBoxSpinach.UseVisualStyleBackColor = true;
            // 
            // checkBoxShreddedChicken
            // 
            this.checkBoxShreddedChicken.AutoSize = true;
            this.checkBoxShreddedChicken.Location = new System.Drawing.Point(682, 86);
            this.checkBoxShreddedChicken.Name = "checkBoxShreddedChicken";
            this.checkBoxShreddedChicken.Size = new System.Drawing.Size(140, 20);
            this.checkBoxShreddedChicken.TabIndex = 5;
            this.checkBoxShreddedChicken.Text = "Shredded Chicken";
            this.checkBoxShreddedChicken.UseVisualStyleBackColor = true;
            // 
            // checkBoxPineapple
            // 
            this.checkBoxPineapple.AutoSize = true;
            this.checkBoxPineapple.Location = new System.Drawing.Point(341, 86);
            this.checkBoxPineapple.Name = "checkBoxPineapple";
            this.checkBoxPineapple.Size = new System.Drawing.Size(91, 20);
            this.checkBoxPineapple.TabIndex = 4;
            this.checkBoxPineapple.Text = "Pineapple";
            this.checkBoxPineapple.UseVisualStyleBackColor = true;
            // 
            // checkBoxExtraCheese
            // 
            this.checkBoxExtraCheese.AutoSize = true;
            this.checkBoxExtraCheese.Location = new System.Drawing.Point(40, 86);
            this.checkBoxExtraCheese.Name = "checkBoxExtraCheese";
            this.checkBoxExtraCheese.Size = new System.Drawing.Size(109, 20);
            this.checkBoxExtraCheese.TabIndex = 3;
            this.checkBoxExtraCheese.Text = "Extra Cheese";
            this.checkBoxExtraCheese.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroundedBeef
            // 
            this.checkBoxGroundedBeef.AutoSize = true;
            this.checkBoxGroundedBeef.Location = new System.Drawing.Point(682, 140);
            this.checkBoxGroundedBeef.Name = "checkBoxGroundedBeef";
            this.checkBoxGroundedBeef.Size = new System.Drawing.Size(120, 20);
            this.checkBoxGroundedBeef.TabIndex = 8;
            this.checkBoxGroundedBeef.Text = "Grounded Beef";
            this.checkBoxGroundedBeef.UseVisualStyleBackColor = true;
            // 
            // checkBoxDriedShrimp
            // 
            this.checkBoxDriedShrimp.AutoSize = true;
            this.checkBoxDriedShrimp.Location = new System.Drawing.Point(341, 140);
            this.checkBoxDriedShrimp.Name = "checkBoxDriedShrimp";
            this.checkBoxDriedShrimp.Size = new System.Drawing.Size(107, 20);
            this.checkBoxDriedShrimp.TabIndex = 7;
            this.checkBoxDriedShrimp.Text = "Dried Shrimp";
            this.checkBoxDriedShrimp.UseVisualStyleBackColor = true;
            // 
            // checkBoxMushroom
            // 
            this.checkBoxMushroom.AutoSize = true;
            this.checkBoxMushroom.Location = new System.Drawing.Point(40, 140);
            this.checkBoxMushroom.Name = "checkBoxMushroom";
            this.checkBoxMushroom.Size = new System.Drawing.Size(92, 20);
            this.checkBoxMushroom.TabIndex = 6;
            this.checkBoxMushroom.Text = "Mushroom";
            this.checkBoxMushroom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount Due: R";
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplay.Location = new System.Drawing.Point(419, 604);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(0, 25);
            this.labelDisplay.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 641);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonThin;
        private System.Windows.Forms.RadioButton radioButtonThick;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxSpinach;
        private System.Windows.Forms.CheckBox checkBoxJalapeno;
        private System.Windows.Forms.CheckBox checkBoxPepperoni;
        private System.Windows.Forms.CheckBox checkBoxGroundedBeef;
        private System.Windows.Forms.CheckBox checkBoxDriedShrimp;
        private System.Windows.Forms.CheckBox checkBoxMushroom;
        private System.Windows.Forms.CheckBox checkBoxShreddedChicken;
        private System.Windows.Forms.CheckBox checkBoxPineapple;
        private System.Windows.Forms.CheckBox checkBoxExtraCheese;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDisplay;
    }
}

