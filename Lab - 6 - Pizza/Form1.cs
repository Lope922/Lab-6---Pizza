using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab___6___Pizza
{
    /* PIZZA APPLICATION THAT WILL UTILIZE COMBO BOXES RADIO BUTTONS TO ALLOW USER TO BUILD PIZZA ORDERS
     * Pizza party calculator SHOUDL INCLUDE THE FOLLOWING: include size, toppings, extras, prices, purchase summary 
     * CONOR , JIM , CARLOS 
    */

    //other features will be coded later just trying to get the basics going. 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //BRAINSTORMING PIZZA STUCTURE FOR pizzaOrder;
        // STRING for the type of crust 
        string crust = "";
        // list of the toppings selected from checkbox 
        List<string> toppingsList = new List<string>();







        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // prompt the user to see if their selection is correct
            DialogResult result = MessageBox.Show("Are you sure you want to place your order?", "Confirm", MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
            {

                // call the method to get the toppings and pass it the check boxes as well as the list to store the topping selections
                GetToppings(chkBoxCheese, chkBoxPepperoni, chkBoxSausage, chkBoxBlackOlive, checkBoxGreenPepper, toppingsList);

                

                // add the crust to the listbox
                listBoxOrderBuilder.Items.Add(GetCrustType(rdoThickCrust, rdoThinCrust, rdoStuffedCrust));

                // add the toppings to the list box 
                listBoxOrderBuilder.Items.Add(GetToppings(chkBoxCheese, chkBoxPepperoni, chkBoxSausage, chkBoxBlackOlive, checkBoxGreenPepper, toppingsList));


                //need to find a way to add the toppings to the list and test to make sure they go to the right pizza order. 
                // add each item in the toppings list to the list box 
                //      foreach (string topping in toppingsList)
                //    {
                //      listBoxOrderBuilder.Items.Add(topping);
                //}
            }

        }


        public string GetCrustType(RadioButton radioBtn1, RadioButton radioBtn2, RadioButton radioBtn3)
        {
            string crustType = "none";
            if (radioBtn1.Checked == true)
            {
                crustType = "Thick Crust";
                return crustType;

            }
            else if (radioBtn2.Checked == true)
            {
                crustType = "Thin Crust";
                return crustType;
            }
            else if (radioBtn3.Checked == true)
            {
                crustType = "Stuffed Crust";
                return crustType;
            }
            else
            {
                return crustType;
            }

        }





        // try and pull the infro from the selected toppings check boxes 
        private List<string> GetToppings(CheckBox Cheese, CheckBox Pepperoni, CheckBox Sausage, CheckBox BlackOlives, CheckBox GreenPepper, List<string> toppingList)
        {
            if (Cheese.Checked == true)
            {
                toppingList.Add("Cheese");
            }


            else if (Pepperoni.Checked == true)
            {
                toppingList.Add("Pepperoni");
            }

            else if (Sausage.Checked == true)
            {
                toppingList.Add("Sausage");
            }
            
            else if (BlackOlives.Checked == true)
            {
                toppingList.Add("Black Olives");
            }
            
            else if (GreenPepper.Checked == true)
            {
                toppingList.Add("Green Peppers");
                return toppingsList;
            }

            else
            {
                return toppingsList;
            }
        }
    }
}