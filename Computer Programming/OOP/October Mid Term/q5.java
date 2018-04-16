/**
 * @(#)q5.java
 * Write a program that will take two names and two ages.
 * Pass the two names and two ages to a method.
 * Return the name of the person who is oldest or "Both" if thtey are the same
 * Print name of oldest
 *
 * @author 
 * @version 1.00 2015/10/28
 */

import java.util.Scanner;
public class q5 {

    public static void main(String args[]) {
    	
    	Scanner input = new Scanner(System.in);
    	String result;
    	String name1, name2;
    	int age1, age2;
    	
    	//first person name and age
    	System.out.print("Enter name: ");
    	name1 = input.next();
    	System.out.print("Enter age for " + name1 + ": ");
    	age1 = input.nextInt();
    	System.out.println();
    	//second person name and age
    	System.out.print("Enter name 2: ");
    	name2 = input.next();
    	System.out.print("Enter age for " + name2 + ": ");
    	age2 = input.nextInt();
    	
    	result = nameoldest(name1,name2,age1,age2);
    	
    	System.out.print("\n****************");
    	System.out.println("\n" + result + " is the oldest");
    	System.out.print("****************\n\n");
    	System.out.println();    	
    	
    }//end main method
    
    public static String nameoldest(String mname1, String mname2, int mage1, int mage2){
    	if(mage1 > mage2){
    		return mname1;
    	}//end if
    	if(mage2 > mage1){
    		return mname2;
    	}//end if
    	else{
    		return "Both";
    	}//end else
    }//end nameoldest
    
    
}//end class