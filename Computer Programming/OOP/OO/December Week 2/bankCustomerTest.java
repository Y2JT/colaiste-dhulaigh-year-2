/**
 * @(#)bankCustomerTest.java
 * bankCustomerTest to go with bankCustomer
 *
 * @author
 * @version 1.00 2015/12/11
 */


public class bankCustomerTest {

    public static void main(String args[]) {

    	//create customer with all details
    	bankCustomer bc1 = new bankCustomer("Joey","Dublin",400,1150,false);
    	//bankCustomer with only name and account number known
    	bankCustomer bc2 = new bankCustomer("Rick",4670);
    	//bankCustomer with name, address and account number
    	bankCustomer bc3 = new bankCustomer("Ted","Cork",3092);

		//print details
    	System.out.println(bc1.toString());
    	System.out.println(bc2.toString());
    	System.out.println(bc3.toString());

    }//end main method


}//end class