/**
 * @(#)waterAnimal.java
 *
 *
 * @author
 * @version 1.00 2016/2/26
 */


public class waterAnimal extends animal{

	private int size, speed;

    public waterAnimal(String n, String c, int s, int spd) {
    	super(n,c);		//calls superclass constructor
    	size = s;
    	speed = spd;
    }//end constructor

    //toString
    public String toString(){
    	return super.toString() + "\nSize: " + size + "ft. " + "\nSpeed: " + speed + "mph\n\n";
    }//end toString

}//end class