/**
 * @(#)carTest.java
 *
 *
 * @author
 * @version 1.00 2016/1/21
 */
import java.io.*;	//needed for writing to a file
import java.util.Scanner;
public class carTest {

    public static void main(String args[]) {
    	Scanner input = new Scanner(System.in);

    	String make, model, fueltype;
    	int enginesize;

    	//take inputs from user
    	System.out.print("Enter Car Make: ");
    	make = input.next();
    	System.out.print("Enter Car Model: ");
    	model = input.next();

    	System.out.print("Enter Fuel Type: ");
    	fueltype = input.next();
    	System.out.print("Enter Engine Size: ");
    	enginesize = input.nextInt();

    	//create engine object
    	engine e1 = new engine(enginesize, fueltype);
    	//create car object
    	car c1 = new car(make, model, e1);

    	System.out.println(c1.toString());
    	System.out.println();

    	//write to file
    	BufferedWriter Information = null;
    	String location = "CarDetails.doc";

    	try{
    		Information = new BufferedWriter(new FileWriter(location, true));
    		Information.newLine();
    		Information.write(c1.toString());
    		Information.close();
    		System.out.println("File Updated\n");
    	}
    	catch (Exception e){
    		System.out.println("Cannont access file\n");
    	}

    }//end main

}//end class