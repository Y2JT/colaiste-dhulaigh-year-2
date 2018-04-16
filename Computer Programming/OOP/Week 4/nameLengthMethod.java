/**
 * @(#)nameLengthMethod.java
 * Pass your name to a method which will print the number
 * of characters in your name
 *
 * @author
 * @version 1.00 2015/10/8
 */


public class nameLengthMethod {

    public static void main(String args[]) {

    	//method call
    	namelength("Joey Tierney");

    }//end main method

    public static void namelength(String x){
    	System.out.println(x + " has " + x.length() + " characters");
    }//end namelength method

}//end class