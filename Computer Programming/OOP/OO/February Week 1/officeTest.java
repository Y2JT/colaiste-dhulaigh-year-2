/**
 * @(#)officeTest.java
 *
 *
 * @author
 * @version 1.00 2016/2/5
 */

import java.util.Scanner;
public class officeTest {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	String location, name;
    	int id, phone_number, salary;

    	//create office array
    	Office officeArray[] = new Office[3];
    	//loop to create office objects
    	for(int i = 0;i<officeArray.length;i++){
    		System.out.print("Enter Office Location: ");
    		if(i!=0){	//if not the first time in the loop
    			input.nextLine();	//read a blank line
    		}
    		location = input.nextLine();
    		System.out.print("Enter Office Phone Number: ");
    		phone_number = input.nextInt();
    		System.out.print("Enter Worker Name: ");
    		input.nextLine();	//read a blank line
    		name = input.nextLine();
    		System.out.print("Enter Worker ID: ");
    		id = input.nextInt();
    		System.out.print("Enter Worker Salary: $");
    		salary = input.nextInt();
			//create worker object
    		Worker w1 = new Worker(name,id,salary);
    		//create office object
    		officeArray[i] = new Office(location,phone_number,w1);
    	}//end for

    	System.out.println("\n\nEmployee Details: ");
    	for(int i = 0;i<officeArray.length;i++){
    		System.out.println(officeArray[i].toString());
    	}//end for

    	System.out.println();	//blank line

    }//end main

}//end class