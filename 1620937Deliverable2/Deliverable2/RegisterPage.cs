using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliverable2
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Registers the new user as long as all textboxes hold text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //variables to be used
            string fName = "", lName = "", phone = "", email = "";

            //Check that the text boxes has something typed in it using a method
            bool hasText = checkTextBoxes();
            if (!hasText)
            {
                MessageBox.Show("Please make sure all textboxes have text");
                txtFname.Focus();
                return;
            }



            //(1) GET the data from the textboxes and store into variables created above, good to put in a try catch with error message
            try
            {
                //GET the users data and store into variables
                fName = txtFname.Text.Trim();
                lName = txtLname.Text.Trim();
                phone = txtPhone.Text.Trim();
                email = txtEmail.Text.Trim();

            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Please make sure your text is in correct format.");
                return;
            }


            if (!IsValidEmail(email)) 
            {
                MessageBox.Show("Invalid email address");
                return;
            }

            if (!Regex.IsMatch(phone, @"^[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]$")) 
            {
                MessageBox.Show("Failed to convert phone number. Use format [0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]");
                return;
            }

            if (!Regex.IsMatch(fName, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid first name");
                return;
            }

            if (!Regex.IsMatch(lName, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid last name");
                return;
            }

            //(2) Execute the INSERT statement, making sure all quotes and commas are in the correct places.
            //      Practice first on SQL Server Management Studio to make sure it is entering the correct data and in the correct format,
            //      then copy across the statement and where there are string replace the actual text for the variables stored above.
            //Example query: " INSERT INTO Users VALUES ('jkc1', 'John', 'Middle', 'Carter', 'pass1') "
            try
            {
                //Using the SQL class executeQuery, INSERT statement to put data into
                //database
                // INSERT INTO Users VALUES ('jkc1', 'John', 'Middle', 'Carter', 'pass1')
                SQL.executeQuery("INSERT INTO Customer VALUES ('" + email + "', '" + fName +
                "', '" + lName + "', '" + phone + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Register attempt unsuccessful.  Check insert statement.");
                return;
            }



            //success message for the user to know it worked
            MessageBox.Show("Successfully Registered");

            //hides this form currently on
            Hide();
            //is the login page as a new object               
            RentalRecords rentalRecords = new RentalRecords();
            //Shows the login page window
            rentalRecords.ShowDialog();
            //closes the current open windows so its only the new one showing
            this.Close();
        }

        /// <summary>
        /// Clears all text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            initialiseTextBoxes();
        }


        /// <summary>
        /// Checks if they textboxes have data in them
        /// </summary>
        /// <returns>TRUE if all hold text, but FALSE if at least one does not hold data</returns>
        private bool checkTextBoxes()
        {
            bool holdsData = true;
            //go through all of the controls
            foreach (Control c in this.Controls)
            {
                //if its a textbox, but doesnt matter if its middle textbox
                if (c is TextBox)
                {
                    //If it is not the case that it is empty
                    if ("".Equals((c as TextBox).Text.Trim()))
                    {
                        //set boolean to false because on textbox is empty
                        holdsData = false;
                    }
                }
            }
            //returns true or false based on if data is in all text boxs or not
            return holdsData;
        }
        /// <summary>
        /// Initialises all textboxes to blank text
        /// Does nothing in terms of re-focusing
        /// </summary>
        private void initialiseTextBoxes()
        {
            //goes through and clears all of the textboxes
            foreach (Control c in this.Controls)
            {
                //if the it is a textbox
                if (c is TextBox)
                {
                    //clear the text box
                    (c as TextBox).Clear();
                }
            }
            //focus on first text box
            txtFname.Focus();
        }

        private void btnRentalRecords_Click(object sender, EventArgs e)
        {
            //hides this form currently on
            Hide();
            //is the login page as a new object               
            RentalRecords rentalRecords = new RentalRecords();
            //Shows the login page window
            rentalRecords.ShowDialog();
            //closes the current open windows so its only the new one showing
            this.Close();
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

    }
}
