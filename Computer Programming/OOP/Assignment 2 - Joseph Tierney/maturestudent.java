/**
 * @(#)maturestudent.java
 *
 *
 * @author
 * @version 1.00 2016/4/7
 */


public class maturestudent extends student {

	private String dob;

	//constructor
    public maturestudent(String name, int id, String address, application a1, String dob) {
    	super(name,id,address,a1);
    	this.dob = ((dob.length()>0)? dob : "Unknown");
    }//end constructor

    //toString
    public String toString(){
    	return super.toString() + "Date of Birth: " + dob + "\n";
    }//end toString

}//end class