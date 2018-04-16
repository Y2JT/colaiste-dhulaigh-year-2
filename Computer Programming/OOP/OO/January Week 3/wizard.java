/**
 * @(#)wizard.java
 *
 *
 * @author
 * @version 1.00 2016/1/22
 */


public class wizard extends character {

	private String power;
	private String hatcolour;

	//constructor
    public wizard(String name, int speed, double height, String power, String hatcolour) {
    	super(name, speed, height);	//calls the constructor of the superclass (character)
    	this.power = ((power.length()>0)?power:"Secret");
    	this.hatcolour = hatcolour;
    }//end constructor

    public String toString(){
    	return super.toString() + "\nPower: " + power + "\nHat Colour: " + hatcolour + "\n";
    }//end toString

}//end class