/**
 * @(#)soldier.java
 * subclass of character
 *
 * @author
 * @version 1.00 2016/1/22
 */


public class soldier extends character {

	private int number;
	private String rank;

	//constructor
    public soldier(String name, int speed, double height, int number, String rank) {
    	super(name, speed, height);	//calls the constructor of the superclass (character)
    	this.number = ((number>0)?number:1111);
    	this.rank = rank;
    }//end constructor

    public String toString(){
    	return super.toString() + "\nNumber: " + number + "\nRank: " + rank + "\n";
    }//end toString

}//end class