/**
 * @(#)character.java
 * Create a character object with attributes name, speed and height
 * Create a soldier object that will inherit from character
 * but also has attributes number and rank
 * Create a soldier object in the characterTest class
 * @author
 * @version 1.00 2016/1/22
 */


public class character {

	private String name;
	private int speed;
	private double height;
	private static int count = 0;

	//constructor
    public character(String n, int s, double h) {
    	name = n;
    	speed = ((s>0)?s:1);
    	height = ((h>0.0)?h:1.0);
    	count++;	//increment the static count
    }//end constructor

    //method to return the value of the static count
    public static int getcount(){
    	return count;
    }//end get method

    public String toString(){
    	return "\nName: " + name + "\nSpeed: " + speed + "\nHeight: " + height;
    }//end toString

}//end class