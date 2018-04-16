/**
 * @(#)q1i.java
 * Joey Tierney
 *
 * Write a program that will use a while loop to take in 5 ages
 * Get the highest and lowest age
 * @author
 * @version 1.00 2015/9/17
 */

import java.util.Scanner;
public class q1i {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	//declare variables
    	int age;
    	int highest = 0, lowest = 100;
    	int i = 0;

    	//while loop to take in ages
    	while(i<5){
    		//prompt user
    		System.out.print("Enter age " + (i + 1) + ": ");
    		age = input.nextInt();

			//check if age is highest/lowest
    		if(age>highest){
    			highest = age;
    		}//end if
    		if(age<lowest){
    			lowest = age;
    		}//end if

    		//increment i
    		i++;
    	}//end while

		//print result
    	System.out.print("\nHighest age is: " + highest);
    	System.out.print("\nLowest age is: " + lowest + "\n\n\n");


    }//end main


}//end class