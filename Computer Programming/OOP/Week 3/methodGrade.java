/**
 * @(#)methodGrade.java
 * Take a grade from the user and pass it to a method
 * The method should tell the user if it is a distinction, merit, pass or unsuccessful
 *
 * @author
 * @version 1.00 2015/10/2
 */

import java.util.Scanner;
public class methodGrade {

    public static void main(String args[]) {

		Scanner input = new Scanner(System.in);
		//declare variable
    	int grade;
		//prompt the user
    	System.out.print("Please enter a grade: ");
    	grade = input.nextInt();

    	//method call
    	grade_check(grade);		//pass grade to the method grade_check

    }//end main method

    public static void grade_check(int mgrade){
		//check if the grade is Distinction, Merit, Pass or Fail
    	if(mgrade>79){
    		System.out.println("\nGrade is a: Distinction\n\n");
    	}//end if
    	else if(mgrade>64){
    		System.out.println("\nGrade is a: Merit\n\n");
    	}//end else if
    	else if(mgrade>49){
    		System.out.println("\nGrade is a: Pass\n\n");
    	}//end else if
    	else{
    		System.out.println("\nGrade is Unsuccessful\n\n");
    	}//end else

    }//end grade_check method


}//end class