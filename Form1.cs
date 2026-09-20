using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Your_Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.photo_2026_09_17_19_39_33;
            BackgroundImageLayout = ImageLayout.Stretch;
            UpdateOrderSummray();
        }
        void UpdateOrderSummray()
        {
            UpdateCrust();
            UpdateSize();
            UpdateToppings();
            UpdateWhereEat();
        }
        double getSizePrice()
        {
            return radlarg.Checked ? 15 : radmedium.Checked ? 10 : radsmall.Checked ? 5 : 0;
        }
        double getCrustPrice()
        {
            return radThick.Checked ? 10 : radThin.Checked ? 5 : 0;
        }
        double getToppingsPrice()
        {
            double price = 0;
            foreach (Control c in grpToppings.Controls)
            {
                if (c is CheckBox topping && topping.Checked)
                {
                    price += Convert.ToDouble(topping.Tag);
                }
            }
            return price;
        }
        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = $" {getSizePrice() + getCrustPrice() + getToppingsPrice()}$";
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            string size = radlarg.Checked ? "Large" : radmedium.Checked ? "Medium" : radsmall.Checked ? "small" : "";
            lblSize.Text = "Size: " + size;
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            string crustType = radThick.Checked ? "Thick" : radThin.Checked ? "Thin" : "";
            lblcrustType.Text = "Crust Type: " +   crustType;
        }
        void UpdateToppings()
        {
            UpdateTotalPrice();
            string Toppings = "";
            if (chkExtra.Checked) Toppings += "Extra Cheese, ";
            if (chkmushrooms.Checked) Toppings += "Mushroom, ";
            if (chktomato.Checked) Toppings += "Tomato, ";
            if (chkOnion.Checked) Toppings += "Onion, ";
            if (chkOlives.Checked) Toppings += "Olives, ";
            if (chkPeppers.Checked) Toppings += "Green Peppers, ";
            if (Toppings == "") lblToppings.Text = "No Toppings.";
            else
            {
                if (Toppings.EndsWith(", "))
                {
                    Toppings = Toppings.Substring(0, Toppings.Length - 2);
                }
                lblToppings.Text = Toppings;
            }


        }
        void UpdateWhereEat()
        {
            string WhereEat =radEatIn.Checked ? "In" : radEatOut.Checked ? "Out" : "";
            lblWhereToEat.Text = "Where to Eat: "+ WhereEat;

        }
        private void grpOrderSummry_Enter(object sender, EventArgs e)
        {

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();

        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Orderd();
        }
        private void radsmall_CheckedChanged(object sender, EventArgs e)
        {
           UpdateSize();
        }

        private void radmedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radlarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void radThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkExtra_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkmushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chktomato_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void radEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereEat();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void radEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereEat();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }


        

        void ResetForm()
        {
            foreach (Control c in this.Controls)
            {

                if (c is GroupBox && c.Name != grbOrderSummry.Name)
                {
                    c.Enabled = true;
                    
                }
            }

            DefaultForm();

        }

        void DefaultForm()
        {
            foreach (Control c2 in grpToppings.Controls)
            {
                if (c2 is CheckBox)
                {
                    CheckBox c3 = (CheckBox)c2;
                    c3.Checked = false;
                }
            }
            radmedium.Checked = true;
            radThin.Checked = true;
            radEatIn.Checked = true;
            btnOrder.Enabled = true;
        }

        void Orderd()
        {
            if (MessageBox.Show("Are you sure you want to place this order?", "Confirm Order",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Order Placed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableForm();
            }
          
        }
        void DisableForm()
        {
            foreach(Control c in this.Controls)
            { if (c is GroupBox gb && gb.Name!=grbOrderSummry.Name)
                {
                    gb.Enabled = false;
                }
            }
            btnOrder.Enabled = false;

        }
    }
}
