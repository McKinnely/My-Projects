using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Tech_Jeopardy
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer playerI_Lived = new System.Media.SoundPlayer();
      
        public Form1()
        {
            InitializeComponent();
            //Created to disable the user from entering data into the textboxes when the application starts. 
            //The reasoning was because the tab would jump in the cpu textbox immediately upon the user pressing enter. 
            usrTxtBx.Enabled = false;
            cpuTxtBx.Enabled = false;
            playerI_Lived.SoundLocation  = "I_Lived.wav";
            playerI_Lived.Play();
            
        }

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer userTimer;

        //I coded arrays questionArray, and answerArray, to logically match each other question and answser based on the same indexes.
        string[] questionArray = 
            {
            /*CompTia -->*/ "What's the port number for SSH?", "What's the port number for HTTPS?", "What's the port number for PPTP?", "What's the port number forTACACS+", /*<--CompTia*/ 
              /*Linux--> */  "Which of the following commands does not reboot the system?  shutdown –r now, init 6, reboot, telinit 0.", "NTP is used to synchronize the system________with a central resource. clock, restoration, backup, or command processor",
              /*Linux-->*/  "How can you set the SGID on a file called PaulPaulitoTest? Chmod g+s PaulPaulitoTest, Chmod u+t PaulPaulitoTest, Chmod u+s PaulPaulitoTest, Chmod o+s PaulPaulitoTest",
             /*Linux-->*/   "What command will set a regular users password to force changing it every 90 days? Choose all that apply. useradd –e 90 userpaul,chage –M 90 userpaul, passwd +x 90 userpaul, usermod –f 90 userpaul, passwd –x 90 userpaul",
             /*C#*     */   "What data type holds data that can be a mixture of text and numbers?", "The operator used to access member function of a class? ____", "Can C# use the Boolean data type?", "Was C# created with JavaScript?",
            /*Java     */   "An array is a group of _______, called elements or components?", "The number used to refer to a particular array element is called the element's _______?", "THe first node of a tree is the _____node.",
            /*Java     */   "A queue is referred to as a(n)_______ data structure because the first nodes inserted are the first ones removed?",
            /*Networks */   "What's the port number for LDAP?", "What's the port number for SMTP?","What's the port number for HTTP?", "What's the port number for TELNET?",
            /*Computer Science */ "The brain of the computer is the _______?", "The binary system uses powers of __? (Enter a number)", "Which access method is used for obtaining a record from a cassette tape?", "The section of the CPU that selects, interprets and sees to the execution of program instructions?"
            };

        string[] answerArray =
            { 
            /*CompTia*/        "22", "443", "1723", "49", 
             /*Linux*/          "telinit 0", "clock", "Chmod g+s PaulPaulitoTest", "passwd –x 90 userpaul",
             /*C#*  */          "String", ".", "Yes", "No",
             /*Java */          "Variables", "Index", "Root", "FIFO",
            /*Networks */       "389", "25", "80", "23",
            /*Computer Science */"CPU", "2", "Sequential", "Control unit",
            };

        //Coded list to randomaly give relevant incorrect data for the cpu. 
        //Each of these will be with a corrosponding button category.
        List<string> cmpTiaRndmArray      = new List<string> { "69", "88", "20", "44" };
        List<string> linuxRndmArray       = new List<string> { "init 6", "reboot", "shutdown –r now", "init 6", "command processor", "useradd –e 90 userpaul", "Linux -Help" };
        List<string> cSharpRndmArray      = new List<string> { "Int", "::", "Thinking....", "Not sure", "C#" };
        List<string> javaRndmArray        = new List<string> { "LIFO", "STAC", "Big-O", "Sort"};
        List<string> networkRndmArray     = new List<string> { "18", "33", "20", "90", "22" };
        List<string> computerSciRndmArray = new List<string> { "ALU", "1", "", "Open Unit", "Logic Bypass" };

        
        int positionTracker  =  0;
        int timer_cntr       = 10;
        int userTimerCounter = 10;
        int userScore        =  0;
        int cpuScore         =  0;


        string showQ;
        string scoreHolder;

        bool timer_stopper   = false;
        bool userEnterButton = false;


        //Purpose: Enables each button after it is disable
        //Reason:  This happens because all of the buttons will be disasbled by the btnDisable method when a user clicks a question button.
        private void BtnEnabler()
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.Enabled = true;
            }
        }


        private void BtnDisabler(Button acceptionBtn)
        {

            foreach (Button button in this.Controls.OfType<Button>())
            {

                button.Enabled = false;
            }

            acceptionBtn.Enabled = true;
            usrAnswrBtn.Enabled  = true;
            cpuAnswrBtn.Enabled  = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer_cntr--;
            if (timer_cntr == 0)
                timer1.Stop();
            timerLbl.Text = timer_cntr.ToString();
            if (timer_cntr == 3)
            {
                cpuAnswrBtn.PerformClick();
            }
            if (timer_cntr == 0)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    button.Enabled = true;
                }

            }
        }

       /* private void userTimerTick(object sender, EventArgs e)
        {
            
            userTimerCounter--;
            if (userTimerCounter == 0)
                userTimer.Stop();
            userTimerLbl.Text = userTimerCounter.ToString();
            if (userTimerCounter == 0)
            {
               
             
                if (usrTxtBx.Text == answerArray[positionTracker])
                {
                    //wait ten secs then read the input. 
                    userScore += Convert.ToInt32(scoreHolder);
                    
                    humanScore.Text = "$" + userScore.ToString();
                    useRt_Or_WrngLbl.Text = "Correct";
                    usrTxtBx.Clear();
                }
                else
                {
                   
                    userScore -= Convert.ToInt32(scoreHolder);
                    humanScore.Text = "$" + userScore.ToString();
                    useRt_Or_WrngLbl.Text = "Almost";
                    usrTxtBx.Clear();
                }
             

            }
        
    */


     //Purpose:Created to stop, set and restart the time if it hits 0.
     //Reason :I encounterd the timer counting below zero and not restarting. This allowed for this issue to be rectfied.
        private void timerCntDwnStop()
        {
            if (timer_cntr == 0)
            {
                timer1.Stop();
                timer_cntr = 10;
                timer1.Start();
            }
        }

        /* private void userTmrCntDwnStop()
         {
             if (userTimerCounter == 0)
             {
                 userTimer.Stop();
                 userTimerCounter = 10;
                 userTimer.Start();
             }
         }
         */


        //Purpose:To loop through every button and 
        //Reason :
        private void showQuestion()
        {

            foreach (Button button in this.Controls.OfType<Button>())
            {

                showQ = button.Text.ToString();

                if (showQ.Contains("$"))
                {
                    qstnLbl.Text = questionArray[positionTracker];                   
                }

            }

        }

        private void DollarSignRmvr(string dlrRmvr)
        {
            scoreHolder = scoreHolder.Remove(0, 1);
        }

        //Purpose: The orginal purpose was to just run the timer logic on every method, but I also put other methods inside of it because 
        //to keep from having to call them inside of each button
        
        private void TimerObjectLogic()
        {           
            showQuestion();
            int counter = 10;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            timerCntDwnStop();
            timerLbl.Text = counter.ToString();
        }
        /*
        private void userAnswerTimer()
        {         
            int counter = 10;
            userTimer = new System.Windows.Forms.Timer();           
            userTimer.Interval = 1000; // 1 second
            userTimer.Tick += new EventHandler(userTimerTick);
            userTimer.Start();

            userTmrCntDwnStop();
            userTimerLbl.Text = counter.ToString();
        }
        */

      


        

        private void UserPressedEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (usrTxtBx.Text == answerArray[positionTracker])
                {
                    userScore += Convert.ToInt32(scoreHolder);
                    humanScore.Text = "$" + userScore.ToString();
                    useRt_Or_WrngLbl.Text = "Correct";
                    usrTxtBx.Clear();
                }
                else
                {
                    userScore -= Convert.ToInt32(scoreHolder);
                    humanScore.Text = "$" + userScore.ToString();
                    useRt_Or_WrngLbl.Text = "Almost";
                    usrTxtBx.Clear();
                }
                usrTxtBx.Enabled = false;
            }
        }
        //Purpose:Disables both the user and cpu red buttons when clicked and both stops and resets the time.
        //Reason :This keeps the user and cpu from pressing the button while the other user is already answering it.
        private void UsrAnswrBtn_Click(object sender, EventArgs e)
        { 
            cpuAnswrBtn.Enabled = false;
            usrAnswrBtn.Enabled = false;
            if (timer_stopper == false)
            {
                return;
            }
            timer1.Stop();
            BtnEnabler();
            usrQstnLbl.Text = questionArray[positionTracker];
            timer_cntr = 10;
            usrAnswrBtn.Enabled = false;  //I did this to keep the button from going to negative numbers if the user decides to rapidly clic it. 
            usrTxtBx.Enabled = true;      
        }

        private void CpuAnswrBtn_Click(object sender, EventArgs e)
        {         
            usrAnswrBtn.Enabled = false;
            if (timer_stopper == false)
            {
                return;
            }
            timer1.Stop();
            BtnEnabler();

            cpuQstnLbl.Text = questionArray[positionTracker];
            CpuThinker(positionTracker);
            timer_cntr = 10;
        }

        //Purpose:To randomly pick array data based on cpu's incorrect answer
        //Reason :The reason for this is to make the cpu answer incorrectly but with relevant data
        private void RndmAnswerPicker(string btnCategory)
        {

            Random rnd = new Random();
            int cmpTiaIndex   =  rnd.Next(cmpTiaRndmArray.Count      - 1 );
            int linuxIndex    =  rnd.Next(linuxRndmArray.Count       - 1 );
            int cSharpIndex   =  rnd.Next(cSharpRndmArray.Count      - 1 );
            int javaIndex     =  rnd.Next(javaRndmArray.Count        - 1 );
            int networkIndex  =  rnd.Next(networkRndmArray.Count     - 1 );
            int cmpSciIndex   =  rnd.Next(computerSciRndmArray.Count - 1 );


            switch (btnCategory)
            {
                case "CompTia":
                    cpuTxtBx.Text = ((cmpTiaRndmArray[cmpTiaIndex]));
                    break;
                case "Linux":
                    cpuTxtBx.Text = ((linuxRndmArray[linuxIndex]));
                    break;
                case "C#":
                    cpuTxtBx.Text = ((cSharpRndmArray[cSharpIndex]));
                    break;
                case "Java":
                    cpuTxtBx.Text = ((javaRndmArray[javaIndex]));
                    break;
                case "Networks":
                    cpuTxtBx.Text = ((networkRndmArray[networkIndex]));
                    break;
                case "Computer Science":
                    cpuTxtBx.Text = ((computerSciRndmArray[cmpSciIndex]));
                    break;
            }

        }

        //Purpose:To get the number associated with the button in use and send that data to the above RndmAnswerPicker
        //Reason :The reason for this is to make the cpu answer incorrectly but with relevant data
        private void CpuThinker(int btnPressed)
        {

            Random rnd = new Random();
            var guessAcrcy = rnd.Next(1, 3);
            if (guessAcrcy == 2)
            {
                cpuTxtBx.Text = answerArray[positionTracker];
                cpuScore += Convert.ToInt32(scoreHolder);               
                athenaScore.Text = "$" + cpuScore.ToString();
                cpuRt_Or_WrngLbl.Text = "Correct";
            }
            else
            {
                cpuScore -= Convert.ToInt32(scoreHolder);
                athenaScore.Text = "$" + cpuScore.ToString();
                cpuRt_Or_WrngLbl.Text = "Almost";
               

                switch (btnPressed)
                {
                    case 0: case 1: case 2: case 3:
                        RndmAnswerPicker("CompTia");
                        break;
                    case 4: case 5: case 6: case 7:
                        RndmAnswerPicker("Linux");
                        break;
                    case 8: case 9: case 10: case 11:
                        RndmAnswerPicker("C#");
                        break;
                    case 12: case 13: case 14: case 15:
                        RndmAnswerPicker("Java");
                        break;
                    case 16: case 17: case 18: case 19:
                        RndmAnswerPicker("Networks");
                        break;
                    case 20: case 21: case 22:case 23:
                        RndmAnswerPicker("Computer Science");
                        break;
                }
            }
        }


        /*
        Purpose:The purpose of all of the below functions is too logically pare of all inputed data.
        Reaon:  The reason for this is to uniformally have all methods work correctly together.
        */

        private void CmpTiaSecBtn1_Click(object sender, EventArgs e)
        {
            scoreHolder = cmpTiaSecBtn1.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cmpTiaSecBtn1.Hide();
            positionTracker = 0;
            TimerObjectLogic();
            BtnDisabler(cmpTiaSecBtn1);
        }


        private void CmpTiaSecBtn2_Click(object sender, EventArgs e)
        {

            scoreHolder = cmpTiaSecBtn2.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cmpTiaSecBtn2.Hide();
            positionTracker = 1;
            TimerObjectLogic();
            BtnDisabler(cmpTiaSecBtn2);
        }

        private void CmpTiaSecBtn3_Click(object sender, EventArgs e)
        {
            scoreHolder = cmpTiaSecBtn3.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cmpTiaSecBtn3.Hide();
            positionTracker = 2;
            TimerObjectLogic();
            BtnDisabler(cmpTiaSecBtn3);
        }

        private void CmpTiaSecBtn4_Click(object sender, EventArgs e)
        {
            scoreHolder = cmpTiaSecBtn4.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cmpTiaSecBtn4.Hide();
            positionTracker = 3;
            TimerObjectLogic();
            BtnDisabler(cmpTiaSecBtn4);
        }

        private void LinuxBtn1_Click(object sender, EventArgs e)
        {
            scoreHolder = linuxBtn1.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            linuxBtn1.Hide();
            positionTracker = 4;
            TimerObjectLogic();
            BtnDisabler(linuxBtn1);
        }


        private void LinuxBtn2_Click(object sender, EventArgs e)
        {
            scoreHolder = linuxBtn2.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            linuxBtn2.Hide(); 
            positionTracker = 5;
            TimerObjectLogic();
            BtnDisabler(linuxBtn2);
        }

        private void LinuxBtn3_Click(object sender, EventArgs e)
        {
            scoreHolder = linuxBtn3.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            linuxBtn3.Hide(); 
            positionTracker = 6;
            TimerObjectLogic();
            BtnDisabler(linuxBtn3);
        }

        private void LinuxBtn4_Click(object sender, EventArgs e)
        {
            scoreHolder = linuxBtn4.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            linuxBtn4.Hide(); 
            positionTracker = 7;
            TimerObjectLogic();
            BtnDisabler(linuxBtn4);
        }

        private void CSharpBtn1_Click(object sender, EventArgs e)
        {
            scoreHolder = cSharpBtn1.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cSharpBtn1.Hide(); 
            positionTracker = 8;
            TimerObjectLogic();
            BtnDisabler(cSharpBtn1);
        }

        private void CSharpBtn2_Click(object sender, EventArgs e)
        {
            scoreHolder = cSharpBtn2.Text.ToString();
            scoreHolder = scoreHolder.Remove(0, 1).ToString();
            timer_stopper = true;
            cSharpBtn2.Hide(); 
            positionTracker = 9;
            TimerObjectLogic();
            BtnDisabler(cSharpBtn2);
        }

        private void CSharpBtn3_Click(object sender, EventArgs e)
        {
            scoreHolder = cSharpBtn3.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cSharpBtn3.Hide(); 
            positionTracker = 10;
            TimerObjectLogic();
            BtnDisabler(cSharpBtn3);
        }

        private void CSharpBtn4_Click(object sender, EventArgs e)
        {
            scoreHolder = cSharpBtn4.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cSharpBtn4.Hide(); 
            positionTracker = 11;
            TimerObjectLogic();
            BtnDisabler(cSharpBtn4); 
        }

        private void JavaBtn1_Click(object sender, EventArgs e)
        {
            scoreHolder = javaBtn1.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            javaBtn1.Hide(); 
            positionTracker = 12;  
            TimerObjectLogic();
            BtnDisabler(javaBtn1);
        }

        private void JavaBtn2_Click(object sender, EventArgs e)
        {
            scoreHolder = javaBtn2.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            javaBtn2.Hide(); 
            positionTracker = 13;  
            TimerObjectLogic();
            BtnDisabler(javaBtn2); 
        }
    

        private void JavaBtn3_Click(object sender, EventArgs e)
        {
            scoreHolder = javaBtn3.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            javaBtn3.Hide(); 
            positionTracker = 14;  
            TimerObjectLogic();
            BtnDisabler(javaBtn3); 
        }

        private void JavaBtn4_Click(object sender, EventArgs e)
        {
            scoreHolder = javaBtn4.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            javaBtn4.Hide(); 
            positionTracker = 15;  
            TimerObjectLogic();
            BtnDisabler(javaBtn4); 
        }

        private void NtwrkBtn1_Click(object sender, EventArgs e)
        {
            scoreHolder = ntwrkBtn1.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            ntwrkBtn1.Hide(); 
            positionTracker = 16;  
            TimerObjectLogic();
            BtnDisabler(ntwrkBtn1); 
        }

        private void NtwrkBtn2_Click(object sender, EventArgs e)
        {
            scoreHolder = ntwrkBtn2.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            ntwrkBtn2.Hide(); 
            positionTracker = 17;  
            TimerObjectLogic();
            BtnDisabler(ntwrkBtn2);
        }

        private void NtwrkBtn3_Click(object sender, EventArgs e)
        {
            scoreHolder = ntwrkBtn3.Text.ToString();
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            ntwrkBtn3.Hide(); 
            positionTracker = 18;  
            TimerObjectLogic();
            BtnDisabler(ntwrkBtn3); 
        }

        private void NtwrkBtn4_Click(object sender, EventArgs e)
        {
            scoreHolder = ntwrkBtn4.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            ntwrkBtn4.Hide(); 
            positionTracker = 19;  
            TimerObjectLogic();
            BtnDisabler(ntwrkBtn4); 
        }

        private void CmpSciBtn1_Click(object sender, EventArgs e)
        {
            scoreHolder = cmpSciBtn1.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cmpSciBtn1.Hide(); 
            positionTracker = 20;  
            TimerObjectLogic();
            BtnDisabler(cmpSciBtn1);
        }

        private void CmpSciBtn2_Click(object sender, EventArgs e)
        {
            scoreHolder = cmpSciBtn2.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cmpSciBtn2.Hide(); 
            positionTracker = 21;  
            TimerObjectLogic();
            BtnDisabler(cmpSciBtn2); 
        }

        private void CmpSciBtn3_Click(object sender, EventArgs e)
        {
            scoreHolder = cmpSciBtn3.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cmpSciBtn3.Hide(); 
            positionTracker = 22;  
            TimerObjectLogic();
            BtnDisabler(cmpSciBtn3); 
        }

        private void CmpSciBtn4_Click(object sender, EventArgs e)
        {
            scoreHolder = cmpSciBtn4.Text.ToString(); 
            DollarSignRmvr(scoreHolder);
            timer_stopper = true;
            cmpSciBtn4.Hide(); 
            positionTracker = 23;  
            TimerObjectLogic();
            BtnDisabler(cmpSciBtn4); 
        }
    }
}
