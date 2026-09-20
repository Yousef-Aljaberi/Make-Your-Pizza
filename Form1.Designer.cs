namespace Make_Your_Pizza
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
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radlarg = new System.Windows.Forms.RadioButton();
            this.radmedium = new System.Windows.Forms.RadioButton();
            this.radsmall = new System.Windows.Forms.RadioButton();
            this.grpCrustType = new System.Windows.Forms.GroupBox();
            this.radThick = new System.Windows.Forms.RadioButton();
            this.radThin = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chktomato = new System.Windows.Forms.CheckBox();
            this.chkmushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtra = new System.Windows.Forms.CheckBox();
            this.grpWhereToEat = new System.Windows.Forms.GroupBox();
            this.radEatOut = new System.Windows.Forms.RadioButton();
            this.radEatIn = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.grbOrderSummry = new System.Windows.Forms.GroupBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblcrustType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.grpSize.SuspendLayout();
            this.grpCrustType.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpWhereToEat.SuspendLayout();
            this.grbOrderSummry.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radlarg);
            this.grpSize.Controls.Add(this.radmedium);
            this.grpSize.Controls.Add(this.radsmall);
            this.grpSize.Location = new System.Drawing.Point(55, 288);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(360, 399);
            this.grpSize.TabIndex = 0;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // radlarg
            // 
            this.radlarg.AutoSize = true;
            this.radlarg.Location = new System.Drawing.Point(31, 290);
            this.radlarg.Name = "radlarg";
            this.radlarg.Size = new System.Drawing.Size(97, 37);
            this.radlarg.TabIndex = 4;
            this.radlarg.Text = "larg";
            this.radlarg.UseVisualStyleBackColor = true;
            this.radlarg.CheckedChanged += new System.EventHandler(this.radlarg_CheckedChanged);
            // 
            // radmedium
            // 
            this.radmedium.AutoSize = true;
            this.radmedium.Checked = true;
            this.radmedium.Location = new System.Drawing.Point(31, 195);
            this.radmedium.Name = "radmedium";
            this.radmedium.Size = new System.Drawing.Size(148, 37);
            this.radmedium.TabIndex = 3;
            this.radmedium.TabStop = true;
            this.radmedium.Text = "medium";
            this.radmedium.UseVisualStyleBackColor = true;
            this.radmedium.CheckedChanged += new System.EventHandler(this.radmedium_CheckedChanged);
            // 
            // radsmall
            // 
            this.radsmall.AutoSize = true;
            this.radsmall.Location = new System.Drawing.Point(31, 103);
            this.radsmall.Name = "radsmall";
            this.radsmall.Size = new System.Drawing.Size(113, 37);
            this.radsmall.TabIndex = 2;
            this.radsmall.Text = "small";
            this.radsmall.UseVisualStyleBackColor = true;
            this.radsmall.CheckedChanged += new System.EventHandler(this.radsmall_CheckedChanged);
            // 
            // grpCrustType
            // 
            this.grpCrustType.Controls.Add(this.radThick);
            this.grpCrustType.Controls.Add(this.radThin);
            this.grpCrustType.Location = new System.Drawing.Point(55, 732);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(368, 285);
            this.grpCrustType.TabIndex = 2;
            this.grpCrustType.TabStop = false;
            this.grpCrustType.Text = "Crust Type";
            // 
            // radThick
            // 
            this.radThick.AutoSize = true;
            this.radThick.Location = new System.Drawing.Point(21, 195);
            this.radThick.Name = "radThick";
            this.radThick.Size = new System.Drawing.Size(184, 37);
            this.radThick.TabIndex = 6;
            this.radThick.TabStop = true;
            this.radThick.Text = "Thick Crust";
            this.radThick.UseVisualStyleBackColor = true;
            this.radThick.CheckedChanged += new System.EventHandler(this.radThick_CheckedChanged);
            // 
            // radThin
            // 
            this.radThin.AutoSize = true;
            this.radThin.Checked = true;
            this.radThin.Location = new System.Drawing.Point(31, 92);
            this.radThin.Name = "radThin";
            this.radThin.Size = new System.Drawing.Size(174, 37);
            this.radThin.TabIndex = 5;
            this.radThin.TabStop = true;
            this.radThin.Text = "Thin Crust";
            this.radThin.UseVisualStyleBackColor = true;
            this.radThin.CheckedChanged += new System.EventHandler(this.radThin_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkPeppers);
            this.grpToppings.Controls.Add(this.chkOlives);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chktomato);
            this.grpToppings.Controls.Add(this.chkmushrooms);
            this.grpToppings.Controls.Add(this.chkExtra);
            this.grpToppings.Location = new System.Drawing.Point(469, 298);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(749, 389);
            this.grpToppings.TabIndex = 3;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(464, 281);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(227, 37);
            this.chkPeppers.TabIndex = 5;
            this.chkPeppers.Tag = "5";
            this.chkPeppers.Text = "Green Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chkPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(464, 187);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(123, 37);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(464, 95);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(123, 37);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chktomato
            // 
            this.chktomato.AutoSize = true;
            this.chktomato.Location = new System.Drawing.Point(63, 281);
            this.chktomato.Name = "chktomato";
            this.chktomato.Size = new System.Drawing.Size(145, 37);
            this.chktomato.TabIndex = 2;
            this.chktomato.Tag = "5";
            this.chktomato.Text = "Tomato";
            this.chktomato.UseVisualStyleBackColor = true;
            this.chktomato.CheckedChanged += new System.EventHandler(this.chktomato_CheckedChanged);
            // 
            // chkmushrooms
            // 
            this.chkmushrooms.AutoSize = true;
            this.chkmushrooms.Location = new System.Drawing.Point(63, 187);
            this.chkmushrooms.Name = "chkmushrooms";
            this.chkmushrooms.Size = new System.Drawing.Size(191, 37);
            this.chkmushrooms.TabIndex = 1;
            this.chkmushrooms.Tag = "5";
            this.chkmushrooms.Text = "Mushrooms";
            this.chkmushrooms.UseVisualStyleBackColor = true;
            this.chkmushrooms.CheckedChanged += new System.EventHandler(this.chkmushrooms_CheckedChanged);
            // 
            // chkExtra
            // 
            this.chkExtra.AutoSize = true;
            this.chkExtra.Location = new System.Drawing.Point(63, 94);
            this.chkExtra.Name = "chkExtra";
            this.chkExtra.Size = new System.Drawing.Size(193, 37);
            this.chkExtra.TabIndex = 0;
            this.chkExtra.Tag = "5";
            this.chkExtra.Text = "Extra Chees";
            this.chkExtra.UseVisualStyleBackColor = true;
            this.chkExtra.CheckedChanged += new System.EventHandler(this.chkExtra_CheckedChanged);
            // 
            // grpWhereToEat
            // 
            this.grpWhereToEat.Controls.Add(this.radEatOut);
            this.grpWhereToEat.Controls.Add(this.radEatIn);
            this.grpWhereToEat.Location = new System.Drawing.Point(469, 732);
            this.grpWhereToEat.Name = "grpWhereToEat";
            this.grpWhereToEat.Size = new System.Drawing.Size(749, 232);
            this.grpWhereToEat.TabIndex = 4;
            this.grpWhereToEat.TabStop = false;
            this.grpWhereToEat.Text = "Where to Eat";
            // 
            // radEatOut
            // 
            this.radEatOut.AutoSize = true;
            this.radEatOut.Location = new System.Drawing.Point(464, 92);
            this.radEatOut.Name = "radEatOut";
            this.radEatOut.Size = new System.Drawing.Size(160, 37);
            this.radEatOut.TabIndex = 1;
            this.radEatOut.TabStop = true;
            this.radEatOut.Text = "Take Out";
            this.radEatOut.UseVisualStyleBackColor = true;
            this.radEatOut.CheckedChanged += new System.EventHandler(this.radEatOut_CheckedChanged);
            // 
            // radEatIn
            // 
            this.radEatIn.AutoSize = true;
            this.radEatIn.Checked = true;
            this.radEatIn.Location = new System.Drawing.Point(89, 92);
            this.radEatIn.Name = "radEatIn";
            this.radEatIn.Size = new System.Drawing.Size(119, 37);
            this.radEatIn.TabIndex = 0;
            this.radEatIn.TabStop = true;
            this.radEatIn.Text = "Eat in";
            this.radEatIn.UseVisualStyleBackColor = true;
            this.radEatIn.CheckedChanged += new System.EventHandler(this.radEatIn_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(880, 994);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(338, 106);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(469, 994);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(338, 106);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // grbOrderSummry
            // 
            this.grbOrderSummry.BackColor = System.Drawing.Color.Transparent;
            this.grbOrderSummry.Controls.Add(this.lblToppings);
            this.grbOrderSummry.Controls.Add(this.lblTotalPrice);
            this.grbOrderSummry.Controls.Add(this.label1);
            this.grbOrderSummry.Controls.Add(this.lblWhereToEat);
            this.grbOrderSummry.Controls.Add(this.lblcrustType);
            this.grbOrderSummry.Controls.Add(this.label6);
            this.grbOrderSummry.Controls.Add(this.lblSize);
            this.grbOrderSummry.Location = new System.Drawing.Point(1302, 297);
            this.grbOrderSummry.Name = "grbOrderSummry";
            this.grbOrderSummry.Size = new System.Drawing.Size(764, 970);
            this.grbOrderSummry.TabIndex = 7;
            this.grbOrderSummry.TabStop = false;
            this.grbOrderSummry.Text = "Order Summry";
            this.grbOrderSummry.Enter += new System.EventHandler(this.grpOrderSummry_Enter);
            // 
            // lblToppings
            // 
            this.lblToppings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToppings.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(76, 295);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(662, 188);
            this.lblToppings.TabIndex = 6;
            this.lblToppings.Text = "No toppings";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 21.9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblTotalPrice.Location = new System.Drawing.Point(413, 805);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(219, 88);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "0.00$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 772);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Price: ";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(89, 611);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(243, 40);
            this.lblWhereToEat.TabIndex = 3;
            this.lblWhereToEat.Text = "Where to Eat: ";
            // 
            // lblcrustType
            // 
            this.lblcrustType.AutoSize = true;
            this.lblcrustType.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrustType.Location = new System.Drawing.Point(89, 494);
            this.lblcrustType.Name = "lblcrustType";
            this.lblcrustType.Size = new System.Drawing.Size(204, 40);
            this.lblcrustType.TabIndex = 2;
            this.lblcrustType.Text = "Crust Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 40);
            this.label6.TabIndex = 1;
            this.label6.Text = "Toppings:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(89, 103);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(96, 40);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size:";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.BackColor = System.Drawing.Color.Khaki;
            this.lblProjectTitle.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(396, 55);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(1418, 182);
            this.lblProjectTitle.TabIndex = 1;
            this.lblProjectTitle.Text = "Make Your Pizza";
            this.lblProjectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2245, 1320);
            this.Controls.Add(this.grbOrderSummry);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpWhereToEat);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpCrustType);
            this.Controls.Add(this.lblProjectTitle);
            this.Controls.Add(this.grpSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpWhereToEat.ResumeLayout(false);
            this.grpWhereToEat.PerformLayout();
            this.grbOrderSummry.ResumeLayout(false);
            this.grbOrderSummry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radlarg;
        private System.Windows.Forms.RadioButton radmedium;
        private System.Windows.Forms.RadioButton radsmall;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.GroupBox grpCrustType;
        private System.Windows.Forms.RadioButton radThick;
        private System.Windows.Forms.RadioButton radThin;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chktomato;
        private System.Windows.Forms.CheckBox chkmushrooms;
        private System.Windows.Forms.CheckBox chkExtra;
        private System.Windows.Forms.GroupBox grpWhereToEat;
        private System.Windows.Forms.RadioButton radEatOut;
        private System.Windows.Forms.RadioButton radEatIn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox grbOrderSummry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblcrustType;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToppings;
    }
}

