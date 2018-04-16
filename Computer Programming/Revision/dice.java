/**
 * @(#)dice.java
 * Joey Tierney
 * Write a program to simulate the rolling of a dice 100 times
 * Use an array to store the number of times each face of the dice appears
 *
 * @author
 * @version 1.00 2015/9/24
 */


public class dice {

    public static void main(String args[]) {

    	//declare an array to hold the number of times each face of the dice appears
    	int mydice[] = new int[7];
    	int roll;

    	//loop to roll the dice
    	for(int i = 1;i<=100;i++){
    		roll = 1 + (int)(Math.random()*6);	//generates random number (from 1 to 6)
    		//increment the array
    		mydice[roll]++;
    	}//end for

    	//loop to print out how many times each face was rolled
    	for(int i=1;i<mydice.length;i++){
    		System.out.println(i + " was rolled " + mydice[i] + " times");
    	}//end for

    	//blank line
    	System.out.println();
    	System.out.println();

    }//end main


}//end class