/**
 * @(#)buildingTest.java
 * buildingTest to go with building.java
 *
 * @author
 * @version 1.00 2016/1/28
 */

import java.util.Scanner;
public class buildingTest {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	String location, name;
    	int size, num_floors, capacity;

    	//take inputs for objects
    	System.out.print("Enter Location: ");
    	location = input.next();
    	System.out.print("Enter Size: ");
    	size = input.nextInt();
    	System.out.print("Enter Number of Floors: ");
    	num_floors = input.nextInt();
    	System.out.print("Enter School Name: ");
    	name = input.next();
    	System.out.print("Enter Capacity: ");
    	capacity = input.nextInt();

		//create school object
    	school s1 = new school(location, size, num_floors, name, capacity);
    	System.out.println(s1.toString());

    	s1.setlocation("Dublin 17");
    	System.out.println("New location is: " + s1.getlocation() + "\n\n");

    }//end main

}//end class