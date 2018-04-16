/**
 * @(#)q1ii.java
 * Joey Tierney
 *
 * Write a program that will use a for loop to take in ten grades
 * If the grade is less than 50, it's a fail. Show number of passes and fails
 * @author
 * @version 1.00 2015/9/17
 */

import java.util.Scanner;
public class q1ii {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	//declare variables
    	int grade;
    	int countpass = 0;
    	int countfail = 0;

    	//for loop to take in grades
    	for(int i =0; i < 10; i++){
    		//prompt user
    		System.out.print("Enter grade " + (i +1) + ": ");
    		grade = input.nextInt();

    		//determine if it's a pass or fail
    		if(grade>49){
    			countpass++;
    		}//end if
    		else{
    			countfail++;
    		}//end else

    	}//end for

    	//print result
    	System.out.println("\nThe number of passes are: " + countpass);
    	System.out.println("The number of fails are: " + countfail + "\n\n\n");

    	//System.out.println(); blank line

    }//end main


}//end class