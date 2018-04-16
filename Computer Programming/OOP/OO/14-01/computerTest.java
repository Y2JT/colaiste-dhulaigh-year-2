/**
 * @(#)computerTest.java
 * computerTest to go with computer
 *
 * @author
 * @version 1.00 2016/1/14
 */

import java.util.Scanner;
public class computerTest {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	String make, model, manufacturer;
    	int size;

    	//take inputs from user
    	System.out.print("Enter Computer Make: ");
    	make = input.nextLine();

    	System.out.print("Enter Computer Model: ");
    	model = input.nextLine();

    	System.out.print("Enter Computer Manufacturer: ");
    	manufacturer = input.nextLine();

    	System.out.print("Enter Computer Size (GB): ");
    	size = input.nextInt();

		//create memory object
    	memory m1 = new memory(manufacturer, size);
    	//create computer object
    	computer c1 = new computer(make, model, m1);

    	System.out.println(c1.toString());
    	c1.setmemorySize(120);
    	System.out.println(c1.toString());
    	System.out.println("\nMemory size is: " + c1.getmemorySize());
    	System.out.println();	//blank line

    }//end main

}//end class