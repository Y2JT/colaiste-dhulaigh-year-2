/**
 * @(#)q3ii.java
 * Joey Tierney
 *
 * Write a program to take 10 scores from the user. Store the grades in an array
 * Print all grades which are greater than the average
 *
 * @author
 * @version 1.00 2015/9/23
 */

import java.util.Scanner;
public class q3ii {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	//declare variables
    	int grades[] = new int[10];
    	int total = 0, average = 0;

    	//loop to take in grades
    	for(int i = 0; i<grades.length; i++){
    		System.out.print("Enter grade " + (i+1) + ": ");
    		grades[i] = input.nextInt();

    		//get total
    		total = total + grades[i];

    	}//end for

    	//get average
    	average = total/grades.length;
    	System.out.println("\nThe average grade is: " + average);

    	//grades above average
    	System.out.println("\n**** Grades Above Average ****");
    	System.out.println("\n------------------------------");
    	System.out.println();	//blank line
    	//loop to check which grades are above the average
    	for(int i=0; i<grades.length;i++){
    		if(grades[i]>average){
    			System.out.println(grades[i]);
    		}//end if
    	}//end for

    	//blank line
    	System.out.println();
    	System.out.println();

    }//end main


}//end class