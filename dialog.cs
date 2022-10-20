using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildPizzaApplication
{
    public partial class dialog : Form
    {
        Form1 form1 = new Form1();
        public string pizzaSize = "";
        public string toppings = "";
        public string crustType = "";
        public string eatStatus = "";
        public dialog()
        {
            InitializeComponent();
        }

        private void dialog_Load(object sender, EventArgs e)
        {
            showData();
        }
        void showData() {
            this.lblSize.Text += " "+pizzaSize;
            this.lblToppings.Text += " "+toppings;
            this.lblCrust.Text += " "+crustType;
            this.lblEating.Text = eatStatus;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
