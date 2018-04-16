/**
 * @(#)App.java
 * Create an app object with instance variables Name, size and numLevels
 * Create a phone object
 * A phone object has a make, colour and an app
 * Create a phoneTest class and print the details of the phone
 *
 * @author
 * @version 1.00 2016/2/4
 */


public class App {

	//attributes
	private String name;
	private int size, numLevels;

	//constructor
    public App(String name, int size, int numLevels) {
    	this.name = ((name.length()>0)? name: "Uknown");
    	this.size = ((size>0)? size : 111);
    	this.numLevels = ((numLevels>0)? numLevels : 111);
    }//end constructor

    //toString
    public String toString(){
    	return "\nApp Name: " + name + "\nApp Size: " + size + "GB" + "\nNumber of Levels: " + numLevels;
    }//end toString

}//end class