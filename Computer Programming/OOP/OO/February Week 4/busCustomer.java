/**
 * @(#)busCustomer.java
 *
 * ***BUSINESS CUSTOMER ***
 *
 * @author
 * @version 1.00 2016/2/25
 */


public class busCustomer extends PolyCustomer{

	//attributes
	private int id;
	private String PAname;

	//constructor
    public busCustomer(String name, String address, int id, String PAn) {
    	super(name, address);	//calls superclass constructor
    	this.id = ((id>0)?id:111);
    	PAname = PAn;
    }//end constructor

	//toString
    public String toString(){
    	return "\n\nBusiness Customer: " + super.toString() + "\nID: " + id + "\nPersonal Assistant: " + PAname + "\n\n";
    }//end toString


}//end class