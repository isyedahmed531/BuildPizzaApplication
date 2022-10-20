namespace BuildPizzaApplication
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
            this.grpBoxSize = new System.Windows.Forms.GroupBox();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.grpBoxTopping = new System.Windows.Forms.GroupBox();
            this.checkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.checkBoxOnions = new System.Windows.Forms.CheckBox();
            this.checkBoxMashrooms = new System.Windows.Forms.CheckBox();
            this.checkBoxExtraCheese = new System.Windows.Forms.CheckBox();
            this.grpBox3 = new System.Windows.Forms.GroupBox();
            this.radioThickCrust = new System.Windows.Forms.RadioButton();
            this.radioThinCrust = new System.Windows.Forms.RadioButton();
            this.radioEatIn = new System.Windows.Forms.RadioButton();
            this.radioTakeAway = new System.Windows.Forms.RadioButton();
            this.btnBuildPizza = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxSize.SuspendLayout();
            this.grpBoxTopping.SuspendLayout();
            this.grpBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSize
            // 
            this.grpBoxSize.Controls.Add(this.radioLarge);
            this.grpBoxSize.Controls.Add(this.radioMedium);
            this.grpBoxSize.Controls.Add(this.radioSmall);
            this.grpBoxSize.Location = new System.Drawing.Point(34, 30);
            this.grpBoxSize.Name = "grpBoxSize";
            this.grpBoxSize.Size = new System.Drawing.Size(340, 183);
            this.grpBoxSize.TabIndex = 0;
            this.grpBoxSize.TabStop = false;
            this.grpBoxSize.Text = "Size";
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Location = new System.Drawing.Point(49, 122);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(67, 24);
            this.radioLarge.TabIndex = 2;
            this.radioLarge.TabStop = true;
            this.radioLarge.Text = "Large";
            this.radioLarge.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Location = new System.Drawing.Point(49, 82);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(85, 24);
            this.radioMedium.TabIndex = 1;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Location = new System.Drawing.Point(49, 42);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(67, 24);
            this.radioSmall.TabIndex = 0;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "Small";
            this.radioSmall.UseVisualStyleBackColor = true;
            // 
            // grpBoxTopping
            // 
            this.grpBoxTopping.Controls.Add(this.checkBoxTomatoes);
            this.grpBoxTopping.Controls.Add(this.checkBoxOnions);
            this.grpBoxTopping.Controls.Add(this.checkBoxMashrooms);
            this.grpBoxTopping.Controls.Add(this.checkBoxExtraCheese);
            this.grpBoxTopping.Location = new System.Drawing.Point(401, 30);
            this.grpBoxTopping.Name = "grpBoxTopping";
            this.grpBoxTopping.Size = new System.Drawing.Size(343, 183);
            this.grpBoxTopping.TabIndex = 1;
            this.grpBoxTopping.TabStop = false;
            this.grpBoxTopping.Text = "Toppings";
            // 
            // checkBoxTomatoes
            // 
            this.checkBoxTomatoes.AutoSize = true;
            this.checkBoxTomatoes.Location = new System.Drawing.Point(72, 132);
            this.checkBoxTomatoes.Name = "checkBoxTomatoes";
            this.checkBoxTomatoes.Size = new System.Drawing.Size(96, 24);
            this.checkBoxTomatoes.TabIndex = 3;
            this.checkBoxTomatoes.Text = "Tomatoes";
            this.checkBoxTomatoes.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnions
            // 
            this.checkBoxOnions.AutoSize = true;
            this.checkBoxOnions.Location = new System.Drawing.Point(72, 102);
            this.checkBoxOnions.Name = "checkBoxOnions";
            this.checkBoxOnions.Size = new System.Drawing.Size(77, 24);
            this.checkBoxOnions.TabIndex = 2;
            this.checkBoxOnions.Text = "Onions";
            this.checkBoxOnions.UseVisualStyleBackColor = true;
            // 
            // checkBoxMashrooms
            // 
            this.checkBoxMashrooms.AutoSize = true;
            this.checkBoxMashrooms.Location = new System.Drawing.Point(72, 72);
            this.checkBoxMashrooms.Name = "checkBoxMashrooms";
            this.checkBoxMashrooms.Size = new System.Drawing.Size(108, 24);
            this.checkBoxMashrooms.TabIndex = 1;
            this.checkBoxMashrooms.Text = "Mashrooms";
            this.checkBoxMashrooms.UseVisualStyleBackColor = true;
            // 
            // checkBoxExtraCheese
            // 
            this.checkBoxExtraCheese.AutoSize = true;
            this.checkBoxExtraCheese.Location = new System.Drawing.Point(72, 42);
            this.checkBoxExtraCheese.Name = "checkBoxExtraCheese";
            this.checkBoxExtraCheese.Size = new System.Drawing.Size(115, 24);
            this.checkBoxExtraCheese.TabIndex = 0;
            this.checkBoxExtraCheese.Text = "Extra Cheese";
            this.checkBoxExtraCheese.UseVisualStyleBackColor = true;
            // 
            // grpBox3
            // 
            this.grpBox3.Controls.Add(this.radioThickCrust);
            this.grpBox3.Controls.Add(this.radioThinCrust);
            this.grpBox3.Location = new System.Drawing.Point(34, 239);
            this.grpBox3.Name = "grpBox3";
            this.grpBox3.Size = new System.Drawing.Size(340, 74);
            this.grpBox3.TabIndex = 2;
            this.grpBox3.TabStop = false;
            this.grpBox3.Text = " Crust Type";
            // 
            // radioThickCrust
            // 
            this.radioThickCrust.AutoSize = true;
            this.radioThickCrust.Location = new System.Drawing.Point(172, 30);
            this.radioThickCrust.Name = "radioThickCrust";
            this.radioThickCrust.Size = new System.Drawing.Size(101, 24);
            this.radioThickCrust.TabIndex = 1;
            this.radioThickCrust.TabStop = true;
            this.radioThickCrust.Text = "Thick Crust";
            this.radioThickCrust.UseVisualStyleBackColor = true;
            // 
            // radioThinCrust
            // 
            this.radioThinCrust.AutoSize = true;
            this.radioThinCrust.Location = new System.Drawing.Point(49, 30);
            this.radioThinCrust.Name = "radioThinCrust";
            this.radioThinCrust.Size = new System.Drawing.Size(95, 24);
            this.radioThinCrust.TabIndex = 0;
            this.radioThinCrust.TabStop = true;
            this.radioThinCrust.Text = "Thin Crust";
            this.radioThinCrust.UseVisualStyleBackColor = true;
            // 
            // radioEatIn
            // 
            this.radioEatIn.AutoSize = true;
            this.radioEatIn.Location = new System.Drawing.Point(432, 269);
            this.radioEatIn.Name = "radioEatIn";
            this.radioEatIn.Size = new System.Drawing.Size(67, 24);
            this.radioEatIn.TabIndex = 3;
            this.radioEatIn.TabStop = true;
            this.radioEatIn.Text = "Eat In";
            this.radioEatIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioEatIn.UseVisualStyleBackColor = true;
            // 
            // radioTakeAway
            // 
            this.radioTakeAway.AutoSize = true;
            this.radioTakeAway.Location = new System.Drawing.Point(555, 269);
            this.radioTakeAway.Name = "radioTakeAway";
            this.radioTakeAway.Size = new System.Drawing.Size(99, 24);
            this.radioTakeAway.TabIndex = 4;
            this.radioTakeAway.TabStop = true;
            this.radioTakeAway.Text = "Take Away";
            this.radioTakeAway.UseVisualStyleBackColor = true;
            // 
            // btnBuildPizza
            // 
            this.btnBuildPizza.Location = new System.Drawing.Point(139, 343);
            this.btnBuildPizza.Name = "btnBuildPizza";
            this.btnBuildPizza.Size = new System.Drawing.Size(247, 67);
            this.btnBuildPizza.TabIndex = 5;
            this.btnBuildPizza.Text = "Build Pizza";
            this.btnBuildPizza.UseVisualStyleBackColor = true;
            this.btnBuildPizza.Click += new System.EventHandler(this.btnBuildPizza_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(392, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(247, 67);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBuildPizza);
            this.Controls.Add(this.radioTakeAway);
            this.Controls.Add(this.radioEatIn);
            this.Controls.Add(this.grpBox3);
            this.Controls.Add(this.grpBoxTopping);
            this.Controls.Add(this.grpBoxSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxSize.ResumeLayout(false);
            this.grpBoxSize.PerformLayout();
            this.grpBoxTopping.ResumeLayout(false);
            this.grpBoxTopping.PerformLayout();
            this.grpBox3.ResumeLayout(false);
            this.grpBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpBoxSize;
        private RadioButton radioLarge;
        private RadioButton radioMedium;
        private RadioButton radioSmall;
        private GroupBox grpBoxTopping;
        private CheckBox checkBoxTomatoes;
        private CheckBox checkBoxOnions;
        private CheckBox checkBoxMashrooms;
        private CheckBox checkBoxExtraCheese;
        private GroupBox grpBox3;
        private RadioButton radioThickCrust;
        private RadioButton radioThinCrust;
        private RadioButton radioEatIn;
        private RadioButton radioTakeAway;
        private Button btnBuildPizza;
        private Button btnExit;
    }
}