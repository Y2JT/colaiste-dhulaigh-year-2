/**
 * @(#)EmployeeTest.java
 *
 *
 * @author
 * @version 1.00 2016/2/4
 */

import java.util.Scanner;
public class EmployeeTest {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	String name;
    	int id, salary, grade;

    	System.out.print("Enter Employee Name: ");
    	name = input.next();
    	System.out.print("Enter Employee ID: ");
    	id = input.nextInt();
    	System.out.print("Enter Employee Salary: $");
    	salary = input.nextInt();
    	System.out.print("Enter Employee Grade [1-4]: ");
    	grade = input.nextInt();

    	//create valid employee
    	Employee1 e1 = new Employee1(name, id, salary, grade);
    	//create invalid employee
    	Employee1 e2 = new Employee1();
    	e2.setDetails("John",-123,25000,2);
    	//create employee with just name and id known
    	Employee1 e3 = new Employee1("Tommy",165);

    	//print employee details
    	System.out.println("\nFirst Employee Details: " + e1.toString());
    	System.out.println(e1.getname() + "'s bonus: $" + e1.bonus(salary));
    	System.out.println("\n\nSecond Employee Details: " + e2.toString());
    	System.out.println(e2.getname() + "'s bonus: $" + e2.bonus(25000));
    	System.out.println("\nThird Employee Details: " + e3.toString() + "\n\n");

    	//create employee array
    	Employee1 employeeArray[] = new Employee1[3];
    	for(int i = 0;i<employeeArray.length;i++){
    		System.out.print("Enter name: ");
    		name = input.next();
    		System.out.print("Enter Employee ID: ");
    		id = input.nextInt();
    		System.out.print("Enter Employee Salary: $");
    		salary = input.nextInt();
    		System.out.print("Enter Employee Grade [1-4]: ");
    		grade = input.nextInt();

    		//create object
    		employeeArray[i] = new Employee1(name,id,salary,grade);

    	}//end for

		System.out.println("\n\nEmployee Details: ");
    	for(int i = 0;i<employeeArray.length;i++){
    		System.out.println(employeeArray[i].toString());
    	}//end for

    }//end main

}//end class