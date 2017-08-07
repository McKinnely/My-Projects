/**************Health Profile App********************
*                                               *
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthPrflGUI
{
    class HealthProfile
    {
        double _maxTrgtHR;
        double _minTrgtHR;
        double _bmi;
        string _underweight  = "BMI Category: Underweight";
        string _overweight   = "BMI Category: Overweight";
        string _normalWeight = "BMI Category: Normal Weight";
        string _obese        = "BMI Category: Obese";


        public HealthProfile(string _fname, string _lname, string _gender, int _birthMonth, int _birthDate, int _birthYear, int _height, int _weight)
        {
            BirthMonth = _birthMonth;
            BirthDate  = _birthDate;
            BirthYear  = _birthYear;
            Weight     = _weight;
            Height     = _height;
            UserName   = _fname + " " + _lname;
            //Age is set inside of the below AgeMethod.
        }

        public string FirstName   { get; set; }
        public string LastName    { get; set; }
        public string UserName    { get; set; }
        public bool Gender        { get; set; }
        public int BirthMonth     { get; set; }
        public int Age            { get; set; }
        public int BirthDate      { get; set; }
        public int BirthYear      { get; set; }
        public int CurrenthMonth  { get; set; }
        public int CurrentDate    { get; set; }
        public int CurrentYear    { get; set; }
        public int Height         { get; set; }
        public int Weight         { get; set; }
        public double MaxHR       { get; set; }
        public double MaxTrgtHR   { get; set; }
        public double MinTrgtHR   { get; set; }
        public double BMI         { get; set; }
        public string BMICategory { get; set; }


        //Purpose:To logically calculate ones age based on the data that's enetered. 
        //Reason :To get one's age for use inside of the BMI equation.

        /*
        Side Note:This below method was coded given the code challenge specifictations. If this was coded for a production enviornment I would just 
        use the built in datetime()
        */
        public void AgeMethod()
        {
            Age = CurrentYear - BirthYear;
            if (CurrenthMonth < BirthMonth)
            {
                Age--;
            }
            else if (CurrenthMonth == BirthMonth && CurrentDate < BirthDate)
            {
                Age--;
            }

        }

        //Purpose:The purpose of the this method  is to obtian the user's max heart rate.
        //Reason :The reason is to display the data to the user for health information.
        public void GetMaxHR()
        {
            if (Age == 0)
            {
                return;
            }
            MaxHR = 220 - Age;
        }


        //Purpose:The purpose of the this method  is to obtian the user's max target heart rate.
        //Reason :The reason is to display the data to the user for health information.
        public void GetMaxTrgtHR()
        {

            _maxTrgtHR = Math.Round(MaxHR * 0.85);
            MaxTrgtHR = _maxTrgtHR;
        }

        //Purpose:The purpose of the this method  is to obtian the user's minimum target heart rate.
        //Reason :The reason is to display the data to the user for health information.
        public void GetMinTrgtHR()
        {
            _minTrgtHR = Math.Ceiling(MaxHR / 2);
            MinTrgtHR = _minTrgtHR;
        }
        //Purpose:The purpose of the this method  is to obtian the user's BMI from the give BMI equation. 
        //Reason :The reason is to display the user's data to show the user which weight category the user is in. 
        public void GetBMI()
        {
            _bmi = ((double)Weight * 703) / ((double)Height * Height);
            BMI = Math.Round(_bmi, 1);
        }

        //Purpose:The purpose of the this method  is to obtian the user's BMI.
        //Reason :The reason is to display the user's data to show the user which weight category the user is in. 
        public void GetBMICategory()
        {
            if (Weight == 0)
            {
                return;
            }
            if (BMI < 18.5)
            {
                BMICategory = _underweight;
            }
            else if (BMI > 18.5 && BMI < 24.9)
            {
                BMICategory = _normalWeight;
            }
            else if (BMI > 25 && BMI < 29.9)
            {
                BMICategory = _overweight;
            }
            else
            {
                BMICategory = _obese;
            }
        }

    }
}


