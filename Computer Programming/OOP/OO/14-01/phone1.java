/**
 * @(#)phone1.java
 * phone1 to go with person1
 *
 * @author
 * @version 1.00 2016/1/14
 */


public class phone1 {

	//attributes
	private int number;
	private int ring_volume;
	private String colour;

	//constructor
    public phone1(int n, int rv, String col) {
    	this.number = ((n>0)? n : 1);
    	this.ring_volume = ((rv>0)? rv : 1);
    	this.colour = ((col.length()>0)? col: "Uknown");
    }//end constructor

	//toString
    public String toString(){
    	return "\n\nPhone Details \nNumber: " + number + "\nRing Volume: " + ring_volume + "\nColour: " + colour;
    }//end toString

}//end class