/**************Health Profile App********************
*                                                   *
*   Software Engineer: McKinnely Bentley 	        *
*   Description: Analyzes your health profile       *
*   and tells the user if he/she is in their        *
    ideal weight range.                             *
*   Inputs: Name, gender and date information.      *
*   Outputs: Analyzed data that shows the user      *
*   health information.	                            *
*                                                   *
*****************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHealthPrflGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
           
            string fname;
            string lname;
            string gender;
            int bMonth;
            int bDate;
            int bYear;
            int crntMnth, crntDate, crntYear;
            int height;
            int weight;

        //Calculate date error fixed.
        private void CalculateDataAcceptsNam(object sender, EventArgs e)
        {

            fname = fNameBox.Text;
            lname = lNameBox.Text;
            if (fname == "" || lname == "")
            {
                Console.Beep();
                MessageBox.Show("Please be sure to enter your fisrt and last name.");
            }

            try
            {
                bMonth = Convert.ToInt32(bMonthBox.Text);
                bDate = Convert.ToInt32(bDateBox.Text);
                bYear = Convert.ToInt32(bYearBox.Text);
                crntMnth = Convert.ToInt32(thisMnthBox.Text);
                crntDate = Convert.ToInt32(thisDateBox.Text);
                crntYear = Convert.ToInt32(thisYearBox.Text);
                height = Convert.ToInt32(heightBox.Text);
                weight = Convert.ToInt32(weightBox.Text);
            }

            catch (FormatException frmtEx)
            {
                Console.Beep();
                MessageBox.Show(frmtEx.Message + " Please enter number values in month, date, and years textboxes.");
            }
            catch (OverflowException ovrFlwEx)
            {
                Console.Beep();
                MessageBox.Show(ovrFlwEx.Message + " Wow! That's a lot of numbers there. Try to go easy on the age.");
            }




            HealthProfile myHealthPrfl = new HealthProfile(fname, lname, gender, bMonth, bDate, bYear, height, weight);

            myHealthPrfl.CurrenthMonth = crntMnth;
            myHealthPrfl.CurrentDate = crntDate;
            myHealthPrfl.CurrentYear = crntYear;
            myHealthPrfl.AgeMethod();

            myHealthPrfl.GetMaxHR();
            myHealthPrfl.GetMaxTrgtHR();
            myHealthPrfl.GetMinTrgtHR();
            myHealthPrfl.GetBMI();
            myHealthPrfl.GetBMICategory();
            gender = GetGender();




            resultLbl.Text = "Name:" + myHealthPrfl.UserName + "\n" + "Gender:" + gender + "\n" + "Age:" + myHealthPrfl.Age + "\n" + "Height:" + myHealthPrfl.Height + "\n" +
            "Weight:" + myHealthPrfl.Weight + "\n" + "Max Heart Rate:" + myHealthPrfl.MaxHR + "\n" + "Max Target Heart Rate:" + myHealthPrfl.MaxTrgtHR +
            "\n" + "Min  Targert Heart Rate:" + myHealthPrfl.MinTrgtHR + "\n" + "BMI:" + myHealthPrfl.BMI + "\n" + myHealthPrfl.BMICategory;

        }

        public string GetGender()
            {
                if (maleRdBtn.Checked)
                {
                     gender = "Male";
                }
                else gender = "Female";
                return gender;
            }
    }
}
