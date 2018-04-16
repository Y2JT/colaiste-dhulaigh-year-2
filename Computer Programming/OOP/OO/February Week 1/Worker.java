/**
 * @(#)Worker.java
 *
 *
 * @author
 * @version 1.00 2016/2/5
 */


public class Worker {

	//attributes
    private String name;
    private int id, salary;

	//constructor
    public Worker(String name, int id, int salary) {
    	this.name = ((name.length()>0)? name : "Unknown");
    	this.id = ((id>0)? id : 111);
    	this.salary = ((salary>0)? salary : 111);
    }//end constructor

    //toString
    public String toString(){
    	return "\nWorker Name: " + name + "\nWorker ID: " + id + "\nWorker Salary: " + salary;
    }//end toString

}//end class