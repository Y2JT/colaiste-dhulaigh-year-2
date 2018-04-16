/**
 * @(#)school.java
 * subclass of building
 *
 * @author
 * @version 1.00 2016/1/28
 */

public class school extends building {

	private String name;
	private int capacity;

	//constructor
    public school(String location, int size, int num_floors, String name, int capacity) {
    	super(location, size, num_floors);
    	this.name = ((name.length()>0)?name:"Unknown");
    	this.capacity = ((capacity>0)?capacity:1);
    }//end constructor

    //public String getlocation(){
    	//return " at address " + super.getlocation();
    //}

    public String toString(){
    	return super.toString() + "\nSchool Name: " + name + "\nCapacity: " + capacity + "\n"; //super.toString() can go at the end too
    }//end toString

}//end class