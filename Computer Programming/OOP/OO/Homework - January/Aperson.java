/**
 * @(#)Aperson.java
 * Create a person object with attributes name, address and id
 * Have set and get methods
 * Create a student object with attributes collegeName and courseName
 * A student is a person
 * Have set and get methods. Have a studies behaviour (method) that will have a
 * number-of_hours passed to it and will return "NAME studies NumHours per day"
 * Have a test class and create a student object
 * Call the studies behaviour and the toString method. Change the collegeName and className
 * and print the new details using get methods.
 *
 * @author
 * @version 1.00 2016/1/28
 */


public class Aperson {

	private String name, address;
    private int id;

	//constructor
    public Aperson(String name, String address, int id) {
    	this.name = name;
    	this.address = address;
    	this.id = ((id>0)? id:111);
    }//end constructor

    //set name method
    public void setname(String name){
    	this.name = name;
    }//end set name method

    //set address method
    public void setaddress(String address){
    	this.address = address;
    }//end set address method

    //set id method
    public void setid(int id){
    	this.id = ((id>0)? id:111);
    }//end set id method

    //get name method
    public String getname(){
    	return name;
    }//end get name method

    //get address method
    public String getaddress(){
    	return address;
    }//end get address method

    //get id method
    public int getid(){
    	return id;
    }//end get id method

    //studies behaviour
    public String studies(int x){
    	return name + " studies " + x + " hours per day";
    }//end studies behaviour

    //toString method
    public String toString(){
    	return "\nName: " + name + "\nAddress: " + address + "\nID: " + id;
    }//end toString

}//end class