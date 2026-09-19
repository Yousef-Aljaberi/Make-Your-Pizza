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
            lblToppings.Text="Toppings: "+Environment.NewLine;
            lblToppings.Text += "   No Toppings";
        }

        private void grpOrderSummry_Enter(object sender, EventArgs e)
        {

        }
    }
}
