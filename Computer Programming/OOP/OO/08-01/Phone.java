/**
 * @(#)Phone.java
 *Create a phone object with instance variables make, colour and number
 *Have a toString method
 *Create phone test and create a valid and in valid instance of phone
 *
 *
 * Ciarán Ormonde
 * @version 1.00 2015/12/3
 */


public class Phone {

	//Attributes
	private String make;
	private String colour;
	private int number;

    public Phone(String make, String colour, int number) {
    	this.make = ((make.length()>0)?make : "Unknown");
    	this.colour = ((colour.length()>0)?colour : "Unknown");
    	this.number = ((number>0)?number : 1);
    }//end method

    public String toString(){
    	return "\nMake : " + make + "\nColour : " + colour + "\nNumber : " + number;
    }


}