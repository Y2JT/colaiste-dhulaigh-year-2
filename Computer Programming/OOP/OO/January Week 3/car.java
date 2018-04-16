/**
 * @(#)car.java
 * Create an engine class with attributes type (petrol/desiel) and size (eg 1000, 2000)
 * Create a car class with attributes make, model, and engine
 * In the carTest take all inputs from the user and create a car
 * In engine and car class use setDetails method to set the attributes and not the constructor
 *
 * @author
 * @version 1.00 2016/1/21
 */


public class car {

	//attributes
	private String make;
	private String model;
	private engine e1;

	//constructor
    public car(String m, String md, engine e) {
    	setDetails(m,md,e);
    }//end constructor

    public void setDetails(String m, String md, engine e){
    	this.make = ((m.length()>0)? m : "Unknown");
    	this.model = ((md.length()>0)? md : "Unknown");
    	e1 = e;
    }

	//toString
	public String toString(){
		return "\n\nCar Details: " + "\nCar Make: " + make + "\nCar Model: " + model + e1.toString();
	}//end toString

}//end class