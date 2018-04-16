/**
 * @(#)computer.java
 * Create a memory object with attributes manufacturer, size (gb)
 * Create a computer object with attributes make, model and memory
 * Have a computerTest class and create a computer object
 * Take all instance variables in from the user
 *
 * @author
 * @version 1.00 2016/1/14
 */


public class computer {

	//attributes
	private String make;
	private String model;
	private memory m1;

	//constructor
    public computer(String mk, String md, memory m) {
    	this.make = ((mk.length()>0)? mk : "Unknown");
    	this.model = ((md.length()>0)? md: "Unknown");
    	m1 = m;
    }//end constructor

	//setmemorySize method
    public void setmemorySize(int s){
    	m1.setsize(s);
    }//end setmemorySize

	//getmemorySize method
	 public int getmemorySize(){
    	return m1.getsize();
    }//end getmemorySize

	//toString
    public String toString(){
    	return "\n\nComputer Details: \n\nMake: " + make + "\nModel: " + model + m1;
    }//end toString

}//end class