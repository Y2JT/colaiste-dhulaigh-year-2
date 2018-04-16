/**
 * @(#)q3.java
 * Take a grade from the user. Use a method to validate the grade.
 * Keep asking the user for a grade until digits are entered.
 * Return the grade as digits. Tell the user if they passed or not.
 *
 * @author 
 * @version 1.00 2015/10/28
 */

import java.util.Scanner;
public class q3 {
	
	static Scanner input = new Scanner(System.in);

    public static void main(String args[]) {
    	int grade;
    	String strgrade;
    	int result;
    	
    	System.out.print("Enter a Grade: ");
    	strgrade = input.next();
    	
    	//method call
    	result = validate(strgrade);
    	
    	if(result > 49){
    		System.out.print("\nYou passed!\n\n");
    	}//end if
    	else{
    		System.out.print("\nYou failed...\n\n");
    	}//end else
    	
    }//end main method
    
    public static int validate(String mgrade){
    	while(!mgrade.matches("\\d+")){
    		System.out.print("\nERROR: Digits Only!\n");
    		System.out.print("\nEnter a Grade: ");
    		mgrade = input.next();
    	}//end while
    	return Integer.parseInt(mgrade);
    }//end validate class
    
    
}//end class