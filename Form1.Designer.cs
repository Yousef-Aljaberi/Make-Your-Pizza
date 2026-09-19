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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.radsmall = new System.Windows.Forms.RadioButton();
            this.radmedium = new System.Windows.Forms.RadioButton();
            this.radlarg = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radThin = new System.Windows.Forms.RadioButton();
            this.radThick = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkExtra = new System.Windows.Forms.CheckBox();
            this.chkmushrooms = new System.Windows.Forms.CheckBox();
            this.chktomato = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radEatIn = new System.Windows.Forms.RadioButton();
            this.radEatOut = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.grpOrderSummry = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblcrustType = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpOrderSummry.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radlarg);
            this.groupBox1.Controls.Add(this.radmedium);
            this.groupBox1.Controls.Add(this.radsmall);
            this.groupBox1.Location = new System.Drawing.Point(55, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(396, 55);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(1418, 182);
            this.lblProjectTitle.TabIndex = 1;
            this.lblProjectTitle.Text = "Make Your Pizza";
            this.lblProjectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radsmall
            // 
            this.radsmall.AutoSize = true;
            this.radsmall.Location = new System.Drawing.Point(31, 103);
            this.radsmall.Name = "radsmall";
            this.radsmall.Size = new System.Drawing.Size(113, 37);
            this.radsmall.TabIndex = 2;
            this.radsmall.TabStop = true;
            this.radsmall.Text = "small";
            this.radsmall.UseVisualStyleBackColor = true;
            // 
            // radmedium
            // 
            this.radmedium.AutoSize = true;
            this.radmedium.Location = new System.Drawing.Point(31, 195);
            this.radmedium.Name = "radmedium";
            this.radmedium.Size = new System.Drawing.Size(148, 37);
            this.radmedium.TabIndex = 3;
            this.radmedium.TabStop = true;
            this.radmedium.Text = "medium";
            this.radmedium.UseVisualStyleBackColor = true;
            // 
            // radlarg
            // 
            this.radlarg.AutoSize = true;
            this.radlarg.Location = new System.Drawing.Point(31, 290);
            this.radlarg.Name = "radlarg";
            this.radlarg.Size = new System.Drawing.Size(97, 37);
            this.radlarg.TabIndex = 4;
            this.radlarg.TabStop = true;
            this.radlarg.Text = "larg";
            this.radlarg.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radThick);
            this.groupBox2.Controls.Add(this.radThin);
            this.groupBox2.Location = new System.Drawing.Point(55, 732);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 285);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust Type";
            // 
            // radThin
            // 
            this.radThin.AutoSize = true;
            this.radThin.Location = new System.Drawing.Point(31, 92);
            this.radThin.Name = "radThin";
            this.radThin.Size = new System.Drawing.Size(174, 37);
            this.radThin.TabIndex = 5;
            this.radThin.TabStop = true;
            this.radThin.Text = "Thin Crust";
            this.radThin.UseVisualStyleBackColor = true;
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkPeppers);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.chkOnion);
            this.groupBox3.Controls.Add(this.chktomato);
            this.groupBox3.Controls.Add(this.chkmushrooms);
            this.groupBox3.Controls.Add(this.chkExtra);
            this.groupBox3.Location = new System.Drawing.Point(469, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(749, 389);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // chkExtra
            // 
            this.chkExtra.AutoSize = true;
            this.chkExtra.Location = new System.Drawing.Point(63, 94);
            this.chkExtra.Name = "chkExtra";
            this.chkExtra.Size = new System.Drawing.Size(193, 37);
            this.chkExtra.TabIndex = 0;
            this.chkExtra.Text = "Extra Chees";
            this.chkExtra.UseVisualStyleBackColor = true;
            // 
            // chkmushrooms
            // 
            this.chkmushrooms.AutoSize = true;
            this.chkmushrooms.Location = new System.Drawing.Point(63, 187);
            this.chkmushrooms.Name = "chkmushrooms";
            this.chkmushrooms.Size = new System.Drawing.Size(191, 37);
            this.chkmushrooms.TabIndex = 1;
            this.chkmushrooms.Text = "Mushrooms";
            this.chkmushrooms.UseVisualStyleBackColor = true;
            // 
            // chktomato
            // 
            this.chktomato.AutoSize = true;
            this.chktomato.Location = new System.Drawing.Point(63, 281);
            this.chktomato.Name = "chktomato";
            this.chktomato.Size = new System.Drawing.Size(145, 37);
            this.chktomato.TabIndex = 2;
            this.chktomato.Text = "Tomato";
            this.chktomato.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(464, 95);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(123, 37);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(464, 187);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(178, 37);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(464, 281);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(227, 37);
            this.chkPeppers.TabIndex = 5;
            this.chkPeppers.Text = "Green Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radEatOut);
            this.groupBox4.Controls.Add(this.radEatIn);
            this.groupBox4.Location = new System.Drawing.Point(469, 732);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(749, 232);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Where to Eat";
            // 
            // radEatIn
            // 
            this.radEatIn.AutoSize = true;
            this.radEatIn.Location = new System.Drawing.Point(89, 92);
            this.radEatIn.Name = "radEatIn";
            this.radEatIn.Size = new System.Drawing.Size(119, 37);
            this.radEatIn.TabIndex = 0;
            this.radEatIn.TabStop = true;
            this.radEatIn.Text = "Eat in";
            this.radEatIn.UseVisualStyleBackColor = true;
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
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(880, 994);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(338, 106);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(469, 994);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(338, 106);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // grpOrderSummry
            // 
            this.grpOrderSummry.Controls.Add(this.lblWhereToEat);
            this.grpOrderSummry.Controls.Add(this.lblcrustType);
            this.grpOrderSummry.Controls.Add(this.lblToppings);
            this.grpOrderSummry.Controls.Add(this.lblSize);
            this.grpOrderSummry.Location = new System.Drawing.Point(1302, 297);
            this.grpOrderSummry.Name = "grpOrderSummry";
            this.grpOrderSummry.Size = new System.Drawing.Size(762, 919);
            this.grpOrderSummry.TabIndex = 7;
            this.grpOrderSummry.TabStop = false;
            this.grpOrderSummry.Text = "Order Summry";
            this.grpOrderSummry.Enter += new System.EventHandler(this.grpOrderSummry_Enter);
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
            // lblToppings
            // 
            this.lblToppings.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(89, 225);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(463, 234);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblcrustType
            // 
            this.lblcrustType.AutoSize = true;
            this.lblcrustType.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrustType.Location = new System.Drawing.Point(89, 363);
            this.lblcrustType.Name = "lblcrustType";
            this.lblcrustType.Size = new System.Drawing.Size(204, 40);
            this.lblcrustType.TabIndex = 2;
            this.lblcrustType.Text = "Crust Type:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Arial", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(89, 486);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(243, 40);
            this.lblWhereToEat.TabIndex = 3;
            this.lblWhereToEat.Text = "Where to Eat: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(2245, 1320);
            this.Controls.Add(this.grpOrderSummry);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblProjectTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpOrderSummry.ResumeLayout(false);
            this.grpOrderSummry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radlarg;
        private System.Windows.Forms.RadioButton radmedium;
        private System.Windows.Forms.RadioButton radsmall;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radThick;
        private System.Windows.Forms.RadioButton radThin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chktomato;
        private System.Windows.Forms.CheckBox chkmushrooms;
        private System.Windows.Forms.CheckBox chkExtra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radEatOut;
        private System.Windows.Forms.RadioButton radEatIn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox grpOrderSummry;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblcrustType;
    }
}

