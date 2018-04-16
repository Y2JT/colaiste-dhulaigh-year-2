/**
 * @(#)q1.java
 * Take an age from the user. Pass the age to a method
 * From the method tell the user if they can vote or not
 *
 * @author 
 * @version 1.00 2015/10/28
 */

import java.util.Scanner;
public class q1 {

    public static void main(String args[]) {
    	
    	Scanner input = new Scanner(System.in);
    	int age;
    	
    	System.out.print("Please Enter your age: ");
    	age = input.nextInt();
    	
    	//method call
    	checkage(age);
    	
    }//end main method
    
    public static void checkage(int mage){
    	if(mage >17){
    		System.out.print("\nYou can vote\n\n");
    	}//end if
    	else{
    		System.out.print("\nYou are too young to vote\n\n");
    	}//end else
    }//end checkage method
    
    
}//end class