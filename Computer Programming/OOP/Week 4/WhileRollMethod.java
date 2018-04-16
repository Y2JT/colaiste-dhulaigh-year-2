/**
 * @(#)WhileRollMethod.java
 *call a method  that willl roll a dice when u7ntil six has been rolled
 *return the number of times the dice has been rolled before the dice was rolled
 * @author
 * @version 1.00 2015/10/9
 */


public class WhileRollMethod {

    public static void main (String args[]) {

    	//declare variables
    	int numtimes = 0;

    	numtimes = roll();

    	System.out.println("Dice rolled "  + numtimes + " Before getting a six " );


    }//end main
    public static int roll(){

		int numtimes = 0;
    	int num = 0;
    	int num2 = 0;

    	while(num!= 6){
    		num =	(1+(int)(Math.random()*1000000000*));

    		numtimes++;
    		//have thread 1 second delay before roll
    		try{
    			Thread.currentThread().sleep(100);
    			//print the value of the dice
    			System.out.println(num);
    		}//try
    		catch(Exception e){
    			System.out.print("Couldnt acssess current thread");
    		}//end catch

    	}//end while
    	//return the number of rhimes the dice was rolled before a six
    	return numtimes;

    }//end roll

}//end class