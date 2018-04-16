/**
 * @(#)nameAgeCheck.java
 * Joey Tierney
 * Take in 5 names and grades, display the highest and lowest average grade
 * Store the names and grades in arrays
 * Check for non-digits
 *
 * @version 1.00 2015/10/1
 */

import java.util.Scanner;
public class nameAgeCheck {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	//declare variables
    	String names[] = new String[5];
    	int grades[] = new int[5];
    	String highname = "", lowname = "";
    	String strgrade;	//take in the grade as a String to validate it
    	int high = 0, low = 100, total = 0;
    	String highest = "\nPepole with highest grade: \n";
		String lowest = "\nPepole with lowest grade: \n";

    	//loop to take in names and grades
    	for(int i = 0; i<names.length;i++){
    		System.out.print("Enter name: ");
    		names[i] = input.next();
    		System.out.print("Enter grade for " + names[i] + ": ");
    		strgrade = input.next();

    		//validate strgrade for non-digits
    		while(!strgrade.matches("\\d+")){
    			System.out.println("ERROR: Numbers Only!");
    			//reprompt the user
    			System.out.print("Enter grade for " + names[i] + ": ");
    			strgrade = input.next();
    		}//end while

    		//change strgrade to a digit
    		grades[i] = Integer.parseInt(strgrade);

    		//check for highest
    		if(grades[i]>high){			//if grades[i] is greater than high
    			high = grades[i];		//assign the value of grades[i] to high
    			highname = names[i];	//hold onto the name of the person who got the highest grade (store it in highname)
    		}//end if

    		//check for lowest
    		if(grades[i]<low){			//if grades[i] is less than low
    			low = grades[i];		//assign the value of grades[i] to low
    			lowname = names[i]; 	//hold onto the name of the person who got the lowest grades (store it in lowname)
    		}//end if

    		//add grades[i] to the total
    		total += grades[i];

    	}//end for

    	//get the average
    	System.out.println("\nAverage grade is: " + total/grades.length);
		System.out.println("******************************************");
    	System.out.println("\nThe highest grade is " + high + " which was achieved by: " + highname);
    	System.out.println("\nThe lowest grade is " + low + " which was achieved by: " + lowname);

    	System.out.println("\n" + highest);
    	//print highest name only
		for(int i = 0;i<names.length;i++){
			if(grades[i] == high){
				System.out.println(names[i]);
			}//end if
		}//end for

		System.out.println("\n" + lowest);
		//print highest name only
		for(int i = 0;i<names.length;i++){
			if(grades[i] == low){
				System.out.println(names[i]);
			}//end if
		}//end for

    }//end main


}//end class