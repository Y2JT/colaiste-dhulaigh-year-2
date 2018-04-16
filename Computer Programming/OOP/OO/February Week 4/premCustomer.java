/**
 * @(#)premCustomer.java
 *
 * *** PREMIUM CUSTOMER ***
 *
 * @author
 * @version 1.00 2016/2/25
 */


public class premCustomer extends PolyCustomer{

	//attributes
	private int credlim;

	//constructor
    public premCustomer(String name, String address, int cl) {
    	super(name,address);	//calls superclass constructor
    	credlim = ((cl>0)?cl:1);
    }//end constructor

	//toString
    public String toString(){
    	return "\n\nPremium Customer: " + super.toString() + "\nCredit Limit: " + credlim;
    }//end toString

}//end class