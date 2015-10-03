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
     * CONOR , JAMES , CARLOS 
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
        private struct PizzaOrder
        {
            public string crust;
            public string sizeOfPizza;
            public string toppingList;

            public List<string> pizzaList;
            public int price;

            public void pizzaSize(ComboBox pizzaSizes, int price)
            {
            if (pizzaSizes.SelectedIndex.Equals(0))
            {
                price = 5;
                sizeOfPizza = "Small";

            }
            else if (pizzaSizes.SelectedIndex.Equals(1))
            {
                price = 6;
                sizeOfPizza = "Medium";
            }
            else if (pizzaSizes.SelectedIndex.Equals(2))
                price = 7;
                sizeOfPizza = "Large";
            }
        


            public void crustType(RadioButton crust1, RadioButton crust2, RadioButton crust3)
            {
                if (crust1.Checked == true)
                {
                    crust = "Thick";
                }
                else if (crust2.Checked == true)
                {
                    crust = "Thin";
                }
                else if (crust3.Checked == true)
                {
                    crust = "Stuffed Crust";
                }
                else MessageBox.Show("Please select a crust type");
            }
            public void toppingsChoice(CheckBox chkbx1, CheckBox chkbox2, CheckBox chkbox3, CheckBox chkbox4, CheckBox chkbox5, List<string> toppingList)
            {
                    {

                        if (chkbx1.Checked == true)
                        {
                            toppingList.Add("Cheese");
                        }
                        if (chkbox2.Checked == true)
                        {
                            toppingList.Add("Pepperoni");
                        }
                        if (chkbox3.Checked == true)
                        {
                            toppingList.Add("Sausage");
                        }
                        if (chkbox4.Checked == true)
                        {
                            toppingList.Add("Black Olives");
                        }
                        if (chkbx5.Checked == true)
                        {
                            toppingList.Add("Green Peppers");
                        }

                        //todo stop from adding to the list 
               
                        //if (chkbx1.Checked == false & chkbox2.Checked == false & chkbox3.Checked == false & chkbox4.Checked == false & chkbox5.Checked == false)
                        
                    }
                

                }
            
            // this loops over the toppings stored and builds a string to add to the list. 
            public string pizzaToppingsToString(List<string> pizzaToppingList)
            {

                int lengthOfList = pizzaToppingList.Count;

                string pizzaToppings = "";
                for (int x = 0; x < lengthOfList; x++)
                {
                    pizzaToppings += "" + pizzaToppingList.ElementAt(x) + "";
                }

                return pizzaToppings;
            }



            // overrides the tostring method to output info taken from form into meaninful strings
            public override string ToString()
            {
                return "Size" + sizeOfPizza + "Crust type: " + crust + " Toppings: " + toppingList;
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool toppingsTester = true;
            // prompt the user to see if their selection is correct
            DialogResult result = MessageBox.Show("Have you selected all of your pizza options ?", "Confirm", MessageBoxButtons.YesNo);

            // try while the pizza toppings list count is not nothing then it can be added to the list 

            {
                if (result == DialogResult.Yes && readToppings(toppingsTester) == true)
                {    
                    {

                        int priceOfPizza = 0 ;
                        
                        // first test we run to see if the user has selected toppings. 
                        

                        // declare the pizza object and create a new instance of it. 
                        PizzaOrder pizza = new PizzaOrder();

                        pizza.price = priceOfPizza;
                        pizza.pizzaSize(comboBoxPizzaSize, pizza.price);
                        // also declare the toppings list and pizza order list 
                        List<string> pt = new List<string>(); // pizza toppings 
                        List<string> pO = new List<string>();  // po pizza orer


                        //List<string> toppingsList = pt;



                        // get the crust type selected 
                        pizza.crustType(rdoThickCrust, rdoThinCrust, rdoStuffedCrust);



                        // get the toppings selected 
                        pizza.toppingsChoice(chkBoxCheese, chkBoxPepperoni, chkBoxSausage, chkBoxBlackOlive, checkBoxGreenPepper, pt);

                        pizza.toppingList = pizza.pizzaToppingsToString(pt);

                        // list the pizza to be ordered to the list box
                        listBoxOrderBuilder.Items.Add(pizza);

                        
                        lblPrice.Text = "Total : + " + pizza.price;

                        ClearToppings();

                    }

                }
            }
        }
        
        
        // clears the checkboxes
        private void btnClearToppings_Click(object sender, EventArgs e)
        {
            ClearToppings();

        }

        private void ClearToppings()
        {
            chkBoxCheese.Checked = false;
            chkBoxPepperoni.Checked = false;
            chkBoxSausage.Checked = false;
            chkBoxBlackOlive.Checked = false;
            checkBoxGreenPepper.Checked = false;
               
        }

        // one way to try and do it
        private bool readToppings(bool boolVal)
        {
            if (chkBoxCheese.Checked == false && chkBoxPepperoni.Checked == false && chkBoxSausage.Checked == false && chkBoxBlackOlive.Checked == false && checkBoxGreenPepper.Checked == false)
            
            {
                MessageBox.Show("Please select your toppings","Error Topppings Missing");
               
                return false;
              }
            else 
            {
                return boolVal;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBoxPizzaSize.Items.Add("Small");
            comboBoxPizzaSize.Items.Add("Medium");
            comboBoxPizzaSize.Items.Add("Large");
        }

      
    }
}

        #region CodeImAfraidToDelete

                //public string GetCrustType(RadioButton radioBtn1, RadioButton radioBtn2, RadioButton radioBtn3)
            //{
            //    string crustType = "none";
            //    if (radioBtn1.Checked == true)
            //    {
            //        crustType = "Thick Crust";
            //        return crustType;

            //    }
            //    else if (radioBtn2.Checked == true)
            //    {
            //        crustType = "Thin Crust";
            //        return crustType;
            //    }
            //    else if (radioBtn3.Checked == true)
            //    {
            //        crustType = "Stuffed Crust";
            //        return crustType;
            //    }
            //    else
            //    {
            //        return crustType;
            //    }

        // call the method to get the toppings and pass it the check boxes as well as the list to store the topping selections
        //       GetToppings(chkBoxCheese, chkBoxPepperoni, chkBoxSausage, chkBoxBlackOlive, checkBoxGreenPepper, toppingsList);

        //     GetToppings(chkBoxCheese, chkBoxPepperoni, chkBoxSausage, chkBoxBlackOlive, checkBoxGreenPepper, toppingsList);

        // add the crust to the listbox
        //   listBoxOrderBuilder.Items.Add(GetCrustType(rdoThickCrust, rdoThinCrust, rdoStuffedCrust));

        // add the toppings to the list box 
        //listBoxOrderBuilder.Items.Add(GetToppings(chkBoxCheese, chkBoxPepperoni, chkBoxSausage, chkBoxBlackOlive, checkBoxGreenPepper, toppingsList));


        //need to find a way to add the toppings to the list and test to make sure they go to the right pizza order. 
        // add each item in the toppings list to the list box 

        // {

        // }
        // }

        //}


        // try and pull the infro from the selected toppings check boxes 
            //private List<string> GetToppings(CheckBox Cheese, CheckBox Pepperoni, CheckBox Sausage, CheckBox BlackOlives, CheckBox GreenPepper, List<string> toppingList)
            //{
            //    if (Cheese.Checked == true)
            //    {
            //        toppingList.Add("Cheese");
            //        return toppingsList;
            //    }


            //    else if (Pepperoni.Checked == true)
            //    {
            //        toppingList.Add("Pepperoni");
            //        return toppingsList;
            //    }

            //    else if (Sausage.Checked == true)
            //    {
            //        toppingList.Add("Sausage");
            //        return toppingsList;
            //    }

            //    else if (BlackOlives.Checked == true)
            //    {
            //        toppingList.Add("Black Olives");
            //        return toppingsList;
            //    }

            //    else if (GreenPepper.Checked == true)
            //    {
            //        toppingList.Add("Green Peppers");
            //        return toppingsList;
            //    }

            //    else
            //    {
            //        return toppingsList;
        //    }
        #endregion
    
        

