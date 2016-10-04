
class Student
{

//instance variables
	

String firstName;
String lastName;
String emailAddress;
int    age;
int    studentID;
int [] gradeArray = new int [3];
 

  
  
 public void setStudentID(int setStdntID)
 
 {
     this.studentID = setStdntID;
 }
 
 public int getStudentID()
 
 {
        return this.studentID;
 }
 
 public void setFirstName(String firstName)
 
 {    
    this.firstName = firstName;
   
 }
 
 public String getFirstName()
 
 {
     return this.firstName;
 }
 
 public void setLastName(String lastName)
 
 {
     this.lastName = lastName;
 }
 
 public String getLastName()
 
{
         return this.lastName;
}
 
 public void setEmailAddress(String emailAddress)
 
 {
     this.emailAddress = emailAddress;
 }
 
 public String getEmailAddress()
 
 {
     return this.emailAddress;
 }

 public void setAge(int age)
 
 {
     this.age = age;
 }
 
 public int getAge()
 
 {
     return this.age;
 }
 
 public void setGradeArray(int gradeArray [])
 
 {
     this.gradeArray = gradeArray;
 }
 
 public int [] getGradeArray()
 
 {
     return this.gradeArray;
  
 }
 

  public  String ToString() 
  { 
    return firstName;
  } 

  
//Purpose:The purpsoe of the printData method is to print the captured data in a tab delimited format.
//Reason :To display the data in a clear, crip, concise way.
public String printData()
{
   String printOutput;
   printOutput = "|" + Integer.toString(getStudentID())+ "          " +/*TAB */ "	" + "|" + getFirstName() + "        " +/*TAB */  "	" + "|" + getLastName() + "    " + /*TAB */ "	" + "|" + getAge()+ "" +/*TAB */  "     " + "|" + getEmailAddress();   
   System.out.println(printOutput);
   return printOutput;  
    
}

 Student(int studentID, String firstName, String lastName, String emailAddress, int age, int gradeArray[]) 
 {
      setStudentID(studentID);
      setFirstName(firstName);
      setLastName(lastName);
      setAge(age);
      setGradeArray(gradeArray);
      setEmailAddress(emailAddress);
      
  }
  
         
}
