/**
 * @(#)gradeMethod.java
 * Write a program to take a percentage grade from the user
 * Pass this to a method and return "Distinction", "Merit", "Pass" or "Fail"
 * Tell the user their grade
 *
 * @author
 * @version 1.00 2015/10/22
 */

import java.util.Scanner;
public class gradeMethod {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);
    	int grade;
    	String result;

    	System.out.print("Please enter Grade: ");
    	grade = input.nextInt();

    	//method call
    	result = gradecheck(grade);

    	System.out.println("\nYou got a: " + result);

    }//end main method

    public static String gradecheck(int mgrade){
    	if(mgrade > 79){
    		return "Distinction\n\n";
    	}
    	else if(mgrade > 64){
    		return "Merit\n\n";
    	}
    	else if(mgrade > 49){
    		return "Pass\n\n";
    	}
    	else{
    		return "Fail\n\n";
    	}

    }//end gradecheck


}//end class