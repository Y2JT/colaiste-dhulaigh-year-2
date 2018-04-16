/**
 * @(#)college.java
 *
 *
 * @author 
 * @version 1.00 2016/3/2
 */


public class college {
	
	private String name, location;
	private student s1;

    public college(String name, String location, student s1) {
    	this.name = ((name.length()>0)? name : "Unknown");
    	this.location = ((location.length()>0)? location : "Unknown");
    	this.s1 = s1;
    }//end constructor
    
    //toString
    public String toString(){
    
    return "\nCollege: " + name + "\nLocation: " + location + "\nStudent Details -" + s1;
    }//end toString
}