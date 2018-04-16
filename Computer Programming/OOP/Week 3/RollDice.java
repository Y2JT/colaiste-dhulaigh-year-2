/**
 * @(#)RollDice.java
 *
 * Roll a dice using a method
 * @author
 * @version 1.00 2015/10/1
 */


public class RollDice {

    public static void main(String args[]) {

    	//method call
    	roll_dice();

    }//end main method

    public static void roll_dice(){
    	//int roll = 1+(int)(Math.random()*6)
    	System.out.println(1 + (int)(Math.random()*6));
    }//end roll_dice method

}//end class