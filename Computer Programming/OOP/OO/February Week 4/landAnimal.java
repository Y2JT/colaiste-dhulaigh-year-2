/**
 * @(#)landAnimal.java
 *
 *
 * @author
 * @version 1.00 2016/2/26
 */


public class landAnimal extends animal{

	private int numlegs;
	private String type;

	//constructor
    public landAnimal(String n, String c, int nl, String t) {
    	super(n,c);		//calls superclass constructor
    	numlegs = nl;
    	type = t;
    }//end constructor

    //toString
    public String toString(){
    	return super.toString() + "\nNumber of Legs: " + numlegs + "\nType: " + type;
    }//end toString

}//end class