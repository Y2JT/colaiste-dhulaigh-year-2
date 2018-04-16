/**
 * @(#)ArrayListworkerObject.java
 *
 *
 * @author
 * @version 1.00 2016/2/11
 */

import java.util.*;
public class ArrayListworkerObject {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	ArrayList a1 = new ArrayList();

    	int choice = 1, id, salary;
    	String name;

    	System.out.print("1: Add new Entry\n2: Quit\n>");
    	choice = input.nextInt();

    	while(choice !=2){
    		System.out.print("Enter Name: ");
    		name = input.next();
    		System.out.print("Enter ID: ");
    		id = input.nextInt();
    		System.out.print("Enter Salary: ");
    		salary = input.nextInt();

    		a1.add(new Worker(name,id,salary));

    		System.out.print("1: Add new Entry\n2: Quit\n>");
    		choice = input.nextInt();

    	}//end while

    	System.out.println("Contents of a1: " + a1);

    	for(int i = 0;i<a1.size();i++){
    		System.out.println("\n" + a1.get(i));
    	}

    }//end main


}//end class