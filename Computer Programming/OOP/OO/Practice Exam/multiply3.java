/**
 * @(#)multiply3.java
 *
 *
 * @author 
 * @version 1.00 2016/3/2
 */

import java.util.Scanner;
public class multiply3 {

    public static void main(String args[]) {
    	Scanner input = new Scanner(System.in);
    	int num;
    	int result;
    	
    	System.out.print("Enter a number: ");
    	num = input.nextInt();
    	
    	//method call
    	result = timesthree(num);
    	
    	System.out.println("\nThe number times three is: " + result + "\n\n");
    	
    }//end main
    
    public static int timesthree(int numx){
    	return (numx*3);
    }//end timesthree
    
    
}//end class