/**************Java Challenge************************
*                                                   *                                             
*   Software Engineer: McKinnely Bentley 	    *
*   Description: Just a personal challenge.         *
*   Inputs: the input are hard coded in.            *
*   Outputs: Outputs data based on specs given      *
*   in the challenge doc.                	    *
*  	     	      	                            *
*****************************************************/

import javax.swing.JOptionPane;
public class GraduationPlanner
{

  public  static void myPlanner()
	{
	java.awt.Toolkit.getDefaultToolkit().beep();//Beeps to help alert the user the program has started.  
double    rmnCUs          =    0;      // Created to get user input for remaining CU's.
double    perTerm         =    0;      // Created to get user input for CU's per term.
double    wguPrice        = 2890;      // Created to hold price per 1 term. 
double    wguTermLnth     =    6;      // Created to hold term length. 
double    rqdHours        =   12;      // Created to hold minimum required hours.
String    usrNm;                       // Created to capture the user's name to give the user a more personal feel. 
String    mnySmbl         = "$";       // Created to add money symbol to code. 
String    errorNoName     = "Your name can't be no more than 50 characters and no less than 1.";

boolean myBool = true;



  
  
//usrNm  = JOptionPane.showInputDialog ("Please enter your name: ");
do
{
try 
{
    usrNm  = JOptionPane.showInputDialog("Please enter your name: ");
    if(usrNm.length()> 0 && usrNm.length()<= 50)
{
    myBool = false;
}
 // Check length equals 0
    else if(usrNm.length() > 50 || usrNm.length()== 0)
 {
  throw new Exception();
 }
}

catch(Exception e) 
{
 usrNm = JOptionPane.showInputDialog(errorNoName);
}

    if(usrNm.length()> 0 && usrNm.length()<= 50)
{
    myBool = false;
}
} while(myBool);


//copy this code logic to the perTerm variable below and you can get rid of the noNegative method. It's now no longer needed.   
 myBool = true;
 while(myBool)
 {
 try
 {
	   rmnCUs = Double.parseDouble(JOptionPane.showInputDialog("Hello, " + usrNm + ". " + "Enter total number of CU's needed to graduate: "));
	    if (rmnCUs > -1) 
            {         
                myBool = false;
            }
            else if (rmnCUs <=1)
            {
                JOptionPane.showMessageDialog(null, usrNm + ". " + "Please make sure you are entering positive numbers: ");
            }                     
  }
 
     catch(NumberFormatException e)
     {
	    JOptionPane.showMessageDialog(null, usrNm + ". " + "Please make sure you are entering numeric values: ");
     }
}

 
 myBool = true;
 while(myBool)
 {
 try
 {
	   perTerm = Double.parseDouble(JOptionPane.showInputDialog("Enter planned number of units to complete per term: "));
           while (perTerm < rqdHours)  //Validates that the undergrade has enters 12 or more hours. 
    {
    perTerm = Double.parseDouble(JOptionPane.showInputDialog("Please enter " + rqdHours + " or more hours:"));
    }
	    if (rmnCUs > -1) 
            {         
                myBool = false;
            }
            else if (rmnCUs <=1)
            {
                JOptionPane.showMessageDialog(null, usrNm + ". " + "Please make sure you are entering positive numbers: ");
            }                     
  }
 
     catch(NumberFormatException e)
     {
	    JOptionPane.showMessageDialog(null, usrNm + ". " + "Please make sure you are entering numeric values: ");
     }
}

 
double     term      = rmnCUs/perTerm + (0.49);   /*  Created to divide remaining CU's by per term, the 0.49 was added to the term always round up 
                                                   if it is a decimal and always round down if it is an integer*/ 
           term     = Math.round(term);           // Created to round the term.
double     price     = term * wguPrice;            // Created to get the total cost.
double     months = term * wguTermLnth;        //  Created to get the months left.
  
        //Created to make the 3 outputs, term, price and months look readable.
 JOptionPane.showMessageDialog(null, usrNm + " ---You have " + term + " terms left ---Your total cost is " + mnySmbl + price + " ---You will graduate in " + months + " months---");
    /*When I tried using my "term" variable, inside of my switch statement
     I received a precision error asking me to use the int data type. Type 
     casting "term" and saving it in "isnpr" as int solved this challenge. 
     The case and switch was created to inspire the student as he/she succeeds  
    */   
  int inspr = (int)term;
switch (inspr)
   {    
    case 1:
         JOptionPane.showMessageDialog(null,("Great job, you are down to your last term!\n"));
        break;
    case 2:
         JOptionPane.showMessageDialog(null,("You have come a long ways. Good luck on your studies.\n"));
        break;
    case 3:
         JOptionPane.showMessageDialog(null,("You are doing great. Finish these last " + term + " terms with a bang!\n"));
        break;
    case 4:
         JOptionPane.showMessageDialog(null,("Ha, you have only " + term + " terms left, you have great dedication.\n"));
        break;
    case 5:
         JOptionPane.showMessageDialog(null,("Keep going, you will be down to 4 terms soon.\n"));
        break;
    case 6:
         JOptionPane.showMessageDialog(null,("Not too shabby, keep completing your terms.\n"));
        break;
    case 7:
         JOptionPane.showMessageDialog(null,("Great you are down to your " + term + "th term. Keep going and you will have great success.\n"));
        break;
    case 8:
          JOptionPane.showMessageDialog(null,(term + " terms left, keep going, you are awesome.\n"));
        break;
    case 9:
          JOptionPane.showMessageDialog(null,("We love the fact that you are moving forward. Good job.\n"));
        break;
    case 10:
          JOptionPane.showMessageDialog(null,("Sophomore, look at you, great job! Continue the good work and you will be a Junior soon.\n"));
        break;
    case 11:
          JOptionPane.showMessageDialog(null,("Remember, keep focusing on your goals, you will be on your last term before you know it.\n"));
        break;
    case 12:
         JOptionPane.showMessageDialog(null,("This is probably your fist term at WGU. We are happy to welcome you. You will do fine.\n"));
        break;  
              
    default:
        JOptionPane.showMessageDialog(null,("Please check with your mentor to make sure you inputted the accurate amount of terms.\n"));
        break;
   }
java.awt.Toolkit.getDefaultToolkit().beep();//Beeps to help alert the user the program has ended.
}

  public  static void main(String[] args)
   {
     myPlanner();
   } 
}
