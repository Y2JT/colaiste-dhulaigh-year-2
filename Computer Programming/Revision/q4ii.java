/**
 * @(#)q4ii.java
 *
 *
 * @author
 * @version 1.00 2015/9/24
 */

import java.util.Scanner;
public class q4ii {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	int age, total = 0, average, counter = 0;

    	//take in age
    	System.out.print("Enter age or -1 to quit: ");
    	age = input.nextInt();

    	//loop to take in the ages
    	while(age!= -1){
    		//add the age to the total
    		total += age;
    		//increment counter
    		counter++;		//counter = counter + 1;
    		//take in age
    		System.out.print("Enter age or -1 to quit: ");
    		age = input.nextInt();

    	}//end while

    	if(counter != 0){
    		//get average
    		average = total/counter;

    		System.out.println("\nAverage age is: " + average + "\n");
    	}//end if
    	else{
    		System.out.println("\nNo ages entered\n");
    	}//end else
		System.out.println("*********************************");
    	//q4iii
    	//Write a program that declares an integer array of length 5. Print the values in the array
    	int numbers[] = {60,42,34,54,71};
    	int total2 = 0;

    	for(int i = 0;i<numbers.length;i++){
    		total2=+numbers[i];
    	}//end for

    	System.out.println("\nQuestion 4 (iii): Total of numbers in the array is " + total2 + "\n\n");

    }//end main


}//end class