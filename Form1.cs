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
            radEatIn.Checked = true;
            radsmall.Checked = true;
            radThin.Checked= true;  

        }
        
        private void grpOrderSummry_Enter(object sender, EventArgs e)
        {

        }

        void Orderd()
        {
            
            foreach(Control c in this.Controls)
            {
                if (c.Name != btnReset.Name &&c.Name!=grbOrderSummry.Name)
                {
                    c.Enabled = false;
                }

            }
        }
         void ResetForm()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
                if (c is GroupBox && c.Name != grbOrderSummry.Name)
                {
                    foreach (Control control in c.Controls)
                    {

                        if (control is RadioButton)
                        {
                            RadioButton r = (RadioButton)control;
                            r.Checked = false;

                        }
                        if (control is CheckBox)
                        {
                            CheckBox C = (CheckBox)control;
                            C.Checked = false;
                        }
                    }
                }
            }
            lblcrustType.Text = "Crust Type: ";
            lblSize.Text = "Size: ";
            lblToppings.Text = "No toppings.";
            lblTotalPrice.Text = "0$";
            lblWhereToEat.Text = "Where to Eat";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Orderd();
        }
    }
}
