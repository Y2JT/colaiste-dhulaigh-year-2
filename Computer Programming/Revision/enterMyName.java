/**
 * @(#)enterMyName.java
 * Joey Tierney
 *
 * Prompt the user to enter their name and print "Hello ___"
 * @author
 * @version 1.00 2015/9/16
 */

import java.util.Date;			//allows us to use the date
import java.util.Scanner;		//allows a user to take an input
public class enterMyName {

	//main method
    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);		//allows the user to take an input

		//declare variables
    	String name;
    	Date d = new Date();

    	//print the date
    	System.out.println(d);

    	//prompt user
    	System.out.print("\nPlease enter your name: ");
    	//take input
    	name = input.next();

    	//print result
    	System.out.println("\nHello " + name + "\n");

    	//add surname (change the name)
    	name = "Joey Tierney";

    	System.out.println("\nHello " + name + "\n");


    }//end main


}//end class