/**
 * @(#)validateAge.java
 * Take an age from the user and pass it to a method
 * to validate it (check it only contains digits)
 * The method should keep asking the user for a valid age
 * if the user is entering non-digits
 * The method should return an age, digits only
 *
 * Tell the user if they are old enough to vote
 * @author
 * @version 1.00 2015/10/22
 */

import java.util.Scanner;
public class validateAge {

	static Scanner input = new Scanner(System.in);

    public static void main(String args[]) {

    	String strage;
    	int result;

    	System.out.print("Enter your age: ");
    	strage = input.next();

    	//method call
    	result = validate(strage);

		//check if the user is old enough to vote
    	if(result > 17){
    		System.out.println("\nYou can vote\n\n");
    	}
    	else{
    		System.out.println("\nYou are too young to vote\n\n");
    	}

    }//end main method

    public static int validate(String mstrage){
    	while(!mstrage.matches("\\d+")){
    		System.out.print("Error: Digits Only!");
    		//reprompt user
    		System.out.print("\nEnter your age: ");
    		mstrage = input.next();
    	}//end validation
    	//return the parse int
    	return Integer.parseInt(mstrage);
    }//end validate method


}//end class