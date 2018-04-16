/**
 * @(#)ifexample.java
 * Joey Tierney
 *
 * Shows why we need {} in an if statement
 *
 * @author
 * @version 1.00 2015/9/23
 */

import java.util.Date;	//for printing the date
public class ifexample {

    public static void main(String args[]) {

    	//create a new Date object
    	Date d = new Date();

    	int age = 20;

    	System.out.println(d);

    	if(age>17)
    		System.out.println("\nCongratulations");
    		System.out.println("You can vote\n\n");

    }//end main


}//end class