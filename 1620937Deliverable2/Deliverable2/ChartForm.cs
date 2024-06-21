using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Deliverable2
{

    public partial class ChartForm : Form
    {
        ArrayList branchList;
        ArrayList rentalCountList;
        public ChartForm()
        {
            InitializeComponent();
            branchList = initialiseBranch();
            rentalCountList = initialiseRentalCount();
            initChart(branchList, rentalCountList);
        }

        private void initChart(ArrayList b, ArrayList r)
        {
            string chart_type_strng = (string)((ComboBox)this.Controls["cboxChart"]).SelectedItem;
            if (chart_type_strng == null)
            {
                chart_type_strng = "Line";
            }
            SeriesChartType chartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), chart_type_strng);

            Chart chart = (Chart)this.Controls["chartRental"];

            chart.Series.Clear();
            chart.Titles.Clear();

            chart.Titles.Add("Number of rentals per branch");
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            //chart.ChartAreas["ChartArea"].AxisY.MajorGrid.LineWidth = 0;

            Series series1 = new Series("High");
            series1.ChartType = chartType;

            for (int i = 0; i < b.Count; i++)
            {
                series1.Points.AddXY(b[i], r[i]);

            }
            chart.Series.Add(series1);



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
        private ArrayList initialiseBranch()
        {
            SQL.selectQuery("Select distinct branchName from Equipment");
            ArrayList branchList = new ArrayList();
            try
            {
                if (SQL.read.HasRows)
                {

                    //loop through each table row from the database
                    while (SQL.read.Read())
                    {
                        branchList.Add(SQL.read[0].ToString());
                    }
                }
            }
            catch
            {
                //If an error happens here, it means error in locating data
                MessageBox.Show("Error in querying database.  Please check that the database is connected.");
            }
            return branchList;
        }
        private ArrayList initialiseRentalCount()
        {
            SQL.selectQuery("Select distinct hireFrom, count(hireFrom) from Rental\r\ngroup by hireFrom");
            ArrayList rentalCountList = new ArrayList();
            try
            {
                if (SQL.read.HasRows)
                {
                    //loop through each table row from the database
                    while (SQL.read.Read())
                    {
                        rentalCountList.Add(SQL.read[1].ToString());
                    }
                }
            }
            catch
            {
                //If an error happens here, it means error in locating data
                MessageBox.Show("Error in querying database.  Please check that the database is connected.");
            }
            return rentalCountList;
        }

        private void cboxChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            initChart(branchList, rentalCountList);
        }
    }
}
