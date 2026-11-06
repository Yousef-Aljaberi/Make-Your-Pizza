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
            UpdateOrderSummray();
        }
   
      
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFrom();
            
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
           DisableForm();
        }
        private void radsmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void radmedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void radlarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void radThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void radThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void chkExtra_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void chkmushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void chktomato_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void radEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void radEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();
        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummray();

        }


        void UpdatePrice()
        {
            lblTotalPrice.Text = Convert.ToString(CalculatePrice()) + " $";
        }
        int CalculatePrice()
        {
            int TotalPrice = 0; 
            
            foreach(CheckBox T in grpToppings.Controls.OfType<CheckBox>())
            {
                if(T.Checked)
                {
                    TotalPrice+=Convert.ToInt32(T.Tag);
                }
            }

            TotalPrice+= Convert.ToInt32((radsmall.Checked ? radsmall.Tag : radmedium.Checked ? radmedium.Tag : radlarg.Tag));
            TotalPrice += Convert.ToInt32((radThin.Checked ? radThin.Tag : radThick.Tag));

            return TotalPrice;  
           
        }

       void UpdateOrderSummray()
        {
            UpdatePrice();
            lblSize.Text =  GetSize();
            lblToppings.Text = GetToppings();
            lblcrustType.Text=GetCrustType();
            lblWhereToEat.Text = GetPlace();
        }

        string GetSize()
        {
            return (radsmall.Checked ? "Small" : radmedium.Checked ? "Medium" : "Large");
        }
        string GetPlace()
        {
            return (radEatIn.Checked ? "Eat In" : "Eat Out");
        }
        string GetCrustType()
        {
            return (radThick.Checked ? "Thin" : "Thick");
        }
        string GetToppings()
        {
            string toppings = "";
            
            foreach(CheckBox chk in grpToppings.Controls.OfType<CheckBox>())
            {
                if(chk.Checked)
                {
                    toppings += chk.Text + ", ";
                }
            }
            return (toppings == "" ? "No Toppings" : toppings.Substring(0, toppings.Length - 2));
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

            UpdatePrice();
            EnableForm();
        }

        void DisableForm()
        {
            DialogResult Result = MessageBox.Show("Are you sure?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(Result == DialogResult.OK)
            {
                foreach (Control C in this.Controls)
                {
                    if (C is GroupBox)
                    {
                        C.Enabled = false;
                    }

                }

                btnOrder.Enabled = false;
            }
            
          
        }
        

        void EnableForm()
        {
            foreach (Control C in this.Controls)
            {
                C.Enabled = true;
            }
            btnOrder.Enabled = true;
        }


    }
}
