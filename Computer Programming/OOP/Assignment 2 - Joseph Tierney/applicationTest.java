/**
 * @(#)applicationTest.java
 *
 *
 * @author
 * @version 1.00 2016/4/13
 */

import java.util.Scanner;
import java.util.Date;
import java.io.*;
public class applicationTest {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);
    	int course_number =0, id = 0, numstudents, sub = 0;
    	String course_name = "", name = "", address = "";
    	String strnumstudents, strid, strcoursenum;
    	boolean flag2 = false;

    	char check1,check2;
    	String dob = "";
    	boolean flag = false;

    	String m_app;

    	String menu1 = "\n1: View Course/Personal Details \n2: Edit Course/Personal Details \n3: Quit\n>";
    	int choice1 = 0, id1;
    	String strchoice1, strid1;

    	String menu2 = "\n1: View Application Details \n2: View Personal Details \n3: Change Application Details \n4: Change Personal Details \n5: Quit\n>";
		int choice2 = 0;
		String strchoice2;

		String strenter1, strenter2;
		int enter1, enter2;

    	//loop to determine how many students
    	System.out.print("Enter Number of Students: ");
    	strnumstudents = input.next();

    	//validation for number of students
    	while(!strnumstudents.matches("\\d+")){
    		System.out.println("\nERROR: DIGITS ONLY");
    		java.awt.Toolkit.getDefaultToolkit().beep();
    		//reprompt user
    		System.out.print("\nEnter Number of Students: ");
    		strnumstudents = input.next();
    	}//end validation

    	//parse int
    	numstudents = Integer.parseInt(strnumstudents);

    	//create array
    	student arraystudents[] = new student[numstudents];

    	//loop to take in students details
    	for(int i = 0; i<arraystudents.length; i++){
    		//prompt user to enter name
    		System.out.print("\nEnter Name for Student " + (i+1) + ": ");
    		name = input.next();

    		//prompt user to enter id
    		System.out.print("\nEnter ID: ");
    		strid = input.next();

    		//validation
    		while(!strid.matches("\\d+")){
    			System.out.print("\nERROR: DIGITS ONLY");
    			java.awt.Toolkit.getDefaultToolkit().beep();
    			//reprompt user
    			System.out.print("\n\nEnter ID: ");
    			strid = input.next();
    		}//end validation

    		//parse int
    		id = Integer.parseInt(strid);

    		//prompt user to enter address
    		System.out.print("\nEnter Student Address: ");
    		address = input.next();

    		//enter course name
    		System.out.print("\nEnter Course Name: ");
    		course_name = input.next();

    		//enter course number
    		System.out.print("\nEnter Course Number: ");
    		strcoursenum = input.next();

    		//validation
    		while(!strcoursenum.matches("\\d+")){
    			System.out.print("\nERROR: DIGITS ONLY");
    			java.awt.Toolkit.getDefaultToolkit().beep();
    			//reprompt
    			System.out.print("\n\nEnter Course Number: ");
    			strcoursenum = input.next();
    		}//end validation

    		//parse int
    		course_number = Integer.parseInt(strcoursenum);

    		//are they a mature student
    		System.out.print("\nIs applicant a mature student? (y/n) ");
    		m_app = input.next();
    		m_app = m_app.toUpperCase();

    		//validation
    		while(!(m_app.matches("Y")|| m_app.matches("N"))){
    			System.out.println("\007");
    			System.out.println("ERROR: Y/N ONLY");
    			//reprompt user
    			System.out.print("\nIs applicant a mature student? (y/n) ");
    			m_app = input.next();
    			m_app = m_app.toUpperCase();
    		}//end validation

    		if (m_app.matches("Y")){
    			while(flag == false){
    				System.out.print("\nEnter date of birth dd/mm/yyyy : ");
    				dob = input.next();
    				if (dob.length()!=10){
    				System.out.println("Error invalid format\n\nPlease enter dd/mm/yyyy");
    				}//end if doblength
    				else{
    				check1 = dob.charAt(2);
	    			check2 = dob.charAt(5);
	    			//check for the first /at position 3 and the second at poition 6
	    			if ((check1=='/') && (check2 =='/')){
	    			flag = true;
	    		}//end if
	    		else{
	    			System.out.println("Error invalid format\n\nPlease enter dd/mm/yyyy");
	    		}//end else
	    	}//end else if dob.length != 10
    	}//end while
    		application a1 = new application(course_name,course_number);
    		arraystudents[i] = new maturestudent(name,id,address,a1,dob);
    		}//end yes
    		else{
    			application a1 = new application(course_name,course_number);
    			arraystudents[i] = new student(name,id,address,a1);
    		}//end no
    	}//end for

		//display first menu
		while(choice1!=3){
			System.out.print("\nEnter Choice: " + menu1);
    		strchoice1 = input.next();

    		//validate choice input
    		while(!strchoice1.matches("[1-3]")){
    			System.out.print("\nERROR: 1-3 ONLY!");
    			java.awt.Toolkit.getDefaultToolkit().beep();
    			//reprompt user
    			System.out.print("\n\nEnter Choice: " + menu1);
    			strchoice1 = input.next();
    		}//end choice validation

    		//parse int
    		choice1 = Integer.parseInt(strchoice1);

    		//if user inputs 1
    		if(choice1 == 1){
    		System.out.print("\nEnter ID of Applicant: ");
    		strid1 = input.next();

    		//id1 validation
    		while(!strid1.matches("\\d+")){
    			System.out.print("\nERROR: DIGITS ONLY!");
    			java.awt.Toolkit.getDefaultToolkit().beep();
    			System.out.print("\nEnter ID of Applicant: ");
    			strid1 = input.next();
    		}//end id1 validation

    		//parse int
    		id1 = Integer.parseInt(strid1);

    		//check if id is in array
    		for(int i = 0; i<numstudents; i++){
    			if(id1 == arraystudents[i].getid()){
    				sub = i;
    				System.out.print(arraystudents[i].toString());
    				flag2 = true;
    				break;
    			}//end if
    		}//end for
    		//if flag2 is still false
    		if(flag2 == false){
    			java.awt.Toolkit.getDefaultToolkit().beep();
    			System.out.print("\n\nStudent not found\n\n");
    		}//end if

    		//reset flag
    		flag2 = false;
    		}//end else if choice 1

			//else if user inputs 2
    		else if(choice1 == 2){
    			System.out.print("\nEnter ID of Applicant to Edit: ");
				strid1 = input.next();

			//id1 validation
			while(!strid1.matches("\\d+")){
    			System.out.print("\nERROR: DIGITS ONLY!");
    			java.awt.Toolkit.getDefaultToolkit().beep();
    			System.out.println("\nEnter ID of Applicant: ");
    			strid1 = input.next();
    		}//end id1 validation

    		//parse int
    		id1 = Integer.parseInt(strid1);

    		//check if id is in array
    		for(int i = 0; i<numstudents;i++){
    			if(id1 == arraystudents[i].getid()){
    				sub = i;
    				System.out.print(arraystudents[i].toString());
    				flag2 = true;
    				break;
    			}//end if
    		}//end for
    		if(flag2 == false){
    			System.out.print("\nStudent not found\n");
    		}//end if

			if(flag2 == true){
    		for(int i = 0; i<numstudents; i++){
    			while(choice2!= 5){
    			System.out.print("\n------ Select Choice ------ " + menu2);
    			strchoice2 = input.next();

    			//validate input
    			while(!strchoice2.matches("[1-5]")){
    				System.out.print("\nERROR: 1-5 ONLY");
    				//reprompt user
    				System.out.print("\n------ Select Choice ------ " + menu2);
    				strchoice2 = input.next();
    			}//end validation

    			//parse int
    			choice2 = Integer.parseInt(strchoice2);

    			//if choice = 1
    			if(choice2 == 1){
    				System.out.print(arraystudents[sub].getapplication());
    			}//end choice 1

    			//else if choice is 2
    			else if(choice2 == 2){
    				System.out.print("\nStudent Name: " + arraystudents[sub].getname());
    				System.out.print("\nStudent ID: " + arraystudents[sub].getid());
    				System.out.print("\nStudent Address: " + arraystudents[sub].getaddress());
    				System.out.println();
    			}//end choice 2

    			//else if choice is 3
    			else if(choice2 == 3){
    				System.out.print("\nEnter 1 to Change Course Name\nEnter 2 to Change Course ID\n>");
    				strenter1 = input.next();

    				//validate input
    				while(!strenter1.matches("[1-2]")){
    					System.out.print("\nERROR: 1-2 ONLY");
    					//reprompt user
    					System.out.print("\nEnter 1 to Change Course Name\nEnter 2 to Change Course ID\n>");
    					strenter1 = input.next();
    				}//end validation

    				//parse int
    				enter1 = Integer.parseInt(strenter1);

    				//if enter1 is 1
    				if(enter1 == 1){
    					//create application a1
    					application a1 = new application(course_name, course_number);
    					System.out.print("\nEnter Course Name: ");
    					a1.setcname(course_name = input.next());
    					arraystudents[sub].setapplication(a1);
    					//a1.getcname();
    					System.out.print(arraystudents[sub].getapplication());
    				}//end if enter1 is 1
    				else if(enter1 == 2){
    					//create application a1
    					application a1 = new application(course_name, course_number);
    					System.out.print("\nEnter Course ID: ");
    					a1.setcnumber(course_number = input.nextInt());
    					arraystudents[sub].setapplication(a1);
    					System.out.print(arraystudents[sub].getapplication());
    				}//end else if enter1 is 2
    			}//end else if choice is 3

    			else if(choice2 == 4){
    				System.out.print("\nEnter 1 to Change Name\nEnter 2 to Change ID\n>");
    				strenter2 = input.next();

    				//validate input
    				while(!strenter2.matches("[1-2]")){
    					System.out.print("\nERROR: 1-2 ONLY");
    					//reprompt user
    					System.out.print("\nEnter 1 to Change Name\nEnter 2 to Change ID\n>");
    					strenter2 = input.next();
    				}//end validation

    				//parse int
    				enter2 = Integer.parseInt(strenter2);

    				if(enter2 == 1){
    					System.out.print("\nEnter Name: ");
    					name = input.next();
    					arraystudents[sub].setname(name);
    					System.out.print("\nStudent Name: " + arraystudents[sub].getname() + "\nStudent ID: " + arraystudents[sub].getid() + "\n");
    				}//end input 1

    				if(enter2 == 2){
    					System.out.print("\nEnter ID: ");
    					id = input.nextInt();
    					arraystudents[sub].setid(id);
    					System.out.print("\nStudent Name: " + arraystudents[sub].getname() + "\nStudent ID: " + arraystudents[sub].getid() + "\n");
    				}//end input 2

    			}//end else if choice is 4

    			}//end while choice not equal to 5
    			break;
    		}//end if
    		}//end while

    		}//end choice 2

		}//end while

		//write to file
    	for(int i = 0;i<arraystudents.length;i++){
    		BufferedWriter Information = null;
    		String location = "StudentDetails.doc";

    		try{
    			Information = new BufferedWriter(new FileWriter(location, true));
    			Information.newLine();
    			Information.write(arraystudents[i].toString());
    			Information.close();
    			System.out.println("File Updated\n");
    		}
    		catch (Exception e){
    			System.out.println("Cannont access file\n");
    		}
    	}//end for

		System.out.print("\nThank you for using CAO Online");
		System.out.println();	//blank line

    }//end main method

}//end class