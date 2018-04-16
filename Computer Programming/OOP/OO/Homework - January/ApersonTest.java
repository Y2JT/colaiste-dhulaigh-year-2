/**
 * @(#)ApersonTest.java
 *
 *
 * @author
 * @version 1.00 2016/1/31
 */

import java.util.Scanner;
public class ApersonTest {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	String name, address, collegeName, courseName;
    	int id;

    	//take inputs from user
    	System.out.print("Enter Name: ");
    	name = input.next();
    	System.out.print("Enter Address: ");
    	address = input.next();
    	System.out.print("Enter ID: ");
    	id = input.nextInt();
    	System.out.print("Enter College Name: ");
    	collegeName = input.next();
    	System.out.print("Enter Course Name: ");
    	courseName = input.next();
    	//System.out.print("Enter number of hours studied: ");
    	//numhours = input.nextInt();

    	//create student object
    	student s1 = new student(name, address, id, collegeName, courseName);
    	System.out.println(s1.toString());

		//change details
    	s1.setcollegeName("CDCFE");
    	s1.setcourseName("Computer Science");
    	System.out.println("\n\nUpdate Details: " + s1.toString() + "\n");

    	//call studies behaviour
    	System.out.println(s1.studies(21));
    	System.out.println();

    }//end main


}//end class