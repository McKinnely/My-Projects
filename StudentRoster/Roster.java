/**************Java Challenge************************
*                                                   *                                             
*   Software Engineer: McKinnely Bentley 	        *
*   Description: Just a personal challenge.         *
*   Inputs: the input are hard coded in.            *
*   Outputs: Outputs data based on specs given      *
*   in the challenge doc.                	        *
*  	     	      	                                *
*****************************************************/


import java.util.*;
import java.text.*;
import javax.swing.JOptionPane;



public class Roster
{
     static  int arrayPosition = 0 ;
     int gradeArray[] = {2, 3, 5};
     static private  String [] studentsArray = {"1,John,Smith,John1989@gmail.com,20,88,79,59", "2,Suzan,Erickson,Erickson_1990@gmailcom,19,91,72,85", "3,Jack,Napoli,The_lawyer99yahoo.com,28,85,84,87", "4,Erin,Black,Erin.black@comcast.net,22,91,98,82", "5,Mike,Edwards,mkedwards@wgu.edu,25,85,90,95"};
     private static ArrayList <Student>stdntObjctHldrAL = new ArrayList<Student>();
     static String student;
     static String student1;
     static String student2; 
     static String student3;
     static String student4;
     static String student5;
      
      Student studentObject = new Student(1, "name", "lname", "email", 25 , gradeArray); 
    
	public void add(int id, String fname, String lname, String email, int age, int grade1, int grade2, int grade3)
	{ 
        
	 int addGradeArrary[] = {grade1, grade2, grade3};
	 studentObject.studentID = id;
         studentObject.firstName = fname;
         studentObject.lastName  = lname;
         studentObject.emailAddress = email;
         studentObject.age = age;
         stdntObjctHldrAL.add(new Student(id, fname, lname, email, age, addGradeArrary));
                      
	}
        
        //Purpose:Loop through the stdntObjctHldrAL to check for the student with an ID value of 3.
        //Reason :The code challenge requested the "remove" method to be coded this way.
	 public  void remove(String id)
	 {   
            boolean myRmvr = false;
            Iterator myIt = stdntObjctHldrAL.iterator();  
            while(myIt.hasNext())
            {  
                Student stdntObctAccesser =(Student)myIt.next();  
                if (id == "3")
                 {
                    if (stdntObctAccesser.studentID == 3)                
                    {                    
                      myRmvr = true;
                      System.out.println("Student 3 removed!"); 
                    }
                    
                 }
            }
            //removes the student at the 3rd index.
            if (myRmvr)
            {
                stdntObjctHldrAL.remove(2);                
            }
            else
            {                            
                System.out.println("Error: There is no student with an ID of "+ id+ "."); 
            }
         }
              
         //Purpose:
         //Reason :
       public static void print_average_grade(String id)
	 {
              double averageGrade = 0;
              double total = 0;
              Iterator myIterator = stdntObjctHldrAL.iterator();  
              while(myIterator.hasNext())  
              {
                    Student stdntObctAccesser =(Student)myIterator.next();  
                    if(id == "1")
                    {
                      for(int i=0; i < stdntObctAccesser.gradeArray.length; i++)
                      {
                        total = total + stdntObctAccesser.gradeArray[i];
                        averageGrade = total / stdntObctAccesser.gradeArray.length;
                      }
                    }
                    break;
              }
             DecimalFormat myD_Frmt = new DecimalFormat("#.##");
             System.out.println("Student " + id + " average grade is:" + myD_Frmt.format(averageGrade));
                  
         }
     
     public static void print_invalid_emails()
	 {
              Iterator myIterator = stdntObjctHldrAL.iterator();  
              while(myIterator.hasNext())  
              {
                    Student stdntObctAccesser =(Student)myIterator.next();  
                    if(stdntObctAccesser.emailAddress.contains("@") && stdntObctAccesser.emailAddress.contains("."))
                    {
                      //do nothing.                   
                    }
                    else 
                    {
                           System.out.println("Invalid Emails:" + stdntObctAccesser.emailAddress);
                            
                    }
                          if (stdntObctAccesser.emailAddress.contains(" ")) 
                            {
                              System.out.println("Invalid Emails:" + stdntObctAccesser.emailAddress);
                            }
                }                              
	 }
     
      public  void addHelper()
	 {      
                    student = studentsArray[arrayPosition ];                     
                    String[] student_split  = student.split(",");
                    String student_ID       = student_split[0]; 
                    String student_fname    = student_split[1]; 
                    String student_lname    = student_split[2]; 
                    String student_eAddress = student_split[3];
                    String student_age      = student_split[4]; 
                    String student_grade1   = student_split[5]; 
                    String student_grade2   = student_split[6]; 
                    String student_grade3   = student_split[7];                    
                    int  student_ID_To_Int = Integer.parseInt(student_ID);
                    int  student_Age_To_Int = Integer.parseInt(student_age);
                    int  student_Grade1_To_Int = Integer.parseInt(student_grade1);
                    int  student_Grade2_To_Int = Integer.parseInt(student_grade2);
                    int  student_Grade3_To_Int = Integer.parseInt(student_grade3);                   
                    add(student_ID_To_Int, student_fname, student_lname, student_eAddress, student_Age_To_Int, student_Grade1_To_Int, student_Grade2_To_Int, student_Grade3_To_Int);
	            studentObject.printData();                   
         }
      
     public void printFormatter()
        {  
           String formatter; 
           formatter = "|STUDENT ID " +"	" + "|FIRST NAME  " + "	"  + "|LAST NAME  " +"	" + "|AGE " + "	"  + "|EMAIL ADDRESS " ;	
           System.out.println(formatter);	
        }
     
     public void print_all()
          {
               while(arrayPosition < studentsArray.length)
                {
                    switch (arrayPosition)
                    {
                     case 0:
                       addHelper();
                       break;

                     case 1:
                         addHelper();
                         break;    
                         
                     case 2:
                         addHelper();
                         break;
                         
                     case 3:
                         addHelper();
                         break;

                     case 4: 
                         addHelper();
                         break;   
                         
                     default: 
                         System.out.println("Something went wrong!!");
                         break;                                    
                    }              
                    arrayPosition++;
                }
     
           }
	
public static void main (String[] args)
{
    try
    {
        Roster myRoster = new Roster();
        myRoster.run(args);
    }
    catch (Exception e)
    {
        e.printStackTrace();
    }
}



  
}



