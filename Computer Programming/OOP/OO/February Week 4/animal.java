/**
 * @(#)animal.java
 * Create an animal class with name and colour
 * Create a land animal class with numlegs and type
 * Create a water animal class with size and speed
 * Create an array of animals made up of animla, land animal and water animal
 *
 * @author
 * @version 1.00 2016/2/26
 */


public class animal {

	private String name, colour;

	//constructor
    public animal(String n, String c) {
    	name = n;
    	colour = c;
    }//end constructor

    //toString
    public String toString(){
    	return "\nName: " + name + "\nColour: " + colour;
    }//end toString

}//end class