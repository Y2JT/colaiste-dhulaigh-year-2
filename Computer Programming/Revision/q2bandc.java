/**
 * @(#)q2bandc.java
 * Joey Tierney
 *
 * @author
 * @version 1.00 2015/9/23
 */

import java.util.Scanner;
public class q2bandc {

    public static void main(String args[]) {

    	//Q2b
    	//Write a program to take a persons name and age, print their name
    	//and a star for every year old they are

    	Scanner input = new Scanner(System.in);

    	//declare variables
    	int age;
    	String name;

    	//prompt user for their name
    	System.out.print("Enter your name: ");
    	name = input.next();

		//prompt user for their age
    	System.out.print("\nEnter your age: ");
    	age = input.nextInt();

    	//print their name
    	System.out.print("\n" + name + "\n");

    	//while loop to print stars
    	for(int i = 1; i<=age; i++){
    		System.out.print("*");
    	}//end for

		//print blank line
		System.out.println();
		System.out.println();

		//Q2c
		//Write a program which uses a for loop to print the even numbers from 2 to 20

		for(int i=2; i<=20; i+=2){
			System.out.print("\n2" + "\n");
		}//end for

    }//end main


}//end class