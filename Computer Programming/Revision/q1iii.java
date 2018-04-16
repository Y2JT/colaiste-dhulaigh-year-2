/**
 * @(#)q1iii.java
 * Joey Tierney
 *
 * Take an age in from the user as a String (validate to check if numbers only)
 * Check if the user is old enough to vote
 * @author
 * @version 1.00 2015/9/17
 */

import java.util.Scanner;
public class q1iii {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	//declare variables
    	int age;
    	String strage;

		//prompt user
    	System.out.print("Enter your age: ");
    	strage = input.next();

    	//validate
    	while(!strage.matches("\\d+")){		//while strage does not match digits only
    		System.out.print("Error: Numbers Only!");
    		//prompt user again
    		System.out.print("\n\nEnter your age: ");
    		strage = input.next();
    	}//end validation

    	//change to strage to an Int
    	age = Integer.parseInt(strage);

    	//check if they can vote
    	if(age>17){
    		System.out.println("\nYou can vote!" +"\n\n");
    	}//end if
    	else{
    		System.out.println("\nYou're too young to vote" +"\n\n");
    	}//end else


    }//end main


}//ebd class