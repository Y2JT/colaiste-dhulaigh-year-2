/**
 * @(#)studentTest.java
 *
 *
 * @author
 * @version 1.00 2016/3/3
 */

import java.util.Scanner;
public class studentTest {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);
    	int choice, number, id, courselength, grade;
    	String make, name, coursename, degreetype;

		//take in student details
    	//System.out.print("\nEnter Student Name: ");
    	//name = input.next();
    	//System.out.print("\nEnter Student ID: ");
    	//id = input.nextInt();

    	//take in phone details
    	System.out.print("\nEnter Phone Number: ");
    	number = input.nextInt();
    	System.out.print("\nEnter Make: ");
    	make = input.next();

		//create phone object
    	phone p1 = new phone(number,make);
    	//create student object
    	//student s1 = new student(name,id,p1);

    	student s[] = new student[2];

    	for(int i = 0;i<s.length;i++){
    		//take in student details
    		System.out.print("\nEnter Student Name: ");
    		name = input.next();
    		System.out.print("\nEnter Student ID: ");
    		id = input.nextInt();
    		//ask the user if they're undergrad or postgrad
    		System.out.print("\n\nEnter 1 for Undergrad or 2 for Postgrad: ");
    		choice = input.nextInt();
    		if(choice ==1){
    			System.out.print("\nEnter Course Name: ");
    			coursename = input.next();
    			System.out.print("\nEnter Course Length: ");
    			courselength = input.nextInt();
    			s[i] = new undergrad(name,id,p1,coursename,courselength);
    		}//end if
    		else if(choice ==2){
    			System.out.print("\nEnter Degree Type: ");
    			degreetype = input.next();
    			System.out.print("\nEnter Grade: ");
    			grade = input.nextInt();
    			s[i] = new postgrad(name,id,p1,degreetype,grade);
    		}//end else
    	}//end for

    	System.out.print("\n\nStudent Details: ");
		for(int i = 0;i<s.length;i++){
			System.out.print(s[i].toString());
			System.out.print("\nNumber of Students are: " + s[i].getcount());
		}//end for

    	System.out.println();
    	System.out.println();

    }//end main

}//end class