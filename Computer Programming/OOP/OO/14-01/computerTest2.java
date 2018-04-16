/**
 * @(#)computerTest2.java
 * Create an array of computer objects and display all objects
 *
 * @author
 * @version 1.00 2016/1/15
 */

import java.util.Scanner;
public class computerTest2 {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);
    	String make, model, manufacturer;
    	int size;

    	int numcomps;

    	System.out.print("Enter number of computers: ");
    	numcomps = input.nextInt();

    	computer comps[] = new computer[numcomps];

    	//loop to initialise the arrays
    	for(int i = 0; i<comps.length;i++){
    		System.out.print("\n\n--Computer " + (i+1) + " details\n");
    		System.out.print("Enter Computer Make: ");
    		make = input.next();

    		System.out.print("Enter Computer Model: ");
    		model = input.next();

    		System.out.print("Enter Computer Manufacturer: ");
    		manufacturer = input.next();

    		System.out.print("Enter Computer Size (GB): ");
    		size = input.nextInt();

			//create memory object
    		memory m1 = new memory(manufacturer, size);

    		comps[i] = new computer(make,model,m1);
    	}//end for

    	//loop to print out computers
    	for(int i = 0;i<comps.length;i++){
    		System.out.println(comps[i].toString());
    	}//end for

    }//end main


}//end class