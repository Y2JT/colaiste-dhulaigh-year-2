/**
 * @(#)NameLengthMethodTwo.java
 *pass your name to method and if have the method return the length of your name
 *tell the uer if the have a long or short name
 * @author
 * @version 1.00 2015/10/8
 */


public class NameLengthMethodTwo {

    public static void main(String args[]) {

    	int result; //this will hold the number held by the method
    	//mehtod call
       result =	namelength("Dean");

       if(result>10){
       	System.out.println("your name is  Long");
       	System.out.println();
       }//end if
       else{
       	System.out.println(" your name is Short");
        System.out.println();
       }//end else




    }//end main

    public static  int namelength(String x){
    	int num;
    	num = x.length(); //asign the length to the num
    	return num; // return num
    }//end namelength method


}//end class