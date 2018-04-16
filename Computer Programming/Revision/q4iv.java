/**
 * @(#)q4iv.java
 * Joey Tierney
 *
 * Write a program to take in 5 names and ages from the user
 * Print the names who are above the average age. Check for non-digits
 * @author
 * @version 1.00 2015/9/24
 */

import java.util.Scanner;
public class q4iv {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	int ages[] = new int[5];
    	String names[] = new String[5];
    	String strage;
    	int total = 0, average = 0;

    	//loop to take in 5 names and ages
    	for(int i=0;i<ages.length;i++){
    		System.out.print("Enter name " + (i+1) + ": ");
    		names[i] = input.next();
    		System.out.print("Enter age for " + names[i] + ": ");
    		//take in age as a String
    		strage = input.next();

    		//validation
    		while(!strage.matches("\\d+")){
    			System.out.print("\nError! Numbers Only");
    			//reprompt user
    			System.out.print("Enter age for " + names[i] + ": ");
    			strage = input.next();
    		}//end validation

    		//change strage to an int
    		ages[i] = Integer.parseInt(strage);

    		//add age to total
    		total += ages[i];
    	}//end for

    	//get average
    	average = total/ages.length;

    	System.out.println("\nPeople above the average age are:");
    	System.out.print("\n****************************\n");

    	//loop to print names who are above average
    	for(int i = 0;i<ages.length;i++){
    		if(ages[i]>average){
    			System.out.println(names[i]);
    		}//end if
    	}//end for

    }//end main


}//end class