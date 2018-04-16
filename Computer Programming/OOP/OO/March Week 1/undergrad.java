/**
 * @(#)undergrad.java
 *
 *
 * @author
 * @version 1.00 2016/3/3
 */


public class undergrad extends student{

	private String coursename;
	private int courselength;

    public undergrad(String n, int i, phone p, String cn, int cl) {
    	super(n,i,p);	//calls superclass constructor
    	coursename = ((cn.length()>0)? cn : "Unknown");
    	courselength = ((cl>0)? cl : 111);
    }//end constructor

    //toString
    public String toString(){
    	return super.toString() + "\nCourse Name: " + coursename + "\nCourse Length: " + courselength + " years\n\n";
    }//end toString

}//end class