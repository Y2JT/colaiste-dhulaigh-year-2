/**
 * @(#)q2.java
 * Ask the user to guess what value will be rolled by a dice.
 * Call a method to generate a random number from 1-6 and return this value.
 * Check if the user guessed correctly or not
 *
 * @author 
 * @version 1.00 2015/10/28
 */

import java.util.Scanner;
public class q2 {

    public static void main(String args[]) {
    	
    	Scanner input = new Scanner(System.in);
    	int guess;
    	int num = 0;
    	int result;
    	
    	System.out.print("Enter guess on what value will be rolled: ");
    	guess = input.nextInt();
    	
    	//method call
    	result = rolldice(num);
    	
    	if(guess == result){
    		System.out.print("\nCongratulations! You guessed correctly\n\n");
    	}//end if
    	else{
    		System.out.print("\nWrong!\n\n");
    	}
    	
    	
    }//end main method
    
    public static int rolldice(int numx){
    	numx = 1 +(int)(Math.random()*6);
    	return numx;
    }//end rolldice method
    
    
}//end class