namespace BuildPizzaApplication
{
    public partial class Form1 : Form
    {

        dialog dialogBox;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuildPizza_Click(object sender, EventArgs e)
        {
            dialogBox =  new dialog();
            checkAll();
            //
            dialogBox.ShowDialog();
        }
        void checkAll() {
            if (this.radioSmall.Checked) { dialogBox.pizzaSize = this.radioSmall.Text; }
            else if (this.radioMedium.Checked) { dialogBox.pizzaSize = this.radioMedium.Text; }
            else if (this.radioLarge.Checked) { dialogBox.pizzaSize = this.radioLarge.Text; }
            else dialogBox.pizzaSize = " - ";
            //
            if (this.radioEatIn.Checked) { dialogBox.eatStatus = this.radioEatIn.Text; }
            else if (this.radioTakeAway.Checked) { dialogBox.eatStatus = this.radioTakeAway.Text; }
            else dialogBox.eatStatus = " - ";
            //
            if (this.checkBoxExtraCheese.Checked) { dialogBox.toppings += this.checkBoxExtraCheese.Text + ", "; }
            if (this.checkBoxMashrooms.Checked) { dialogBox.toppings += this.checkBoxMashrooms.Text + ", "; }
            if (this.checkBoxOnions.Checked) { dialogBox.toppings += this.checkBoxOnions.Text + ", "; }
            if (this.checkBoxTomatoes.Checked) { dialogBox.toppings += this.checkBoxTomatoes.Text + ", "; }
            else dialogBox.toppings = " - ";
            //
            if (this.radioThinCrust.Checked) { dialogBox.crustType = this.radioThinCrust.Text; }
            else if (this.radioThickCrust.Checked) { dialogBox.crustType = this.radioThickCrust.Text; }
            else dialogBox.crustType = " - ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}