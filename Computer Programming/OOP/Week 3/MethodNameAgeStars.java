/**
 * @(#)MethodNameAgeStars.java
 * Take a name and an age from the user
 * Pass these to a method
 * The method should print the name and print age number of stars
 *
 * @author
 * @version 1.00 2015/10/2
 */

import java.util.Scanner;
public class MethodNameAgeStars {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	String name;
    	int age;

    	System.out.print("Enter your name: ");
    	name = input.next();

    	System.out.print("Enter your age: ");
    	age = input.nextInt();

    	//pass name and age to a method
    	AgeStar(name, age);

    }//end main method

    public static void AgeStar(String m_name, int m_age){
    	System.out.println("\nHello " + m_name);
    	String spaces = "";
    	//print m_age stars
    	for(int i = 1; i<=m_age; i++){
    		System.out.println(spaces + "*");
    		spaces += " ";		//add (append) a space to the String spaces
    	}//end for

    }//end AgeStar method

}//end class