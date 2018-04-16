/**
 * @(#)q2i.java
 * Joey Tierney
 *
 * Write a program that will ask the user for a password.
 * If the password is incorrect an error message must be shown and the user must enter the password again
 * This should keep happening until the user enters the correct password. "Hello" should be printed when it's correct
 * The password is pin
 * @author
 * @version 1.00 2015/9/23
 */

import java.util.Scanner;
public class q2i {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	//declare variables
    	String password;

    	//prompt user for password
    	System.out.print("Please enter password: ");
    	password = input.next();

    	//change password to lowercase
    	password = password.toLowerCase();	//uppercase is .toUpperCase

    	//validate
    	while(!password.matches("pin")){
    		//error message
    		System.out.println("Incorrect Password");
    		//beep
    		System.out.println("\007");
    		//prompt user for password
    		System.out.print("Please enter password: ");
    		password = input.next();
    		//change password to lowercase
    		password = password.toLowerCase();
    	}//end while

    	System.out.println("\nHello, is it me you're looking for?" + "\n");

    }//end main


}//end class