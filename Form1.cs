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

        void UpdateSize()
        {
            UpdatePrice();
            lblSize.Text = radsmall.Checked ? "Small" : radlarg.Checked ? "Large" : "Medium";
        }

        void UpdateToppings()
        {
            UpdatePrice();
            string toppings = "";

            foreach (CheckBox chk in grpToppings.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                {
                    toppings += chk.Text + ", ";
                }
            }

            lblToppings.Text = (toppings == "" ? "No Toppings" : toppings.Substring(0, toppings.Length - 2));
        }

        void UpdateCrust()
        {
            UpdatePrice();
            lblcrustType.Text = (radThick.Checked ? "Thick" : "Thin");
        }

        void UpdateWhereToEat()
        {
            UpdatePrice();
            lblWhereToEat.Text = (radEatIn.Checked ? "Eat In" : "Eat Out");
        }

        

        float GetSelectedSizePrice()
        {
            Object Price = (radsmall.Checked ? radsmall.Tag : radmedium.Checked ? radmedium.Tag : radlarg.Tag);

            return Convert.ToSingle(Price);
        }

        float CalculateToppingsPrice()
        {
            float toppingsPrice = 0;

            foreach (CheckBox T in grpToppings.Controls.OfType<CheckBox>())
            {
                if (T.Checked)
                {
                    toppingsPrice += Convert.ToInt32(T.Tag);
                }
            }

            return toppingsPrice;
        }

        float GetSelectedCrustPrice()
        {
            return Convert.ToSingle((radThin.Checked ? radThin.Tag : radThick.Tag));
        }

        float CalculateTotalPrice()
        {
            return (GetSelectedCrustPrice() + GetSelectedSizePrice() + CalculateToppingsPrice()) *(float) nupAmount.Value ;
        }

        void UpdatePrice()
        {
            lblTotalPrice.Text = "$" + Convert.ToString(CalculateTotalPrice());
        }

        void UpdateOrderSummray()
        {
            UpdatePrice();
            UpdateCrust();
            UpdateSize();
            UpdateWhereToEat();
            UpdateToppings();



        }
        void DisableForm()
        {
            grpSize.Enabled = false;
            grpCrustType.Enabled = false;
            grpToppings.Enabled = false;
            grpWhereToEat.Enabled = false;
            btnOrder.Enabled = false;
        }

        void EnableForm()
        {
            grpSize.Enabled = true;
            grpCrustType.Enabled = true;
            grpToppings.Enabled = true;
            grpWhereToEat.Enabled = true;
            btnOrder.Enabled = true;
        }

        void ResetFrom()
        {
            foreach (CheckBox c in grpToppings.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }

            radEatIn.Checked = true;
            radmedium.Checked = true;
            radThin.Checked = true;

            EnableForm();
            UpdateOrderSummray();
        }
        DialogResult ConfirmMessage()
        {
            return MessageBox.Show("Are you sure?", "Confirm Order!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        }
       

        


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Make Your Own Pizza 🍕";
            UpdateOrderSummray();
        }
   
      
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFrom();
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
           if(ConfirmMessage()==DialogResult.OK)
            {
                DisableForm();
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            UpdateWhereToEat();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void radEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void nupAmount_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }
    }
}
