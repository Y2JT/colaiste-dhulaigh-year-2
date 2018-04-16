/**
 * @(#)rollDice2.java
 * Create a method to roll a dice a number of times.
 * The number of times the dice is to be rolled should be passed to the method
 *
 * @author
 * @version 1.00 2015/10/2
 */


public class rollDice2 {

    public static void main(String args[]) {

    	//method call
    	roll_dice(5);

    }//end main method

    public static void roll_dice(int x){
    	for(int i = 1; i<=x; i++){
    		int r = 1 + (int)(Math.random()*6);
    		//roll the dice
    		System.out.println("Roll " + i + ": " + r);
    	}//end for
    }//end roll_dice method

}//end class