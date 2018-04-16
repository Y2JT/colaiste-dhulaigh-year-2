/**
 * @(#)ThreadEg.java
 *
 *
 * @author
 * @version 1.00 2016/1/28
 */


public class ThreadEg {

    public static void main(String args[]) {

    	String sentence = "Welcome to my java programming class in room 203";
    	char mychar;
    	String mysentence = "";

    	try{
    		for(int i =0; i<sentence.length();i++){
    			Thread.currentThread().sleep(100);
    			mychar = sentence.charAt(i);
    			mysentence += mychar;
    			System.out.print("\r " + mysentence);
    			printing(mysentence);
    		}//end for
    	}
    	catch(Exception e){
    		System.out.print("Cannot find data required");
    	}

    	System.out.println();

    }//end main

    public static void printing(String x){
    	System.out.print("\r " + x);
    }


}//end class