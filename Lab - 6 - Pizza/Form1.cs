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
        private struct PizzaOrder
        {
         public string crust;
          public   List<string> pizzaList;
           public string toppingList;
            
           public int price;

        
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
                if (chkbx1.Checked == true)
                {
                    toppingList.Add("Green Peppers");
                }
                else
                {
                    MessageBox.Show("Please select toppings for your pizza");
                }
            }

            public string pizzaToppingsToString(List<string> pizzaToppingList)
            {

                int lengthOfList = pizzaToppingList.Count;

                string pizzaToppings = "";
      //          while (pizzaToppingList.Count != 0) ;
        //        {
                    for (int x = 0; x < lengthOfList; x++)
                    {
                        pizzaToppings += "" + pizzaToppingList.ElementAt(x) + "";
                    }
          //      }
                return pizzaToppings;
            }

            

            // overrides the tostring method to output info taken from form into meaninful strings
            public override string ToString()
            {
                return "Crust type: " + crust + " Toppings: " + toppingList;
            }
 
        }
       
            private void btnConfirm_Click(object sender, EventArgs e)
            {
                // prompt the user to see if their selection is correct
                DialogResult result = MessageBox.Show("Have you selected all of your pizza options ?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    // declare the pizza object and create a new instance of it. 
                    PizzaOrder pizza = new PizzaOrder();
                    
                    // also declare the toppings list and pizza order list 
                    List<string> pt = new List<string>();
                    List<string> pO = new List<string>();  // po pizza orer

                    
                    //List<string> toppingsList = pt;

                   
                    
                    // get the crust type selected 
                    pizza.crustType(rdoThickCrust, rdoThinCrust, rdoStuffedCrust);

                    // get the toppings selected 
                    pizza.toppingsChoice(chkBoxCheese,chkBoxPepperoni,chkBoxSausage,chkBoxBlackOlive,checkBoxGreenPepper,pt);

                    pizza.toppingList = pizza.pizzaToppingsToString(pt); 

                    // list the pizza to be ordered to the list box
                    listBoxOrderBuilder.Items.Add(pizza);

                 

                }
            }
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
            }
        }
 //   }
