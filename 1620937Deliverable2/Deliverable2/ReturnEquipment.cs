using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Deliverable2
{
    public partial class ReturnEquipment : Form
    {
        public ReturnEquipment()
        {
            InitializeComponent();
            //string rEquipmentIDQuery = "Select distinct EquipmentID from Equipment";
            //string rRentalIDQuery = "Select  distinct RentalID from Rental";
            string equipIDQuery = "Select distinct rEquipmentID from rentEquipment where returnTime is null and returnTo is null\r\norder by rEquipmentID";
            //SQL.editComboBoxItems(cboxEquipID, rEquipmentIDQuery);
            //SQL.editComboBoxItems(cboxRentalID, rRentalIDQuery);
            SQL.editComboBoxItems(cboxEquipID, equipIDQuery);
        }
        private void btnRecordReturn_Click_1(object sender, EventArgs e)
        {
            //variables
            string rEquipmentID = "", rRentalID = "", returnTime = "", returnTo = "", query = "";
            bool returnCreated = false;

            bool hasText = checkTextBoxes();
            if (!hasText)
            {
                MessageBox.Show("Please make sure all textboxes have text.");
                cboxEquipID.Focus();
                return;
            }

            //Check that the combo boxes hold data first
            if (cboxEquipID.SelectedItem == null
                || cboxRentalID.SelectedItem == null || cboxBranchReturn.SelectedItem == null)
            {
                //One of the boxes do not have a selected item
                MessageBox.Show("Please make sure that you select an equipment ID, rental ID and branch to return to");
                return;
            }

            rEquipmentID = cboxEquipID.SelectedItem.ToString();
            rRentalID = cboxRentalID.SelectedItem.ToString();
            returnTo = cboxBranchReturn.SelectedItem.ToString();
            //(1) GET the data from the textboxes and store into variables created above, good to put in a try catch with error message
            try
            {
                returnTime = txtReturnTime.Text.Trim();

            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Please make sure your text is in correct format.");
                return;
            }
            DateTime returnTimeParse;
            string format = "yyyy-MM-dd HH:mm:ss";
            if (!DateTime.TryParseExact(txtReturnTime.Text, format, null,
        System.Globalization.DateTimeStyles.None, out returnTimeParse))
            {
                MessageBox.Show("Failed to convert time. Use format yyyy-MM-dd hh:mm:ss");
                return;
            }


            //SQL.executeQuery("Update rentEquipment set returnTime = '" + returnTime + "', returnTo= '" + returnTo + "' where rEquipmentID like \'" + rEquipmentID + "\' and rRentalID like \'" + rRentalID + "'");
            //initialiseBoxes();
            //return;

            //query = "Select * from Equipment where BranchName like \'" + returnTo + "'";
            ////The SQL select query, using above string
            //SQL.selectQuery(query);
            //Console.WriteLine("1");
            //if (SQL.read.HasRows)
            //{
            //    Console.WriteLine("2");
            //    //cycle through all users checking if the username exists and
            //    //if the password matches
            //    while (SQL.read.Read())
            //    {
            //        Console.WriteLine("3");
            //        //SQL.read[i]: i=0 is UserName ... i=4 is Password
            //        if (rEquipmentID.Equals(SQL.read[0].ToString()) && returnTo.Equals(SQL.read[3].ToString()) && checkRentalID(rRentalID))
            //        {
            //            Console.WriteLine("4");
            //            returnCreated = true;
            //            SQL.executeQuery("Update rentEquipment set returnTime = '" + returnTime + "', returnTo= '" + returnTo + "' where rEquipmentID like \'" + rEquipmentID + "\' and rRentalID like \'" + rRentalID + "'");
            //            break; //stops the while loop since they have logged in
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("5");
            //    //Error message to show that no users have been registered
            //    MessageBox.Show("No equipment to return with those specifications.");
            //    return;
            //}
            //Console.WriteLine("6");
            ////if logged in display a success message
            //if (returnCreated)
            //{
            //    //message stating we logged in good
            //    initialiseBoxes();
            //}
            //else
            //{
            //    //message stating we couldn't log in
            //    MessageBox.Show("Return equipment attempt unsuccessful! Please check details");
            //    cboxEquipID.Focus();
            //    return;
            //}
            SQL.executeQuery("Update rentEquipment set returnTime = '" + returnTime + "', returnTo= '" + returnTo + "' where rEquipmentID like \'" + rEquipmentID + "\' and rRentalID like \'" + rRentalID + "'");


            Console.WriteLine("R1");
            SQL.selectQuery("Select * from rentEquipment where rRentalID = '"+rRentalID+"'");
            while (SQL.read.Read())
            {
                Console.WriteLine("R2");
                if (rEquipmentID.Equals(SQL.read[0].ToString()) && returnTo.Equals(SQL.read[3].ToString()))
                {
                    Console.WriteLine("R3");
                    MessageBox.Show("Successfully returned equipment");
                    initialiseBoxes();
                    return;
                }
            }
            Console.WriteLine("R4");
            MessageBox.Show("Return equipment attempt unsuccessful! Please check details");
            cboxEquipID.Focus();
        }
        private bool checkRentalID(string rRentalID)
        {
            //(2) SELECT statement getting all data from users, i.e. SELECT * FROM Users
            SQL.selectQuery("SELECT * from Rental");

            //(3) IF it returns some data, THEN check each username and password combination, ELSE There are no registered users
            //If there exists at least one User
            if (SQL.read.HasRows)
            {
                //cycle through all users checking if the username exists and
                //if the password matches
                while (SQL.read.Read())
                {
                    Console.WriteLine("a");
                    //SQL.read[i]: i=0 is UserName ... i=4 is Password
                    if (rRentalID.Equals(SQL.read[0].ToString()))
                    {
                        return true;
                    }
                }
            }
            else
            {
                //Error message to show that no users have been registered
                MessageBox.Show("No Rentals in database.");
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
            cboxBranchReturn.Items.Clear();
            cboxRentalID.Items.Clear();
            string equipIDQuery = "Select distinct rEquipmentID from rentEquipment where returnTime is null and returnTo is null\r\norder by rEquipmentID";
            SQL.editComboBoxItems(cboxEquipID, equipIDQuery);
            //makes next place user types the text box
            cboxEquipID.Focus();
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


        private void btnClear_Click(object sender, EventArgs e)
        {
            initialiseBoxes();
        }

        private void btnGetRentalID_Click(object sender, EventArgs e)
        {
            //Check that the combo boxes hold data first
            if (cboxEquipID.SelectedItem == null)
            {
                //One of the boxes do not have a selected item
                MessageBox.Show("Please make sure that you select an equipment ID");
                return;
            }
            string equipID = "";
            equipID  = cboxEquipID.SelectedItem.ToString();

            string rentalIDQuery = "Select distinct rRentalID from rentEquipment where rEquipmentID = '"+equipID+"' and returnTime is null and returnTo is null";

            SQL.selectQuery(rentalIDQuery);
            if (SQL.read.HasRows)
            {
                MessageBox.Show("RentalID obtained from \r\nequipment ID:" +equipID);
                SQL.editComboBoxItems(cboxRentalID, rentalIDQuery);
            }
            else
            {
                MessageBox.Show("No existing RentalID with equipment ID");
                cboxRentalID.Items.Clear();
            }
        }


        private void btnGetBranch_Click(object sender, EventArgs e)
        {
            //Check that the combo boxes hold data first
            if (cboxEquipID.SelectedItem == null)
            {
                //One of the boxes do not have a selected item
                MessageBox.Show("Please make sure that you select an equipment ID");
                return;
            }

            string equipID = "";
            equipID = cboxEquipID.SelectedItem.ToString();

            string branchQuery = "Select distinct hireFrom from Equipment left outer join rentEquipment on Equipment.EquipmentID = rentEquipment.rEquipmentID left outer join Rental on Rental.RentalID = rentEquipment.rRentalID where typeName in (Select typeName from equipment where EquipmentID = '"+equipID+"')";
            //string branchQuery2 = "Select distinct hireFrom from Equipment left outer join rentEquipment \r\non Equipment.EquipmentID = rentEquipment.rEquipmentID left outer join Rental \r\non Rental.RentalID = rentEquipment.rRentalID \r\nwhere typeName in (Select typeName from equipment where EquipmentID = '"+equipID+ "') and hirefrom not in \r\n(Select distinct branchName from Equipment left outer join rentEquipment \r\non Equipment.EquipmentID = rentEquipment.rEquipmentID left outer join Rental \r\non Rental.RentalID = rentEquipment.rRentalID \r\nwhere typeName in (Select typeName from equipment where EquipmentID = '"+equipID+"'))";
            SQL.selectQuery(branchQuery);
            if (SQL.read.HasRows)
            {
                MessageBox.Show("Branch obtained from \r\nequipment ID:" + equipID);
                SQL.editComboBoxItems(cboxBranchReturn, branchQuery);
            }
            else
            {
                MessageBox.Show("No existing branch with correlated equipment ID");
                cboxEquipID.Items.Clear();
            }

            //SQL.selectQuery(branchQuery2);
            //if (SQL.read.HasRows)
            //{
            //    SQL.editComboBoxItems(cboxBranchReturn, branchQuery2);
            //}
        }
    }
}
