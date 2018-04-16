/**
 * @(#)dobCheck.java
 * Take 5 date of births in from the user in the format dd/mm/yyyy (as String)
 * Pass this input to a method and check if the date of birth is valid
 * When it is valid return it and store it in an array
 *
 * @author
 * @version 1.00 2015/10/16
 */

import java.util.*;
public class dobCheck {

	static Scanner input = new Scanner(System.in);
    public static void main(String args[]) {


    	Date d = new Date();

    	String dob;
    	//String array to hold the Date of Births in a String format
    	String dateofbirths[] = new String[5];

    	System.out.println(d);

    	//take in date of births
    	for(int i = 0; i<dateofbirths.length;i++){
    		System.out.print("Enter DOB (dd/mm/yyyy): ");
    		dob =input.next();
    		//dobcheck method call
    		dateofbirths[i] = dobcheckmethod(dob);
    	}//end for

    	//print out date of births
    	for(int i = 0;i<dateofbirths.length;i++){
    		System.out.println(dateofbirths[i]);
    	}//end for

    }//end main method

	public static String dobcheckmethod(String mdob){
		boolean flag = false;
		char check1, check2;

		while(flag == false){
			if(mdob.length()!=10){
				System.out.println("Invalid format\nPlease re-enter (dd/mm/yyyy): ");
				mdob = input.next();
			}//end if
			else{	//if it is length 10
				//check where / are
				check1 = mdob.charAt(2);
				check2 = mdob.charAt(5);

				if((check1 == '/') && (check2 == '/')){
					flag = true;	//change flag to true
				}//end if
				else{
					System.out.println("Invalid format\nPlease re-enter (dd/mm/yyyy): ");
					mdob = input.next();
				}//end inner else

			}//end outer else
		}//end while

		return mdob;

	}//end dobcheckmethod

}//end class