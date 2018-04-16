/**
 * @(#)phoneTest.java
 * phoneTest class to go with phone.java
 *
 * @author
 * @version 1.00 2015/12/3
 */


public class phoneTest {

    public static void main(String args[]) {

    	//create new phone object
    	phone p1 = new phone("Apple", "Black", 830070293);	//create valid phone
    	phone p2 = new phone("", "", -861297792);	//create invalid phone

		//print details of phone objects
    	System.out.println("Phone 1 Details\n" + p1.toString());
    	System.out.println("\n\nPhone 2 Details\n" + p2.toString());

    }//end main method


}//end class