using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Deliverable2
{
    public partial class RentalRecords : Form
    {
        public static string query = "Select EquipmentType.TypeName,startTime,returnTime,hireFrom,returnTo,Email\r\n" +
                                     "from rentEquipment join Rental\r\n" +
                                     "on rentEquipment.rRentalID = Rental.RentalID\r\n" +
                                     "join Customer on Customer.Email = Rental.CustomerEmail\r\n" +
                                     "join Equipment on Equipment.EquipmentID = rentEquipment.rEquipmentID\r\n" +
                                     "join EquipmentType on EquipmentType.TypeName = Equipment.TypeName";
        public RentalRecords()
        {
            InitializeComponent();
            DisplayQuery(query);
        }

        private void DisplayQuery(string q) 
        {
            //variables
            string typeName = "", startTime = "", returnTime = "", hireFrom = "", returnTo = "", email = "";

            //the SQL select query, using above string
            SQL.selectQuery(q + "\r\nOrder by startTime");

            //clear the listbox previous data
            listBoxDisplay.Items.Clear();

            try
            {
                //check that data has been returned
                //Then loop through each row, printing the data to the list box

                //Check that there is something to write into list box
                if (SQL.read.HasRows)
                {
                    //header
                    listBoxDisplay.Items.Add("typeName".PadRight(20) + "startTime".PadRight(30) + "returnTime".PadRight(30) +
                                             "hireFrom".PadRight(30) + "returnTo".PadRight(30) + "Email");

                    //loop through each table row from the database
                    while (SQL.read.Read())
                    {
                        //get the data values and store them in variables
                        typeName = SQL.read[0].ToString();
                        startTime = SQL.read[1].ToString();
                        returnTime = SQL.read[2].ToString();
                        hireFrom = SQL.read[3].ToString();
                        returnTo = SQL.read[4].ToString();
                        email = SQL.read[5].ToString();
                        //display each of the rows in a nice way
                        listBoxDisplay.Items.Add(typeName.PadRight(20) + startTime.PadRight(30) + returnTime.PadRight(30) +
                        hireFrom.PadRight(30) + returnTo.PadRight(30) + email);
                    }
                }
                else //where it doesnt have any successful searches
                {
                    listBoxDisplay.Items.Add("No rental records found.");
                }
            }
            catch
            {
                //If an error happens here, it means error in locating data
                MessageBox.Show("Error in querying database.  Please check that the database is connected.");
            }
        }

        private void resetRadio(RadioButton r) 
        {
            RadioButton[] rbtnArray = { rbtnFilterAll, rbtnFilterUp, rbtnFilterPast,rbtnFilterOn };
            for (int i = 0; i< rbtnArray.Length;i++) 
            {
                if (rbtnArray[i] != r)
                {
                    rbtnArray[i].Checked = false;
                }
            }
        }
        private void rbtnFilterAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFilterAll.Checked == true)
            {
                DisplayQuery(query);
                resetRadio(rbtnFilterAll);
            }
        }

        private void rbtnFilterUp_CheckedChanged(object sender, EventArgs e)
        {
                if (rbtnFilterUp.Checked == true)
                {
                    DisplayQuery(query + "\r\nwhere CURRENT_TIMESTAMP < startTime");
                    resetRadio(rbtnFilterUp);
                }
        }

        private void rbtnFilterPast_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFilterPast.Checked == true)
            {
                DisplayQuery(query + "\r\nwhere CURRENT_TIMESTAMP > startTime and CURRENT_TIMESTAMP > returnTime and returnTime is not null");
                resetRadio(rbtnFilterPast);
            }
        }

        private void rbtnFilterOn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFilterOn.Checked == true)
            {
                DisplayQuery(query + "\r\nwhere CURRENT_TIMESTAMP > startTime and (CURRENT_TIMESTAMP < returnTime or returnTime is null)");
                resetRadio(rbtnFilterOn);
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            //Hides the login page form from user
            this.Hide();
            //Create a Register Page object to change to
            CreateBooking createBooking = new CreateBooking();
            //show the register page
            createBooking.ShowDialog();
            //close the login page we are currently on
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //hides this form currently on
            Hide();
            //is the login page as a new object               
            RegisterPage registerPage = new RegisterPage();
            //Shows the login page window
            registerPage.ShowDialog();
            //closes the current open windows so its only the new one showing
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Hides the login page form from user
            this.Hide();
            //Create a Register Page object to change to
            ReturnEquipment returnEquipment = new ReturnEquipment();
            //show the register page
            returnEquipment.ShowDialog();
            //close the login page we are currently on
            this.Close();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            resetRadio(rbtnFilterAll);
            rbtnFilterAll.Checked = false;

            string query1 = "Select count(distinct CustomerEmail) as 'Unique Customers', hireFrom from Rental where startTime like '%2023%' group by hireFrom";
            SQL.selectQuery(query1);
            listBoxDisplay.Items.Add("Number of unique customers who rented quipment in each branch in 2023");
            while (SQL.read.Read())
            {
                listBoxDisplay.Items.Add(SQL.read[1].ToString().PadRight(30) + ": " + SQL.read[0].ToString());
            }
            listBoxDisplay.Items.Add("");

            string query2 = "Select distinct TypeName, sum(DateDiff(hour,startTime,returnTime))/count(DateDiff(hour,startTime,returnTime)) as 'Average rental duration' from\r\n" +
                "Equipment join rentEquipment on\r\n" +
                "Equipment.EquipmentID = rentEquipment.rEquipmentID\r\n" +
                "join Rental on Rental.RentalID = rentEquipment.rRentalID\r\n" +
                "where startTime like '%2023%'\r\ngroup by TypeName";
            SQL.selectQuery(query2);
            listBoxDisplay.Items.Add("Average rental duration per equipment type in 2023 (IN HOURS)");
            while (SQL.read.Read())
            {
                listBoxDisplay.Items.Add(SQL.read[0].ToString().PadRight(30) + ": " + SQL.read[1].ToString()+" hrs");
            }
            listBoxDisplay.Items.Add("");

                //3
                listBoxDisplay.Items.Add("Most popular equipment type rented in each branch in 2023");
            string query3 = "Select top 1 TypeName from Equipment\r\n\tjoin rentEquipment on Equipment.EquipmentID=rentEquipment.rEquipmentID\r\n\twhere BranchName = 'Auckland Central Branch'\r\n\tGroup by TypeName,BranchName\r\n\torder by BranchName, count(TypeName) desc";
            SQL.selectQuery(query3);
            while (SQL.read.Read())
            {
                listBoxDisplay.Items.Add("Auckland Central Branch: ".PadRight(30) + SQL.read[0].ToString());
            }
            query3 = "Select top 1 TypeName from Equipment\r\n\tjoin rentEquipment on Equipment.EquipmentID=rentEquipment.rEquipmentID\r\n\twhere BranchName = 'Christchurch Central Branch'\r\n\tGroup by TypeName,BranchName\r\n\torder by BranchName, count(TypeName) desc";
            SQL.selectQuery(query3);
            while (SQL.read.Read())
            {
                listBoxDisplay.Items.Add("Christchurch Central Branch: ".PadRight(30) + SQL.read[0].ToString());
            }
          
            query3 = "Select top 1 TypeName from Equipment\r\n\tjoin rentEquipment on Equipment.EquipmentID=rentEquipment.rEquipmentID\r\n\twhere BranchName = 'Hamilton East Branch'\r\n\tGroup by TypeName,BranchName\r\n\torder by BranchName, count(TypeName) desc";
            SQL.selectQuery(query3);
            while (SQL.read.Read())
            {
                listBoxDisplay.Items.Add("Hamilton East Branch: ".PadRight(30) + SQL.read[0].ToString());
            }
           
            query3 = "Select top 1 TypeName from Equipment\r\n\tjoin rentEquipment on Equipment.EquipmentID=rentEquipment.rEquipmentID\r\n\twhere BranchName = 'Tauranga Downtown Branch'\r\n\tGroup by TypeName,BranchName\r\n\torder by BranchName, count(TypeName) desc";
            SQL.selectQuery(query3);
            while (SQL.read.Read())
            {
                listBoxDisplay.Items.Add("Tauranga Downtown Branch: ".PadRight(30) + SQL.read[0].ToString());
            }
           
            query3= "Select top 1 TypeName from Equipment\r\n\tjoin rentEquipment on Equipment.EquipmentID=rentEquipment.rEquipmentID\r\n\twhere BranchName = 'Wellington CBD Branch'\r\n\tGroup by TypeName,BranchName\r\n\torder by BranchName, count(TypeName) desc";
            while (SQL.read.Read())
            {
                listBoxDisplay.Items.Add("Wellington CBD Branch: ".PadRight(30) + SQL.read[0].ToString());
            }
            SQL.selectQuery(query3);
           
            listBoxDisplay.Items.Add("");

            string query4 = "Select Count(RentalID) as 'Total number of rentals' ,year_ = DATEPART(YEAR,startTime), month_ = DATEPART(MONTH,startTime) from Rental\r\nwhere startTime >= '2023-01-01 00:00:00'\r\nand startTime <= '2024-01-01 00:00:00'\r\nGroup by DATEPART(YEAR,startTime),DATEPART(MONTH,startTime)";
            SQL.selectQuery(query4);
            listBoxDisplay.Items.Add("The total number of rentals per month in 2023");
            string[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            while (SQL.read.Read())
            {
                listBoxDisplay.Items.Add(months[int.Parse(SQL.read[2].ToString())-1] + ": " + SQL.read[0].ToString());
            }
            listBoxDisplay.Items.Add("Nov: 0");
            listBoxDisplay.Items.Add("Dec: 0");
            listBoxDisplay.Items.Add("");

            string query5 = "Select rEquipmentID,Equipment.TypeName,sum(ratePerHour)as sumRatePerHour,sum(DateDiff(hour,startTime,returnTime)) as hours_,sum(ratePerHour)*sum(DateDiff(hour,startTime,returnTime)) as 'total'  from EquipmentType\r\n" +
                "join Equipment on EquipmentType.TypeName = Equipment.TypeName\r\njoin rentEquipment on rentEquipment.rEquipmentID = Equipment.EquipmentID\r\njoin Rental on Rental.RentalID = rentEquipment.rRentalID\r\nwhere startTime like '%2023%'\r\ngroup by rEquipmentID,Equipment.TypeName";
            SQL.selectQuery(query5);
            listBoxDisplay.Items.Add("Total income generated by each equipment type in 2023");
            while (SQL.read.Read())
            {
                listBoxDisplay.Items.Add(SQL.read[1].ToString().PadRight(20) + ": $" + SQL.read[4].ToString());
            }
            listBoxDisplay.Items.Add("");
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            //Hides the login page form from user
            this.Hide();
            //Create a Register Page object to change to
            ChartForm chart = new ChartForm();
            //show the register page
            chart.ShowDialog();
            //close the login page we are currently on
            this.Close();
        }
    }
}
