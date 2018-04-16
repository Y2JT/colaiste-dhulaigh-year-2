/**
 * @(#)q4.java
 * Write a program that will take in your name and pass it to a method
 * The method will print name.length() stars
 *
 * @author 
 * @version 1.00 2015/10/28
 */

import java.util.Scanner;
public class q4 {

    public static void main(String args[]) {
    	
    	Scanner input = new Scanner(System.in);
    	String name;
    	
    	System.out.print("Enter your name: ");
    	name = input.next();
    	int size = name.length();
    	//method call
    	namelength(size);
    	
    }//end main method
    
    public static void namelength(int msize){
    	for(int i =1;i<=msize;i++){
    	System.out.print("*");
    	}//end for
    	System.out.println();
    	System.out.println();
    }//end namelength
    
    
}//end class