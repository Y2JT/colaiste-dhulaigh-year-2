/**
 * @(#)rolldice3.java
 * Take two numbers from the user
 * First number is how many times we want to generate a random number
 * Second number is the number we want to generate up to e.g. 1 to XX
 * Pass the two of the numbers to a method and display the numbers generated
 *
 * @author
 * @version 1.00 2015/10/2
 */

import java.util.Scanner;
public class rolldice3 {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	int numtimes, urange;

    	System.out.print("Enter the number of times to generate the random number: ");
    	numtimes = input.nextInt();

    	System.out.print("Enter the number to generate up to: ");
    	urange = input.nextInt();

    	//call method
    	generate(numtimes, urange);

    }//end main method

    public static void generate(int m_numtimes, int m_urange){
    	//loop to generate the random numbers
    	for(int i = 1; i<=m_numtimes; i++){
    		//generate the number
    		System.out.println(1 + (int)(Math.random()*m_urange));
    	}//end for
    }//end generate method


}//end class