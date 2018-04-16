/**
 * @(#)q3i.java
 * Joey Tierney
 *
 * Write a program that will take in one grade as an input
 * If the grade is over 79 print "Distinction"; If the grade is over 64 print "Merit"
 * If the grade is over 49 print "Pass"; If the grade is less than 50 print "Unsuccessful"
 * @author
 * @version 1.00 2015/9/23
 */

import java.util.Scanner;
public class q3i {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	//declare variables
    	int grade;

    	//prompt user for grade
    	System.out.print("Please enter grade: ");
    	//take in the grade
    	grade = input.nextInt();

    	//check if it's Distinction, Merit, Pass or Unsuccessful
    	if(grade>79){
    		System.out.print("\n**** Distinction ****");
    	}//end if
    	else if(grade>64){
    		System.out.print("\n**** Merit ****");
    	}//end else if
    	else if(grade>49){
    		System.out.print("\n**** Pass ****");
    	}//end else if
    	else{
    		System.out.print("\n**** Unsuccessful ****");
    	}//end else

		//print blank line
		System.out.println();
		System.out.println();

    }//end main


}//end class