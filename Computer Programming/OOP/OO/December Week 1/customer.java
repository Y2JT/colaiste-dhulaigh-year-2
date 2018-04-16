/**
 * @(#)customer.java
 * Create a customer object with name, id and address
 * Have a toString method
 * Create a customerTest class and create a valid and invalid customer
 * Print the details of the customer objects
 * @author
 * @version 1.00 2015/12/4
 */


public class customer {
	private String name;
	private int id;
	private String address;

	//constructor
    public customer(String name, int id, String address) {

    	this.name = ((name.length()>0)?name : "Unknown");
    	this.id = ((id>0)?id : 1);
    	this.address = ((address.length()>0)?address : "Unknown");

    }//end constructor

    //setname method takes a name and sets the name instance variable
    public void setname(String name){
    	this.name = ((name.length()>0)?name : "Unknown");
    }//end setname method

    //getname method returns name to test class
    public String getname(){
    	return name;
    }//end getname method

    //setid method takes an id and sets the id instance variable
    public void setid(int id){
    	this.id = ((id>0)?id : 1);
    }//end setid method

    //getid method returns id to test class
    public int getid(){
    	return id;
    }//end getid method

    //setaddress method takes an address and sets the address instance variable
    public void setaddress(String address){
    	this.address = ((address.length()>0)?address : "Unknown");
    }//end setaddress method

    //getaddress method returns address to test class
    public String getaddress(){
    	return address;
    }//end getaddress method

    //toString method
    public String toString(){
    	return "\nCustomer Details\n\nName: " + name + "\nID: " + id + "\nAddress: " + address;
    }//end toString method


}//end class