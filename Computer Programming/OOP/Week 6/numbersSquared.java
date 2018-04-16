/**
 * @(#)numbersSquared.java
 * Take a number from the user. Pass it to a method and
 * return the square of the number
 *
 * @author
 * @version 1.00 2015/10/22
 */

import java.util.Scanner;
public class numbersSquared {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);
    	int num;
    	int result;

    	System.out.print("Enter a number: ");
    	num = input.nextInt();

    	//method call
    	result = squarenum(num);

    	System.out.println("\nThe number squared is: " + result + "\n\n");

    }//end main method

    public static int squarenum(int numx){
    	return (numx*numx);

    }//end squarenum


}//end class