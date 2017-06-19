/**************SecurityPlusQuizzer*******************
*                                                   *                                             
*   Software Engineer: McKinnely Bentley 	    *
*   Description: Quiz that is designed to help      *
*   CompTia Security Plus students study ports.     *
*   Inputs: Port number that relates to the port    *
*   name in question.                               *
*   Outputs: Message box will show correct for      *
*   every correct answer and a label will shows	    *
*   a total score percentage at the end.            *
*  	     	      	                            *
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

namespace SecurityPlusQuizzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }
        // PositionTracker is used to hold the current index position of the arrays.
        // errorChecker is used for excepting handling.
        int positionTracker = 0;
        int errorChecker;
        int quizEnded = 0;
        double score;

      
        string[] btn1_QuestionArray = { /*"RDP"*/ "IMAP", "POP3", "SSH", "HTTP", "HTTPS", "FTP Data Portal (Active Mode)", "FTP Control Port", "SSH", "SCP", "SFTP", "Telnet", "SMTP", "TACACS+", "DNS NAME QUIRIES", "DNS ZONE TRANSFERS", "TFTP", "HTTP", "KERBEROS", "POP3", "SNMP", "SNMP TRAP", "NETBIOS", "NETBIOS", "NETBIOS", "IMAP3", "LDAP", "HTTPS", "SMTP SSL/TLS", "IPSEC (FOR VPN WITH IKE)", "LDAP/SSL", "LDAP/TLS", "IMAP SSL/TLS", "POP SSL/TLS", "L2TP", "PPTP", "MS SQL SERVER", "" };
        string[] btn1_AnswerArray   = { "3389", "143", "110", "22", "80", "443", "20", "21", "22", "22", "22", "23", "25", "49", "53", "53", "69", "80", "88", "110", "161", "162", "137", "138", "139", "143", "389", "443", "465", "500", "636", "636", "993", "995", "1701","1723", "1433" };

        //Check button method starts***************************************************************
        private void CheckBtn1_Click(object sender, EventArgs e)
        {

            //Loops through btn1_QuestionArray to show the questions in a label while
            //also using exeption handling.
            while (btn1_QuestionArray.Length > positionTracker)
            {
               
                questionLabel.Text = btn1_QuestionArray[positionTracker];
                try
                {
                    errorChecker = Convert.ToInt32(answerTextBox.Text);
                }
                catch (FormatException frmtEx)
                {
                    Console.Beep();
                    MessageBox.Show(frmtEx.Message + " Please enter number values.");
                    break;
                }
                catch (OverflowException ovrFlwEx)
                {
                    Console.Beep();
                    MessageBox.Show(ovrFlwEx.Message + " Wow! That's a lot of numbers there. Try to go easy on the port numbers. Lol.");
                    break;
                }
                    if (answerTextBox.Text == btn1_AnswerArray[positionTracker])
                    {
                       
                        score++;
                        MessageBox.Show("Correct!");                   
                    }                 
                  
                   positionTracker++;                
                   break;
            }
            //Loop ends***************************************************************
            
            //Gets the score percentage.
            
            if (quizEnded == 1)
            {
                MessageBox.Show("End of quiz."); 
            }
            else if (positionTracker == btn1_QuestionArray.Length)
            {
                quizEnded++;
                score = score / (btn1_AnswerArray.Length) * 100;
                scoreLabel.Text = "Score: " + Math.Round(score) + "%";
                MessageBox.Show("End of quiz.");                
            }
        }
        //Check button method ends***************************************************************

        
        
        private void ShwAnsrBtn_Click(object sender, EventArgs e)
        {

            //Shows the current answer to the question or shows end of quiz
            //message box to keep from creating an array overflow exception.
            if (positionTracker == btn1_QuestionArray.Length)
            {             
                MessageBox.Show("End of quiz.");
            }
            else
            {
                MessageBox.Show("The answer is: " + btn1_AnswerArray[positionTracker]);
            }
        }




        
        int counter   = 0;
        int myCounter = 1;
        StringBuilder toDisplay = new StringBuilder();
       
        
        private void StdyModeBtn_Click_1(object sender, EventArgs e)
        {         
            while(btn1_QuestionArray.Length > counter)
            {
                
                if (myCounter == btn1_QuestionArray.Length)
                {                   
                    break;
                }
                
                toDisplay.Append(btn1_QuestionArray[counter]);
                toDisplay.Append(" = ");
                toDisplay.Append(btn1_AnswerArray[myCounter]);
                toDisplay.Append("\n");
                counter++;
                myCounter++;
               
            }           
                MessageBox.Show(toDisplay.ToString());                           
        }

              
  }                     
 }

       
                
               
                
        

     

