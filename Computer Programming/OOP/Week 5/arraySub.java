/**
 * @(#)arraySub.java
 * Declare arrays to hold names, addresses and ages
 * Ask the user what person they want to view (ID 1-5)
 * Pass the ID to a method that will print all the details held for that user ID
 *
 * @author
 * @version 1.00 2015/10/15
 */

import java.util.Scanner;
public class arraySub {
	static int ages[] = {21,32,43,54,23};
	static String names[] = {"Joey","Fred","Ted","Will","Bill"};
	static String addresses[] = {"Dublin","Meath","Louth","Cork","Galway"};

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);
    	int choice = 0;

		//prompt user
    	System.out.print("Enter ID 1-5: ");
    	choice = input.nextInt();
    	choice = (choice-1);
    	//method call
    	id(choice);


    }//end main method

    public static void id(int mchoice){
    	System.out.print("\n"  + names[mchoice] + "\n" + ages[mchoice] + "\n" + addresses[mchoice] + "\n\n\n");
    }//end id method


}//end class