/**
 * @(#)TwoNames.java
 *pass the names to a mehtod
 *the method will return the names  of the person with longest name to the method or the word both
 *if both are the same length
 * @author
 * @version 1.00 2015/10/9
 */

import java.util.Scanner;
public class TwoNames {

    public  static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	String result;
    	String name1;
    	String name2;

    	System.out.print("Enter name :");
    	name1 = input.nextLine();

    	System.out.print("Enter name 2  :");
    	name2 = input.nextLine();

     	result = nameslength(name1,name2);

   		System.out.print("\n-------------------------------------");
    	System.out.println("\n" + result + " Has the longest Name ");
    	System.out.print("\n-------------------------------------");
    	System.out.println();



    }//end main
    public static String nameslength(String mname1,String mname2){

    	if(mname1.length()>mname2.length()){
    		return mname1;

    	}
    	if(mname1.length()<mname2.length()){
    		return mname2;

    	}
    	else{
    		return "Both";
    	}




    }//end names length


}//end class