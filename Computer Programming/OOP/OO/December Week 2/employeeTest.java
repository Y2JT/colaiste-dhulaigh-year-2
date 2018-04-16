/**
 * @(#)employeeTest.java
 * employeeTest to go with employee.java
 *
 * @author
 * @version 1.00 2015/12/10
 */

import java.util.Scanner;
public class employeeTest {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

		String name1, name2;
    	int id1, id2;
    	int numHours1, numHours2;

		//take inputs for objects
    	System.out.print("Enter Employee 1 Name: ");
    	name1 = input.nextLine();
    	System.out.print("Enter Employee 1 ID: ");
    	id1 = input.nextInt();
    	System.out.print("Enter Employee 1 Hours: ");
    	numHours1 = input.nextInt();

    	System.out.print("\nEnter Emplyee 2 Name: ");
    	name2 = input.next();
    	System.out.print("Enter Employee 2 ID: ");
    	id2 = input.nextInt();
    	System.out.print("Enter Employee 2 Hours: ");
    	numHours2 = input.nextInt();

    	employee e1 = new employee(name1, id1, numHours1);
    	employee e2 = new employee(name2, id2, numHours2);

    	//print employee details
    	System.out.println(e1.toString());
    	System.out.println(e2.toString());

    	//change values of employee e2
    	e2.setname("Fred Baker");
    	e2.setid(174);
    	e2.setnumHours(39);

    	//display new details for e2 using getmethods
    	System.out.println("\nNew details for employee e2: ");
    	System.out.println("Name: " + e2.getname());
    	System.out.println("ID: " + e2.getid());
    	System.out.println("Hours: " + e2.getnumHours());
		//display wages
    	System.out.println("\nWages: ");
    	System.out.println(e1.getname() + "'s Wages: " + e1.calculateWages(10.75));
    	System.out.println(e2.getname() + "'s Wages: " + e2.calculateWages(8.65));

    }//end main method


}//end class