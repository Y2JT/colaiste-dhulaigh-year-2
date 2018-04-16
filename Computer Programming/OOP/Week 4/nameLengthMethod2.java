/**
 * @(#)nameLengthMethod2.java
 * Pass your name to a method and have the method return the length of your name
 * Tell the user if they have a long or a short name
 *
 * @author
 * @version 1.00 2015/10/8
 */


public class nameLengthMethod2 {

    public static void main(String args[]) {

    	int result;		//this will hold the number returned by the method
    	//method call
    	result = namelength("Joey");

    	if(result > 10){
    		System.out.println("Your name is long\n\n");
    	}//end if
    	else{
    		System.out.println("Your name is short\n\n");
    	}//end else

    }//end main method

    public static int namelength(String x){

    	int num;
    	num = x.length();	//assign the length of your name to num
    	return num;			//return num

    }//end namelength method

}//end class