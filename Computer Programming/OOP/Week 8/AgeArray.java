/**
 * @(#)AgeArray.java
 *declare an array globally and pass it down  the subscript value to the mehtod
 *double the age in the method
 *print out the age
 *
 * @author
 * @version 1.00 2015/11/5
 */

import java.util.Scanner;
public class AgeArray {

	static	Scanner input = new Scanner(System.in);
    static int ages[] = {21,32,34,19,43};

    public static void main(String args[]) {

    int sub;
    8



    // pass the middle subscript to the method
    doubleage(2);

    System.out.print(" \n\nAfter the method the new age is " + "\n\n" +  ages[2]);
	System.out.println();

    }///end main method

    public static void doubleage(int msub){
    	ages[msub] = ages[msub] * 2;


    }//end doubleages


}//end class