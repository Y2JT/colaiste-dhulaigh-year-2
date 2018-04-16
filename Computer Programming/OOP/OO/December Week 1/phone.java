/**
 * @(#)phone.java
 * Create a phone object with instance variables, make, colour and number
 * Have a toString method
 * Create a phoneTest and a valid and invalid instance of phone
 *
 * @author
 * @version 1.00 2015/12/3
 */


public class phone {
	//attributes
	private String make;
	private String colour;
	private int number;

	//constructor
    public phone(String make, String colour, int number) {
    	this.make = ((make.length()>0)?make : "Unknown");
    	this.colour = ((colour.length()>0)?colour : "Unknown");
    	this.number = ((number > 0)?number : 1);	//conditional statement
    }//end constructor

    //toString method
    public String toString(){
    	return "\nMake: " + make + "\nColour: " + colour + "\nNumber: " + number;
    }//end toString method


}//end class