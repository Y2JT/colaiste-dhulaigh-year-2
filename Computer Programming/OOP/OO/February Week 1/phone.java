/**
 * @(#)phone.java
 *
 *
 * @author
 * @version 1.00 2016/2/4
 */


public class phone {

	//attributes
	private String make, colour;
	private App a1;

	//constructor
    public phone(String make, String colour, App a1) {
    	this.make = ((make.length()>0)? make: "Unknown");
    	this.colour = ((colour.length()>0)? colour: "Unknown");
    	this.a1 = a1;
    }//end constructor

    //toString
    public String toString(){
    	return "\nPhone Make: " + make + "\nPhone Colour: " + colour + a1;
    }//end toString

}//end class