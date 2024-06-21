using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Deliverable2
{
    public partial class CreateBooking : Form
    {
        public CreateBooking()
        {
            InitializeComponent();
            string typeNameQuery = "Select distinct typeName from Equipment";
            string branchNameQuery = "Select distinct BranchName from Branch";
            SQL.editComboBoxItems(cboxEquipName, typeNameQuery);
            SQL.editComboBoxItems(cboxPickBranch, branchNameQuery);
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            //variables
            string typeName = "", branchName = "", startTime = "",email = "",equipID = "",query = "";
            bool bookingCreated = false;

            bool hasText = checkTextBoxes();
            if (!hasText)
            {
                MessageBox.Show("Please make sure all textboxes have text.");
                cboxEquipName.Focus();
                return;
            }

            //Check that the combo boxes hold data first
            if (cboxEquipName.SelectedItem == null
                || cboxPickBranch.SelectedItem == null || cboxEquipID.SelectedItem == null)
            {
                //One of the boxes do not have a selected item
                MessageBox.Show("Please make sure that you select an equipment,branch and equipment ID");
                return;
            }

            typeName = cboxEquipName.SelectedItem.ToString();
            branchName = cboxPickBranch.SelectedItem.ToString();
            equipID = cboxEquipID.SelectedItem.ToString();
            //(1) GET the data from the textboxes and store into variables created above, good to put in a try catch with error message
            try
            {
                startTime = txtStartTime.Text.Trim();
                email = txtEmail.Text.Trim();

            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Please make sure your text is in correct format.");
                return;
            }
            DateTime startTimeParse;
            string format = "yyyy-MM-dd HH:mm:ss";
            if (!DateTime.TryParseExact(txtStartTime.Text, format, null,
        System.Globalization.DateTimeStyles.None, out startTimeParse))
            {
                MessageBox.Show("Failed to convert time. Use format yyyy-MM-dd hh:mm:ss");
                return;
            }
            //string result = String.Format(format, startTime);
            if (checkEmail(email))
            {
                //(2) SELECT statement getting all data from users, i.e. SELECT * FROM Users
                SQL.selectQuery("SELECT * from Equipment");
                Console.WriteLine("A");
                //(3) IF it returns some data, THEN check each username and password combination, ELSE There are no registered users
                //If there exists at least one User
                if (SQL.read.HasRows)
                {
                    Console.WriteLine("B");
                    //cycle through all users checking if the username exists and
                    //if the password matches
                    while (SQL.read.Read())
                    {
                        Console.WriteLine("C");
                        //SQL.read[i]: i=0 is UserName ... i=4 is Password
                        if (typeName.Equals(SQL.read[4].ToString()) &&
                        branchName.Equals(SQL.read[3].ToString())&& equipID.Equals(SQL.read[0].ToString()))
                        {
                            Console.WriteLine("D");
                            //Username and Password correct, get fname, lname to
                            //display
                            //string startTimeFormat = String.Format("{0:d} {0:t}",startTime);
                            bookingCreated = true;
                            SQL.executeQuery("INSERT INTO Rental VALUES ('" + startTime + "', '" + branchName + "', '" + email + "')");
                            Console.WriteLine("D1");
                            SQL.executeQuery("Insert into rentEquipment values ('" + equipID + "','" + getRentalID() + "','" + startTime + "',null)");
                            Console.WriteLine("E");
                            //SQL.executeQuery("Update Equipment set available = '0' where BranchName = '" + branchName + "' and typeName = '" + typeName + "' and EquipmentID ='" + equipID + "'");
                            break; //stops the while loop since they have logged in
                        }
                    }
                }
                else
                {
                    Console.WriteLine("F");
                    //Error message to show that no users have been registered
                    MessageBox.Show("No users have been registered.");
                    return;
                }
                Console.WriteLine("G");
                //if logged in display a success message
                if (bookingCreated)
                {
                    Console.WriteLine("H");
                    //message stating we logged in good
                    initialiseBoxes();
                }
                else
                {
                    Console.WriteLine("I");
                    //message stating we couldn't log in
                    MessageBox.Show("Booking creation attempt unsuccessful! Please check details");
                    cboxEquipName.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid email");
            }

            Console.WriteLine("T1");
            SQL.selectQuery("Select * from Rental where CustomerEmail = '"+ email+"'");
            while (SQL.read.Read())
            {

                Console.WriteLine("T2");
                if (getRentalID().Equals(SQL.read[0].ToString()))
                {
                    Console.WriteLine("T3");
                    MessageBox.Show("Successfully created booking");
                    return;
                }
            }
            Console.WriteLine("T4");
            MessageBox.Show("Failed to create booking");
        }

        private string getRentalID() 
        {
            Console.WriteLine("11");
            string rentalID = "null";
            string query = "Select max(RentalID) from Rental";
            SQL.selectQuery(query);
            if (SQL.read.HasRows)
            {
                Console.WriteLine("22");
                //cycle through all users checking if the username exists and
                //if the password matches
                while (SQL.read.Read())
                {
                    Console.WriteLine("33");
                   return SQL.read[0].ToString(); 
                }
            }
            else
            {
                //Error message to show that no users have been registered
                MessageBox.Show("No max rental ID.");
                return "null";
            }
            return "null";
        }
        private bool checkEmail(string e) 
        {
            //(2) SELECT statement getting all data from users, i.e. SELECT * FROM Users
            SQL.selectQuery("SELECT * from Customer");

            //(3) IF it returns some data, THEN check each username and password combination, ELSE There are no registered users
            //If there exists at least one User
            if (SQL.read.HasRows)
            {
                //cycle through all users checking if the username exists and
                //if the password matches
                while (SQL.read.Read())
                {
                    //SQL.read[i]: i=0 is UserName ... i=4 is Password
                    if (e.Equals(SQL.read[0].ToString()))
                    {
                        return true;
                    }
                    Console.WriteLine("yay");
                }
            }
            else
            {
                //Error message to show that no users have been registered
                MessageBox.Show("No users have been registered.");
                return false;
            }
            return false;
        }

        /// <summary>
        /// Initialises all textboxes to blank text
        /// Re focus to first text box
        /// </summary>
        public void initialiseBoxes()
        {
            //goes through and clears all of the textboxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
                else if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndex = -1;
                }
            }
            cboxEquipID.Items.Clear();
            string typeNameQuery = "Select distinct typeName from Equipment";
            SQL.editComboBoxItems(cboxEquipName, typeNameQuery);
            //makes next place user types the text box
            cboxEquipName.Focus();
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

        private void btnRentalRecords_Click(object sender, EventArgs e)
        {
            //Hides the login page form from user
            this.Hide();
            //Create a Register Page object to change to
            RentalRecords rentalRecords = new RentalRecords();
            //show the register page
            rentalRecords.ShowDialog();
            //close the login page we are currently on
            this.Close();
        }

        private void btnGetEquipID_Click(object sender, EventArgs e)
        {
            //Check that the combo boxes hold data first
            if (cboxEquipName.SelectedItem == null
                || cboxPickBranch.SelectedItem == null)
            {
                //One of the boxes do not have a selected item
                MessageBox.Show("Please make sure that you select an equipment and a branch");
                return;
            }

            string typeName = "", branchName = "";
            typeName = cboxEquipName.SelectedItem.ToString();
            branchName = cboxPickBranch.SelectedItem.ToString();

            string equipID = "Select EquipmentID from Equipment where BranchName like \'" + branchName + "\' and TypeName like \'" + typeName + "' and available = '1'";

            SQL.selectQuery(equipID);
            if (SQL.read.HasRows)
            {
                MessageBox.Show("EquipmentID obtained from \r\nbranch:" + branchName + "\r\nEquipment Name: " +typeName);
                SQL.editComboBoxItems(cboxEquipID, equipID);
            }
            else 
            {
                MessageBox.Show("No existing/available EquipmentID with correlated branch and equipment name");
                cboxEquipID.Items.Clear();
            }



        }

        private void btnRecent_Click(object sender, EventArgs e)
        {
            if (cboxPickBranch.SelectedItem == null)
            {
                //One of the boxes do not have a selected item
                MessageBox.Show("Please make sure that you select a branch");
                return;
            }
            string branchName = cboxPickBranch.SelectedItem.ToString();
            MessageBox.Show("Equipment names have been sorted by most recently purchased from branch: " +branchName);
            string typeNameQuery = "Select typeName,max(purchaseDate) as 'Most Recent'from Equipment where BranchName = '" + branchName+ "' group by typeName order by max(purchaseDate) desc";
            SQL.editComboBoxItems(cboxEquipName, typeNameQuery);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            initialiseBoxes();
        }
    }
}
