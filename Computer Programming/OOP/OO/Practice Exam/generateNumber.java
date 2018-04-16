/**
 * @(#)generateNumber.java
 *
 *
 * @author 
 * @version 1.00 2016/3/2
 */

import java.util.Scanner;
public class generateNumber {

    public static void main(String args[]) {
    	Scanner input = new Scanner(System.in);
    	int num;
    	
    	System.out.print("Enter the number of times to generate a number between 1 and 10: ");
    	num = input.nextInt();
    	
    	//method call
    	generate(num);
    	
    	//System.out.println("The average number is: ");
    	
    }//end main
    
    public static void generate(int numx){
    	//loop to generate numbers
    	for(int i = 1; i<=numx; i++){
    		//generate the number
    		System.out.println(1 + (int) (Math.random()*10));
    	}//end for
    }//end generate
    
    
}//end class