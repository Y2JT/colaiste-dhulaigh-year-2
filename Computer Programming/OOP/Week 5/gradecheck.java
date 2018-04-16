/**
 * @(#)gradecheck.java
 * Take 5 grades from the user. Use a method to check for non-digits
 * Send the grades to a method that will count the number of passes and fails.
 * Store the grades in an array and display all grades after the number of passes/fails
 *
 * @author
 * @version 1.00 2015/10/15
 */

import java.util.Scanner;
public class gradecheck {
	//declare variables
	static Scanner input = new Scanner(System.in);
	static int passes = 0, fails = 0;

    public static void main(String args[]) {
    	String strgrade;
		int grades[] = new int[5];
		int result;		//this will hold the number returned by the method
		//for loop to take in grade
    	for(int i = 0; i<grades.length; i++){
    		System.out.print("Please enter grade " + (i+1)+ ": ");
    		strgrade = input.next();
    		//call method
    		result = validate(strgrade, i);
    		//put result into the array
    		grades[i] = result;
    		//check for pass and fail in method passfail
    		passfail(grades[i]);
    	}//end for

    	System.out.println("\n\nThe number of passes are: " + passes);
    	System.out.println("The number of fails are: " + fails);

    	System.out.println();	//print blank line

    }//end main method

    public static int validate(String mstrgrade, int mi){
    	//validation
    	while(!mstrgrade.matches("\\d+")){
    		System.out.print("\nERROR: Numbers Only\n");
    		//reprompt the user
    		System.out.print("\nPlease enter grade " + (mi+1) + ": ");
    		mstrgrade = input.next();
    	}//end while

    	return Integer.parseInt(mstrgrade);   //return grade

    }//end validate method

    public static void passfail(int x){
		if(x >49){
			passes++;
		}//end if
		else{
			fails++;
		}//end else

    }//end passfail

}//end class