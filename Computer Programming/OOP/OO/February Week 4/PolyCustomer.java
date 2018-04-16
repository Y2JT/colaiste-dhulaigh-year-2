/**
 * @(#)PolyCustomer.java
 * Create a customer object with name and address
 * Create a premium customer which inherits from customer but also has credit limit
 * Have a business customer that inherits from customer but also has id and personal assistant (string PAname)
 *
 * Create an array of customers and populate it with a customer, premium customer and business customer
 * @author
 * @version 1.00 2016/2/25
 */


public class PolyCustomer {

	//attributes
	private String name, address;

	//constructor
    public PolyCustomer(String n, String a) {
    	name = n;
    	address = a;
    }//end constructor

	//toString
    public String toString(){
    	return "\nName: " + name + "\nAddress: " + address;
    }//end toString

}//end class