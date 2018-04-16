/**
 * @(#)Office.java
 * Create an office object. An office has a location, phone_number and worker
 * Create a worker object with attributes name, id and salary
 * In the officeTest create an array of office objects, length 3
 * Print the details of the office objects
 *
 * @author
 * @version 1.00 2016/2/5
 */


public class Office {

	//attributes
	private String location;
	private int phone_number;
	private Worker w1;

    public Office(String location, int phone_number, Worker w1) {
    	this.location = ((location.length()>0)? location : "Unknown");
    	this.phone_number = ((phone_number>0)? phone_number : 111);
    	this.w1 = w1;
    }//end constructor

    //toString
    public String toString(){
    	return "\nOffice Location: " + location + "\nPhone Number: " + phone_number + w1;
    }//end toString

}//end class