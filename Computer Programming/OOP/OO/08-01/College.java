/**
 * @(#)College.java
 *
 *
 * @author
 * @version 1.00 2016/1/8
 */


public class College {

    //Attributes
	private String name;
	private String address;
	private int numcourses;

    public College (String n, String add, int numc) {
    	this.name = ((n.length()>0)?n : "Unknown");
    	this.address = ((add.length()>0)?add : "Unknown");
    	this.numcourses = ((numc>0)?numc : 1);
    }//end method

    public String toString(){
    	return "\nName: " + name + "\nAddress: " + address + "\nNumber of courses: " + numcourses;
    }


}