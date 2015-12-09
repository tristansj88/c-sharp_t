
//Project: Pet Naming Program
//Name:Tristan San Juan
//Date: 12/08/2015
//Purpose:Displays their pet name from their entry
//Class: POS/409
//Intructor: Ashish Gulati

//Hello this is Ahmed
//hi there

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPetName
{
    public partial class frmPetName : Form
    {
        public frmPetName()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //declaring a variable
            string Pet  = txtPetsName.Text;

            if (Pet == "")
            {
                //if statemen to make sure the user enters something
                MessageBox.Show("Please Enter Something in the Line");
               this.txtPetsName.Focus();
            }
         
            else
            {
             //what the label change to when they press display
            this.lblResult.Text = ("My pet's Name is Lucky, Duke, Foxie and Beauty" 
            + Environment.NewLine  + "and Your Pet's Name is " + Pet+".");
            }
           



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //clears the text field and puts the lable back to blank
            this.txtPetsName.Clear();
            this.lblResult.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // exits application
            Application.Exit(); 

        }
    }
}
