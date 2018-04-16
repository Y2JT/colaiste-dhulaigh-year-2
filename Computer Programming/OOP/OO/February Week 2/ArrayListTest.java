/**
 * @(#)ArrayListTest.java
 *
 *
 * @author
 * @version 1.00 2016/2/11
 */

import java.util.ArrayList;
public class ArrayListTest {

    public static void main(String args[]) {

    	//create an arraylist
    	ArrayList a1 = new ArrayList();

    	System.out.println("Inital size of array is: " + a1.size());
    	//add elements to the list
    	a1.add("C");
    	a1.add("A");
    	a1.add("E");
    	a1.add("P");
    	a1.add("J");
    	a1.add("K");

    	//print the contents of the arraylist
    	System.out.println("Contents of array list are: " + a1);
    	System.out.println("Size of array list is: " + a1.size());

    	//add to the arraylist subscript 1
    	a1.add(1,"A2");
    	//print the contents of the arraylist
    	System.out.println("Contents of array list are: " + a1);

    	//remove from arraylist
    	a1.remove("K");
    	a1.remove(2);

    	System.out.println("Size of array list after deleting is: " + a1.size());
    	//print the contents of the arraylist
    	System.out.println("Contents of array list are: " + a1);

    }//end main method

}//end class